using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterApp.DAL.DAO;
using TrainingCenterApp.DAL.Gateway;

namespace TrainingCenterApp.BLL
{
    class ResultBLL
    {
        private ResultGateway aResultGateway = new ResultGateway();

        public string Add(Result aResult)
        {
            if (HasThisStudentInCourse(aResult.ACourse))
            {
                return aResultGateway.Add(aResult);
            }
            return "Student Not In This Course";
        }
        public bool HasThisStudentInCourse(Course aCourse)
        {
            return aResultGateway.HasThisStudentInCourse(aCourse);
        }
        //Faez Section
        public List<Result> GetAllResult(Student aStudent)
        {
            return aResultGateway.GetAllResult(aStudent);
        }
        public string MakeGradeLetter(Result aResult)
        {
            string gradeLetter = "";
            if (aResult.ScorePercentage >= 90)
            {
                gradeLetter = "A";
            }
            else if (aResult.ScorePercentage >= 70 && aResult.ScorePercentage < 90)
            {
                gradeLetter = "B";
            }
            else if (aResult.ScorePercentage >= 50 && aResult.ScorePercentage < 70)
            {
                gradeLetter = "C";
            }
            else if (aResult.ScorePercentage < 50)
            {
                gradeLetter = "F";
            }
            return gradeLetter;
        }

    }
}
