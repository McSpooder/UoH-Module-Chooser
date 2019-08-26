namespace CourseInfo
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnGuestSelect = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.btnBackToPnlMain = new System.Windows.Forms.Button();
            this.cmbBoxYearOfStudy = new System.Windows.Forms.ComboBox();
            this.btnSubmitSignUp = new System.Windows.Forms.Button();
            this.lstboxCoursesSignUp = new System.Windows.Forms.ListBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.lblYearOfStudy = new System.Windows.Forms.Label();
            this.lblEnrolledCourse = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlSignIn = new System.Windows.Forms.Panel();
            this.btnLeaveSignUp = new System.Windows.Forms.Button();
            this.btnSendSignIn = new System.Windows.Forms.Button();
            this.txtboxPassword2 = new System.Windows.Forms.TextBox();
            this.txtboxUsername2 = new System.Windows.Forms.TextBox();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblUsername2 = new System.Windows.Forms.Label();
            this.pnlModules = new System.Windows.Forms.Panel();
            this.btnLeavePnlModules = new System.Windows.Forms.Button();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cmbBoxModulesSort = new System.Windows.Forms.ComboBox();
            this.flowLayoutModules = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlModuleInfo = new System.Windows.Forms.Panel();
            this.pnlCourseSelect = new System.Windows.Forms.Panel();
            this.lstboxCourses = new System.Windows.Forms.ListBox();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.btnExitCourseSelect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlStudentPortal = new System.Windows.Forms.Panel();
            this.btnModules = new System.Windows.Forms.Button();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.btnReviews = new System.Windows.Forms.Button();
            this.btnSingOut = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlSignUp.SuspendLayout();
            this.pnlSignIn.SuspendLayout();
            this.pnlModules.SuspendLayout();
            this.pnlCourseSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlStudentPortal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuestSelect
            // 
            this.btnGuestSelect.Location = new System.Drawing.Point(62, 210);
            this.btnGuestSelect.Name = "btnGuestSelect";
            this.btnGuestSelect.Size = new System.Drawing.Size(135, 50);
            this.btnGuestSelect.TabIndex = 0;
            this.btnGuestSelect.Text = "Use as Guest";
            this.btnGuestSelect.UseVisualStyleBackColor = true;
            this.btnGuestSelect.Click += new System.EventHandler(this.btnGuestSelect_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Controls.Add(this.btnSignUp);
            this.pnlMain.Controls.Add(this.btnSignIn);
            this.pnlMain.Controls.Add(this.btnGuestSelect);
            this.pnlMain.Location = new System.Drawing.Point(2, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(263, 478);
            this.pnlMain.TabIndex = 1;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(62, 372);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(135, 50);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(62, 292);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(135, 50);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.Controls.Add(this.btnBackToPnlMain);
            this.pnlSignUp.Controls.Add(this.cmbBoxYearOfStudy);
            this.pnlSignUp.Controls.Add(this.btnSubmitSignUp);
            this.pnlSignUp.Controls.Add(this.lstboxCoursesSignUp);
            this.pnlSignUp.Controls.Add(this.txtbxPassword);
            this.pnlSignUp.Controls.Add(this.txtbxUsername);
            this.pnlSignUp.Controls.Add(this.lblYearOfStudy);
            this.pnlSignUp.Controls.Add(this.lblEnrolledCourse);
            this.pnlSignUp.Controls.Add(this.lblPassword);
            this.pnlSignUp.Controls.Add(this.lblUsername);
            this.pnlSignUp.Location = new System.Drawing.Point(0, 0);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(260, 478);
            this.pnlSignUp.TabIndex = 3;
            // 
            // btnBackToPnlMain
            // 
            this.btnBackToPnlMain.Location = new System.Drawing.Point(12, 12);
            this.btnBackToPnlMain.Name = "btnBackToPnlMain";
            this.btnBackToPnlMain.Size = new System.Drawing.Size(30, 31);
            this.btnBackToPnlMain.TabIndex = 9;
            this.btnBackToPnlMain.Text = "<";
            this.btnBackToPnlMain.UseVisualStyleBackColor = true;
            this.btnBackToPnlMain.Click += new System.EventHandler(this.btnBackToPnlMain_Click);
            // 
            // cmbBoxYearOfStudy
            // 
            this.cmbBoxYearOfStudy.FormattingEnabled = true;
            this.cmbBoxYearOfStudy.Location = new System.Drawing.Point(112, 116);
            this.cmbBoxYearOfStudy.Name = "cmbBoxYearOfStudy";
            this.cmbBoxYearOfStudy.Size = new System.Drawing.Size(42, 21);
            this.cmbBoxYearOfStudy.TabIndex = 8;
            // 
            // btnSubmitSignUp
            // 
            this.btnSubmitSignUp.Location = new System.Drawing.Point(65, 407);
            this.btnSubmitSignUp.Name = "btnSubmitSignUp";
            this.btnSubmitSignUp.Size = new System.Drawing.Size(134, 38);
            this.btnSubmitSignUp.TabIndex = 7;
            this.btnSubmitSignUp.Text = "Sign Up";
            this.btnSubmitSignUp.UseVisualStyleBackColor = true;
            this.btnSubmitSignUp.Click += new System.EventHandler(this.btnSubmitSignUp_Click);
            // 
            // lstboxCoursesSignUp
            // 
            this.lstboxCoursesSignUp.FormattingEnabled = true;
            this.lstboxCoursesSignUp.Location = new System.Drawing.Point(18, 212);
            this.lstboxCoursesSignUp.Name = "lstboxCoursesSignUp";
            this.lstboxCoursesSignUp.Size = new System.Drawing.Size(234, 173);
            this.lstboxCoursesSignUp.TabIndex = 6;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(112, 79);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(120, 20);
            this.txtbxPassword.TabIndex = 5;
            this.txtbxPassword.UseSystemPasswordChar = true;
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Location = new System.Drawing.Point(112, 47);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(120, 20);
            this.txtbxUsername.TabIndex = 4;
            // 
            // lblYearOfStudy
            // 
            this.lblYearOfStudy.AutoSize = true;
            this.lblYearOfStudy.Location = new System.Drawing.Point(25, 116);
            this.lblYearOfStudy.Name = "lblYearOfStudy";
            this.lblYearOfStudy.Size = new System.Drawing.Size(71, 13);
            this.lblYearOfStudy.TabIndex = 3;
            this.lblYearOfStudy.Text = "Year of Study";
            // 
            // lblEnrolledCourse
            // 
            this.lblEnrolledCourse.AutoSize = true;
            this.lblEnrolledCourse.Location = new System.Drawing.Point(15, 180);
            this.lblEnrolledCourse.Name = "lblEnrolledCourse";
            this.lblEnrolledCourse.Size = new System.Drawing.Size(81, 13);
            this.lblEnrolledCourse.TabIndex = 2;
            this.lblEnrolledCourse.Text = "Enrolled Course";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(43, 79);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(41, 47);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // pnlSignIn
            // 
            this.pnlSignIn.Controls.Add(this.btnLeaveSignUp);
            this.pnlSignIn.Controls.Add(this.btnSendSignIn);
            this.pnlSignIn.Controls.Add(this.txtboxPassword2);
            this.pnlSignIn.Controls.Add(this.txtboxUsername2);
            this.pnlSignIn.Controls.Add(this.lblPassword2);
            this.pnlSignIn.Controls.Add(this.lblUsername2);
            this.pnlSignIn.Location = new System.Drawing.Point(0, 0);
            this.pnlSignIn.Name = "pnlSignIn";
            this.pnlSignIn.Size = new System.Drawing.Size(265, 480);
            this.pnlSignIn.TabIndex = 3;
            // 
            // btnLeaveSignUp
            // 
            this.btnLeaveSignUp.Location = new System.Drawing.Point(12, 12);
            this.btnLeaveSignUp.Name = "btnLeaveSignUp";
            this.btnLeaveSignUp.Size = new System.Drawing.Size(30, 31);
            this.btnLeaveSignUp.TabIndex = 5;
            this.btnLeaveSignUp.Text = "<";
            this.btnLeaveSignUp.UseVisualStyleBackColor = true;
            this.btnLeaveSignUp.Click += new System.EventHandler(this.btnLeaveSignUp_Click);
            // 
            // btnSendSignIn
            // 
            this.btnSendSignIn.Location = new System.Drawing.Point(46, 363);
            this.btnSendSignIn.Name = "btnSendSignIn";
            this.btnSendSignIn.Size = new System.Drawing.Size(162, 38);
            this.btnSendSignIn.TabIndex = 4;
            this.btnSendSignIn.Text = "Sign In";
            this.btnSendSignIn.UseVisualStyleBackColor = true;
            this.btnSendSignIn.Click += new System.EventHandler(this.btnSendSignIn_Click);
            // 
            // txtboxPassword2
            // 
            this.txtboxPassword2.Location = new System.Drawing.Point(102, 109);
            this.txtboxPassword2.Name = "txtboxPassword2";
            this.txtboxPassword2.Size = new System.Drawing.Size(146, 20);
            this.txtboxPassword2.TabIndex = 3;
            this.txtboxPassword2.UseSystemPasswordChar = true;
            // 
            // txtboxUsername2
            // 
            this.txtboxUsername2.Location = new System.Drawing.Point(102, 70);
            this.txtboxUsername2.Name = "txtboxUsername2";
            this.txtboxUsername2.Size = new System.Drawing.Size(146, 20);
            this.txtboxUsername2.TabIndex = 2;
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Location = new System.Drawing.Point(25, 109);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(53, 13);
            this.lblPassword2.TabIndex = 1;
            this.lblPassword2.Text = "Password";
            // 
            // lblUsername2
            // 
            this.lblUsername2.AutoSize = true;
            this.lblUsername2.Location = new System.Drawing.Point(25, 73);
            this.lblUsername2.Name = "lblUsername2";
            this.lblUsername2.Size = new System.Drawing.Size(55, 13);
            this.lblUsername2.TabIndex = 0;
            this.lblUsername2.Text = "Username";
            // 
            // pnlModules
            // 
            this.pnlModules.Controls.Add(this.btnLeavePnlModules);
            this.pnlModules.Controls.Add(this.lblSortBy);
            this.pnlModules.Controls.Add(this.cmbBoxModulesSort);
            this.pnlModules.Controls.Add(this.flowLayoutModules);
            this.pnlModules.Location = new System.Drawing.Point(0, 0);
            this.pnlModules.Name = "pnlModules";
            this.pnlModules.Size = new System.Drawing.Size(260, 478);
            this.pnlModules.TabIndex = 5;
            // 
            // btnLeavePnlModules
            // 
            this.btnLeavePnlModules.Location = new System.Drawing.Point(12, 12);
            this.btnLeavePnlModules.Name = "btnLeavePnlModules";
            this.btnLeavePnlModules.Size = new System.Drawing.Size(30, 31);
            this.btnLeavePnlModules.TabIndex = 3;
            this.btnLeavePnlModules.Text = "<";
            this.btnLeavePnlModules.UseVisualStyleBackColor = true;
            this.btnLeavePnlModules.Click += new System.EventHandler(this.btnLeavePnlModules_Click);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(99, 23);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(40, 13);
            this.lblSortBy.TabIndex = 2;
            this.lblSortBy.Text = "Sort by";
            // 
            // cmbBoxModulesSort
            // 
            this.cmbBoxModulesSort.FormattingEnabled = true;
            this.cmbBoxModulesSort.Items.AddRange(new object[] {
            "Name",
            "Pass Rate",
            "Rating"});
            this.cmbBoxModulesSort.Location = new System.Drawing.Point(144, 20);
            this.cmbBoxModulesSort.Name = "cmbBoxModulesSort";
            this.cmbBoxModulesSort.Size = new System.Drawing.Size(103, 21);
            this.cmbBoxModulesSort.TabIndex = 1;
            this.cmbBoxModulesSort.Text = "Select Sort";
            this.cmbBoxModulesSort.SelectedIndexChanged += new System.EventHandler(this.cmbBoxModulesSort_SelectedIndexChanged);
            // 
            // flowLayoutModules
            // 
            this.flowLayoutModules.Location = new System.Drawing.Point(12, 73);
            this.flowLayoutModules.Name = "flowLayoutModules";
            this.flowLayoutModules.Size = new System.Drawing.Size(236, 407);
            this.flowLayoutModules.TabIndex = 0;
            // 
            // pnlModuleInfo
            // 
            this.pnlModuleInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlModuleInfo.Name = "pnlModuleInfo";
            this.pnlModuleInfo.Size = new System.Drawing.Size(262, 476);
            this.pnlModuleInfo.TabIndex = 3;
            // 
            // pnlCourseSelect
            // 
            this.pnlCourseSelect.Controls.Add(this.btnExitCourseSelect);
            this.pnlCourseSelect.Controls.Add(this.lblSelectCourse);
            this.pnlCourseSelect.Controls.Add(this.lstboxCourses);
            this.pnlCourseSelect.Location = new System.Drawing.Point(0, 0);
            this.pnlCourseSelect.Name = "pnlCourseSelect";
            this.pnlCourseSelect.Size = new System.Drawing.Size(263, 480);
            this.pnlCourseSelect.TabIndex = 3;
            // 
            // lstboxCourses
            // 
            this.lstboxCourses.FormattingEnabled = true;
            this.lstboxCourses.Location = new System.Drawing.Point(19, 77);
            this.lstboxCourses.Name = "lstboxCourses";
            this.lstboxCourses.Size = new System.Drawing.Size(213, 368);
            this.lstboxCourses.TabIndex = 0;
            this.lstboxCourses.SelectedIndexChanged += new System.EventHandler(this.lstboxCourses_SelectedIndexChanged);
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.Location = new System.Drawing.Point(61, 24);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(122, 20);
            this.lblSelectCourse.TabIndex = 3;
            this.lblSelectCourse.Text = "Select Course";
            // 
            // btnExitCourseSelect
            // 
            this.btnExitCourseSelect.Location = new System.Drawing.Point(12, 20);
            this.btnExitCourseSelect.Name = "btnExitCourseSelect";
            this.btnExitCourseSelect.Size = new System.Drawing.Size(30, 25);
            this.btnExitCourseSelect.TabIndex = 4;
            this.btnExitCourseSelect.Text = "<";
            this.btnExitCourseSelect.UseVisualStyleBackColor = true;
            this.btnExitCourseSelect.Click += new System.EventHandler(this.btnExitCourseSelect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pnlStudentPortal
            // 
            this.pnlStudentPortal.Controls.Add(this.btnSingOut);
            this.pnlStudentPortal.Controls.Add(this.btnReviews);
            this.pnlStudentPortal.Controls.Add(this.lblWelcomeUser);
            this.pnlStudentPortal.Controls.Add(this.btnModules);
            this.pnlStudentPortal.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentPortal.Name = "pnlStudentPortal";
            this.pnlStudentPortal.Size = new System.Drawing.Size(263, 480);
            this.pnlStudentPortal.TabIndex = 4;
            // 
            // btnModules
            // 
            this.btnModules.Image = ((System.Drawing.Image)(resources.GetObject("btnModules.Image")));
            this.btnModules.Location = new System.Drawing.Point(60, 81);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(150, 155);
            this.btnModules.TabIndex = 0;
            this.btnModules.Text = "Courses";
            this.btnModules.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModules.UseVisualStyleBackColor = true;
            this.btnModules.Click += new System.EventHandler(this.btnModules_Click);
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUser.Location = new System.Drawing.Point(60, 36);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(150, 20);
            this.lblWelcomeUser.TabIndex = 1;
            this.lblWelcomeUser.Text = "Welcome User98!";
            // 
            // btnReviews
            // 
            this.btnReviews.Image = ((System.Drawing.Image)(resources.GetObject("btnReviews.Image")));
            this.btnReviews.Location = new System.Drawing.Point(60, 268);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(148, 152);
            this.btnReviews.TabIndex = 2;
            this.btnReviews.Text = "Reviews";
            this.btnReviews.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReviews.UseVisualStyleBackColor = true;
            // 
            // btnSingOut
            // 
            this.btnSingOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingOut.Location = new System.Drawing.Point(184, 5);
            this.btnSingOut.Name = "btnSingOut";
            this.btnSingOut.Size = new System.Drawing.Size(68, 23);
            this.btnSingOut.TabIndex = 3;
            this.btnSingOut.Text = "Sign Out";
            this.btnSingOut.UseVisualStyleBackColor = true;
            this.btnSingOut.Click += new System.EventHandler(this.btnSingOut_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 481);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSignIn);
            this.Controls.Add(this.pnlSignUp);
            this.Controls.Add(this.pnlModules);
            this.Controls.Add(this.pnlModuleInfo);
            this.Controls.Add(this.pnlCourseSelect);
            this.Controls.Add(this.pnlStudentPortal);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUp.PerformLayout();
            this.pnlSignIn.ResumeLayout(false);
            this.pnlSignIn.PerformLayout();
            this.pnlModules.ResumeLayout(false);
            this.pnlModules.PerformLayout();
            this.pnlCourseSelect.ResumeLayout(false);
            this.pnlCourseSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlStudentPortal.ResumeLayout(false);
            this.pnlStudentPortal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuestSelect;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Panel pnlSignUp;
        private System.Windows.Forms.Button btnSubmitSignUp;
        private System.Windows.Forms.ListBox lstboxCoursesSignUp;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.Label lblYearOfStudy;
        private System.Windows.Forms.Label lblEnrolledCourse;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnBackToPnlMain;
        private System.Windows.Forms.ComboBox cmbBoxYearOfStudy;
        private System.Windows.Forms.Panel pnlSignIn;
        private System.Windows.Forms.Button btnSendSignIn;
        private System.Windows.Forms.TextBox txtboxPassword2;
        private System.Windows.Forms.TextBox txtboxUsername2;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.Label lblUsername2;
        private System.Windows.Forms.Panel pnlModules;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutModules;
        private System.Windows.Forms.Button btnLeaveSignUp;
        private System.Windows.Forms.Button btnLeavePnlModules;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.ComboBox cmbBoxModulesSort;
        private System.Windows.Forms.Panel pnlModuleInfo;
        private ModuleInfoPage moduleInfoPage1;
        private System.Windows.Forms.Panel pnlCourseSelect;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.ListBox lstboxCourses;
        private System.Windows.Forms.Button btnExitCourseSelect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlStudentPortal;
        private System.Windows.Forms.Button btnSingOut;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.Button btnModules;
    }
}

