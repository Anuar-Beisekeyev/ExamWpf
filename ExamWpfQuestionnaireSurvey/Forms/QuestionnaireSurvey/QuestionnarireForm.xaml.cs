using ExamWpfQuestionnaireSurvey.Forms.Result;
using ExamWpfQuestionnaireSurvey.Model;
using ExamWpfQuestionnaireSurvey.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExamWpfQuestionnaireSurvey.Forms.QuestionnaireSurvey
{
    /// <summary>
    /// Interaction logic for QuestionnarireForm.xaml
    /// </summary>
    public partial class QuestionnarireForm : Window
    {
        private DbOperation_Dapper dbOperation;
        private List<Test> tests;        
        public User user;
        public QuestionnarireForm()
        {
            InitializeComponent();
            dbOperation = new DbOperation_Dapper();
            tests = dbOperation.GetTests().ToList();
            lb_1.Content = tests[0].Question;
            lb_2.Content = tests[1].Question;
            lb_3.Content = tests[2].Question;
            lb_4.Content = tests[3].Question;
            lb_5.Content = tests[4].Question;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int res = 0;
            if (tb_1.Text == tests[0].Answer)
            {
                ++res;
            }
            if (tb_2.Text == tests[1].Answer)
            {
                ++res;
            }
            if (tb_3.Text == tests[2].Answer)
            {
                ++res;
            }
            if (tb_4.Text == tests[3].Answer)
            {
                ++res;
            }
            if (tb_5.Text == tests[4].Answer)
            {
                ++res;
            }
            TestResult result = new TestResult();
            result.FullName = user.LastName + " " + user.FirstName;
            result.NumberOfQuestion = 5;
            result.NumberOfCorrectAnswer = res;
            result.PercentageOfCorrectAnswer = (res * 100) / 5;
            ResultForms resultForms = new ResultForms();
            resultForms.Show();
            resultForms.Close();
        }
    }
}
