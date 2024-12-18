using System;
using System.Collections.Generic;
using System.Data.SqlClient;
struct Student
{
	public string Number;
	public string Course;
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
			List<Student> students = new List<Student>();

			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = "SELECT *, Curso.sigla FROM Aluno JOIN Curso ON Curso.referencia = Aluno.referenciaCurso WHERE Aluno.numero = @numero";
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
								Course = reader["sigla"].ToString(),
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

			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				// Obter o maior número
				string query = "SELECT MAX(numero) AS maior_numero FROM Aluno;";
				int studentNumber = 1; // Caso não haja alunos na tabela, começamos do 1.

				using (SqlCommand command = new SqlCommand(query, cn))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read() && !reader.IsDBNull(0)) // Verifica se há valor
						{
							studentNumber = reader.GetInt32(0) + 1; // Incrementa o maior número
						}
					}
				}

				// Gerar o e-mail do aluno
				string studentEmail = $"aluno{studentNumber}@ipw.pt";

				// Inserir o novo aluno
				query = @"
INSERT INTO Aluno 
    (numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone) 
SELECT
    @numero, 
    Curso.referencia, 
    @nomeProprio, 
    @apelido, 
    @dataNascimento, 
    @morada, 
    @email, 
    @telefone
FROM Curso
WHERE Curso.sigla = @referenciaCurso";

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@numero", studentNumber);
					cmd.Parameters.AddWithValue("@referenciaCurso", student.Course);
					cmd.Parameters.AddWithValue("@nomeProprio", student.Name);
					cmd.Parameters.AddWithValue("@apelido", student.LastName);
					cmd.Parameters.AddWithValue("@dataNascimento", DateTime.Parse(student.Birthday));
					cmd.Parameters.AddWithValue("@morada", student.Address);
					cmd.Parameters.AddWithValue("@email", studentEmail);
					cmd.Parameters.AddWithValue("@telefone", student.Phone);

					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}

		public static bool UpdateStudent(Student student)
		{
			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = @"UPDATE Aluno 
                             SET referenciaCurso = Curso.referencia,
                                 nomeProprio = @nomeProprio,
                                 apelido = @apelido,
                                 dataNascimento = @dataNascimento,
                                 morada = @morada,
                                 telefone = @telefone
								 FROM Aluno
							 INNER JOIN Curso ON Curso.sigla = @referenciaCurso
                             WHERE numero = @numero";


				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@numero", student.Number);
					cmd.Parameters.AddWithValue("@referenciaCurso", student.Course);
					cmd.Parameters.AddWithValue("@nomeProprio", student.Name);
					cmd.Parameters.AddWithValue("@apelido", student.LastName);
					cmd.Parameters.AddWithValue("@dataNascimento", DateTime.Parse(student.Birthday));
					cmd.Parameters.AddWithValue("@morada", student.Address);
					cmd.Parameters.AddWithValue("@telefone", student.Phone);

					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}

		public static List<Student> GetAllStudents()
		{
			List<Student> allStudents = new List<Student>();

			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = @"SELECT numero, referenciaCurso, nomeProprio, apelido, dataNascimento, morada, email, telefone FROM Aluno";

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							Student student = new Student
							{
								Number = reader["numero"].ToString(),
								Course = reader["referenciaCurso"].ToString(),
								Name = reader["nomeProprio"].ToString(),
								LastName = reader["apelido"].ToString(),
								Birthday = reader["dataNascimento"].ToString(),
								Address = reader["morada"].ToString(),
								Email = reader["email"].ToString(),
								Phone = reader["telefone"].ToString()
							};
							allStudents.Add(student);
						}
					}
				}
			}
			return allStudents;
		}
		public static bool DeleteStudent(int numero)
		{
			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				string query = @"DELETE FROM Aluno
                             WHERE numero = @numero";

				using (SqlCommand cmd = new SqlCommand(query, cn))
				{
					cmd.Parameters.AddWithValue("@numero", numero);
					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}
		public static bool GetStudentEnrollment(int student)
		{

			using (SqlConnection cn = new SqlConnection(Connection.Conn()))
			{
				cn.Open();

				// Obter o maior número
				string query = "SELECT * FROM Inscricao WHERE numeroAluno = @numero;";

				using (SqlCommand command = new SqlCommand(query, cn))
				{
					command.Parameters.AddWithValue("@numero", student);
					bool studentEnroll = true;
					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read() && !reader.IsDBNull(0)) // Verifica se há valor
						{
							studentEnroll = false;
						}
						return studentEnroll;
					}
				}
			}
		}

	}
}
