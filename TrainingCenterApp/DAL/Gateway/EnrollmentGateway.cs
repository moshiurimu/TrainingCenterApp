﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using TrainingCenterApp.DAL.DAO;

namespace TrainingCenterApp.DAL.Gateway
{
    internal class EnrollmentGateway
    {
        private SqlConnection connection;

        public EnrollmentGateway()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        }

        public Student Find(string regNo)
        {
            Student aStudent = new Student();
            connection.Open();
            string qurey = string.Format("SELECT * FROM t_Student WHERE RegNo='{0}'", regNo);
            SqlCommand cmd = new SqlCommand(qurey, connection);
            SqlDataReader aReader = cmd.ExecuteReader();

            bool HasRow = aReader.HasRows;

            if (HasRow)
            {
                while (aReader.Read())
                {
                    aStudent.Id = (int) aReader[0];
                    aStudent.RegNo = aReader[1].ToString();
                    aStudent.Name = aReader[2].ToString();
                    aStudent.Email = aReader[3].ToString();
                }
                connection.Close();
            }
            
            return aStudent;
        }

        public string Add(Enrollment anEnrollment)
        {
            connection.Open();
            string query = string.Format("INSERT INTO t_Enrollment VALUES ('{0}','{1}',{2})", anEnrollment.AStudent.Id,
                anEnrollment.ACourse.Id, anEnrollment.DateTime);
            SqlCommand cmd = new SqlCommand();
            int affectedrow = cmd.ExecuteNonQuery();
            connection.Close();
            if (affectedrow > 0)
            {
                return "Course enrollment successfull.";
            }
            return "somthing wrong";
        }




        public bool HasThisStudentInCourse(Student aStudent)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Enrollment WHERE StudentId={0}", aStudent.Id);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader aDataReader = cmd.ExecuteReader();
            bool Hasrow = aDataReader.HasRows;

            connection.Close();
            return Hasrow;
        }

        public List<Course> GetAllCourse()
        {
            Course aCourse;
            connection.Open();
            string qurey = string.Format("SELECT * FROM t_Course");
            SqlCommand cmd = new SqlCommand(qurey, connection);
            SqlDataReader aReader = cmd.ExecuteReader();
            List<Course> courses = new List<Course>();
            bool HasRow = aReader.HasRows;

            if (HasRow)
            {
                while (aReader.Read())
                {
                    aCourse = new Course();
                    aCourse.Id = (int) aReader[0];
                    aCourse.Name = aReader[1].ToString();
                    aCourse.Title = aReader[2].ToString();
                    courses.Add(aCourse);
                }
                connection.Close();
            }
            return courses;
        }
    }
}
