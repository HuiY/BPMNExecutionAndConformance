using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BPMNExecutionAndComplianceCheck
{
    /// <summary>
    /// Interaction logic for StateSpaceUserControl.xaml
    /// </summary>
    public partial class StateSpaceUserControl : UserControl
    {
        public StateSpaceUserControl()
        {
            InitializeComponent();
        }

        const double HInter = 20;
        const double VInter = 20;
        const double ItemWid = 80;
        const double ItemHeg = 40;
        double SINGLEWIDTH = ItemWid + HInter;
        double SINGLEHEIGHT = ItemHeg + VInter;

        Node RootNode = new Node();
        List<Node> listNode = new List<Node>();
        List<string> listLeafNode;
        int NumLayer;
        int NumWidth;
        List<int> NumDesAndLayer;
        List<List<string>> Elements;
        public void SetDataResource(List<Node> statespace,string firstIndex)
        {
            this.listNode = statespace;
            this.RootNode=listNode.Find(x=>x.ID==firstIndex);
            CalculateTheDepth();
            //CalculateThePosition();
            ShowGraph();
        }
        private void CalculateTheDepth()
        {
            listLeafNode = new List<string>();
            
            NumLayer = 0;
            NumWidth = 0;
            NumDesAndLayer = new List<int>();

            int index = listNode.FindIndex(delegate(Node a) { return a.ID == RootNode.ID; });
            listNode[index].Layer = 0;
            List<List<string>> layerNode = new List<List<string>>();
            layerNode.Add(listNode[index].Descendants);
            int i = 0;
            for (; ; i++)
            {
                List<string> lsOfOne = new List<string>();
                if (layerNode[i].Count > 0)
                {
                    foreach (string s in layerNode[i])
                    {
                        index = listNode.FindIndex(delegate(Node a) { return a.ID == s; });
                        listNode[index].Layer = i + 1;
                        //lsOfOne.AddRange(listNode[index].Descendants);  
                        
                        foreach(string desNode in listNode[index].Descendants)
                        {
                            if (listNode.Find(x => x.ID == desNode).Layer == 0 || listNode.Find(x => x.ID == desNode).Layer > i + 1)
                            {
                                lsOfOne.Add(desNode);
                            }
                        }
                        
                        List<string> lsOfOne1=lsOfOne.Distinct().ToList();
                        lsOfOne = lsOfOne1;
                    }
                    layerNode.Add(lsOfOne);                    
                }
                else
                    break;
            }
            
            this.NumLayer=listNode.Max(x=>x.Layer)+1;
            Elements = new List<List<string>>();
            for (int k = 0; k < this.NumLayer; k++)
            {
                List<string> l = new List<string>();
                Elements.Add(l);
            }
            foreach (Node node in listNode)
            {
                if (!Elements[node.Layer].Contains(node.ID))
                {
                    Elements[node.Layer].Add(node.ID);
                }
            }
            this.NumWidth = Elements.Max(x => x.Count);
            for (int h = 0; h < Elements.Count; h++)
            {
                for (int v = 0; v < Elements[h].Count; v++)
                {
                    int indInList = listNode.FindIndex(x => x.ID == Elements[h][v]);
                    if (indInList > -1)
                    {
                        listNode[indInList].POSITION = (double)(v + 1) / (double)(Elements[h].Count + 1) * (double)this.NumWidth;
                    }

                }
            }
        }

        private void CalculateThePosition()
        {          
            
            Queue<string> queueParentNode = new Queue<string>();
            queueParentNode.Enqueue(RootNode.ID);

            listLeafNode.Clear();
            foreach (Node node in listNode)
            {                
                node.POSITION = 0;
            }

            #region annotation
            //int numOfCol = 0;
            ////heighAndWidth中存放着每行的节点数
            //while (this.heighAndWidth[numOfCol] != 0)
            //{
            //    numOfCol++;
            //}
            ////从倒数第二行开始，遍历到第一行的节点
            //for (int i = numOfCol - 2; i >= 0; i--)
            //{
            //    //listOfNodeForLayer中存放的每行中的节点的名称
            //    List<string> testString = listOfNodeForLayer[i];

            //    //遍历每个节点
            //    for (int k = 0; k < testString.Count; k++)
            //    {
            //        string s = testString[k];
            //        int index = listNode.FindIndex(delegate(Node a) { return a.ID == s; });
            //        Node curNode = listNode[index];
            //        //若某节点被隐藏了，那么其宽度不变，即不予计算，否则，计算其所有子节点的宽度和
            //        if (curNode.HIDE)
            //        {
            //            break;
            //        }
            //        if (curNode.Descendants.Count == 1)
            //        {
            //            string desString = curNode.Descendants[0];
            //            Node desNode = listNode.Find(delegate(Node a) { return a.ID == desString; });

            //            listNode[index].HeightOfNode += desNode.HeightOfNode;
            //        }
            //        //如果该节点的子节点数大于1，那么重新计算该节点的宽度，即为其子节点的宽度的和
            //        if (curNode.Descendants.Count > 1)
            //        {
            //            int length = 0;
            //            int maxHeightOfDes = curNode.HeightOfNode; ;
            //            foreach (string desString in curNode.Descendants)
            //            {
            //                Node desNode = listNode.Find(delegate(Node a) { return a.ID == desString; });

            //                if (desNode.HeightOfNode > maxHeightOfDes)
            //                {
            //                    maxHeightOfDes = desNode.HeightOfNode;
            //                }
            //                if (!desNode.HIDE)
            //                {
            //                    length += desNode.WidthOfNode;
            //                }
            //            }
            //            listNode[index].WidthOfNode = length;
            //            listNode[index].HeightOfNode += maxHeightOfDes;
            //        }
            //    }
            //}
            #endregion
        }
        private Queue<string> OrderNodeByLayer(Queue<string> queueNode)
        {
            List<string> listLeafNode = new List<string>();
            while (queueNode.Count > 0)
            {
                listLeafNode.Add(queueNode.Dequeue());
            }
            //将节点进行排序，按层数的高低，从底向高排列
            Queue<string> OrderedQue = new Queue<string>();
            while (listLeafNode.Count > 0)
            {
                string head = listLeafNode[0];
                int index = listNode.FindIndex(delegate(Node a) { return a.ID == head; });
                int maxLayer = listNode[index].Layer;
                string maxLayersID = listNode[index].ID;
                for (int i = 1; i < listLeafNode.Count; i++)
                {
                    index = listNode.FindIndex(delegate(Node a) { return a.ID == listLeafNode[i]; });
                    if (listNode[index].Layer > maxLayer)
                    {
                        maxLayer = listNode[index].Layer;
                        maxLayersID = listNode[index].ID;
                    }
                }
                List<string> newLeafNode = new List<string>();
                foreach (string s in listLeafNode)
                {
                    index = listNode.FindIndex(delegate(Node a) { return a.ID == s; });
                    if (listNode[index].Layer == maxLayer)
                    {
                        OrderedQue.Enqueue(listNode[index].ID);
                    }
                    else
                        newLeafNode.Add(listNode[index].ID);
                }
                listLeafNode = newLeafNode;
            }
            return OrderedQue;

        }

        private void ShowGraph()
        {
            this.ShowCan.Children.Clear();
            this.ShowCan.Width = this.NumWidth * SINGLEWIDTH;
            this.ShowCan.Height = (this.NumLayer + 1) * SINGLEHEIGHT;
            foreach (Node n in listNode)
            {
                Thickness th = new Thickness();
                th.Left = (n.POSITION) * SINGLEWIDTH - ItemWid * 0.5;
                th.Top = (n.Layer + 1) * SINGLEHEIGHT - 0.5 * ItemHeg;
                NodeButton nodebutton1 = new NodeButton(n.ID, n.Description, n.HIDE);

                nodebutton1.Margin = th;
                this.ShowCan.Children.Add(nodebutton1);
                foreach (string s in n.Descendants)
                {
                    Node ch = listNode.Find(x => x.ID == s);
                    //画直线
                    Line parToChi = new System.Windows.Shapes.Line();
                    parToChi.X1 = (n.POSITION) * SINGLEWIDTH;
                    parToChi.Y1 = (n.Layer + 1) * SINGLEHEIGHT + 0.5 * ItemHeg;
                    parToChi.X2 = ch.POSITION * SINGLEWIDTH;
                    parToChi.Y2 = (ch.Layer + 1) * SINGLEHEIGHT - 0.5 * ItemHeg;

                    SolidColorBrush br = new SolidColorBrush(Colors.Black);
                    parToChi.Stroke = br;
                    this.ShowCan.Children.Add(parToChi);
                }

            }
        }
    }
}
