using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projectoPOO
{
	public partial class Form1 : Form
	{
		string connection;

		public Form1()
		{
			InitializeComponent();

			Sql.SqlConn();
			connection = Sql.SqlConn();
			lbl_conn.Text = connection.ToString();

			txtStudentNumber.ReadOnly = true;
			txtStudentCourse.ReadOnly = true;
			txtStudentName.ReadOnly = true;
			txtStudentLastName.ReadOnly = true;
			txtStudentBirthdate.ReadOnly = true;
			txtStudentAddress.ReadOnly = true;
			txtStudentEmail.ReadOnly = true;
			txtStudentPhone.ReadOnly = true;

		}

		private void btnSearchStudent_Click(object sender, System.EventArgs e)
		{
			int number = Int32.Parse(txtSearchStudent.Text);
			List<Student> student = Students.GetStudents(number);

			if (student.Count > 0)
			{
				txtStudentNumber.Text = student[0].Number;
				txtStudentCourse.Text = student[0].CourseRef;
				txtStudentName.Text = student[0].Name;
				txtStudentLastName.Text = student[0].LastName;
				txtStudentBirthdate.Text = student[0].Birthday;
				txtStudentAddress.Text = student[0].Address;
				txtStudentEmail.Text = student[0].Email;
				txtStudentPhone.Text = student[0].Phone;
			}
			else
			{
				MessageBox.Show($"Nenhum aluno encontrado com o número {number}", "Info");
			}
		}
	}
}




