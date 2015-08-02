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
    /// Interaction logic for NodeButton.xaml
    /// </summary>
    public partial class NodeButton : UserControl
    {
        private bool HideFlag = false;
        private string ID;

        public delegate void SpreadBtnClickedHandler(object sender, EventArgs e);
        public event SpreadBtnClickedHandler SpreadClicked;

        public delegate void NodeClickedColoredHandler(object sender, EventArgs e);
        public event NodeClickedColoredHandler NodeClickedColoredEvent;

        private bool PropertyHideFlag
        {
            get { return HideFlag; }
            set { this.HideFlag = value; }
        }
        public string NodeId
        {
            get { return this.ID; }
        }
        public Brush ColorOfNode
        {
            get { return this.ellipse1.Fill; }
            set { this.ellipse1.Fill = value; }

        }
        public NodeButton(string ID, string description, bool flagOfHide)
        {
            InitializeComponent();
            this.label2.Text = description;
            this.ID = ID;
            //this.SID.Text = description;
            this.hiddenText.Text = ID;
            //if (!flagOfHide)
            //{
            //    LinearGradientBrush br = new LinearGradientBrush(Colors.Red,Colors.Orange,90);
            //    this.ellipse1.Fill = br;
            //}
            //else
            //{
            //    SolidColorBrush br = new SolidColorBrush(Colors.Yellow);
            //    this.ellipse1.Fill = br;
            //}
        }

        public NodeButton(string ID, string description, bool flagOfHide, string HidenText)
        {
            InitializeComponent();
            this.label2.Text = description;
            this.ID = ID;
            //this.hiddenText.Text = description;
            this.hiddenText.Text = HidenText;
            this.hiddenText.FontSize = 30;
        }

        private void OnMouseDown_NodeButton(object sender, MouseButtonEventArgs e)
        {
            // PropertyHideFlag =! PropertyHideFlag;
            //if (NodeClickedColoredEvent != null)
            //{
            //    NodeClickedColoredEvent(this,e);
            //}
            NodeButton nodeButton = (NodeButton)sender;
            SolidColorBrush br = new SolidColorBrush(Colors.Beige);
            nodeButton.ColorOfNode = br;


        }
        protected void OnCheckboxClicked(EventArgs e)
        {
            if (SpreadClicked != null)
                SpreadClicked(this, e);
        }
        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            // ... Change Text to Enter when mouse enters.
            var block = sender as Canvas;
            if (block != null)
            {
                hiddenText.Visibility = Visibility.Visible;
            }
        }

        private void TextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            // ... Change Text to Leave when mouse leaves.
            var block = sender as Canvas;
            if (block != null)
            {
                hiddenText.Visibility = Visibility.Hidden;
            }
        }       
    }
}
