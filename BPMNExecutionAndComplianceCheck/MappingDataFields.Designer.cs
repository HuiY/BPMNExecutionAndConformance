namespace BPMNExecutionAndComplianceCheck
{
    partial class MappingDataFields
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
            this.radBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cB_LogAll = new System.Windows.Forms.CheckBox();
            this.cB_modelAll = new System.Windows.Forms.CheckBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxModel = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // radBtn
            // 
            this.radBtn.AutoSize = true;
            this.radBtn.Location = new System.Drawing.Point(147, 445);
            this.radBtn.Name = "radBtn";
            this.radBtn.Size = new System.Drawing.Size(69, 17);
            this.radBtn.TabIndex = 15;
            this.radBtn.TabStop = true;
            this.radBtn.Text = "Template";
            this.radBtn.UseVisualStyleBackColor = true;
            this.radBtn.CheckedChanged += new System.EventHandler(this.radBtn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Activities in log:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Activities in model:";
            // 
            // cB_LogAll
            // 
            this.cB_LogAll.AutoSize = true;
            this.cB_LogAll.Location = new System.Drawing.Point(301, 445);
            this.cB_LogAll.Name = "cB_LogAll";
            this.cB_LogAll.Size = new System.Drawing.Size(37, 17);
            this.cB_LogAll.TabIndex = 12;
            this.cB_LogAll.Text = "All";
            this.cB_LogAll.UseVisualStyleBackColor = true;
            this.cB_LogAll.CheckedChanged += new System.EventHandler(this.cB_LogAll_CheckedChanged);
            // 
            // cB_modelAll
            // 
            this.cB_modelAll.AutoSize = true;
            this.cB_modelAll.Location = new System.Drawing.Point(13, 445);
            this.cB_modelAll.Name = "cB_modelAll";
            this.cB_modelAll.Size = new System.Drawing.Size(37, 17);
            this.cB_modelAll.TabIndex = 11;
            this.cB_modelAll.Text = "All";
            this.cB_modelAll.UseVisualStyleBackColor = true;
            this.cB_modelAll.CheckedChanged += new System.EventHandler(this.cB_modelAll_CheckedChanged);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(509, 451);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 10;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(301, 30);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(305, 409);
            this.checkedListBox2.TabIndex = 9;
            // 
            // checkedListBoxModel
            // 
            this.checkedListBoxModel.CheckOnClick = true;
            this.checkedListBoxModel.FormattingEnabled = true;
            this.checkedListBoxModel.Location = new System.Drawing.Point(13, 30);
            this.checkedListBoxModel.Name = "checkedListBoxModel";
            this.checkedListBoxModel.Size = new System.Drawing.Size(245, 409);
            this.checkedListBoxModel.TabIndex = 8;
            // 
            // MappingDataFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 484);
            this.Controls.Add(this.radBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_LogAll);
            this.Controls.Add(this.cB_modelAll);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBoxModel);
            this.Name = "MappingDataFields";
            this.Text = "MappingDataFields";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cB_LogAll;
        private System.Windows.Forms.CheckBox cB_modelAll;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBoxModel;
    }
}