using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingCenterApp.DAL.DAO;
using TrainingCenterApp.DAL.Gateway;

namespace TrainingCenterApp.BLL
{

    class EnrollmentBLL
    {
        private EnrollmentGateway anEnrollmentGateway;
        public Enrollment AnEnrollment { get; set; }
        public ListViewItem lvi { get; set; }

        public EnrollmentBLL()
        {
            anEnrollmentGateway= new EnrollmentGateway();
            lvi = new ListViewItem("");
            lvi.SubItems.Add("");
            lvi.SubItems.Add("");
        }
        public Student Find(string regNo)
        {
            return anEnrollmentGateway.Find(regNo);
        }

        public string Enroll(Enrollment anEnrollment)
        {
            if (HasThisStudentInCourse(anEnrollment.AStudent,anEnrollment.ACourse))
            {
                AnEnrollment = anEnrollmentGateway.GetEnrolledStudent(anEnrollment.AStudent,anEnrollment.ACourse);
                lvi = new ListViewItem(AnEnrollment.ACourse.Title);
                lvi.SubItems.Add(AnEnrollment.DateTime.ToString());
                return "Student already enrolled";
            }
            return anEnrollmentGateway.Enroll(anEnrollment);
        }

        private bool HasThisStudentInCourse(Student aStudent,Course aCourse)
        {
            return anEnrollmentGateway.HasThisStudentInCourse(aStudent,aCourse);
        }

        public List<Course> GetAllCourse()
        {
            return anEnrollmentGateway.GetAllCourse();
        }
    }
}
