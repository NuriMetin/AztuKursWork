using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRatingTableApp.v1._0.Core
{
    public static class Extension
    {
        public static string ConnectToDb()
        {
            string connection= "Data Source= DESKTOP-A4JVK6F\\SQLEXPRESS; Initial Catalog=AZTU; Integrated Security=true;";
            return connection;
        }

        public static string StudentRatingQuery(string sesValue, string grValue)
        {
            string query = @" SELECT Stud.Name AS[StName], AVG(Pounts.ResultPount) AS SessiounAVGPounts
                            FROM Students as Stud
                            INNER JOIN Groups AS GR
                            ON GR.ID = Stud.GroupID
                            INNER JOIN Professions AS PR
                            ON PR.ID = GR.ProfessionID
                            INNER JOIN Pounts
                            ON Pounts.StudentID = Stud.ID
                            INNER JOIN Sessions
                            ON SessionID = Pounts.SessionID
                            INNER JOIN Subjects
                            ON Pounts.SubjectID = Subjects.ID
                            WHERE SessionID=" + sesValue + "AND GR.ID=" + grValue + 
                            "Group by Stud.Name ORDER BY SessiounAVGPounts DESC";
            return query;
        }
    }
}
