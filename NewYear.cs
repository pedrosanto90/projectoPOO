using System;
using System.Windows.Forms;

namespace projectoPOO
{
	public partial class NewYear : Form
	{
		public NewYear()
		{
			InitializeComponent();
		}

		private void btnCancelYear_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAddYear_Click(object sender, EventArgs e)
		{
			string startYear = txtStartYear.Text;
			string endYear = txtEndYear.Text;



			bool inserted = Year.AddYear(startYear, endYear);

			if (inserted)
			{
				MessageBox.Show("Ano Criado com Sucesso", "Info");
				this.Close();
			}
			else
			{
				MessageBox.Show("Ocorreu um erro", "Error");
			}
		}
	}
}
