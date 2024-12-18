using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectoPOO
{
    public partial class NewSubject : Form
    {
        public NewSubject()
        {
            InitializeComponent();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            Subject newSubject = new Subject();

            newSubject.Course = txtAddCourseSubject.Text;
            newSubject.Teacher = txtAddTeacherSubject.Text;
            newSubject.Name = txtAddNameSubject.Text;
            newSubject.Credits = txtAddCreditsSubject.Text;
            newSubject.Year = txtAddYearSubject.Text;
            newSubject.Semester = txtAddSemesterSubject.Text;

            Subjects.AddSubject(newSubject);
            MessageBox.Show("UC inserida com sucesso");
            this.Close();
        }

        private void btnCancelAddSubject_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
