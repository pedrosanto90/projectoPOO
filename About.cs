using System;
using System.Windows.Forms;

namespace projectoPOO
{
	public partial class About : Form
	{
		public About()
		{
			InitializeComponent();
		}

		private void btnCloseAbout_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
