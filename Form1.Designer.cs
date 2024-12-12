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
			this.btnDeleteStudent = new System.Windows.Forms.Button();
			this.btnCancelUpdateStudent = new System.Windows.Forms.Button();
			this.btnUpdateStudent = new System.Windows.Forms.Button();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblCourse = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblBirthDate = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblStudentNumber = new System.Windows.Forms.Label();
			this.txtStudentPhone = new System.Windows.Forms.TextBox();
			this.txtStudentAddress = new System.Windows.Forms.TextBox();
			this.txtStudentLastName = new System.Windows.Forms.TextBox();
			this.txtStudentCourse = new System.Windows.Forms.TextBox();
			this.txtStudentEmail = new System.Windows.Forms.TextBox();
			this.txtStudentBirthdate = new System.Windows.Forms.TextBox();
			this.txtStudentName = new System.Windows.Forms.TextBox();
			this.txtStudentNumber = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSearchStudent = new System.Windows.Forms.Button();
			this.txtSearchStudent = new System.Windows.Forms.TextBox();
			this.tabTeachers = new System.Windows.Forms.TabPage();
			this.btnCancelUpdateTeacher = new System.Windows.Forms.Button();
			this.btnUpdateTeacher = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblTeacherNumber = new System.Windows.Forms.Label();
			this.txtTeacherPhone = new System.Windows.Forms.TextBox();
			this.txtTeacherSalary = new System.Windows.Forms.TextBox();
			this.txtTeacherLastName = new System.Windows.Forms.TextBox();
			this.txtTeacherExtension = new System.Windows.Forms.TextBox();
			this.txtTeacherEmail = new System.Windows.Forms.TextBox();
			this.txtTeacherBirthdate = new System.Windows.Forms.TextBox();
			this.txtTeacherName = new System.Windows.Forms.TextBox();
			this.txtTeacherNumber = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnSearchTeacher = new System.Windows.Forms.Button();
			this.txtSearchTeacher = new System.Windows.Forms.TextBox();
			this.tabCourses = new System.Windows.Forms.TabPage();
			this.tabSubjects = new System.Windows.Forms.TabPage();
			this.btnDeleteTeacher = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabStudents.SuspendLayout();
			this.tabTeachers.SuspendLayout();
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
			this.tabStudents.Controls.Add(this.btnDeleteStudent);
			this.tabStudents.Controls.Add(this.btnCancelUpdateStudent);
			this.tabStudents.Controls.Add(this.btnUpdateStudent);
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
			// btnDeleteStudent
			// 
			this.btnDeleteStudent.Location = new System.Drawing.Point(73, 87);
			this.btnDeleteStudent.Name = "btnDeleteStudent";
			this.btnDeleteStudent.Size = new System.Drawing.Size(115, 23);
			this.btnDeleteStudent.TabIndex = 21;
			this.btnDeleteStudent.Text = "Eliminar Aluno";
			this.btnDeleteStudent.UseVisualStyleBackColor = true;
			this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
			// 
			// btnCancelUpdateStudent
			// 
			this.btnCancelUpdateStudent.Location = new System.Drawing.Point(46, 306);
			this.btnCancelUpdateStudent.Name = "btnCancelUpdateStudent";
			this.btnCancelUpdateStudent.Size = new System.Drawing.Size(75, 23);
			this.btnCancelUpdateStudent.TabIndex = 20;
			this.btnCancelUpdateStudent.Text = "Cancelar";
			this.btnCancelUpdateStudent.UseVisualStyleBackColor = true;
			this.btnCancelUpdateStudent.Click += new System.EventHandler(this.btnCancelUpdateStudent_Click);
			// 
			// btnUpdateStudent
			// 
			this.btnUpdateStudent.Location = new System.Drawing.Point(143, 306);
			this.btnUpdateStudent.Name = "btnUpdateStudent";
			this.btnUpdateStudent.Size = new System.Drawing.Size(75, 23);
			this.btnUpdateStudent.TabIndex = 19;
			this.btnUpdateStudent.Text = "Atualizar";
			this.btnUpdateStudent.UseVisualStyleBackColor = true;
			this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Location = new System.Drawing.Point(566, 284);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(49, 13);
			this.lblPhone.TabIndex = 18;
			this.lblPhone.Text = "Telefone";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(566, 219);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(43, 13);
			this.lblAddress.TabIndex = 17;
			this.lblAddress.Text = "Morada";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(566, 147);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(42, 13);
			this.lblLastName.TabIndex = 16;
			this.lblLastName.Text = "Apelido";
			// 
			// lblCourse
			// 
			this.lblCourse.AutoSize = true;
			this.lblCourse.Location = new System.Drawing.Point(566, 63);
			this.lblCourse.Name = "lblCourse";
			this.lblCourse.Size = new System.Drawing.Size(34, 13);
			this.lblCourse.TabIndex = 15;
			this.lblCourse.Text = "Curso";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(360, 284);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(32, 13);
			this.lblEmail.TabIndex = 14;
			this.lblEmail.Text = "Email";
			// 
			// lblBirthDate
			// 
			this.lblBirthDate.AutoSize = true;
			this.lblBirthDate.Location = new System.Drawing.Point(357, 219);
			this.lblBirthDate.Name = "lblBirthDate";
			this.lblBirthDate.Size = new System.Drawing.Size(104, 13);
			this.lblBirthDate.TabIndex = 13;
			this.lblBirthDate.Text = "Data de Nascimento";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(357, 147);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 12;
			this.lblName.Text = "Nome";
			// 
			// lblStudentNumber
			// 
			this.lblStudentNumber.AutoSize = true;
			this.lblStudentNumber.Location = new System.Drawing.Point(357, 63);
			this.lblStudentNumber.Name = "lblStudentNumber";
			this.lblStudentNumber.Size = new System.Drawing.Size(89, 13);
			this.lblStudentNumber.TabIndex = 11;
			this.lblStudentNumber.Text = "Número de Aluno";
			// 
			// txtStudentPhone
			// 
			this.txtStudentPhone.Location = new System.Drawing.Point(569, 309);
			this.txtStudentPhone.Name = "txtStudentPhone";
			this.txtStudentPhone.Size = new System.Drawing.Size(146, 20);
			this.txtStudentPhone.TabIndex = 10;
			// 
			// txtStudentAddress
			// 
			this.txtStudentAddress.Location = new System.Drawing.Point(569, 245);
			this.txtStudentAddress.Name = "txtStudentAddress";
			this.txtStudentAddress.Size = new System.Drawing.Size(146, 20);
			this.txtStudentAddress.TabIndex = 9;
			// 
			// txtStudentLastName
			// 
			this.txtStudentLastName.Location = new System.Drawing.Point(569, 172);
			this.txtStudentLastName.Name = "txtStudentLastName";
			this.txtStudentLastName.Size = new System.Drawing.Size(146, 20);
			this.txtStudentLastName.TabIndex = 8;
			// 
			// txtStudentCourse
			// 
			this.txtStudentCourse.Location = new System.Drawing.Point(569, 90);
			this.txtStudentCourse.Name = "txtStudentCourse";
			this.txtStudentCourse.Size = new System.Drawing.Size(146, 20);
			this.txtStudentCourse.TabIndex = 7;
			// 
			// txtStudentEmail
			// 
			this.txtStudentEmail.Location = new System.Drawing.Point(360, 309);
			this.txtStudentEmail.Name = "txtStudentEmail";
			this.txtStudentEmail.Size = new System.Drawing.Size(153, 20);
			this.txtStudentEmail.TabIndex = 6;
			// 
			// txtStudentBirthdate
			// 
			this.txtStudentBirthdate.Location = new System.Drawing.Point(360, 245);
			this.txtStudentBirthdate.Name = "txtStudentBirthdate";
			this.txtStudentBirthdate.Size = new System.Drawing.Size(153, 20);
			this.txtStudentBirthdate.TabIndex = 5;
			// 
			// txtStudentName
			// 
			this.txtStudentName.Location = new System.Drawing.Point(360, 172);
			this.txtStudentName.Name = "txtStudentName";
			this.txtStudentName.Size = new System.Drawing.Size(153, 20);
			this.txtStudentName.TabIndex = 4;
			// 
			// txtStudentNumber
			// 
			this.txtStudentNumber.Location = new System.Drawing.Point(360, 90);
			this.txtStudentNumber.Name = "txtStudentNumber";
			this.txtStudentNumber.Size = new System.Drawing.Size(153, 20);
			this.txtStudentNumber.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Número de Aluno";
			// 
			// btnSearchStudent
			// 
			this.btnSearchStudent.Location = new System.Drawing.Point(143, 42);
			this.btnSearchStudent.Name = "btnSearchStudent";
			this.btnSearchStudent.Size = new System.Drawing.Size(75, 23);
			this.btnSearchStudent.TabIndex = 1;
			this.btnSearchStudent.Text = "Pesquisar Aluno";
			this.btnSearchStudent.UseVisualStyleBackColor = true;
			this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
			// 
			// txtSearchStudent
			// 
			this.txtSearchStudent.Location = new System.Drawing.Point(35, 44);
			this.txtSearchStudent.Name = "txtSearchStudent";
			this.txtSearchStudent.Size = new System.Drawing.Size(92, 20);
			this.txtSearchStudent.TabIndex = 0;
			// 
			// tabTeachers
			// 
			this.tabTeachers.Controls.Add(this.btnDeleteTeacher);
			this.tabTeachers.Controls.Add(this.btnCancelUpdateTeacher);
			this.tabTeachers.Controls.Add(this.btnUpdateTeacher);
			this.tabTeachers.Controls.Add(this.label2);
			this.tabTeachers.Controls.Add(this.label3);
			this.tabTeachers.Controls.Add(this.label4);
			this.tabTeachers.Controls.Add(this.label5);
			this.tabTeachers.Controls.Add(this.label6);
			this.tabTeachers.Controls.Add(this.label7);
			this.tabTeachers.Controls.Add(this.label8);
			this.tabTeachers.Controls.Add(this.lblTeacherNumber);
			this.tabTeachers.Controls.Add(this.txtTeacherPhone);
			this.tabTeachers.Controls.Add(this.txtTeacherSalary);
			this.tabTeachers.Controls.Add(this.txtTeacherLastName);
			this.tabTeachers.Controls.Add(this.txtTeacherExtension);
			this.tabTeachers.Controls.Add(this.txtTeacherEmail);
			this.tabTeachers.Controls.Add(this.txtTeacherBirthdate);
			this.tabTeachers.Controls.Add(this.txtTeacherName);
			this.tabTeachers.Controls.Add(this.txtTeacherNumber);
			this.tabTeachers.Controls.Add(this.label10);
			this.tabTeachers.Controls.Add(this.btnSearchTeacher);
			this.tabTeachers.Controls.Add(this.txtSearchTeacher);
			this.tabTeachers.Location = new System.Drawing.Point(4, 22);
			this.tabTeachers.Name = "tabTeachers";
			this.tabTeachers.Padding = new System.Windows.Forms.Padding(3);
			this.tabTeachers.Size = new System.Drawing.Size(792, 411);
			this.tabTeachers.TabIndex = 1;
			this.tabTeachers.Text = "Docentes";
			this.tabTeachers.UseVisualStyleBackColor = true;
			// 
			// btnCancelUpdateTeacher
			// 
			this.btnCancelUpdateTeacher.Location = new System.Drawing.Point(48, 307);
			this.btnCancelUpdateTeacher.Name = "btnCancelUpdateTeacher";
			this.btnCancelUpdateTeacher.Size = new System.Drawing.Size(75, 23);
			this.btnCancelUpdateTeacher.TabIndex = 39;
			this.btnCancelUpdateTeacher.Text = "Cancelar";
			this.btnCancelUpdateTeacher.UseVisualStyleBackColor = true;
			this.btnCancelUpdateTeacher.Click += new System.EventHandler(this.btnCancelUpdateTeacher_Click);
			// 
			// btnUpdateTeacher
			// 
			this.btnUpdateTeacher.Location = new System.Drawing.Point(145, 307);
			this.btnUpdateTeacher.Name = "btnUpdateTeacher";
			this.btnUpdateTeacher.Size = new System.Drawing.Size(75, 23);
			this.btnUpdateTeacher.TabIndex = 38;
			this.btnUpdateTeacher.Text = "Atualizar";
			this.btnUpdateTeacher.UseVisualStyleBackColor = true;
			this.btnUpdateTeacher.Click += new System.EventHandler(this.btnUpdateTeacher_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(568, 284);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 37;
			this.label2.Text = "Telefone";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(568, 219);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 36;
			this.label3.Text = "Salário";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(568, 147);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 35;
			this.label4.Text = "Apelido";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(568, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 13);
			this.label5.TabIndex = 34;
			this.label5.Text = "Extensão";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(362, 284);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 33;
			this.label6.Text = "Email";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(359, 219);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 13);
			this.label7.TabIndex = 32;
			this.label7.Text = "Data de Nascimento";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(359, 147);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 13);
			this.label8.TabIndex = 31;
			this.label8.Text = "Nome";
			// 
			// lblTeacherNumber
			// 
			this.lblTeacherNumber.AutoSize = true;
			this.lblTeacherNumber.Location = new System.Drawing.Point(359, 63);
			this.lblTeacherNumber.Name = "lblTeacherNumber";
			this.lblTeacherNumber.Size = new System.Drawing.Size(103, 13);
			this.lblTeacherNumber.TabIndex = 30;
			this.lblTeacherNumber.Text = "Número de Docente";
			// 
			// txtTeacherPhone
			// 
			this.txtTeacherPhone.Location = new System.Drawing.Point(571, 309);
			this.txtTeacherPhone.Name = "txtTeacherPhone";
			this.txtTeacherPhone.Size = new System.Drawing.Size(146, 20);
			this.txtTeacherPhone.TabIndex = 29;
			// 
			// txtTeacherSalary
			// 
			this.txtTeacherSalary.Location = new System.Drawing.Point(571, 245);
			this.txtTeacherSalary.Name = "txtTeacherSalary";
			this.txtTeacherSalary.Size = new System.Drawing.Size(146, 20);
			this.txtTeacherSalary.TabIndex = 28;
			// 
			// txtTeacherLastName
			// 
			this.txtTeacherLastName.Location = new System.Drawing.Point(571, 172);
			this.txtTeacherLastName.Name = "txtTeacherLastName";
			this.txtTeacherLastName.Size = new System.Drawing.Size(146, 20);
			this.txtTeacherLastName.TabIndex = 27;
			// 
			// txtTeacherExtension
			// 
			this.txtTeacherExtension.Location = new System.Drawing.Point(571, 90);
			this.txtTeacherExtension.Name = "txtTeacherExtension";
			this.txtTeacherExtension.Size = new System.Drawing.Size(146, 20);
			this.txtTeacherExtension.TabIndex = 26;
			// 
			// txtTeacherEmail
			// 
			this.txtTeacherEmail.Location = new System.Drawing.Point(362, 309);
			this.txtTeacherEmail.Name = "txtTeacherEmail";
			this.txtTeacherEmail.Size = new System.Drawing.Size(153, 20);
			this.txtTeacherEmail.TabIndex = 25;
			// 
			// txtTeacherBirthdate
			// 
			this.txtTeacherBirthdate.Location = new System.Drawing.Point(362, 245);
			this.txtTeacherBirthdate.Name = "txtTeacherBirthdate";
			this.txtTeacherBirthdate.Size = new System.Drawing.Size(153, 20);
			this.txtTeacherBirthdate.TabIndex = 24;
			// 
			// txtTeacherName
			// 
			this.txtTeacherName.Location = new System.Drawing.Point(362, 172);
			this.txtTeacherName.Name = "txtTeacherName";
			this.txtTeacherName.Size = new System.Drawing.Size(153, 20);
			this.txtTeacherName.TabIndex = 23;
			// 
			// txtTeacherNumber
			// 
			this.txtTeacherNumber.Location = new System.Drawing.Point(362, 90);
			this.txtTeacherNumber.Name = "txtTeacherNumber";
			this.txtTeacherNumber.Size = new System.Drawing.Size(153, 20);
			this.txtTeacherNumber.TabIndex = 22;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(34, 28);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(103, 13);
			this.label10.TabIndex = 21;
			this.label10.Text = "Número de Docente";
			// 
			// btnSearchTeacher
			// 
			this.btnSearchTeacher.Location = new System.Drawing.Point(145, 42);
			this.btnSearchTeacher.Name = "btnSearchTeacher";
			this.btnSearchTeacher.Size = new System.Drawing.Size(75, 23);
			this.btnSearchTeacher.TabIndex = 20;
			this.btnSearchTeacher.Text = "Pesquisar Docente";
			this.btnSearchTeacher.UseVisualStyleBackColor = true;
			this.btnSearchTeacher.Click += new System.EventHandler(this.btnSearchTeacher_Click);
			// 
			// txtSearchTeacher
			// 
			this.txtSearchTeacher.Location = new System.Drawing.Point(37, 44);
			this.txtSearchTeacher.Name = "txtSearchTeacher";
			this.txtSearchTeacher.Size = new System.Drawing.Size(92, 20);
			this.txtSearchTeacher.TabIndex = 19;
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
			// btnDeleteTeacher
			// 
			this.btnDeleteTeacher.Location = new System.Drawing.Point(78, 87);
			this.btnDeleteTeacher.Name = "btnDeleteTeacher";
			this.btnDeleteTeacher.Size = new System.Drawing.Size(113, 23);
			this.btnDeleteTeacher.TabIndex = 40;
			this.btnDeleteTeacher.Text = "Eliminar Docente";
			this.btnDeleteTeacher.UseVisualStyleBackColor = true;
			this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
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
			this.tabTeachers.ResumeLayout(false);
			this.tabTeachers.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTeacherNumber;
        private System.Windows.Forms.TextBox txtTeacherSalary;
        private System.Windows.Forms.TextBox txtTeacherLastName;
        private System.Windows.Forms.TextBox txtTeacherExtension;
        private System.Windows.Forms.TextBox txtTeacherEmail;
        private System.Windows.Forms.TextBox txtTeacherBirthdate;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.TextBox txtTeacherNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearchTeacher;
        private System.Windows.Forms.TextBox txtSearchTeacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTeacherPhone;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnCancelUpdateStudent;
        private System.Windows.Forms.Button btnCancelUpdateTeacher;
        private System.Windows.Forms.Button btnUpdateTeacher;
		private System.Windows.Forms.Button btnDeleteStudent;
		private System.Windows.Forms.Button btnDeleteTeacher;
	}
}

