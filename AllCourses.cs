using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projectoPOO
{
	public partial class AllCourses : Form
	{
		public AllCourses()
		{
			InitializeComponent();
            dgAllCourses.DataSource = Courses.GetAllCourses();
        }
	}
}
