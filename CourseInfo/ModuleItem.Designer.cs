namespace CourseInfo
{
    partial class ModuleItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(65, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label1";
            this.lblTitle.Click += new System.EventHandler(this.panel1_Click);
            this.lblTitle.MouseEnter += new System.EventHandler(this.ModuleItem_MouseEnter);
            this.lblTitle.MouseLeave += new System.EventHandler(this.ModuleItem_MouseLeave);
            // 
            // lblBody
            // 
            this.lblBody.AutoEllipsis = true;
            this.lblBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBody.Location = new System.Drawing.Point(66, 17);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(160, 47);
            this.lblBody.TabIndex = 2;
            this.lblBody.Text = "asguasu sagoihasg oiashgsaoi asgoih ";
            this.lblBody.Click += new System.EventHandler(this.panel1_Click);
            this.lblBody.MouseEnter += new System.EventHandler(this.ModuleItem_MouseEnter);
            this.lblBody.MouseLeave += new System.EventHandler(this.ModuleItem_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 74);
            this.panel1.TabIndex = 3;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.ModuleItem_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.ModuleItem_MouseLeave);
            // 
            // ModuleItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ModuleItem";
            this.Size = new System.Drawing.Size(233, 74);
            this.Click += new System.EventHandler(this.panel1_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseClick);
            this.MouseEnter += new System.EventHandler(this.ModuleItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ModuleItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Panel panel1;
    }
}
