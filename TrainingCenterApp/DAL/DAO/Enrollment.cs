using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCenterApp.DAL.DAO
{
    class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student AStudent { get; set; }
        public Course ACourse { get; set; }
        public DateTime DateTime { get; set; }

        public Enrollment(Student aStudent, Course aCourse, DateTime dateTime): this()
        {
            AStudent = aStudent;
            ACourse = aCourse;
            DateTime = dateTime;
        }

        public Enrollment()
        {
        }
    }
}
