using ExamWpfQuestionnaireSurvey.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWpfQuestionnaireSurvey.Abstract
{
    public interface IDbOperation
    {
        int Create (User user);
        IEnumerable<Test> GetTests();
       
    }
}
