using System;
using System.Windows.Forms;


namespace projectoPOO
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void btnAddStudent_Click(object sender, EventArgs e)
		{
			Student newStudent = new Student();

			newStudent.Name = txtAddName.Text;
			newStudent.LastName = txtAddLastName.Text;
			newStudent.Birthday = txtAddBirthdate.Value.ToString("yyyy-MM-dd");
			newStudent.Address = txtAddAddress.Text;
			newStudent.Phone = txtAddPhone.Text;

			Students.AddStudent(newStudent);
			this.Close();
		}

        private void btnCancelAddStudent_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
