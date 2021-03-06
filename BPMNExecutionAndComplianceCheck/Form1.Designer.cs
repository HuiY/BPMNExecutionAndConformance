﻿namespace BPMNExecutionAndComplianceCheck
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BPMNExec = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_generate = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cB_Gate2 = new System.Windows.Forms.CheckBox();
            this.cB_BothStartEnd = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_OpenStatespace = new System.Windows.Forms.Button();
            this.txbBx_statespaceAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DevCheck = new System.Windows.Forms.Button();
            this.btn_OpenLog = new System.Windows.Forms.Button();
            this.LogFileTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.DataViewForAlignment = new System.Windows.Forms.DataGridView();
            this.btn_Show = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dataGridViewModel = new System.Windows.Forms.DataGridView();
            this.dataGridViewLog = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BPMNExec.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewForAlignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).BeginInit();
            this.SuspendLayout();
            // 
            // BPMNExec
            // 
            this.BPMNExec.Controls.Add(this.tabPage1);
            this.BPMNExec.Controls.Add(this.tabPage2);
            this.BPMNExec.Location = new System.Drawing.Point(2, 2);
            this.BPMNExec.Name = "BPMNExec";
            this.BPMNExec.SelectedIndex = 0;
            this.BPMNExec.Size = new System.Drawing.Size(295, 143);
            this.BPMNExec.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.btn_open);
            this.tabPage1.Controls.Add(this.btn_generate);
            this.tabPage1.Controls.Add(this.textBoxFilePath);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(287, 117);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BPMN";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(206, 60);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 21);
            this.btn_open.TabIndex = 28;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(206, 89);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 21);
            this.btn_generate.TabIndex = 27;
            this.btn_generate.Text = "Generate Statespace";
            this.toolTip1.SetToolTip(this.btn_generate, "\"The generated statespace is stored in the same file with After\"");
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(16, 30);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(263, 21);
            this.textBoxFilePath.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "Please select a .xpdl file to generate a statespace:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cB_Gate2);
            this.groupBox1.Controls.Add(this.cB_BothStartEnd);
            this.groupBox1.Location = new System.Drawing.Point(16, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 60);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preference";
            // 
            // cB_Gate2
            // 
            this.cB_Gate2.AutoSize = true;
            this.cB_Gate2.Location = new System.Drawing.Point(6, 39);
            this.cB_Gate2.Name = "cB_Gate2";
            this.cB_Gate2.Size = new System.Drawing.Size(192, 16);
            this.cB_Gate2.TabIndex = 8;
            this.cB_Gate2.Text = "Gateways and Events Included";
            this.cB_Gate2.UseVisualStyleBackColor = true;
            // 
            // cB_BothStartEnd
            // 
            this.cB_BothStartEnd.AutoSize = true;
            this.cB_BothStartEnd.Location = new System.Drawing.Point(6, 18);
            this.cB_BothStartEnd.Name = "cB_BothStartEnd";
            this.cB_BothStartEnd.Size = new System.Drawing.Size(132, 16);
            this.cB_BothStartEnd.TabIndex = 7;
            this.cB_BothStartEnd.Text = "Both Start and End";
            this.cB_BothStartEnd.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPage2.Controls.Add(this.btn_OpenStatespace);
            this.tabPage2.Controls.Add(this.txbBx_statespaceAdress);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(287, 117);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Statespace";
            // 
            // btn_OpenStatespace
            // 
            this.btn_OpenStatespace.Location = new System.Drawing.Point(18, 71);
            this.btn_OpenStatespace.Name = "btn_OpenStatespace";
            this.btn_OpenStatespace.Size = new System.Drawing.Size(75, 21);
            this.btn_OpenStatespace.TabIndex = 31;
            this.btn_OpenStatespace.Text = "Open";
            this.btn_OpenStatespace.UseVisualStyleBackColor = true;
            this.btn_OpenStatespace.Click += new System.EventHandler(this.btn_OpenStatespace_Click);
            // 
            // txbBx_statespaceAdress
            // 
            this.txbBx_statespaceAdress.Location = new System.Drawing.Point(18, 39);
            this.txbBx_statespaceAdress.Name = "txbBx_statespaceAdress";
            this.txbBx_statespaceAdress.Size = new System.Drawing.Size(248, 21);
            this.txbBx_statespaceAdress.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "Please select a statespace file(.grs) to show:";
            // 
            // btn_DevCheck
            // 
            this.btn_DevCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DevCheck.Location = new System.Drawing.Point(1680, 20);
            this.btn_DevCheck.Name = "btn_DevCheck";
            this.btn_DevCheck.Size = new System.Drawing.Size(94, 49);
            this.btn_DevCheck.TabIndex = 28;
            this.btn_DevCheck.Text = "Deviation Check";
            this.btn_DevCheck.UseVisualStyleBackColor = true;
            this.btn_DevCheck.Click += new System.EventHandler(this.btn_DevCheck_Click);
            // 
            // btn_OpenLog
            // 
            this.btn_OpenLog.Location = new System.Drawing.Point(1409, 15);
            this.btn_OpenLog.Name = "btn_OpenLog";
            this.btn_OpenLog.Size = new System.Drawing.Size(85, 21);
            this.btn_OpenLog.TabIndex = 27;
            this.btn_OpenLog.Text = "Open a trace";
            this.btn_OpenLog.UseVisualStyleBackColor = true;
            this.btn_OpenLog.Click += new System.EventHandler(this.btn_OpenTrace_Click);
            // 
            // LogFileTb
            // 
            this.LogFileTb.Location = new System.Drawing.Point(1225, 37);
            this.LogFileTb.Name = "LogFileTb";
            this.LogFileTb.Size = new System.Drawing.Size(356, 21);
            this.LogFileTb.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1222, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "Please select a .xml (log) file to open:";
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(9, 150);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(730, 800);
            this.elementHost1.TabIndex = 22;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // DataViewForAlignment
            // 
            this.DataViewForAlignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewForAlignment.Location = new System.Drawing.Point(745, 523);
            this.DataViewForAlignment.Name = "DataViewForAlignment";
            this.DataViewForAlignment.Size = new System.Drawing.Size(1063, 128);
            this.DataViewForAlignment.TabIndex = 29;
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.Location = new System.Drawing.Point(303, 66);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(88, 21);
            this.btn_Show.TabIndex = 30;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1506, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 31;
            this.button1.Text = "Open a log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenALog_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(1733, 937);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 21);
            this.btn_save.TabIndex = 32;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dataGridViewModel
            // 
            this.dataGridViewModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModel.Location = new System.Drawing.Point(745, 669);
            this.dataGridViewModel.Name = "dataGridViewModel";
            this.dataGridViewModel.Size = new System.Drawing.Size(1063, 122);
            this.dataGridViewModel.TabIndex = 33;
            // 
            // dataGridViewLog
            // 
            this.dataGridViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLog.Location = new System.Drawing.Point(745, 809);
            this.dataGridViewLog.Name = "dataGridViewLog";
            this.dataGridViewLog.Size = new System.Drawing.Size(1063, 126);
            this.dataGridViewLog.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(745, 654);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 12);
            this.label4.TabIndex = 35;
            this.label4.Text = "Results of activities in the model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(745, 794);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 12);
            this.label5.TabIndex = 36;
            this.label5.Text = "Results of events in the log:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(745, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 12);
            this.label6.TabIndex = 37;
            this.label6.Text = "Results of patient traces:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1813, 959);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewLog);
            this.Controls.Add(this.dataGridViewModel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_DevCheck);
            this.Controls.Add(this.btn_OpenLog);
            this.Controls.Add(this.LogFileTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.DataViewForAlignment);
            this.Controls.Add(this.BPMNExec);
            this.Name = "Form1";
            this.Text = "BPMN and Deviations";
            this.BPMNExec.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewForAlignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl BPMNExec;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cB_Gate2;
        private System.Windows.Forms.CheckBox cB_BothStartEnd;
        private System.Windows.Forms.Button btn_OpenStatespace;
        private System.Windows.Forms.TextBox txbBx_statespaceAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_DevCheck;
        private System.Windows.Forms.Button btn_OpenLog;
        private System.Windows.Forms.TextBox LogFileTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.DataGridView DataViewForAlignment;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dataGridViewModel;
        private System.Windows.Forms.DataGridView dataGridViewLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

