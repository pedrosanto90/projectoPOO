using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projectoPOO
{
    public partial class AllStudents : Form
    {
        public AllStudents()
        {
            InitializeComponent();
            dgAllStudents.DataSource = Students.GetAllStudents();
        }
    }
}
