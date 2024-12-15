using System;
using System.Windows.Forms;

namespace projectoPOO
{
	public partial class Form6 : Form
	{
		public Form6()
		{
			InitializeComponent();
		}

		private void btnAddCourse_Click(object sender, EventArgs e)
		{
			Course newCourse = new Course();

			newCourse.Name = txtAddNameCourse.Text;
			newCourse.StartDate = txtAddStartDateCourse.Value.ToString("yyyy-MM-dd");

			Courses.AddCourse(newCourse);
			MessageBox.Show("Curso inserido com sucesso");
			this.Close();
		}

		private void btnCancelNewCourse_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
