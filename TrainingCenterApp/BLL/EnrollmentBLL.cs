using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterApp.DAL.DAO;
using TrainingCenterApp.DAL.Gateway;

namespace TrainingCenterApp.BLL
{

    class EnrollmentBLL
    {
        private EnrollmentGateway anEnrollmentGateway;
        public EnrollmentBLL()
        {
            anEnrollmentGateway= new EnrollmentGateway();
        }

        

        public Student Find(string regNo)
        {
            return anEnrollmentGateway.Find(regNo);
        }

        public string Add(Enrollment anEnrollment)
        {
            if (HasThisStudentInCourse(anEnrollment.AStudent))
            {
                return "Student already in this course!";
            }
            return anEnrollmentGateway.Add(anEnrollment);
        }

        private bool HasThisStudentInCourse(Student aStudent)
        {
            return anEnrollmentGateway.HasThisStudentInCourse(aStudent);
        }
    }
}
