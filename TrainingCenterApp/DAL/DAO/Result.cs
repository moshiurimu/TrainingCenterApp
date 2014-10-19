using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCenterApp.DAL.DAO
{
    class Result
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public double ScorePercentage { get; set; }
        public DateTime DateTime { get; set; }
        public Student AStudent { get; set; }
        public Course ACourse { get; set; }
    }
}
