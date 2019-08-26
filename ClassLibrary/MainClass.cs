using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ClassLibrary
{
    static public class MainClass
    {
        static public SQLiteConnection dbConnection;
        
        static public void SetUpSQLite()
        {
            SQLiteConnection.CreateFile("Database.sqlite");

            dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");

            using (dbConnection)
            {
                dbConnection.Open();

                string sql = "CREATE TABLE Courses (Id INT, Name VARCHAR(30), PassRate FLOAT)";
                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "CREATE TABLE Modules (Id INT, Name VARCHAR(30), PassRate FLOAT, Rating float, CourseId INT)";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "CREATE TABLE Reviews (Id INT PRIMARY KEY, Upvotes INT, Text VARCHAR(500), StudentId INT, ModuleId INT)";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "CREATE TABLE Students (Id INTEGER PRIMARY KEY, Username VARCHAR(30), EnrolledCourse VARCHAR(30), YearOfStudy VARCHAR(30), Password VARCHAR(12))";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "CREATE TABLE Lecturers (Id INT, Name VARCHAR(30), YearsTeaching INT, Biography VARCHAR(300))";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();


                //associative tables

                sql = "CREATE TABLE LecturerModule (LecturerId INT, ModuleId INT)";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                

                

            }

        }
        

        
        static public void InsertData()
        {
            dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");

            using (dbConnection)
            {
                dbConnection.Open();

                string sql = "INSERT into Courses (Id, Name, PassRate) values (1, 'Computer Science', 54.3)";
                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "INSERT into Courses (Id, Name, PassRate) values (2, 'Mathematics', 64.7)";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "INSERT into Courses (Id, Name, PassRate) values (3, 'Business', 76.4)";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "INSERT into Courses (Id, Name, PassRate) values (4, 'Geography', 72.3)";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "INSERT into Modules (Id, Name, PassRate, Rating, CourseId) values (1, 'Agile', 76.2, 4.32, 1)";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "INSERT into Modules (Id, Name, PassRate, Rating, CourseId) values (2, 'Networking and UID', 64.7, 3.89, 1)";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "INSERT into Modules (Id, Name, PassRate, Rating, CourseId) values (3, 'Advanced Programming', 56.7, 3.13, 1)";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "INSERT into Lecturers (Id, Name, YearsTeaching, Biography) values (1, 'John Whelan', 6, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vitae condimentum lectus. Integer non semper tortor. Curabitur dolor justo, porttitor at velit ac, laoreet mollis tortor. " +
                    "Nulla iaculis vel purus scelerisque ultricies. Nulla congue justo id pellentesque finibus. Donec eu justo eu diam pellentesque tincidunt vitae ut velit. " +
                    "Aliquam dictum, orci a iaculis viverra, nisl quam sollicitudin arcu, aliquet dapibus lacus arcu id eros. Phasellus vehicula urna ut lacus congue faucibus. ')";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "INSERT into Lecturers (Id, Name, YearsTeaching, Biography) values (2, 'Darren Clarkson', 2, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vitae condimentum lectus. Integer non semper tortor. Curabitur dolor justo, porttitor at velit ac, laoreet mollis tortor. " +
                    "Nulla iaculis vel purus scelerisque ultricies. Nulla congue justo id pellentesque finibus. Donec eu justo eu diam pellentesque tincidunt vitae ut velit. " +
                    "Aliquam dictum, orci a iaculis viverra, nisl quam sollicitudin arcu, aliquet dapibus lacus arcu id eros. Phasellus vehicula urna ut lacus congue faucibus. ')";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "INSERT into Lecturers (Id, Name, YearsTeaching, Biography) values (3, 'Brian C. Tompsett', 12, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vitae condimentum lectus. Integer non semper tortor. Curabitur dolor justo, porttitor at velit ac, laoreet mollis tortor. " +
                    "Nulla iaculis vel purus scelerisque ultricies. Nulla congue justo id pellentesque finibus. Donec eu justo eu diam pellentesque tincidunt vitae ut velit. " +
                    "Aliquam dictum, orci a iaculis viverra, nisl quam sollicitudin arcu, aliquet dapibus lacus arcu id eros. Phasellus vehicula urna ut lacus congue faucibus. ')";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "INSERT into Lecturers (Id, Name, YearsTeaching, Biography) values (4, 'Warren J. Viant', 7, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse vitae condimentum lectus. Integer non semper tortor. Curabitur dolor justo, porttitor at velit ac, laoreet mollis tortor. " +
                    "Nulla iaculis vel purus scelerisque ultricies. Nulla congue justo id pellentesque finibus. Donec eu justo eu diam pellentesque tincidunt vitae ut velit. " +
                    "Aliquam dictum, orci a iaculis viverra, nisl quam sollicitudin arcu, aliquet dapibus lacus arcu id eros. Phasellus vehicula urna ut lacus congue faucibus. ')";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                //populating students
                sql = "INSERT into Students (Id, Username, EnrolledCourse, YearOfStudy, Password) values (1, 'rayn3r_', 'Computer Science', 3, 'password')";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "INSERT into Students (Id, Username, EnrolledCourse, YearOfStudy, Password) values (2, 'JohnnySmith98', 'Computer Science', 3, 'password')";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();


                //populating reviews
                sql = "INSERT into Reviews (Upvotes, Text, StudentId, ModuleId) values (10, 'I actually really enjoyed this module. It taught me a lot about working in a constantly changing environment. The scrum methodology was explained in great detail where I now feel confident enough to work in the industry.', 1, 1)";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "INSERT into Reviews (Upvotes, Text, StudentId, ModuleId) values (2, 'Its aight. There could have been more detail for certain parts sauibs dsg faubisagusa asoigu asiohgsa asoighsaiom e sgsa oiehas m.', 2, 1)";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                //associative table insertion

                sql = "INSERT into LecturerModule (LecturerId, ModuleId) values (1, 1)";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "INSERT into LecturerModule (LecturerId, ModuleId) values (2, 2)";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "INSERT into LecturerModule (LecturerId, ModuleId) values (3, 2)";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

                sql = "INSERT into LecturerModule (LecturerId, ModuleId) values (4, 3)";
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();

            }
        }

    

        static public string[] getCourseNames()
        {
            dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");

            using (dbConnection)
            {
                dbConnection.Open();

                string sql = "SELECT Name FROM Courses";
                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                List<string> courseNames = new List<string>();

                while (reader.Read())
                {
                    courseNames.Add(reader["Name"].ToString());
                }

                return courseNames.ToArray();

            }


        }

        static public bool ValidateUser(string pUsername, string pPassword)
        {

            dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");

            using (dbConnection)
            {
                dbConnection.Open();

                string sql = "SELECT Username, Password FROM Students Where Students.Username ='" + pUsername + "'";
                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (reader["Password"].ToString() == pPassword)
                    {
                        return true;
                    }

                }


            }

            return false;
        }

        static public string GetStudentUsernameById(int Id)
        {
            dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            Student s = null;

            using (dbConnection)
            {
                dbConnection.Open();

                string sql = "SELECT * FROM Students Where Students.Id = " + Id;
                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();

                string username = "";

                while (reader.Read())
                {
                    username = reader["Username"].ToString();
                }

                return username;



            }


        }

        static public Student GetStudent(string pUsername, string pPassword)
        {
            dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            Student s = null;

            using (dbConnection)
            {
                dbConnection.Open();

                string sql = "SELECT * FROM Students Where Students.Username ='" + pUsername + "' AND Students.Password = '" + pPassword +"'";
                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    s = new Student(reader.GetInt32(0),pUsername, pPassword, reader["EnrolledCourse"].ToString(), int.Parse(reader["YearOfStudy"].ToString()), true);

                }


            }

            return s; 
        }

        static public List<string> GetLectures(Module pModule, int pModuleId)
        {
            dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3");
            List<string> lecturerNames = new List<string>();

            using (dbConnection)
            {
                dbConnection.Open();
                string sql = "SELECT * FROM Lecturers INNER JOIN LecturerModule ON Lecturers.Id = LecturerModule.LecturerId WHERE LecturerModule.ModuleId = " + pModuleId;
                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                string name;


                while (reader.Read())
                {
                    name = reader["Name"].ToString();
                    lecturerNames.Add(name);
                }
                
            }

            return lecturerNames;
        }

        static public List<Review> GetReviewsOfModule(Module pModule)
        {
            dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3");
            int moduleId = pModule.GetModuleId();
            List<Review> reviews = new List<Review>();

            using (dbConnection)
            {
                dbConnection.Open();

                string sql = "SELECT * FROM Reviews WHERE Reviews.ModuleId = " + moduleId;
                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Review review = new Review(reader.GetInt32(0), reader["Text"].ToString(), reader.GetInt32(1), reader.GetInt32(3), reader.GetInt32(4));
                    reviews.Add(review);    
                }


            }

            return reviews;
        }

    }
}
