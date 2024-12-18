using System;
using System.Windows.Forms;

namespace projectoPOO
{
	public partial class Enroll : Form
	{
		public Enroll()
		{
			InitializeComponent();
		}

		private void btnCancelEnroll_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
