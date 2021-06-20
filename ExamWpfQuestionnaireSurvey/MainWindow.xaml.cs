using ExamWpfQuestionnaireSurvey.Forms.QuestionnaireSurvey;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamWpfQuestionnaireSurvey
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        private DbOperation_Dapper dbOperation;
        
        public MainWindow()
        {
            InitializeComponent();
            dbOperation = new DbOperation_Dapper();
        }

        private void bt_Ok_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.FirstName = tb_FName.Text;
            user.LastName = tb_LName.Text;            
            dbOperation.Create(user);

            QuestionnarireForm questionnarireForm = new QuestionnarireForm();
            questionnarireForm.Show();
            this.Close();

        }
    }
}
