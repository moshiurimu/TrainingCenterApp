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

    }
}
