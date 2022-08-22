using System;
using System.Data.SqlClient;

namespace Data
{
    public class SQLRepository
    {
        // establish azure connection
        // normally you do not want to hard code it in, but do so just so you can get it working for now
        private static string? connectionString = "Server=tcp:rogersql.database.windows.net,1433;Initial Catalog=rogersql;Persist Security Info=False;User ID=rogersql;Password=Wyclief@1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        // you will need this to connect to your database
        public SqlConnection DbConnect()
        {
            SqlConnection dbConn = new SqlConnection(connectionString);

            dbConn.Open();
            System.Console.WriteLine("Sql Connection Established");

            return dbConn;
        }

        // Database function to get all students
        public List<Student> FetchAllStudents()
        {
            SqlConnection dbConn = DbConnect();

            List<Student> allStudents = new List<Student>();

            SqlCommand command = new SqlCommand("SELECT * FROM Projectone.Students", dbConn);
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Student student = new Student();
                student.Id = reader.GetInt32(0);
                student.Name = reader.GetString(1);
                student.Batch= reader.GetString(2);

                // what other columns do you have in your table?
                // MAKE SURE that all of the columns are inserted in order


                allStudents.Add(student);
            }

            dbConn.Close();
            return allStudents;
        }
    }
}