using System.Collections;
using System.Data.SqlClient;

namespace projectoPOO
{
	internal class Sql
	{
		public static string SqlConn()
		{
			string myConn = "Data Source=(local); User ID=pedro; Initial Catalog=escoladb; Integrated Security=True;";
			using (SqlConnection connection = new SqlConnection(myConn))
			{
				try
				{
					connection.Open();
					return "Status: Connect";
				}
				catch
				{
					return "Status: Not Connected";
				}

			}
		}

		public static ArrayList SqlUserData()
		{
			ArrayList data = new ArrayList();

			string userQuery = "SELECT nomeProprio FROM Aluno";
			SqlCommand studentData = new SqlCommand(userQuery);
			for (int i = 0; i < studentData.Parameters.Count; i++)
			{
				data.Add(studentData.Parameters[i].Value);
			}
			return data;

		}
	}
}
