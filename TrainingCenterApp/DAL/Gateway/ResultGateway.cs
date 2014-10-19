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
            string query = string.Format("INSERT INTO t_Result VALUES ({0},{1},{2},'{3}')", aResult.AStudent.Id, aResult.ACourse.Id, aResult.ScorePercentage, aResult.DateTime);
            SqlCommand cmd = new SqlCommand(query, connection);
            int affectedrow = cmd.ExecuteNonQuery();
            connection.Close();
            if (affectedrow > 0)
            {
                return "Student Result Insert successfull.";
            }
            return "somthing wrong";
        }

        public bool HasThisStudentInCourse(Result aResult)
        {
            connection.Open();
            string query = string.Format("SELECT *FROM t_Enrollment WHERE CourseId={0} ", aResult.ACourse.Id);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            connection.Close();
            return Hasrow;
        }
        public bool HasResultPublishInCourse(Result aResult)
        {
            connection.Open();
            string query = string.Format("SELECT *FROM t_Result WHERE StudentId=({0}) ", aResult.StudentId);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            connection.Close();
            return Hasrow;
        }

        //Faez Section
        public List<Result> GetAllResult(Student aStudent)
        {
            connection.Open();
            List<Result> results = new List<Result>();
            Result aResult;
            string query = string.Format("SELECT * FROM result_Course_View WHERE StudentId = {0}", aStudent.Id);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aResult = new Result();
                    aResult.Id = (int)aReader[0];
                    aResult.StudentId = (int)aReader[1];
                    aResult.CourseId = (int)aReader[2];
                    aResult.ACourse = new Course();
                    aResult.ACourse.Id = (int)aReader[3];
                    aResult.ACourse.Name = aReader[4].ToString();
                    aResult.ACourse.Title = aReader[5].ToString();
                    aResult.ScorePercentage = (double)aReader[6];
                    aResult.DateTime = (DateTime)aReader[7];
                    results.Add(aResult);
                }
            }
            connection.Close();
            return results;
        }
    }
}
