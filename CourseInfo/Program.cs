using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using ClassLibrary;

namespace CourseInfo
{
    static class Program
    {

        static public SQLiteConnection dbConnection;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainClass.SetUpSQLite();
            MainClass.InsertData();
            //MainClass.SetUpSQLite();
            //MainClass.InsertData();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm(dbConnection));

            
        }
        
    }
}
