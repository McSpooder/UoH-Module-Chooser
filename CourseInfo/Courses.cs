using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CourseInfo
{


    public partial class Courses : Form
    {
        SQLiteConnection dbConnection;
        string selectedCourseName;

        public Courses(SQLiteConnection pConnection)
        {
            dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            InitializeComponent();

            pnlModules.Hide();
            pnlSelectCourse.Show();

            PopulateListboxCourses();

            cmbboxSortBy.Items.Add("Name");
            cmbboxSortBy.Items.Add("Pass Rate");
            cmbboxSortBy.Items.Add("Rating");

        }

        // populates the listbox with courses until the end of the sql table is reached.
        private void PopulateListboxCourses()
        {
            using (dbConnection)
            {
                dbConnection.Open();
                string sql = "SELECT * FROM Courses order by Name asc";
                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lstboxCourses.Items.Add(reader["Name"]);
                }
                dbConnection.Close();
            }

        }
        
        //same as before but instead of courses its modules.
        private void PopulateListBoxModules(string courseName, string orderBy)
        {

            dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");

            using (dbConnection)
            {
                dbConnection.Open();
                string sql;
                if (orderBy == "PassRate")
                {
                    sql = "SELECT * FROM Modules INNER JOIN Courses ON Modules.CourseId = Courses.Id WHERE Courses.Name = '" + courseName + "' order by PassRate DESC ";
                }
                else if (orderBy == "Rating")
                {
                    sql = "SELECT * FROM Modules INNER JOIN Courses ON Modules.CourseId = Courses.Id WHERE Courses.Name = '" + courseName + "' order by Rating DESC";
                }
                else
                {
                    sql = "SELECT * FROM Modules INNER JOIN Courses ON Modules.CourseId = Courses.Id WHERE Courses.Name = '" + courseName + "' order by Name";
                }

                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lstboxModules.Items.Add(reader["Name"] + "  Pass Rate: " + reader["PassRate"]);
                }
                dbConnection.Close();
                
                
                //TODO: call module info form when item in list box is clicked/selected.
                //HACK: I can show the form but when i click


            }
        }

        private void lstboxCourses_Click(object sender, EventArgs e)
        {
            pnlSelectCourse.Hide();
            lstboxModules.Items.Clear();
            selectedCourseName = (string)lstboxCourses.SelectedItem;
            PopulateListBoxModules(selectedCourseName, "Name");
            pnlModules.Show();
        }

        private void lstboxModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            moduleinfoForm infomodule = new moduleinfoForm(lstboxModules.SelectedItem);
            infomodule.ShowDialog();
        }

        private void cmbboxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbboxSortBy.SelectedItem == "Pass Rate")
            {
                lstboxModules.Items.Clear();
                PopulateListBoxModules(selectedCourseName, "PassRate");
            }
            else if (cmbboxSortBy.SelectedItem == "Name")
            {
                lstboxModules.Items.Clear();
                PopulateListBoxModules(selectedCourseName, "Name");
            }
            else if (cmbboxSortBy.SelectedItem == "Rating")
            {
                lstboxModules.Items.Clear();
                PopulateListBoxModules(selectedCourseName, "Rating");
            }
        }

        private void btnReturnFrmModulesSlct_Click(object sender, EventArgs e)
        {
            pnlModules.Hide();
            pnlSelectCourse.Show();
        }
    }
}
