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
            this.dgAllScores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchStudentExamEntry = new System.Windows.Forms.Button();
            this.txtSearchStudentExamEntry = new System.Windows.Forms.TextBox();
            this.btnEnrollStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.btnCancelUpdateStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllScores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAllScores
            // 
            this.dgAllScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllScores.Location = new System.Drawing.Point(12, 46);
            this.dgAllScores.Name = "dgAllScores";
            this.dgAllScores.Size = new System.Drawing.Size(314, 316);
            this.dgAllScores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inscrever em Exame";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número de Aluno";
            // 
            // btnSearchStudentExamEntry
            // 
            this.btnSearchStudentExamEntry.Location = new System.Drawing.Point(120, 17);
            this.btnSearchStudentExamEntry.Name = "btnSearchStudentExamEntry";
            this.btnSearchStudentExamEntry.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStudentExamEntry.TabIndex = 5;
            this.btnSearchStudentExamEntry.Text = "Pesquisar Aluno";
            this.btnSearchStudentExamEntry.UseVisualStyleBackColor = true;
            this.btnSearchStudentExamEntry.Click += new System.EventHandler(this.btnSearchStudentExamEntry_Click);
            // 
            // txtSearchStudentExamEntry
            // 
            this.txtSearchStudentExamEntry.Location = new System.Drawing.Point(12, 19);
            this.txtSearchStudentExamEntry.Name = "txtSearchStudentExamEntry";
            this.txtSearchStudentExamEntry.Size = new System.Drawing.Size(92, 20);
            this.txtSearchStudentExamEntry.TabIndex = 4;
            // 
            // btnEnrollStudent
            // 
            this.btnEnrollStudent.Location = new System.Drawing.Point(508, 216);
            this.btnEnrollStudent.Name = "btnEnrollStudent";
            this.btnEnrollStudent.Size = new System.Drawing.Size(115, 23);
            this.btnEnrollStudent.TabIndex = 24;
            this.btnEnrollStudent.Text = "Época Especial ";
            this.btnEnrollStudent.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(367, 216);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(115, 23);
            this.btnDeleteStudent.TabIndex = 23;
            this.btnDeleteStudent.Text = "Época de Recurso";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(593, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(30, 13);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Nota";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(342, 57);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(140, 13);
            this.lblStudentNumber.TabIndex = 27;
            this.lblStudentNumber.Text = "Nome da Unidade Curricular";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(595, 73);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(28, 20);
            this.txtStudentName.TabIndex = 26;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(342, 73);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(227, 20);
            this.txtStudentNumber.TabIndex = 25;
            // 
            // btnCancelUpdateStudent
            // 
            this.btnCancelUpdateStudent.Location = new System.Drawing.Point(481, 339);
            this.btnCancelUpdateStudent.Name = "btnCancelUpdateStudent";
            this.btnCancelUpdateStudent.Size = new System.Drawing.Size(75, 23);
            this.btnCancelUpdateStudent.TabIndex = 30;
            this.btnCancelUpdateStudent.Text = "Cancelar";
            this.btnCancelUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(562, 339);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStudent.TabIndex = 29;
            this.btnUpdateStudent.Text = "Confirmar";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // ExamEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 374);
            this.Controls.Add(this.btnCancelUpdateStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.btnEnrollStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchStudentExamEntry);
            this.Controls.Add(this.txtSearchStudentExamEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgAllScores);
            this.Name = "ExamEntry";
            this.Text = "ExamEntry";
            ((System.ComponentModel.ISupportInitialize)(this.dgAllScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAllScores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchStudentExamEntry;
        private System.Windows.Forms.TextBox txtSearchStudentExamEntry;
        private System.Windows.Forms.Button btnEnrollStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Button btnCancelUpdateStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
    }
}