namespace WinFormAppEntityFramework.GUI
{
    partial class TestForm2
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
            this.labelProjInfo = new System.Windows.Forms.Label();
            this.labelEmpInfo = new System.Windows.Forms.Label();
            this.buttonAssignProject = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxEndDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStartDate = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelProjInfo
            // 
            this.labelProjInfo.AutoSize = true;
            this.labelProjInfo.Location = new System.Drawing.Point(352, 277);
            this.labelProjInfo.Name = "labelProjInfo";
            this.labelProjInfo.Size = new System.Drawing.Size(52, 17);
            this.labelProjInfo.TabIndex = 24;
            this.labelProjInfo.Text = "Project";
            // 
            // labelEmpInfo
            // 
            this.labelEmpInfo.AutoSize = true;
            this.labelEmpInfo.Location = new System.Drawing.Point(60, 254);
            this.labelEmpInfo.Name = "labelEmpInfo";
            this.labelEmpInfo.Size = new System.Drawing.Size(70, 17);
            this.labelEmpInfo.TabIndex = 23;
            this.labelEmpInfo.Text = "Employee";
            // 
            // buttonAssignProject
            // 
            this.buttonAssignProject.Location = new System.Drawing.Point(54, 274);
            this.buttonAssignProject.Name = "buttonAssignProject";
            this.buttonAssignProject.Size = new System.Drawing.Size(147, 46);
            this.buttonAssignProject.TabIndex = 22;
            this.buttonAssignProject.Text = "Assign Project";
            this.buttonAssignProject.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ending Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Starting Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Select Project";
            // 
            // maskedTextBoxEndDate
            // 
            this.maskedTextBoxEndDate.Location = new System.Drawing.Point(590, 228);
            this.maskedTextBoxEndDate.Mask = "00/00/0000";
            this.maskedTextBoxEndDate.Name = "maskedTextBoxEndDate";
            this.maskedTextBoxEndDate.Size = new System.Drawing.Size(170, 22);
            this.maskedTextBoxEndDate.TabIndex = 18;
            this.maskedTextBoxEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxStartDate
            // 
            this.maskedTextBoxStartDate.Location = new System.Drawing.Point(590, 174);
            this.maskedTextBoxStartDate.Mask = "00/00/0000";
            this.maskedTextBoxStartDate.Name = "maskedTextBoxStartDate";
            this.maskedTextBoxStartDate.Size = new System.Drawing.Size(170, 22);
            this.maskedTextBoxStartDate.TabIndex = 17;
            this.maskedTextBoxStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(361, 204);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(186, 24);
            this.comboBoxProject.TabIndex = 16;
            this.comboBoxProject.SelectedIndexChanged += new System.EventHandler(this.comboBoxProject_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select Employee";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(45, 204);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(186, 24);
            this.comboBoxEmployee.TabIndex = 14;
            this.comboBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployee_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Employee - Project Assignment";
            // 
            // TestForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelProjInfo);
            this.Controls.Add(this.labelEmpInfo);
            this.Controls.Add(this.buttonAssignProject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBoxEndDate);
            this.Controls.Add(this.maskedTextBoxStartDate);
            this.Controls.Add(this.comboBoxProject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.label1);
            this.Name = "TestForm2";
            this.Text = "TestForm2";
            this.Load += new System.EventHandler(this.TestForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProjInfo;
        private System.Windows.Forms.Label labelEmpInfo;
        private System.Windows.Forms.Button buttonAssignProject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartDate;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label label1;
    }
}