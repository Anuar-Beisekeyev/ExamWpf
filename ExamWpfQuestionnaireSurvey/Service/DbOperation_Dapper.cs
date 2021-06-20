using Dapper;
using ExamWpfQuestionnaireSurvey.Abstract;
using ExamWpfQuestionnaireSurvey.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWpfQuestionnaireSurvey.Service
{
    public class DbOperation_Dapper : GetConnection, IDbOperation
    {
        public int Create(User user)
        {
            using (var connection = Connection) {
                string sqlScript = @"insert into [User] (FirstName, LastName) values (@FirstName, @LastName)";
                return connection.Execute(sqlScript, new DynamicParameters(user));
            }
        }

        public IEnumerable<Test> GetTests()
        {
            using (var conection = Connection)
            {
                return conection.Query<Test>("Select * from Test");
            }
        }
    }
}
