using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projectoPOO
{
    public partial class AllTeachers : Form
    {
        public AllTeachers()
        {
            InitializeComponent();
            dgAllTeachers.DataSource = Teachers.GetAllTeachers();
        }
    }
}
