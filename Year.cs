using System;
using System.Data.SqlClient;

namespace projectoPOO
{
	internal class Year
	{
		public static bool AddYear(string startYear, string endYear)
		{
			int iStartYear = Int32.Parse(startYear);
			int iEndYear = Int32.Parse(endYear);
			int idYear = Int32.Parse($"{startYear.Substring(startYear.Length - 2)}{endYear.Substring(endYear.Length - 2)}");

			string query = @"INSERT INTO AnoLetivo (id, anoInicial, anoFinal)
							VALUES (@id, @anoInicial, @anoFinal)";

			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();
				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@id", idYear);
					cmd.Parameters.AddWithValue("@anoInicial", iStartYear);
					cmd.Parameters.AddWithValue("@anoFinal", iEndYear);


					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}
	}
}
