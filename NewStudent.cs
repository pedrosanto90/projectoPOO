using System;
using System.Windows.Forms;


namespace projectoPOO
{
	public partial class NewStudent : Form
	{
		public NewStudent()
		{
			InitializeComponent();
		}

		private void btnAddStudent_Click(object sender, EventArgs e)
		{
			Student newStudent = new Student();

			newStudent.Name = txtAddNameStudent.Text;
			newStudent.LastName = txtAddLastNameStudent.Text;
			newStudent.Birthday = txtAddBirthdateStudent.Value.ToString("yyyy-MM-dd");
			newStudent.Address = txtAddAddressStudent.Text;
			newStudent.Phone = txtAddPhoneStudent.Text;
			newStudent.Course = txtAddCourse.Text;

			Students.AddStudent(newStudent);
			MessageBox.Show("Aluno inserido com sucesso");
			this.Close();
		}

		private void btnCancelAddStudent_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
