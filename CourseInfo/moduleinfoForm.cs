using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CourseInfo
{
    public partial class moduleinfoForm : Form
    {
        public moduleinfoForm(object lstboxModulesSelectedItem)
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            CreateReview form = new CreateReview();
            Hide();// hides current form
            form.ShowDialog();
        }
    }
}
