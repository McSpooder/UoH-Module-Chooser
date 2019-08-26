using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ClassLibrary
{
    public class User
    {
        string username;
        string password;

        public User(string pUsername, string pPassword)
        {
            this.username = pUsername;
            this.password = pPassword;
        }

        public string GetName()
        {
            return this.username;
        }

    }

    public class Student : User
    {
        int _studentId;
        string enrolledCourse;
        int yearOfStudy;


        public Student(int pStudentId, string pUsername, string pPassword, string pEnrolledCourse, int pYearOfStudy, bool pInDatabase) : base(pUsername, pPassword)
        {
            this.enrolledCourse = pEnrolledCourse;
            this.yearOfStudy = pYearOfStudy;

            if (pInDatabase == true)
            {
                _studentId = pStudentId;
            }
            else
            {
                AddToSQLDatabase(pUsername, pPassword, pEnrolledCourse, pYearOfStudy);
            }

            

        }

        public string getEnrolledCourse()
        {
            return enrolledCourse;
        }

        public int getYearOfStudy()
        {
            return yearOfStudy;
        }

        public int geStudentId()
        {
            return _studentId;
        }

        private void AddToSQLDatabase(string pUsername, string pPassword, string pEnrolledCourse, int pYearOfStudy)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");

            using (dbConnection)
            {
                dbConnection.Open();
                string sql = "INSERT into Students (Username, EnrolledCourse, YearOfStudy, Password) values ( '" + pUsername + "', '"  + pEnrolledCourse + "', " + pYearOfStudy + ", '" + pPassword + "')";
                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();
            }

        }

    }

}
