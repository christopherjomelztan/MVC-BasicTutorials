using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;

namespace MVC_BasicTutorials.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }



        public List<Student> FillStudent()
        {


            SqlConnection sqlConnection = new SqlConnection();
            string strConString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDatabase;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True";
            sqlConnection.ConnectionString = strConString;
            sqlConnection.Open();

            string query = "Select * from Student";
            SqlCommand sqlCommand = new SqlCommand(query);
            sqlCommand.Connection = sqlConnection;
            SqlDataReader dr = sqlCommand.ExecuteReader();

            var studentList = new List<Student>();

            while (dr.Read())
            {
                studentList.Add(new Student() { StudentId = dr.GetInt32(dr.GetOrdinal("StudentId")), StudentName = dr["StudentName"].ToString(), Age = dr.GetInt32(dr.GetOrdinal("Age")) });
            }

            sqlConnection.Close();
            return studentList;
        }
    }

    

}