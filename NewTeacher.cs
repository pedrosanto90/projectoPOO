using System;
using System.Windows.Forms;

namespace projectoPOO
{
    public partial class NewTeacher : Form
    {
        public NewTeacher()
        {
            InitializeComponent();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            Teacher newTeacher = new Teacher();

            newTeacher.Name = txtAddNameTeacher.Text;
            newTeacher.LastName = txtAddLastNameTeacher.Text;
            newTeacher.Birthday = txtAddBirthdateTeacher.Value.ToString("yyyy-MM-dd");
            newTeacher.Phone = txtAddPhoneTeacher.Text;

            Teachers.AddTeacher(newTeacher);
            this.Close();
        }

        private void btnCancelAddTeacher_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
