using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWpfQuestionnaireSurvey.Model
{
    public class TestResult
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int NumberOfQuestion { get; set; }
        public int NumberOfCorrectAnswer { get; set; }
        public float PercentageOfCorrectAnswer { get; set; }
    }
}
