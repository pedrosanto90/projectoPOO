using System.Collections.Generic;
using System.Data.SqlClient;
struct Student
{
	public string Number;
	public string CourseRef;
	public string Name;
	public string LastName;
	public string Birthday;
	public string Address;
	public string Email;
	public string Phone;
}

namespace projectoPOO
{
	internal class Students
	{
		public static List<Student> GetStudents(int numero)
		{
			string connectionString = "Data Source=(local); User ID=pedro; Initial Catalog=escoladb; Integrated Security=True;";
			List<Student> students = new List<Student>();

			using (SqlConnection cn = new SqlConnection(connectionString))
			{
				cn.Open();

				string query = "SELECT * FROM Aluno WHERE numero = @numero";
				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					// Use parameterized query to prevent SQL injection
					cmd.Parameters.AddWithValue("@numero", numero);

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							Student student = new Student
							{
								Number = reader["numero"].ToString(),
								CourseRef = reader["referenciaCurso"].ToString(),
								Name = reader["nomeProprio"].ToString(),
								LastName = reader["apelido"].ToString(),
								Birthday = reader["dataNascimento"].ToString(),
								Address = reader["morada"].ToString(),
								Email = reader["email"].ToString(),
								Phone = reader["telefone"].ToString()
							};
							students.Add(student);
						}
					}
				}
			}
			return students;
		}
	}
}
