using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCenterApp.DAL.DAO
{
    class Result
    {
        public int ResultId { get; set; }
        public float ScorePercentage { get; set; }
        public DateTime DateTime { get; set; }
        public Student AStudent { get; set; }
        public Course ACourse { get; set; }
    }
}
