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
using ClassLibrary;

namespace CourseInfo
{
    public partial class mainForm : Form
    {
        public static SQLiteConnection dbConnection;
        public static Student student;
        public static User user;
        private static int yearNumber;
        private static string course;
        private static bool signedIn;

        bool coursesPopulated;

        public mainForm(SQLiteConnection pConnection)
        {
            //MainClass.SetUpSQLite();
            //MainClass.InsertData();

            signedIn = false;
            coursesPopulated = false;

            dbConnection = pConnection;
            InitializeComponent();
            cmbBoxYearOfStudy.Items.Add(1);
            cmbBoxYearOfStudy.Items.Add(2);
            cmbBoxYearOfStudy.Items.Add(3);
        }

        private void btnGuestSelect_Click(object sender, EventArgs e)
        {

            //show course panel
            
            pnlCourseSelect.Show();
            pnlCourseSelect.BringToFront();

            if (coursesPopulated == false)
            {
                string[] coursenames = MainClass.getCourseNames();

                foreach (string name in coursenames)
                {
                    lstboxCourses.Items.Add(name);
                }
                coursesPopulated = true;
            }

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            pnlMain.Hide();
            pnlSignIn.Hide();
            pnlSignUp.Show();
            

            if (lstboxCoursesSignUp.Items.Count == 0)
            {
                string[] coursenames = MainClass.getCourseNames();

                foreach (string name in coursenames)
                {
                    lstboxCoursesSignUp.Items.Add(name);
                }
            }
        }

        private void btnBackToPnlMain_Click(object sender, EventArgs e)
        {
            pnlMain.Show();
            pnlSignUp.Hide();
        }

        private void btnSubmitSignUp_Click(object sender, EventArgs e)
        {
            //do some error checking here
            //....

            Student s = new Student(0,txtbxUsername.Text, txtbxPassword.Text, lstboxCoursesSignUp.SelectedItem.ToString(), int.Parse(cmbBoxYearOfStudy.SelectedItem.ToString()), false);
            //Courses c = new Courses(dbConnection);
            //c.Show();
        }

        private void btnSendSignIn_Click(object sender, EventArgs e)
        {


            if (MainClass.ValidateUser(txtboxUsername2.Text, txtboxPassword2.Text))
            {
                pnlModules.Show();
                pnlSignIn.Hide();
                pnlMain.Hide();

                //find student in the sql...
                //get his course name and year...
                //the following are just default vals.

                student = MainClass.GetStudent(txtboxUsername2.Text, txtboxPassword2.Text);

                lblWelcomeUser.Text = "Welcome " + student.GetName() + "!";
                course = student.getEnrolledCourse();
                yearNumber = student.getYearOfStudy();

                signedIn = true;


                //initializePnlModules();
                //pnlModules.Show();
                //populateFlowWithModules("Name");

                pnlStudentPortal.Show();
                pnlStudentPortal.BringToFront();
                //lblWelcomeUser.Text = "Welcome " + 

            }
            else
            {
                MessageBox.Show("Invalid login credentials", "Big Bad Error", MessageBoxButtons.OK);
            }
        }

        private void populateFlowWithModules(string pSortType)
        {

            dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3");

            if (flowLayoutModules.Controls.Count > 0)
            {
                flowLayoutModules.Controls.Clear();
            }

            using (dbConnection)
            {
                dbConnection.Open();
                string sql = "";

                if (pSortType == "Pass Rate")
                {
                    sql = "SELECT * FROM Modules INNER JOIN Courses ON Modules.CourseId = Courses.Id WHERE Courses.Name = '" + course + "' ORDER BY PassRate DESC";
                }
                else if (pSortType == "Name")
                {
                    sql = "SELECT * FROM Modules INNER JOIN Courses ON Modules.CourseId = Courses.Id WHERE Courses.Name = '" + course + "' ORDER BY Name ASC";
                }
                else if (pSortType == "Rating")
                {
                    sql = "SELECT * FROM Modules INNER JOIN Courses ON Modules.CourseId = Courses.Id WHERE Courses.Name = '" + course + "' ORDER BY Rating DESC";
                }



                SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();

                List<ModuleItem> modules = new List<ModuleItem>();

                while (reader.Read())
                {
                    //hack for the time being because there is no module description
                    string moduleDescription = "Here is the module description lmao. Its pretty dang good if I say so myself. But what do I know Im only the lecturer. Also it is totally okay to review your own modules everyone does it so dont judge me. If you dont believe me then look at...Actually we're not gonna go there.";
                    string moduleName = reader["Name"].ToString();
                    float moduleRating = (float)reader.GetFloat(4);
                    int moduleId = reader.GetInt32(0);
                    Module m = new Module(moduleId, moduleName, moduleRating, moduleDescription);
                    ModuleItem mI = new ModuleItem(this, m);
                    //mI.Title = reader["Name"].ToString();
                    //mI.BodyText = "";

                    modules.Add(mI);
                    flowLayoutModules.Controls.Add(mI);
                }

            }

        }

        public void initializeModuleInfo(Module m)
        {
            if (pnlModuleInfo.Controls.Count > 0)
            {
                pnlModuleInfo.Controls.Clear();
            }

            //show the module panel with the relevent module information.
            ModuleInfoPage mf;

            if (signedIn)
            {
                mf = new ModuleInfoPage(this, m, student);
                pnlModuleInfo.Controls.Add(mf);
            }
            else
            {
                student = null;
               mf = new ModuleInfoPage(this, m, student);
               pnlModuleInfo.Controls.Add(mf);
            }

            pnlModuleInfo.Show();
            pnlModuleInfo.BringToFront();


        }

        public void ExitModuleInfoPage()
        {
            pnlModuleInfo.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            pnlSignUp.Hide();
            pnlMain.Hide();
            pnlSignIn.Show();
            pnlSignIn.BringToFront();
            
        }

        private void btnLeaveSignUp_Click(object sender, EventArgs e)
        {
            pnlSignIn.Hide();
            pnlMain.Show();
        }

        private void btnLeavePnlModules_Click(object sender, EventArgs e)
        {
            pnlModules.Hide();
            if (signedIn == false)
            {

                pnlCourseSelect.Show();
                pnlCourseSelect.BringToFront();

            }
            else
            {
                pnlStudentPortal.Show();
                pnlStudentPortal.BringToFront();
            }

        }

        private void cmbBoxModulesSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxModulesSort.SelectedItem.ToString() == "Pass Rate")
            {
                populateFlowWithModules("Pass Rate");
            }
            else if (cmbBoxModulesSort.SelectedItem.ToString() == "Name")
            {
                populateFlowWithModules("Name");
            }
            else if (cmbBoxModulesSort.SelectedItem.ToString() == "Rating")
            {
                populateFlowWithModules("Rating");
            }
        }

        private void flowLayoutModules_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void btnExitCourseSelect_Click(object sender, EventArgs e)
        {
            if (signedIn == false)
            {
                pnlCourseSelect.Hide();
                pnlMain.Show();
                pnlMain.BringToFront();
            }
        }

        private void lstboxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            course = lstboxCourses.SelectedItem.ToString();
            pnlCourseSelect.Hide();
            pnlModules.Show();
            pnlModules.BringToFront();
            populateFlowWithModules("Name");
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            //initializePnlModules();
            pnlModules.Show();
            pnlModules.BringToFront();
            populateFlowWithModules("Name");
        }

        private void btnSingOut_Click(object sender, EventArgs e)
        {
            signedIn = false;
            student = null;
            pnlStudentPortal.Hide();
            pnlMain.Show();
            pnlMain.BringToFront();
        }
    }
}
