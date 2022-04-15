namespace IgnatovWinContainer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ignatovControl = new System.Windows.Forms.TabControl();
            this.pervii = new System.Windows.Forms.TabPage();
            this.but = new System.Windows.Forms.Button();
            this.myBox = new System.Windows.Forms.GroupBox();
            this.myBoxButt2 = new System.Windows.Forms.RadioButton();
            this.myBoxButt1 = new System.Windows.Forms.RadioButton();
            this.vtoroi = new System.Windows.Forms.TabPage();
            this.myPanel = new System.Windows.Forms.Panel();
            this.panelBut4 = new System.Windows.Forms.Button();
            this.panelBut3 = new System.Windows.Forms.Button();
            this.panelBut2 = new System.Windows.Forms.Button();
            this.panelBut1 = new System.Windows.Forms.Button();
            this.tretii = new System.Windows.Forms.TabPage();
            this.myFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.flowBut1 = new System.Windows.Forms.Button();
            this.flowBut2 = new System.Windows.Forms.Button();
            this.flowBut3 = new System.Windows.Forms.Button();
            this.flowBut4 = new System.Windows.Forms.Button();
            this.chetvert = new System.Windows.Forms.TabPage();
            this.myTLP = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBut1 = new System.Windows.Forms.Button();
            this.pyatii = new System.Windows.Forms.TabPage();
            this.mySplitCont = new System.Windows.Forms.SplitContainer();
            this.fixBut2 = new System.Windows.Forms.Button();
            this.fixBut = new System.Windows.Forms.Button();
            this.pan2But = new System.Windows.Forms.Button();
            this.ignatovControl.SuspendLayout();
            this.pervii.SuspendLayout();
            this.myBox.SuspendLayout();
            this.vtoroi.SuspendLayout();
            this.myPanel.SuspendLayout();
            this.tretii.SuspendLayout();
            this.myFlow.SuspendLayout();
            this.chetvert.SuspendLayout();
            this.myTLP.SuspendLayout();
            this.pyatii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mySplitCont)).BeginInit();
            this.mySplitCont.Panel1.SuspendLayout();
            this.mySplitCont.Panel2.SuspendLayout();
            this.mySplitCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // ignatovControl
            // 
            this.ignatovControl.Controls.Add(this.pervii);
            this.ignatovControl.Controls.Add(this.vtoroi);
            this.ignatovControl.Controls.Add(this.tretii);
            this.ignatovControl.Controls.Add(this.chetvert);
            this.ignatovControl.Controls.Add(this.pyatii);
            this.ignatovControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ignatovControl.Location = new System.Drawing.Point(0, 0);
            this.ignatovControl.Name = "ignatovControl";
            this.ignatovControl.SelectedIndex = 0;
            this.ignatovControl.Size = new System.Drawing.Size(773, 381);
            this.ignatovControl.TabIndex = 0;
            // 
            // pervii
            // 
            this.pervii.Controls.Add(this.but);
            this.pervii.Controls.Add(this.myBox);
            this.pervii.Location = new System.Drawing.Point(4, 24);
            this.pervii.Name = "pervii";
            this.pervii.Padding = new System.Windows.Forms.Padding(3);
            this.pervii.Size = new System.Drawing.Size(765, 353);
            this.pervii.TabIndex = 0;
            this.pervii.Text = "GroupBox";
            this.pervii.UseVisualStyleBackColor = true;
            this.pervii.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // but
            // 
            this.but.Location = new System.Drawing.Point(28, 102);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(75, 23);
            this.but.TabIndex = 1;
            this.but.UseVisualStyleBackColor = true;
            this.but.Click += new System.EventHandler(this.but_Click);
            // 
            // myBox
            // 
            this.myBox.Controls.Add(this.myBoxButt2);
            this.myBox.Controls.Add(this.myBoxButt1);
            this.myBox.Location = new System.Drawing.Point(3, 6);
            this.myBox.Name = "myBox";
            this.myBox.Size = new System.Drawing.Size(132, 90);
            this.myBox.TabIndex = 0;
            this.myBox.TabStop = false;
            this.myBox.Text = "MyBox";
            // 
            // myBoxButt2
            // 
            this.myBoxButt2.AutoSize = true;
            this.myBoxButt2.Location = new System.Drawing.Point(6, 47);
            this.myBoxButt2.Name = "myBoxButt2";
            this.myBoxButt2.Size = new System.Drawing.Size(64, 19);
            this.myBoxButt2.TabIndex = 1;
            this.myBoxButt2.TabStop = true;
            this.myBoxButt2.Text = "Second";
            this.myBoxButt2.UseVisualStyleBackColor = true;
            // 
            // myBoxButt1
            // 
            this.myBoxButt1.AutoSize = true;
            this.myBoxButt1.Location = new System.Drawing.Point(6, 22);
            this.myBoxButt1.Name = "myBoxButt1";
            this.myBoxButt1.Size = new System.Drawing.Size(47, 19);
            this.myBoxButt1.TabIndex = 0;
            this.myBoxButt1.TabStop = true;
            this.myBoxButt1.Text = "First";
            this.myBoxButt1.UseVisualStyleBackColor = true;
            // 
            // vtoroi
            // 
            this.vtoroi.Controls.Add(this.myPanel);
            this.vtoroi.Location = new System.Drawing.Point(4, 24);
            this.vtoroi.Name = "vtoroi";
            this.vtoroi.Padding = new System.Windows.Forms.Padding(3);
            this.vtoroi.Size = new System.Drawing.Size(765, 353);
            this.vtoroi.TabIndex = 1;
            this.vtoroi.Text = "Panel";
            this.vtoroi.UseVisualStyleBackColor = true;
            // 
            // myPanel
            // 
            this.myPanel.AutoScroll = true;
            this.myPanel.Controls.Add(this.panelBut4);
            this.myPanel.Controls.Add(this.panelBut3);
            this.myPanel.Controls.Add(this.panelBut2);
            this.myPanel.Controls.Add(this.panelBut1);
            this.myPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myPanel.Location = new System.Drawing.Point(3, 3);
            this.myPanel.Name = "myPanel";
            this.myPanel.Size = new System.Drawing.Size(759, 347);
            this.myPanel.TabIndex = 0;
            // 
            // panelBut4
            // 
            this.panelBut4.Location = new System.Drawing.Point(14, 375);
            this.panelBut4.Name = "panelBut4";
            this.panelBut4.Size = new System.Drawing.Size(75, 23);
            this.panelBut4.TabIndex = 3;
            this.panelBut4.Text = "Хыхыха";
            this.panelBut4.UseVisualStyleBackColor = true;
            // 
            // panelBut3
            // 
            this.panelBut3.Location = new System.Drawing.Point(697, 375);
            this.panelBut3.Name = "panelBut3";
            this.panelBut3.Size = new System.Drawing.Size(75, 23);
            this.panelBut3.TabIndex = 2;
            this.panelBut3.Text = "Валорант";
            this.panelBut3.UseVisualStyleBackColor = true;
            // 
            // panelBut2
            // 
            this.panelBut2.Location = new System.Drawing.Point(677, 39);
            this.panelBut2.Name = "panelBut2";
            this.panelBut2.Size = new System.Drawing.Size(75, 23);
            this.panelBut2.TabIndex = 1;
            this.panelBut2.Text = "А я здесь";
            this.panelBut2.UseVisualStyleBackColor = true;
            // 
            // panelBut1
            // 
            this.panelBut1.Location = new System.Drawing.Point(25, 17);
            this.panelBut1.Name = "panelBut1";
            this.panelBut1.Size = new System.Drawing.Size(242, 23);
            this.panelBut1.TabIndex = 0;
            this.panelBut1.Text = "Я тут притаился";
            this.panelBut1.UseVisualStyleBackColor = true;
            // 
            // tretii
            // 
            this.tretii.Controls.Add(this.myFlow);
            this.tretii.Location = new System.Drawing.Point(4, 24);
            this.tretii.Name = "tretii";
            this.tretii.Size = new System.Drawing.Size(765, 353);
            this.tretii.TabIndex = 2;
            this.tretii.Text = "FlowLayoutPage";
            this.tretii.UseVisualStyleBackColor = true;
            // 
            // myFlow
            // 
            this.myFlow.Controls.Add(this.flowBut1);
            this.myFlow.Controls.Add(this.flowBut2);
            this.myFlow.Controls.Add(this.flowBut3);
            this.myFlow.Controls.Add(this.flowBut4);
            this.myFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myFlow.Location = new System.Drawing.Point(0, 0);
            this.myFlow.Name = "myFlow";
            this.myFlow.Size = new System.Drawing.Size(765, 353);
            this.myFlow.TabIndex = 0;
            // 
            // flowBut1
            // 
            this.flowBut1.Location = new System.Drawing.Point(3, 3);
            this.flowBut1.Name = "flowBut1";
            this.flowBut1.Size = new System.Drawing.Size(75, 23);
            this.flowBut1.TabIndex = 0;
            this.flowBut1.Text = "button1";
            this.flowBut1.UseVisualStyleBackColor = true;
            this.flowBut1.Click += new System.EventHandler(this.flowBut1_Click);
            // 
            // flowBut2
            // 
            this.flowBut2.Location = new System.Drawing.Point(84, 3);
            this.flowBut2.Name = "flowBut2";
            this.flowBut2.Size = new System.Drawing.Size(72, 23);
            this.flowBut2.TabIndex = 1;
            this.flowBut2.Text = "button2";
            this.flowBut2.UseVisualStyleBackColor = true;
            // 
            // flowBut3
            // 
            this.flowBut3.Location = new System.Drawing.Point(162, 3);
            this.flowBut3.Name = "flowBut3";
            this.flowBut3.Size = new System.Drawing.Size(75, 23);
            this.flowBut3.TabIndex = 2;
            this.flowBut3.Text = "button3";
            this.flowBut3.UseVisualStyleBackColor = true;
            // 
            // flowBut4
            // 
            this.flowBut4.Location = new System.Drawing.Point(243, 3);
            this.flowBut4.Name = "flowBut4";
            this.flowBut4.Size = new System.Drawing.Size(75, 23);
            this.flowBut4.TabIndex = 3;
            this.flowBut4.Text = "button4";
            this.flowBut4.UseVisualStyleBackColor = true;
            // 
            // chetvert
            // 
            this.chetvert.Controls.Add(this.myTLP);
            this.chetvert.Location = new System.Drawing.Point(4, 24);
            this.chetvert.Name = "chetvert";
            this.chetvert.Size = new System.Drawing.Size(765, 353);
            this.chetvert.TabIndex = 3;
            this.chetvert.Text = "TableLayoutPanel";
            this.chetvert.UseVisualStyleBackColor = true;
            // 
            // myTLP
            // 
            this.myTLP.AutoScroll = true;
            this.myTLP.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.myTLP.ColumnCount = 2;
            this.myTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.myTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.myTLP.Controls.Add(this.tlpBut1, 0, 0);
            this.myTLP.Location = new System.Drawing.Point(8, 3);
            this.myTLP.Name = "myTLP";
            this.myTLP.RowCount = 2;
            this.myTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.myTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.myTLP.Size = new System.Drawing.Size(200, 100);
            this.myTLP.TabIndex = 0;
            // 
            // tlpBut1
            // 
            this.tlpBut1.Location = new System.Drawing.Point(5, 5);
            this.tlpBut1.Name = "tlpBut1";
            this.tlpBut1.Size = new System.Drawing.Size(75, 23);
            this.tlpBut1.TabIndex = 0;
            this.tlpBut1.Text = "button1";
            this.tlpBut1.UseVisualStyleBackColor = true;
            this.tlpBut1.Click += new System.EventHandler(this.tlpBut1_Click);
            // 
            // pyatii
            // 
            this.pyatii.Controls.Add(this.mySplitCont);
            this.pyatii.Location = new System.Drawing.Point(4, 24);
            this.pyatii.Name = "pyatii";
            this.pyatii.Size = new System.Drawing.Size(765, 353);
            this.pyatii.TabIndex = 4;
            this.pyatii.Text = "SplitContainer";
            this.pyatii.UseVisualStyleBackColor = true;
            // 
            // mySplitCont
            // 
            this.mySplitCont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mySplitCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mySplitCont.Location = new System.Drawing.Point(0, 0);
            this.mySplitCont.Name = "mySplitCont";
            // 
            // mySplitCont.Panel1
            // 
            this.mySplitCont.Panel1.Controls.Add(this.fixBut2);
            this.mySplitCont.Panel1.Controls.Add(this.fixBut);
            // 
            // mySplitCont.Panel2
            // 
            this.mySplitCont.Panel2.Controls.Add(this.pan2But);
            this.mySplitCont.Size = new System.Drawing.Size(765, 353);
            this.mySplitCont.SplitterDistance = 255;
            this.mySplitCont.TabIndex = 0;
            // 
            // fixBut2
            // 
            this.fixBut2.Location = new System.Drawing.Point(56, 123);
            this.fixBut2.Name = "fixBut2";
            this.fixBut2.Size = new System.Drawing.Size(141, 23);
            this.fixBut2.TabIndex = 1;
            this.fixBut2.Text = "Fix/Unfix Splitter";
            this.fixBut2.UseVisualStyleBackColor = true;
            this.fixBut2.Click += new System.EventHandler(this.fixBut2_Click);
            // 
            // fixBut
            // 
            this.fixBut.CausesValidation = false;
            this.fixBut.Location = new System.Drawing.Point(56, 94);
            this.fixBut.Name = "fixBut";
            this.fixBut.Size = new System.Drawing.Size(141, 23);
            this.fixBut.TabIndex = 0;
            this.fixBut.Text = "Fix/Unfix Panel1";
            this.fixBut.UseVisualStyleBackColor = true;
            this.fixBut.Click += new System.EventHandler(this.fixBut_Click);
            // 
            // pan2But
            // 
            this.pan2But.Location = new System.Drawing.Point(58, 94);
            this.pan2But.Name = "pan2But";
            this.pan2But.Size = new System.Drawing.Size(218, 23);
            this.pan2But.TabIndex = 0;
            this.pan2But.Text = "Collapse/Uncollapse Рапеl1";
            this.pan2But.UseVisualStyleBackColor = true;
            this.pan2But.Click += new System.EventHandler(this.pan2But_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 381);
            this.Controls.Add(this.ignatovControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ignatovControl.ResumeLayout(false);
            this.pervii.ResumeLayout(false);
            this.myBox.ResumeLayout(false);
            this.myBox.PerformLayout();
            this.vtoroi.ResumeLayout(false);
            this.myPanel.ResumeLayout(false);
            this.tretii.ResumeLayout(false);
            this.myFlow.ResumeLayout(false);
            this.chetvert.ResumeLayout(false);
            this.myTLP.ResumeLayout(false);
            this.pyatii.ResumeLayout(false);
            this.mySplitCont.Panel1.ResumeLayout(false);
            this.mySplitCont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mySplitCont)).EndInit();
            this.mySplitCont.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ignatovControl;
        private System.Windows.Forms.TabPage pervii;
        private System.Windows.Forms.TabPage vtoroi;
        private System.Windows.Forms.TabPage tretii;
        private System.Windows.Forms.TabPage chetvert;
        private System.Windows.Forms.TabPage pyatii;
        private System.Windows.Forms.Button but;
        private System.Windows.Forms.GroupBox myBox;
        private System.Windows.Forms.RadioButton myBoxButt2;
        private System.Windows.Forms.RadioButton myBoxButt1;
        private System.Windows.Forms.Panel myPanel;
        private System.Windows.Forms.Button panelBut4;
        private System.Windows.Forms.Button panelBut3;
        private System.Windows.Forms.Button panelBut2;
        private System.Windows.Forms.Button panelBut1;
        private System.Windows.Forms.FlowLayoutPanel myFlow;
        private System.Windows.Forms.Button flowBut1;
        private System.Windows.Forms.Button flowBut2;
        private System.Windows.Forms.Button flowBut3;
        private System.Windows.Forms.Button flowBut4;
        private System.Windows.Forms.TableLayoutPanel myTLP;
        private System.Windows.Forms.Button tlpBut1;
        private System.Windows.Forms.SplitContainer mySplitCont;
        private System.Windows.Forms.Button fixBut2;
        private System.Windows.Forms.Button fixBut;
        private System.Windows.Forms.Button pan2But;
    }
}
