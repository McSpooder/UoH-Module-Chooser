namespace CourseInfo
{
    partial class Courses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstboxCourses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSelectCourse = new System.Windows.Forms.Panel();
            this.pnlModules = new System.Windows.Forms.Panel();
            this.btnReturnFrmModulesSlct = new System.Windows.Forms.Button();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cmbboxSortBy = new System.Windows.Forms.ComboBox();
            this.lstboxModules = new System.Windows.Forms.ListBox();
            this.pnlSelectCourse.SuspendLayout();
            this.pnlModules.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstboxCourses
            // 
            this.lstboxCourses.FormattingEnabled = true;
            this.lstboxCourses.Location = new System.Drawing.Point(23, 98);
            this.lstboxCourses.Name = "lstboxCourses";
            this.lstboxCourses.Size = new System.Drawing.Size(225, 277);
            this.lstboxCourses.TabIndex = 0;
            this.lstboxCourses.Click += new System.EventHandler(this.lstboxCourses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Course";
            // 
            // pnlSelectCourse
            // 
            this.pnlSelectCourse.Controls.Add(this.lstboxCourses);
            this.pnlSelectCourse.Controls.Add(this.label1);
            this.pnlSelectCourse.Location = new System.Drawing.Point(-1, 0);
            this.pnlSelectCourse.Name = "pnlSelectCourse";
            this.pnlSelectCourse.Size = new System.Drawing.Size(277, 445);
            this.pnlSelectCourse.TabIndex = 2;
            // 
            // pnlModules
            // 
            this.pnlModules.Controls.Add(this.btnReturnFrmModulesSlct);
            this.pnlModules.Controls.Add(this.lblSortBy);
            this.pnlModules.Controls.Add(this.cmbboxSortBy);
            this.pnlModules.Controls.Add(this.lstboxModules);
            this.pnlModules.Location = new System.Drawing.Point(0, 0);
            this.pnlModules.Name = "pnlModules";
            this.pnlModules.Size = new System.Drawing.Size(264, 482);
            this.pnlModules.TabIndex = 2;
            // 
            // btnReturnFrmModulesSlct
            // 
            this.btnReturnFrmModulesSlct.Location = new System.Drawing.Point(22, 12);
            this.btnReturnFrmModulesSlct.Name = "btnReturnFrmModulesSlct";
            this.btnReturnFrmModulesSlct.Size = new System.Drawing.Size(33, 27);
            this.btnReturnFrmModulesSlct.TabIndex = 3;
            this.btnReturnFrmModulesSlct.Text = "<";
            this.btnReturnFrmModulesSlct.UseVisualStyleBackColor = true;
            this.btnReturnFrmModulesSlct.Click += new System.EventHandler(this.btnReturnFrmModulesSlct_Click);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(69, 45);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(41, 13);
            this.lblSortBy.TabIndex = 2;
            this.lblSortBy.Text = "Sort By";
            // 
            // cmbboxSortBy
            // 
            this.cmbboxSortBy.FormattingEnabled = true;
            this.cmbboxSortBy.Location = new System.Drawing.Point(126, 41);
            this.cmbboxSortBy.Name = "cmbboxSortBy";
            this.cmbboxSortBy.Size = new System.Drawing.Size(121, 21);
            this.cmbboxSortBy.TabIndex = 1;
            this.cmbboxSortBy.Text = "Name";
            this.cmbboxSortBy.SelectedIndexChanged += new System.EventHandler(this.cmbboxSortBy_SelectedIndexChanged);
            // 
            // lstboxModules
            // 
            this.lstboxModules.FormattingEnabled = true;
            this.lstboxModules.Location = new System.Drawing.Point(22, 74);
            this.lstboxModules.Name = "lstboxModules";
            this.lstboxModules.Size = new System.Drawing.Size(225, 381);
            this.lstboxModules.TabIndex = 0;
            this.lstboxModules.SelectedIndexChanged += new System.EventHandler(this.lstboxModules_SelectedIndexChanged);
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 481);
            this.Controls.Add(this.pnlModules);
            this.Controls.Add(this.pnlSelectCourse);
            this.Name = "Courses";
            this.Text = "Courses";
            this.pnlSelectCourse.ResumeLayout(false);
            this.pnlSelectCourse.PerformLayout();
            this.pnlModules.ResumeLayout(false);
            this.pnlModules.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSelectCourse;
        private System.Windows.Forms.Panel pnlModules;
        private System.Windows.Forms.ListBox lstboxModules;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.ComboBox cmbboxSortBy;
        private System.Windows.Forms.Button btnReturnFrmModulesSlct;
    }
}