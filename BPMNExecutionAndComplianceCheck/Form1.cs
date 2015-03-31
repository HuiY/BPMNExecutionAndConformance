using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace BPMNExecutionAndComplianceCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btn_generate.Enabled = false;
            this.cB_BothStartEnd.Enabled = false;
            this.cB_Gate2.Enabled = false;
            this.btn_Show.Enabled = false;
        }

        private string FileNameWithType;
        private string afterDirectory;
        private int maxLayerDev;
        private DataTable resultDataTable; 
        List<CauseNode> originalCauseNodes = new List<CauseNode>();

        List<ActionNode> StructuredMarkingList = new List<ActionNode>();
        //from log file
        List<AuditTrailEntry> listAuditEntry = new List<AuditTrailEntry>();

        bool flagOnlyStart;
        bool FlagOfTrace;

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "Document";
            //dlg.DefaultExt = ".grbpmn";
            //dlg.Filter = "BPMN process file(*.xpdl)|*.xpdl|statespace file(*.grs)|*.grs";
            dlg.Filter = "BPMN process file(*.xpdl)|*.xpdl";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                #region specify the location of marking file
                this.textBoxFilePath.Text = dlg.FileName;
                this.FileNameWithType = dlg.FileName;
                #endregion   

                this.txbBx_statespaceAdress.Text = "";
                if (this.originalCauseNodes.Count != 0)
                {
                    this.originalCauseNodes.Clear();
                    this.elementHost1.Child = null;
                }

                this.btn_generate.Enabled = true;

                this.cB_BothStartEnd.Enabled = false;
                this.cB_Gate2.Enabled = false;
                this.btn_Show.Enabled = false;
            }            
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            string strFileType = this.FileNameWithType.Substring(this.FileNameWithType.LastIndexOf(".") + 1, (this.FileNameWithType.Length - this.FileNameWithType.LastIndexOf(".") - 1));  
            if(strFileType=="xpdl")
            {
                bool flagParseSuccess=true;
                string parsedGrsFile = ParseXPDLIntoGrs(this.FileNameWithType,out flagParseSuccess);
                if (flagParseSuccess)
                {
                    this.afterDirectory = LoadAndRunBPMNFile(parsedGrsFile);
                }
                else
                {
                    return;
                }
            }
            else if(strFileType=="grs")
            {
                this.afterDirectory = LoadAndRunBPMNFile(this.FileNameWithType);
            }
            else
            {
                MessageBox.Show("Please import a file with type: .xpdl or .grs!");
                return;
            }
            //sw.Stop();
            //string miSeconds = sw.ElapsedMilliseconds.ToString();
            //this.lab_Time.Text = miSeconds;
            MessageBox.Show("Running finished!");
            this.cB_BothStartEnd.Enabled = true;
            this.cB_Gate2.Enabled = true;
            this.btn_Show.Enabled = true;

            this.originalCauseNodes = ReadModelMarkingFileAndParsing(this.afterDirectory);
            
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            List<Node> listNode = new List<Node>();
            string rootIndex = "";
            //Check for different combined options
            bool flagOnlyStart = false;
            if (this.cB_BothStartEnd.Checked == true)
            {
                flagOnlyStart = true;
            }

            bool flagGateAndEventInclude = false;
            if (this.cB_Gate2.Checked == true)
            {
                flagGateAndEventInclude = true;
            }

            List<CauseNode> CauseNodeShow = FilteringCauseNodes(this.originalCauseNodes, flagOnlyStart, flagGateAndEventInclude);
            //AddLayerInformation

            foreach (CauseNode cNode in CauseNodeShow)
            {
                Node node = new Node();
                node.ID = cNode.ID;
                string des = "";

                switch (cNode.ActivityEle.Type)
                {
                    case TypeOfElement.Task:
                        des += cNode.ActivityEle.Name + " ";
                        break;
                    //case TypeOfElement.BlockActivity:
                    //    des += "Block" + "(" + cNode.ActivityEle.Name + ")" + " ";
                    //    break;
                    case TypeOfElement.GateWay:
                        des += cNode.ActivityEle.Name + " ";
                        break;
                    case TypeOfElement.StartEvent:
                    case TypeOfElement.EndEvent:
                        des += cNode.ActivityEle.Type.ToString() + "(" + cNode.ActivityEle.Name + ")";
                        break;
                    //default:
                    //    des += cNode.ActivityEle.Type.ToString() + " ";
                    //    break;
                }
                des += cNode.ruleName;
                node.Description = des;
                node.Descendants = cNode.NextCauselist;
                node.Ancestors = cNode.PreCauselist;
                if (cNode.PreCauselist.Count == 0)
                {
                    rootIndex = cNode.ID;
                    //node.Description = "Start";
                }

                listNode.Add(node);
            }
            //chose to show the tree view of statespace or not
            StateSpaceUserControl userControl1 = new StateSpaceUserControl();
            userControl1.SetDataResource(listNode, rootIndex);
            this.elementHost1.Child = userControl1;
        }

        private void btn_OpenLog_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "Document";
            dlg.DefaultExt = ".xml";
            dlg.Filter = "Xml documents (.xml)|*.xml";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.FlagOfTrace = true;
                if (this.listAuditEntry.Count > 0)
                {
                    this.listAuditEntry.Clear();
                }

                this.LogFileTb.Text = dlg.FileName;
                string LogFileName = this.LogFileTb.Text;

                this.listAuditEntry = ReadXmlFileForATrace(LogFileName);
                bool flagStart = (this.listAuditEntry.FindIndex(x=>x.State=="Start")>-1? true : false );
                bool flagComplete = (this.listAuditEntry.FindIndex(x => x.State == "Complete") > -1 ? true : false);

                this.flagOnlyStart = flagStart & flagComplete;

                string logLabel = "";
                foreach (AuditTrailEntry entry in this.listAuditEntry)
                {
                    logLabel += entry.Name;
                    logLabel += "    ";
                }
            }
        }

        private void btn_DevCheck_Click(object sender, EventArgs e)
        {
            if (this.LogFileTb.Text == "" || (this.textBoxFilePath.Text == "" && this.txbBx_statespaceAdress.Text==""))
            {
                MessageBox.Show("Please check the input file again! One of them is empty!");
                return;
            }
            List<string> RefModelName = new List<string>();
            List<string> RefLogName = new List<string>();

            MappingDataFields mappingForm = new MappingDataFields();
            if (this.FlagOfTrace == true)
            {
                mappingForm.activitiesFromLog = this.listAuditEntry; ;
            }
            else
            {
                mappingForm.activitiesFromLog = ExractingActivitiesSetFromLog(this.listTraces);
            }
            
            mappingForm.activitiesFromModel = this.originalCauseNodes;           

            mappingForm.ShowList();
            mappingForm.ShowDialog();
            RefModelName = mappingForm.modelNames;
            RefLogName = mappingForm.logNames;
            if (RefModelName != null)
            {
                this.StructuredMarkingList = FilteringCauseNodesForConformanceCheck(this.originalCauseNodes, RefModelName);
            }
            else
            {
                this.StructuredMarkingList = FilteringCauseNodesForConformanceCheck(this.originalCauseNodes);
            }            
            List<ActionNode> layeredLsModel = this.MaxXYDev(this.StructuredMarkingList, out this.maxLayerDev);

            this.dynamicParameter = (double)(1 / ((double)(this.maxLayerDev - 1))) - 0.01;

            if (this.FlagOfTrace == true)
            {
                List<AuditTrailEntry> newlistAuditEntry = new List<AuditTrailEntry>();
                if (RefLogName != null)
                {
                    newlistAuditEntry = FilteringAuditEntiesForConformanceCheck(this.listAuditEntry, RefLogName);
                }
                #region for testing
                //string rootIndex="";
                //List<Node> listNode = new List<Node>();
                //foreach (ActionNode cNode in layeredLsModel)
                //{
                //    Node node = new Node();
                //    node.ID = cNode.ID;
                //    string des = cNode.Layer.ToString();

                //    //des += cNode.ruleName;
                //    node.Description = des;
                //    node.Descendants = cNode.NextMarkingIDlist;
                //    node.Ancestors = cNode.PreMarkingIDlist;
                //    if (cNode.PreMarkingIDlist.Count == 0)
                //    {
                //        rootIndex = cNode.ID;
                //        //node.Description = "Start";
                //    }

                //    listNode.Add(node);
                //}
                ////chose to show the tree view of statespace or not
                //StateSpaceUserControl userControl1 = new StateSpaceUserControl();
                //userControl1.SetDataResource(listNode, rootIndex);
                //this.elementHost1.Child = userControl1;
                #endregion

                List<AMatch> listLeaf = new List<AMatch>();

                List<AMatch> MatchesTree = ConstructTheMatchTree(layeredLsModel, newlistAuditEntry, out listLeaf);

                List<List<AMatch>> alignmentTable = GetAllAlignmentResults(MatchesTree, listLeaf);
                DataTable dtForShow = new DataTable();
                //since now it only contains one line of alignment, later it may change
                for (int i = 0; i < alignmentTable[0].Count; i++)
                {
                    dtForShow.Columns.Add(i.ToString(), typeof(string));
                }
                #region to show
                foreach (var alignment in alignmentTable)
                {
                    DataRow rowLog = dtForShow.NewRow();
                    DataRow rowModel = dtForShow.NewRow();
                    int colNum = 0;
                    for (int i = alignment.Count - 2; i > -1; i--)
                    {
                        switch (alignment[i].MatchType)
                        {
                            case TypeOfMatch.BothCorrect:
                                rowLog[colNum] = alignment[i].Entry.Name;
                                rowModel[colNum] = alignment[i].TaskMarking.Elment.Name;
                                break;
                            case TypeOfMatch.CTaskFEntry:
                                rowModel[colNum] = alignment[i].TaskMarking.Elment.Name;
                                rowLog[colNum] = " ┴ ";
                                break;
                            case TypeOfMatch.FTaskCEntry:
                                rowLog[colNum] = alignment[i].Entry.Name;
                                rowModel[colNum] = " ┴ ";
                                break;
                            case TypeOfMatch.BothFake:
                                if (alignment[i].TaskMarking.ID == alignment[i + 1].TaskMarking.ID)
                                {
                                    rowLog[colNum] = alignment[i].Entry.Name;
                                    rowModel[colNum] = " ┴ ";
                                }
                                else if (alignment[i].Entry.ID == alignment[i + 1].Entry.ID)
                                {
                                    rowModel[colNum] = alignment[i].TaskMarking.Elment.Name;
                                    rowLog[colNum] = " ┴ ";
                                }
                                break;
                        }
                        //this.log.Text += "  |  ";
                        //this.log.Text += rowLog[colNum];
                        //this.model.Text += "  |  ";
                        //this.model.Text += rowModel[colNum];
                        colNum++;
                    }
                    dtForShow.Rows.Add(rowLog);
                    dtForShow.Rows.Add(rowModel);
                    DataRow emptyR = dtForShow.NewRow();
                    dtForShow.Rows.Add(emptyR);
                    this.DataViewForAlignment.DataSource = dtForShow.AsDataView();
                    this.resultDataTable = dtForShow;
                    //MessageBox.Show(this.log.Text + "\n" + this.model.Text);
                #endregion
                }
            }
            else
            {
                List<List<AMatch>> resultOfLog = new List<List<AMatch>>();
                Stopwatch sw = new Stopwatch();
                long frequency = Stopwatch.Frequency;
                sw.Start();
                foreach (var trace in this.listTraces)
                {
                    List<AMatch> leaf = new List<AMatch>();

                    List<AuditTrailEntry> newlistAuditEntry = new List<AuditTrailEntry>();
                    if (RefLogName != null)
                    {
                        newlistAuditEntry = FilteringAuditEntiesForConformanceCheck(trace, RefLogName);
                    }
                    List<AMatch> matchTree = ConstructTheMatchTree(this.StructuredMarkingList, newlistAuditEntry, out leaf);
                    List<AMatch> alignmentTable = GetAllAlignmentResults(matchTree, leaf)[0];
                    resultOfLog.Add(alignmentTable);
                }
                sw.Stop();
                //IEnumerable<List<AMatch>> orderedNodeSetList = resultOfLog.OrderByDescending(n => n.Count);
                int max = resultOfLog.Max(x => x.Count);
                DataTable dtForShow = new DataTable();
                //since now it only contains one line of alignment, later it may change
                for (int i = 0; i < max; i++)
                {
                    dtForShow.Columns.Add(i.ToString(), typeof(string));
                }
                #region to show
                foreach (var alignment in resultOfLog)
                {
                    DataRow rowLog = dtForShow.NewRow();
                    DataRow rowModel = dtForShow.NewRow();
                    int colNum = 0;
                    for (int i = alignment.Count - 2; i > -1; i--)
                    {
                        switch (alignment[i].MatchType)
                        {
                            case TypeOfMatch.BothCorrect:
                                rowLog[colNum] = alignment[i].Entry.Name;
                                rowModel[colNum] = alignment[i].TaskMarking.Elment.Name;
                                break;
                            case TypeOfMatch.CTaskFEntry:
                                rowModel[colNum] = alignment[i].TaskMarking.Elment.Name;
                                rowLog[colNum] = " ┴ ";
                                break;
                            case TypeOfMatch.FTaskCEntry:
                                rowLog[colNum] = alignment[i].Entry.Name;
                                rowModel[colNum] = " ┴ ";
                                break;
                            case TypeOfMatch.BothFake:
                                if (alignment[i].TaskMarking.ID == alignment[i + 1].TaskMarking.ID)
                                {
                                    rowLog[colNum] = alignment[i].Entry.Name;
                                    rowModel[colNum] = " ┴ ";
                                }
                                else if (alignment[i].Entry.ID == alignment[i + 1].Entry.ID)
                                {
                                    rowModel[colNum] = alignment[i].TaskMarking.Elment.Name;
                                    rowLog[colNum] = " ┴ ";
                                }
                                break;
                        }
                        colNum++;
                    }
                    dtForShow.Rows.Add(rowLog);
                    dtForShow.Rows.Add(rowModel);
                    DataRow emptyR = dtForShow.NewRow();
                    dtForShow.Rows.Add(emptyR);
                }
                    this.DataViewForAlignment.DataSource = dtForShow.AsDataView();
                    this.resultDataTable = dtForShow;
                #endregion
                    //MessageBox.Show(this.log.Text + "\n" + this.model.Text);
                    //this.labelTime.Text = sw.ElapsedMilliseconds.ToString();
                    //this.labelTimeTicks.Text = sw.ElapsedTicks.ToString();
                    //long micoSec = (sw.ElapsedTicks * (long)1000 * (long)1000 / frequency);
                    //this.lbl_micoseconds.Text = micoSec.ToString();
                    MessageBox.Show("Succeed!");
                
            }
        }

        private void btn_OpenStatespace_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "Document";
            //dlg.DefaultExt = ".grbpmn";
            //dlg.Filter = "BPMN process file(*.xpdl)|*.xpdl|statespace file(*.grs)|*.grs";
            dlg.Filter = "State space file(*.grs)|*.grs";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                #region specify the location of marking file
                string statespaceAddress = dlg.FileName;
                txbBx_statespaceAdress.Text = statespaceAddress;
                //clear text in xpdl and clear originalCauseNodes
                this.textBoxFilePath.Text = "";
                if (this.originalCauseNodes.Count != 0)
                {
                    this.originalCauseNodes.Clear();
                    this.elementHost1.Child = null;
                    this.btn_generate.Enabled = false;
                }

                this.originalCauseNodes = ReadModelMarkingFileAndParsing(statespaceAddress);
                this.btn_Show.Enabled = true;
                #endregion
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to load a log file？", "Reminder", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "Document";
            dlg.DefaultExt = ".xml";
            dlg.Filter = "Xml documents (.xml)|*.xml";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FlagOfTrace = false;
                this.LogFileTb.Text = dlg.FileName;
                string LogFileName = this.LogFileTb.Text;
                this.listTraces = ReadLogFileForLog(LogFileName);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Document";
            sfd.Filter = ".csv documents(.csv)|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                string fileName = sfd.FileName;

                datatableToCSV(resultDataTable, fileName);

            }
        }

    }
}
