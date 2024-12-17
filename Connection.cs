using System.Configuration;

namespace projectoPOO
{
	internal class Connection
	{
		public static string Conn()
		{
			string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
			return connectionString;
		}
	}
}
