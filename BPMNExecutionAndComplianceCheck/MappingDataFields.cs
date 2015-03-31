using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BPMNExecutionAndComplianceCheck
{
    public partial class MappingDataFields : Form
    {
        public List<CauseNode> activitiesFromModel { get; set; }
        public List<AuditTrailEntry> activitiesFromLog { get; set; }

        public List<string> modelNames { get; set; }
        public List<string> logNames { get; set; }

        public MappingDataFields()
        {
            InitializeComponent();
        }

        public void ShowList()
        {
            List<string> distinctActiviesModel = new List<string>();
            for (int i = activitiesFromModel.Count - 1; i > -1; i--)
            {
                CauseNode m = activitiesFromModel[i];
                if (!distinctActiviesModel.Contains(m.ActivityEle.Name) && m.ActivityEle.Name != null)
                {
                    distinctActiviesModel.Add(m.ActivityEle.Name);
                }
            }

            foreach (string m in distinctActiviesModel)
            {
                this.checkedListBoxModel.Items.Add(m);
            }

            List<string> distinctActiviesLog = new List<string>();
            if (activitiesFromLog != null)
            {
                foreach (AuditTrailEntry m in activitiesFromLog)
                {
                    if (!distinctActiviesLog.Contains(m.Name))
                    {
                        distinctActiviesLog.Add(m.Name);
                    }
                }
                foreach (string m in distinctActiviesLog)
                {
                    this.checkedListBox2.Items.Add(m);
                }
            }
        }
        private void btn_select_Click(object sender, EventArgs e)
        {
            this.modelNames = new List<string>();
            this.logNames = new List<string>();
            for (int i = 0; i < checkedListBoxModel.Items.Count; i++)
            {
                if (checkedListBoxModel.GetItemChecked(i))
                {
                    this.modelNames.Add(checkedListBoxModel.GetItemText(checkedListBoxModel.Items[i]));
                }
            }
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (checkedListBox2.GetItemChecked(i))
                {
                    this.logNames.Add(checkedListBox2.GetItemText(checkedListBox2.Items[i]));
                }
            }
            this.Close();
        }

        private void cB_modelAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cB_modelAll.Checked)
            {
                for (int j = 0; j < this.checkedListBoxModel.Items.Count; j++)
                    checkedListBoxModel.SetItemChecked(j, true);
            }
            else
            {
                for (int j = 0; j < checkedListBoxModel.Items.Count; j++)
                    checkedListBoxModel.SetItemChecked(j, false);
            }
        }

        private void cB_LogAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cB_LogAll.Checked)
            {
                for (int j = 0; j < this.checkedListBox2.Items.Count; j++)
                    checkedListBox2.SetItemChecked(j, true);
            }
            else
            {
                for (int j = 0; j < checkedListBox2.Items.Count; j++)
                    checkedListBox2.SetItemChecked(j, false);
            }
        }

        private void radBtn_CheckedChanged(object sender, EventArgs e)
        {
            string[] templArray = new string[8] { "Patient_record", "Operation_blood", "Bipap_check", "Setup_ASB_ventilation", "Decrease_P-ASB", "Final_blood", "Extubation_criteria", "Extubation" };
            for (int j = 0; j < this.checkedListBoxModel.Items.Count; j++)
            {
                if (templArray.Contains(this.checkedListBoxModel.Items[j].ToString()))
                {
                    checkedListBoxModel.SetItemChecked(j, true);
                }
            }
        }
    }
}
