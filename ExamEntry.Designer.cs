namespace projectoPOO
{
    partial class ExamEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchStudentExam = new System.Windows.Forms.Button();
            this.txtSearchStudentExam = new System.Windows.Forms.TextBox();
            this.btnSpecialExam = new System.Windows.Forms.Button();
            this.btnAppealExam = new System.Windows.Forms.Button();
            this.btnCancelExam = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSubjectExam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStudentNameExam = new System.Windows.Forms.Label();
            this.cbAppealSubjectExam = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inscrever em Exame";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número de Aluno";
            // 
            // btnSearchStudentExam
            // 
            this.btnSearchStudentExam.Location = new System.Drawing.Point(12, 87);
            this.btnSearchStudentExam.Name = "btnSearchStudentExam";
            this.btnSearchStudentExam.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStudentExam.TabIndex = 5;
            this.btnSearchStudentExam.Text = "Pesquisar Aluno";
            this.btnSearchStudentExam.UseVisualStyleBackColor = true;
            this.btnSearchStudentExam.Click += new System.EventHandler(this.btnSearchStudentExamEntry_Click);
            // 
            // txtSearchStudentExam
            // 
            this.txtSearchStudentExam.Location = new System.Drawing.Point(12, 61);
            this.txtSearchStudentExam.Name = "txtSearchStudentExam";
            this.txtSearchStudentExam.Size = new System.Drawing.Size(92, 20);
            this.txtSearchStudentExam.TabIndex = 4;
            // 
            // btnSpecialExam
            // 
            this.btnSpecialExam.Location = new System.Drawing.Point(189, 191);
            this.btnSpecialExam.Name = "btnSpecialExam";
            this.btnSpecialExam.Size = new System.Drawing.Size(115, 23);
            this.btnSpecialExam.TabIndex = 24;
            this.btnSpecialExam.Text = "Época Especial ";
            this.btnSpecialExam.UseVisualStyleBackColor = true;
            this.btnSpecialExam.Click += new System.EventHandler(this.btnSpecialExam_Click);
            // 
            // btnAppealExam
            // 
            this.btnAppealExam.Location = new System.Drawing.Point(12, 191);
            this.btnAppealExam.Name = "btnAppealExam";
            this.btnAppealExam.Size = new System.Drawing.Size(115, 23);
            this.btnAppealExam.TabIndex = 23;
            this.btnAppealExam.Text = "Época de Recurso";
            this.btnAppealExam.UseVisualStyleBackColor = true;
            this.btnAppealExam.Click += new System.EventHandler(this.btnAppealExam_Click);
            // 
            // btnCancelExam
            // 
            this.btnCancelExam.Location = new System.Drawing.Point(368, 191);
            this.btnCancelExam.Name = "btnCancelExam";
            this.btnCancelExam.Size = new System.Drawing.Size(75, 23);
            this.btnCancelExam.TabIndex = 30;
            this.btnCancelExam.Text = "Sair";
            this.btnCancelExam.UseVisualStyleBackColor = true;
            this.btnCancelExam.Click += new System.EventHandler(this.btnCancelExam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Unidade Curricular";
            // 
            // cbSubjectExam
            // 
            this.cbSubjectExam.FormattingEnabled = true;
            this.cbSubjectExam.Location = new System.Drawing.Point(261, 84);
            this.cbSubjectExam.Name = "cbSubjectExam";
            this.cbSubjectExam.Size = new System.Drawing.Size(182, 21);
            this.cbSubjectExam.TabIndex = 31;
            this.cbSubjectExam.SelectedIndexChanged += new System.EventHandler(this.cbSubjectExam_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Época Recurso";
            // 
            // lblStudentNameExam
            // 
            this.lblStudentNameExam.AutoSize = true;
            this.lblStudentNameExam.Location = new System.Drawing.Point(258, 27);
            this.lblStudentNameExam.Name = "lblStudentNameExam";
            this.lblStudentNameExam.Size = new System.Drawing.Size(86, 13);
            this.lblStudentNameExam.TabIndex = 35;
            this.lblStudentNameExam.Text = "Nome do Aluno: ";
            // 
            // cbAppealSubjectExam
            // 
            this.cbAppealSubjectExam.FormattingEnabled = true;
            this.cbAppealSubjectExam.Location = new System.Drawing.Point(261, 144);
            this.cbAppealSubjectExam.Name = "cbAppealSubjectExam";
            this.cbAppealSubjectExam.Size = new System.Drawing.Size(182, 21);
            this.cbAppealSubjectExam.TabIndex = 36;
            this.cbAppealSubjectExam.SelectedIndexChanged += new System.EventHandler(this.cbAppealSubjectExam_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Unidade Curricular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Época Especial";
            // 
            // ExamEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 226);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbAppealSubjectExam);
            this.Controls.Add(this.lblStudentNameExam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSubjectExam);
            this.Controls.Add(this.btnCancelExam);
            this.Controls.Add(this.btnSpecialExam);
            this.Controls.Add(this.btnAppealExam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchStudentExam);
            this.Controls.Add(this.txtSearchStudentExam);
            this.Controls.Add(this.label1);
            this.Name = "ExamEntry";
            this.Text = "ExamEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchStudentExam;
        private System.Windows.Forms.TextBox txtSearchStudentExam;
        private System.Windows.Forms.Button btnSpecialExam;
        private System.Windows.Forms.Button btnAppealExam;
        private System.Windows.Forms.Button btnCancelExam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSubjectExam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStudentNameExam;
        private System.Windows.Forms.ComboBox cbAppealSubjectExam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}