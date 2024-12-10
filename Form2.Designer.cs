namespace projectoPOO
{
	partial class Form2
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
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddPhone = new System.Windows.Forms.TextBox();
            this.txtAddAddress = new System.Windows.Forms.TextBox();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.Label();
            this.txtfjdks = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.Label();
            this.btnCancelAddStudent = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtAddBirthdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeiro Nome";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(148, 123);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(100, 20);
            this.txtAddName.TabIndex = 1;
            // 
            // txtAddPhone
            // 
            this.txtAddPhone.Location = new System.Drawing.Point(349, 205);
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.Size = new System.Drawing.Size(100, 20);
            this.txtAddPhone.TabIndex = 2;
            // 
            // txtAddAddress
            // 
            this.txtAddAddress.Location = new System.Drawing.Point(148, 205);
            this.txtAddAddress.Name = "txtAddAddress";
            this.txtAddAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddAddress.TabIndex = 3;
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Location = new System.Drawing.Point(349, 123);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(100, 20);
            this.txtAddLastName.TabIndex = 4;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(346, 107);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(42, 13);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "Apelido";
            // 
            // txtdate
            // 
            this.txtdate.AutoSize = true;
            this.txtdate.Location = new System.Drawing.Point(563, 107);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(104, 13);
            this.txtdate.TabIndex = 10;
            this.txtdate.Text = "Data de Nascimento";
            // 
            // txtfjdks
            // 
            this.txtfjdks.AutoSize = true;
            this.txtfjdks.Location = new System.Drawing.Point(145, 189);
            this.txtfjdks.Name = "txtfjdks";
            this.txtfjdks.Size = new System.Drawing.Size(43, 13);
            this.txtfjdks.TabIndex = 11;
            this.txtfjdks.Text = "Morada";
            // 
            // txtphone
            // 
            this.txtphone.AutoSize = true;
            this.txtphone.Location = new System.Drawing.Point(346, 189);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(49, 13);
            this.txtphone.TabIndex = 13;
            this.txtphone.Text = "Telefone";
            // 
            // btnCancelAddStudent
            // 
            this.btnCancelAddStudent.Location = new System.Drawing.Point(591, 402);
            this.btnCancelAddStudent.Name = "btnCancelAddStudent";
            this.btnCancelAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddStudent.TabIndex = 16;
            this.btnCancelAddStudent.Text = "Cancelar";
            this.btnCancelAddStudent.UseVisualStyleBackColor = true;
            this.btnCancelAddStudent.Click += new System.EventHandler(this.btnCancelAddStudent_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Novo Aluno";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(693, 402);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 18;
            this.btnAddStudent.Text = "Adicionar";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtAddBirthdate
            // 
            this.txtAddBirthdate.CustomFormat = "yyyy-mm-dd";
            this.txtAddBirthdate.Location = new System.Drawing.Point(524, 123);
            this.txtAddBirthdate.MaxDate = new System.DateTime(2024, 12, 8, 0, 0, 0, 0);
            this.txtAddBirthdate.Name = "txtAddBirthdate";
            this.txtAddBirthdate.Size = new System.Drawing.Size(200, 20);
            this.txtAddBirthdate.TabIndex = 19;
            this.txtAddBirthdate.Value = new System.DateTime(2024, 12, 8, 0, 0, 0, 0);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAddBirthdate);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelAddStudent);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtfjdks);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtAddLastName);
            this.Controls.Add(this.txtAddAddress);
            this.Controls.Add(this.txtAddPhone);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Novo Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAddName;
		private System.Windows.Forms.TextBox txtAddPhone;
		private System.Windows.Forms.TextBox txtAddAddress;
		private System.Windows.Forms.TextBox txtAddLastName;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label txtdate;
		private System.Windows.Forms.Label txtfjdks;
		private System.Windows.Forms.Label txtphone;
		private System.Windows.Forms.Button btnCancelAddStudent;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnAddStudent;
		private System.Windows.Forms.DateTimePicker txtAddBirthdate;
	}
}