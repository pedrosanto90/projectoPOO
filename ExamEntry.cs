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
    public partial class ExamEntry : Form
    {
        public ExamEntry()
        {
            InitializeComponent();
        }

        private void btnSearchStudentExamEntry_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(txtSearchStudentExamEntry.Text);
            dgAllScores.DataSource = Enrollment.GetAllScores(number);
        }
    }
}
