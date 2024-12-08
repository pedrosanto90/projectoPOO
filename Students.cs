using System;
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

		public static bool AddStudent(Student student)
		{

			string connectionString = "Data Source=(local); User ID=pedro; Initial Catalog=EscolaDB; Integrated Security=True;";

			using (SqlConnection cn = new SqlConnection(connectionString))
			{
				cn.Open();
				string query = "SELECT TOP 1 numero FROM Aluno ORDER BY numero DESC;";
				SqlCommand command = new SqlCommand(query, cn);
				SqlDataReader reader = command.ExecuteReader();
				Console.WriteLine(reader.ToString());
				string numero = reader["numero"].ToString();
				int studentNumber = Int32.Parse(numero) + 1;

				query = @"INSERT INTO Aluno 
                                (numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone) 
                                VALUES (@numero, @referenciaCurso, @nomeProprio, @apelido, @dataNascimento, @morada, @email, @telefone)";

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@numero", studentNumber);
					cmd.Parameters.AddWithValue("@referenciaCurso", 100);
					cmd.Parameters.AddWithValue("@nomeProprio", student.Name);
					cmd.Parameters.AddWithValue("@apelido", student.LastName);
					cmd.Parameters.AddWithValue("@dataNascimento", DateTime.Parse(student.Birthday));
					cmd.Parameters.AddWithValue("@morada", student.Address);
					cmd.Parameters.AddWithValue("@email", student.Email);
					cmd.Parameters.AddWithValue("@telefone", student.Phone);

					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}
	}
}
