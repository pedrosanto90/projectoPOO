namespace projectoPOO
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
			this.lbl_conn = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabStudents = new System.Windows.Forms.TabPage();
			this.tabTeachers = new System.Windows.Forms.TabPage();
			this.tabCourses = new System.Windows.Forms.TabPage();
			this.tabSubjects = new System.Windows.Forms.TabPage();
			this.txtSearchStudent = new System.Windows.Forms.TextBox();
			this.btnSearchStudent = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtStudentNumber = new System.Windows.Forms.TextBox();
			this.txtStudentName = new System.Windows.Forms.TextBox();
			this.txtStudentBirthdate = new System.Windows.Forms.TextBox();
			this.txtStudentEmail = new System.Windows.Forms.TextBox();
			this.txtStudentCourse = new System.Windows.Forms.TextBox();
			this.txtStudentLastName = new System.Windows.Forms.TextBox();
			this.txtStudentAddress = new System.Windows.Forms.TextBox();
			this.txtStudentPhone = new System.Windows.Forms.TextBox();
			this.lblStudentNumber = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblBirthDate = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblCourse = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabStudents.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_conn
			// 
			this.lbl_conn.AutoSize = true;
			this.lbl_conn.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lbl_conn.Location = new System.Drawing.Point(0, 437);
			this.lbl_conn.Name = "lbl_conn";
			this.lbl_conn.Size = new System.Drawing.Size(35, 13);
			this.lbl_conn.TabIndex = 2;
			this.lbl_conn.Text = "label2";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabStudents);
			this.tabControl1.Controls.Add(this.tabTeachers);
			this.tabControl1.Controls.Add(this.tabCourses);
			this.tabControl1.Controls.Add(this.tabSubjects);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 437);
			this.tabControl1.TabIndex = 3;
			// 
			// tabStudents
			// 
			this.tabStudents.Controls.Add(this.lblPhone);
			this.tabStudents.Controls.Add(this.lblAddress);
			this.tabStudents.Controls.Add(this.lblLastName);
			this.tabStudents.Controls.Add(this.lblCourse);
			this.tabStudents.Controls.Add(this.lblEmail);
			this.tabStudents.Controls.Add(this.lblBirthDate);
			this.tabStudents.Controls.Add(this.lblName);
			this.tabStudents.Controls.Add(this.lblStudentNumber);
			this.tabStudents.Controls.Add(this.txtStudentPhone);
			this.tabStudents.Controls.Add(this.txtStudentAddress);
			this.tabStudents.Controls.Add(this.txtStudentLastName);
			this.tabStudents.Controls.Add(this.txtStudentCourse);
			this.tabStudents.Controls.Add(this.txtStudentEmail);
			this.tabStudents.Controls.Add(this.txtStudentBirthdate);
			this.tabStudents.Controls.Add(this.txtStudentName);
			this.tabStudents.Controls.Add(this.txtStudentNumber);
			this.tabStudents.Controls.Add(this.label1);
			this.tabStudents.Controls.Add(this.btnSearchStudent);
			this.tabStudents.Controls.Add(this.txtSearchStudent);
			this.tabStudents.Location = new System.Drawing.Point(4, 22);
			this.tabStudents.Name = "tabStudents";
			this.tabStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tabStudents.Size = new System.Drawing.Size(792, 411);
			this.tabStudents.TabIndex = 0;
			this.tabStudents.Text = "Alunos";
			this.tabStudents.UseVisualStyleBackColor = true;
			// 
			// tabTeachers
			// 
			this.tabTeachers.Location = new System.Drawing.Point(4, 22);
			this.tabTeachers.Name = "tabTeachers";
			this.tabTeachers.Padding = new System.Windows.Forms.Padding(3);
			this.tabTeachers.Size = new System.Drawing.Size(792, 411);
			this.tabTeachers.TabIndex = 1;
			this.tabTeachers.Text = "Docentes";
			this.tabTeachers.UseVisualStyleBackColor = true;
			// 
			// tabCourses
			// 
			this.tabCourses.Location = new System.Drawing.Point(4, 22);
			this.tabCourses.Name = "tabCourses";
			this.tabCourses.Padding = new System.Windows.Forms.Padding(3);
			this.tabCourses.Size = new System.Drawing.Size(792, 411);
			this.tabCourses.TabIndex = 2;
			this.tabCourses.Text = "Cursos";
			this.tabCourses.UseVisualStyleBackColor = true;
			// 
			// tabSubjects
			// 
			this.tabSubjects.Location = new System.Drawing.Point(4, 22);
			this.tabSubjects.Name = "tabSubjects";
			this.tabSubjects.Padding = new System.Windows.Forms.Padding(3);
			this.tabSubjects.Size = new System.Drawing.Size(792, 411);
			this.tabSubjects.TabIndex = 3;
			this.tabSubjects.Text = "Unidades Curriculares";
			this.tabSubjects.UseVisualStyleBackColor = true;
			// 
			// txtSearchStudent
			// 
			this.txtSearchStudent.Location = new System.Drawing.Point(40, 46);
			this.txtSearchStudent.Name = "txtSearchStudent";
			this.txtSearchStudent.Size = new System.Drawing.Size(92, 20);
			this.txtSearchStudent.TabIndex = 0;
			// 
			// btnSearchStudent
			// 
			this.btnSearchStudent.Location = new System.Drawing.Point(148, 44);
			this.btnSearchStudent.Name = "btnSearchStudent";
			this.btnSearchStudent.Size = new System.Drawing.Size(75, 23);
			this.btnSearchStudent.TabIndex = 1;
			this.btnSearchStudent.Text = "Pesquisar Aluno";
			this.btnSearchStudent.UseVisualStyleBackColor = true;
			this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Número deAluno";
			// 
			// txtStudentNumber
			// 
			this.txtStudentNumber.Location = new System.Drawing.Point(365, 92);
			this.txtStudentNumber.Name = "txtStudentNumber";
			this.txtStudentNumber.Size = new System.Drawing.Size(153, 20);
			this.txtStudentNumber.TabIndex = 3;
			// 
			// txtStudentName
			// 
			this.txtStudentName.Location = new System.Drawing.Point(365, 174);
			this.txtStudentName.Name = "txtStudentName";
			this.txtStudentName.Size = new System.Drawing.Size(153, 20);
			this.txtStudentName.TabIndex = 4;
			// 
			// txtStudentBirthdate
			// 
			this.txtStudentBirthdate.Location = new System.Drawing.Point(365, 247);
			this.txtStudentBirthdate.Name = "txtStudentBirthdate";
			this.txtStudentBirthdate.Size = new System.Drawing.Size(153, 20);
			this.txtStudentBirthdate.TabIndex = 5;
			// 
			// txtStudentEmail
			// 
			this.txtStudentEmail.Location = new System.Drawing.Point(365, 311);
			this.txtStudentEmail.Name = "txtStudentEmail";
			this.txtStudentEmail.Size = new System.Drawing.Size(153, 20);
			this.txtStudentEmail.TabIndex = 6;
			// 
			// txtStudentCourse
			// 
			this.txtStudentCourse.Location = new System.Drawing.Point(574, 92);
			this.txtStudentCourse.Name = "txtStudentCourse";
			this.txtStudentCourse.Size = new System.Drawing.Size(146, 20);
			this.txtStudentCourse.TabIndex = 7;
			// 
			// txtStudentLastName
			// 
			this.txtStudentLastName.Location = new System.Drawing.Point(574, 174);
			this.txtStudentLastName.Name = "txtStudentLastName";
			this.txtStudentLastName.Size = new System.Drawing.Size(146, 20);
			this.txtStudentLastName.TabIndex = 8;
			// 
			// txtStudentAddress
			// 
			this.txtStudentAddress.Location = new System.Drawing.Point(574, 247);
			this.txtStudentAddress.Name = "txtStudentAddress";
			this.txtStudentAddress.Size = new System.Drawing.Size(146, 20);
			this.txtStudentAddress.TabIndex = 9;
			// 
			// txtStudentPhone
			// 
			this.txtStudentPhone.Location = new System.Drawing.Point(574, 311);
			this.txtStudentPhone.Name = "txtStudentPhone";
			this.txtStudentPhone.Size = new System.Drawing.Size(146, 20);
			this.txtStudentPhone.TabIndex = 10;
			// 
			// lblStudentNumber
			// 
			this.lblStudentNumber.AutoSize = true;
			this.lblStudentNumber.Location = new System.Drawing.Point(362, 65);
			this.lblStudentNumber.Name = "lblStudentNumber";
			this.lblStudentNumber.Size = new System.Drawing.Size(86, 13);
			this.lblStudentNumber.TabIndex = 11;
			this.lblStudentNumber.Text = "Número deAluno";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(362, 149);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 12;
			this.lblName.Text = "Nome";
			// 
			// lblBirthDate
			// 
			this.lblBirthDate.AutoSize = true;
			this.lblBirthDate.Location = new System.Drawing.Point(362, 221);
			this.lblBirthDate.Name = "lblBirthDate";
			this.lblBirthDate.Size = new System.Drawing.Size(104, 13);
			this.lblBirthDate.TabIndex = 13;
			this.lblBirthDate.Text = "Data de Nascimento";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(365, 286);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(32, 13);
			this.lblEmail.TabIndex = 14;
			this.lblEmail.Text = "Email";
			// 
			// lblCourse
			// 
			this.lblCourse.AutoSize = true;
			this.lblCourse.Location = new System.Drawing.Point(571, 65);
			this.lblCourse.Name = "lblCourse";
			this.lblCourse.Size = new System.Drawing.Size(34, 13);
			this.lblCourse.TabIndex = 15;
			this.lblCourse.Text = "Curso";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(571, 149);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(42, 13);
			this.lblLastName.TabIndex = 16;
			this.lblLastName.Text = "Apelido";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(571, 221);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(43, 13);
			this.lblAddress.TabIndex = 17;
			this.lblAddress.Text = "Morada";
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Location = new System.Drawing.Point(571, 286);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(49, 13);
			this.lblPhone.TabIndex = 18;
			this.lblPhone.Text = "Telefone";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.lbl_conn);
			this.Name = "Form1";
			this.Text = "Gestão Escolar";
			this.tabControl1.ResumeLayout(false);
			this.tabStudents.ResumeLayout(false);
			this.tabStudents.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lbl_conn;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabStudents;
		private System.Windows.Forms.TabPage tabTeachers;
		private System.Windows.Forms.TabPage tabCourses;
		private System.Windows.Forms.TabPage tabSubjects;
		private System.Windows.Forms.Button btnSearchStudent;
		private System.Windows.Forms.TextBox txtSearchStudent;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblBirthDate;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblStudentNumber;
		private System.Windows.Forms.TextBox txtStudentPhone;
		private System.Windows.Forms.TextBox txtStudentAddress;
		private System.Windows.Forms.TextBox txtStudentLastName;
		private System.Windows.Forms.TextBox txtStudentCourse;
		private System.Windows.Forms.TextBox txtStudentEmail;
		private System.Windows.Forms.TextBox txtStudentBirthdate;
		private System.Windows.Forms.TextBox txtStudentName;
		private System.Windows.Forms.TextBox txtStudentNumber;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label lblCourse;
	}
}

