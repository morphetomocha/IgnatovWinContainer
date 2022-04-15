using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgnatovWinContainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void but_Click(object sender, EventArgs e)
        {
            if (myBoxButt1.Checked == true)
                this.but.Text = "First";
            else if (myBoxButt2.Checked == true)
                this.but.Text = "Second";

        }

        private void flowBut1_Click(object sender, EventArgs e)
        {
            myFlow.SetFlowBreak(flowBut2, true);
        }

        private void tlpBut1_Click(object sender, EventArgs e)
        {
            Button aButton = new Button();
            myTLP.Controls.Add(aButton, 1, 1);
        }

        private void fixBut_Click(object sender, EventArgs e)
        {
            if (mySplitCont.FixedPanel == FixedPanel.Panel1)
                mySplitCont.FixedPanel = FixedPanel.None;
            else
                mySplitCont.FixedPanel = FixedPanel.Panel1;

        }

        private void fixBut2_Click(object sender, EventArgs e)
        {
            mySplitCont.IsSplitterFixed = !(mySplitCont.IsSplitterFixed);
        }

        private void pan2But_Click(object sender, EventArgs e)
        {
            mySplitCont.Panel1Collapsed = !(mySplitCont.Panel1Collapsed);
        }
    }
}
