using System.Windows.Forms;

namespace projectoPOO
{
	public partial class AllSubjects : Form
	{
		public AllSubjects()
		{
			InitializeComponent();
			dgAllSubjects.DataSource = Subjects.GetAllSubjects();
		}


	}
}
