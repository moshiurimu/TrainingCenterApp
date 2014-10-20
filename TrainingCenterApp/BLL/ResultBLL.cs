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
            if (HasResultPublishInCourse(aResult))
            {
                return "Student Result Already Published In This Course";
            }
            if (HasThisStudentInCourse(aResult))
            {
                return aResultGateway.Add(aResult);
            }
            return "Student Not In This Course";
        }
        public bool HasThisStudentInCourse(Result aResult)
        {
            return aResultGateway.HasThisStudentInCourse(aResult);
        }
        private bool HasResultPublishInCourse(Result aResult)
        {
            return aResultGateway.HasResultPublishInCourse(aResult);
        }

        //Faez Section
        public List<Result> GetAllResult(Student aStudent)
        {
            return aResultGateway.GetAllResult(aStudent);
        }
        public string MakeGradeLetter(double score)
        {
            string gradeLetter = "";
            if (score >= 90)
            {
                gradeLetter = "A";
            }
            else if (score >= 70 && score < 90)
            {
                gradeLetter = "B";
            }
            else if (score >= 50 && score < 70)
            {
                gradeLetter = "C";
            }
            else if (score < 50)
            {
                gradeLetter = "F";
            }
            return gradeLetter;
        }

    }
}
