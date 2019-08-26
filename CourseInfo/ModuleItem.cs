using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace CourseInfo
{
    public partial class ModuleItem : UserControl
    {

        static mainForm returnForm;
        private Module module;

        public ModuleItem(mainForm pReturnForm, Module pModule)
        {

            InitializeComponent();
            module = pModule;
            Title = module.GetName();
            BodyText = module.GetModuleDescription();
            returnForm = pReturnForm;
        }


        #region MyRegion

        private string _title;
        private string _body;
        private Color _iconColour;
        private Image _icon;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string BodyText
        {
            get { return _body; }
            set { _body = value; lblBody.Text = value; }
        }

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }

        [Category("Custom Props")]
        public Color IconColour
        {
            get { return _iconColour; }
            set { _iconColour = value; panel1.BackColor = value; }
        }

        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ModuleItem_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
        }

        private void ModuleItem_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

            returnForm.initializeModuleInfo(module);
        }

        private void lblTitle_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            returnForm.initializeModuleInfo(module);
        }
    }
}
