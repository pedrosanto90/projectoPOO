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

	}
}
