using ExamWpfQuestionnaireSurvey.Model;
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

namespace ExamWpfQuestionnaireSurvey.Forms.Result
{
    /// <summary>
    /// Interaction logic for ResultForms.xaml
    /// </summary>
    public partial class ResultForms : Window
    {
        public TestResult result;
        public ResultForms()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lb_1.Content = result.FullName.ToString();
            lb_2.Content = result.NumberOfQuestion.ToString();
            lb_3.Content = result.NumberOfCorrectAnswer.ToString();
            lb_4.Content = result.PercentageOfCorrectAnswer.ToString();
        }
    }
}
