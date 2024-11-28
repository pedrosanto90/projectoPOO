using System;
using System.Collections;
using System.Windows.Forms;

namespace projectoPOO
{
	public partial class Form1 : Form
	{
		string connection;

		public Form1()
		{
			InitializeComponent();

			Sql.SqlConn();
			connection = Sql.SqlConn();
			lbl_conn.Text = connection.ToString();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		public void ListData()
		{
			ArrayList students = new ArrayList();
			students = Sql.SqlUserData();
			for (int i = 0; i < students.Count; i++)
			{
				lb_students_list.Items.Add($"Nome: {i.ToString()}");
			}

		}


		private void btn_get_students_Click(object sender, EventArgs e)
		{
			ListData();
		}
	}
}




