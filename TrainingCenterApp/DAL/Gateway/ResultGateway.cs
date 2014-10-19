using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterApp.DAL.DAO;

namespace TrainingCenterApp.DAL.Gateway
{
    class ResultGateway
    {
        private SqlConnection connection;
        public ResultGateway()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        }

        public string Add(Result aResult)
        {
            connection.Open();
            string query = string.Format("INSERT INTO t_Result VALUES ('{0}','{1}',{2},{3})", aResult.AStudent.Id, aResult.ACourse.Id, aResult.ScorePercentage, aResult.DateTime);
            SqlCommand cmd = new SqlCommand(query, connection);
            int affectedrow = cmd.ExecuteNonQuery();
            connection.Close();
            if (affectedrow > 0)
            {
                return "Course enrollment successfull.";
            }
            return "somthing wrong";
        }

        public bool HasThisStudentInCourse(Course aCourse)
        {
            connection.Open();
            string query = string.Format("SELECT *FROM Enrollment WHERE CourseID=('{0}') ", aCourse.Id);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            connection.Close();
            return Hasrow;
        }
    }
}
