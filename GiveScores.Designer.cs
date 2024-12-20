namespace projectoPOO
{
    partial class GiveScores
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
            this.cbScore = new System.Windows.Forms.ComboBox();
            this.cbAttendance = new System.Windows.Forms.CheckBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelScoreAttribution = new System.Windows.Forms.Button();
            this.btnScoreAttribution = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchStudentScore = new System.Windows.Forms.Button();
            this.txtSearchStudentScore = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblSeason = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbScore
            // 
            this.cbScore.FormattingEnabled = true;
            this.cbScore.Location = new System.Drawing.Point(321, 153);
            this.cbScore.Name = "cbScore";
            this.cbScore.Size = new System.Drawing.Size(77, 21);
            this.cbScore.TabIndex = 1;
            // 
            // cbAttendance
            // 
            this.cbAttendance.AutoSize = true;
            this.cbAttendance.Location = new System.Drawing.Point(321, 180);
            this.cbAttendance.Name = "cbAttendance";
            this.cbAttendance.Size = new System.Drawing.Size(49, 17);
            this.cbAttendance.TabIndex = 2;
            this.cbAttendance.Text = "Falta";
            this.cbAttendance.UseVisualStyleBackColor = true;
            this.cbAttendance.CheckedChanged += new System.EventHandler(this.cbAttendance_CheckedChanged);
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(318, 128);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(30, 13);
            this.lblStudentNumber.TabIndex = 12;
            this.lblStudentNumber.Text = "Nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Atribuição de Notas";
            // 
            // btnCancelScoreAttribution
            // 
            this.btnCancelScoreAttribution.Location = new System.Drawing.Point(357, 259);
            this.btnCancelScoreAttribution.Name = "btnCancelScoreAttribution";
            this.btnCancelScoreAttribution.Size = new System.Drawing.Size(75, 23);
            this.btnCancelScoreAttribution.TabIndex = 22;
            this.btnCancelScoreAttribution.Text = "Cancelar";
            this.btnCancelScoreAttribution.UseVisualStyleBackColor = true;
            this.btnCancelScoreAttribution.Click += new System.EventHandler(this.btnCancelScoreAttribution_Click);
            // 
            // btnScoreAttribution
            // 
            this.btnScoreAttribution.Location = new System.Drawing.Point(454, 259);
            this.btnScoreAttribution.Name = "btnScoreAttribution";
            this.btnScoreAttribution.Size = new System.Drawing.Size(75, 23);
            this.btnScoreAttribution.TabIndex = 21;
            this.btnScoreAttribution.Text = "Lançar Nota";
            this.btnScoreAttribution.UseVisualStyleBackColor = true;
            this.btnScoreAttribution.Click += new System.EventHandler(this.btnScoreAttribution_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Número de Aluno";
            // 
            // btnSearchStudentScore
            // 
            this.btnSearchStudentScore.Location = new System.Drawing.Point(184, 63);
            this.btnSearchStudentScore.Name = "btnSearchStudentScore";
            this.btnSearchStudentScore.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStudentScore.TabIndex = 24;
            this.btnSearchStudentScore.Text = "Pesquisar Aluno";
            this.btnSearchStudentScore.UseVisualStyleBackColor = true;
            this.btnSearchStudentScore.Click += new System.EventHandler(this.btnSearchStudentScore_Click);
            // 
            // txtSearchStudentScore
            // 
            this.txtSearchStudentScore.Location = new System.Drawing.Point(76, 65);
            this.txtSearchStudentScore.Name = "txtSearchStudentScore";
            this.txtSearchStudentScore.Size = new System.Drawing.Size(92, 20);
            this.txtSearchStudentScore.TabIndex = 23;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(318, 65);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(86, 13);
            this.lblStudentName.TabIndex = 27;
            this.lblStudentName.Text = "Nome do Aluno: ";
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.Location = new System.Drawing.Point(360, 91);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(10, 13);
            this.lblSeason.TabIndex = 28;
            this.lblSeason.Text = " \r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Época: ";
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(77, 153);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(182, 21);
            this.cbSubject.TabIndex = 0;
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Unidade Curricular";
            // 
            // GiveScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 294);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearchStudentScore);
            this.Controls.Add(this.txtSearchStudentScore);
            this.Controls.Add(this.btnCancelScoreAttribution);
            this.Controls.Add(this.btnScoreAttribution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.cbAttendance);
            this.Controls.Add(this.cbScore);
            this.Controls.Add(this.cbSubject);
            this.Name = "GiveScores";
            this.Text = "GiveScores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbScore;
        private System.Windows.Forms.CheckBox cbAttendance;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelScoreAttribution;
        private System.Windows.Forms.Button btnScoreAttribution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchStudentScore;
        private System.Windows.Forms.TextBox txtSearchStudentScore;
        private System.Windows.Forms.Label lblStudentName;
		private System.Windows.Forms.Label lblSeason;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label label1;
    }
}