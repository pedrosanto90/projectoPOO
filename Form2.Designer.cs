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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAddNameStudent = new System.Windows.Forms.TextBox();
			this.txtAddPhoneStudent = new System.Windows.Forms.TextBox();
			this.txtAddAddressStudent = new System.Windows.Forms.TextBox();
			this.txtAddLastNameStudent = new System.Windows.Forms.TextBox();
			this.lbl2 = new System.Windows.Forms.Label();
			this.txtdate = new System.Windows.Forms.Label();
			this.txtfjdks = new System.Windows.Forms.Label();
			this.txtphone = new System.Windows.Forms.Label();
			this.btnCancelAddStudent = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.btnAddStudent = new System.Windows.Forms.Button();
			this.txtAddBirthdateStudent = new System.Windows.Forms.DateTimePicker();
			this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.txtAddCourse = new System.Windows.Forms.TextBox();
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
			// txtAddNameStudent
			// 
			this.txtAddNameStudent.Location = new System.Drawing.Point(148, 123);
			this.txtAddNameStudent.Name = "txtAddNameStudent";
			this.txtAddNameStudent.Size = new System.Drawing.Size(100, 20);
			this.txtAddNameStudent.TabIndex = 1;
			// 
			// txtAddPhoneStudent
			// 
			this.txtAddPhoneStudent.Location = new System.Drawing.Point(349, 205);
			this.txtAddPhoneStudent.Name = "txtAddPhoneStudent";
			this.txtAddPhoneStudent.Size = new System.Drawing.Size(100, 20);
			this.txtAddPhoneStudent.TabIndex = 2;
			// 
			// txtAddAddressStudent
			// 
			this.txtAddAddressStudent.Location = new System.Drawing.Point(148, 205);
			this.txtAddAddressStudent.Name = "txtAddAddressStudent";
			this.txtAddAddressStudent.Size = new System.Drawing.Size(100, 20);
			this.txtAddAddressStudent.TabIndex = 3;
			// 
			// txtAddLastNameStudent
			// 
			this.txtAddLastNameStudent.Location = new System.Drawing.Point(349, 123);
			this.txtAddLastNameStudent.Name = "txtAddLastNameStudent";
			this.txtAddLastNameStudent.Size = new System.Drawing.Size(100, 20);
			this.txtAddLastNameStudent.TabIndex = 4;
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
			this.txtdate.Location = new System.Drawing.Point(517, 189);
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
			// txtAddBirthdateStudent
			// 
			this.txtAddBirthdateStudent.CustomFormat = "yyyy-mm-dd";
			this.txtAddBirthdateStudent.Location = new System.Drawing.Point(520, 205);
			this.txtAddBirthdateStudent.MaxDate = new System.DateTime(2024, 12, 8, 0, 0, 0, 0);
			this.txtAddBirthdateStudent.Name = "txtAddBirthdateStudent";
			this.txtAddBirthdateStudent.Size = new System.Drawing.Size(200, 20);
			this.txtAddBirthdateStudent.TabIndex = 19;
			this.txtAddBirthdateStudent.Value = new System.DateTime(2024, 12, 8, 0, 0, 0, 0);
			// 
			// mySqlCommand1
			// 
			this.mySqlCommand1.CacheAge = 0;
			this.mySqlCommand1.Connection = null;
			this.mySqlCommand1.EnableCaching = false;
			this.mySqlCommand1.Transaction = null;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(520, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 21;
			this.label2.Text = "Curso (Sigla)";
			// 
			// txtAddCourse
			// 
			this.txtAddCourse.Location = new System.Drawing.Point(520, 123);
			this.txtAddCourse.Name = "txtAddCourse";
			this.txtAddCourse.Size = new System.Drawing.Size(100, 20);
			this.txtAddCourse.TabIndex = 22;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtAddCourse);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtAddBirthdateStudent);
			this.Controls.Add(this.btnAddStudent);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnCancelAddStudent);
			this.Controls.Add(this.txtphone);
			this.Controls.Add(this.txtfjdks);
			this.Controls.Add(this.txtdate);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.txtAddLastNameStudent);
			this.Controls.Add(this.txtAddAddressStudent);
			this.Controls.Add(this.txtAddPhoneStudent);
			this.Controls.Add(this.txtAddNameStudent);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Novo Aluno";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAddNameStudent;
		private System.Windows.Forms.TextBox txtAddPhoneStudent;
		private System.Windows.Forms.TextBox txtAddAddressStudent;
		private System.Windows.Forms.TextBox txtAddLastNameStudent;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label txtdate;
		private System.Windows.Forms.Label txtfjdks;
		private System.Windows.Forms.Label txtphone;
		private System.Windows.Forms.Button btnCancelAddStudent;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnAddStudent;
		private System.Windows.Forms.DateTimePicker txtAddBirthdateStudent;
		private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAddCourse;
	}
}