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

			newStudent.Name = txtAddNameStudent.Text;
			newStudent.LastName = txtAddLastNameStudent.Text;
			newStudent.Birthday = txtAddBirthdateStudent.Value.ToString("yyyy-MM-dd");
			newStudent.Address = txtAddAddressStudent.Text;
			newStudent.Phone = txtAddPhoneStudent.Text;

			Students.AddStudent(newStudent);
			this.Close();
		}

        private void btnCancelAddStudent_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
