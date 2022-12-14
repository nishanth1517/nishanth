namespace SaiYogaTraining.View
{
    partial class TeacherEditForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.teachertxt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.qualificationList = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.teacherIDList = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(70, 24);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.teacherIDList);
            this.panel2.Controls.Add(this.qualificationList);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.teachertxt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.nametxt, 0);
            this.panel2.Controls.SetChildIndex(this.label3, 0);
            this.panel2.Controls.SetChildIndex(this.label4, 0);
            this.panel2.Controls.SetChildIndex(this.label5, 0);
            this.panel2.Controls.SetChildIndex(this.contacttxt, 0);
            this.panel2.Controls.SetChildIndex(this.editbtn, 0);
            this.panel2.Controls.SetChildIndex(this.delbtn, 0);
            this.panel2.Controls.SetChildIndex(this.addresstxt, 0);
            this.panel2.Controls.SetChildIndex(this.label6, 0);
            this.panel2.Controls.SetChildIndex(this.teachertxt, 0);
            this.panel2.Controls.SetChildIndex(this.label7, 0);
            this.panel2.Controls.SetChildIndex(this.qualificationList, 0);
            this.panel2.Controls.SetChildIndex(this.teacherIDList, 0);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(553, 376);
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(142, 376);
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // contacttxt
            // 
            this.contacttxt.Location = new System.Drawing.Point(215, 169);
            this.contacttxt.Size = new System.Drawing.Size(426, 27);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(138, 172);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(138, 225);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(328, 9);
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.Text = "Teacher Details";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(215, 116);
            this.nametxt.Size = new System.Drawing.Size(426, 27);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(138, 119);
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(215, 222);
            this.addresstxt.Size = new System.Drawing.Size(426, 67);
            // 
            // banner
            // 
            this.banner.Location = new System.Drawing.Point(174, 34);
            this.banner.Size = new System.Drawing.Size(496, 72);
            this.banner.Text = "Manage Teacher";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Search Teacher";
            // 
            // teachertxt
            // 
            this.teachertxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.teachertxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.teachertxt.FormattingEnabled = true;
            this.teachertxt.Location = new System.Drawing.Point(243, 62);
            this.teachertxt.Name = "teachertxt";
            this.teachertxt.Size = new System.Drawing.Size(256, 28);
            this.teachertxt.TabIndex = 12;
            this.teachertxt.SelectedIndexChanged += new System.EventHandler(this.teachertxt_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(138, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Qualification";
            // 
            // qualificationList
            // 
            this.qualificationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualificationList.FormattingEnabled = true;
            this.qualificationList.Items.AddRange(new object[] {
            "A. Yoga, Journalism & Mass Communication",
            "Sc. Yoga Management",
            "Sc. Yoga & Consciousness",
            "Sc. Yoga Education",
            "Sc. Yoga",
            "PGD in Yoga Therapy for Doctors",
            "PGD in Yoga Therapy",
            "A. Yoga & Journalism",
            "Sc. Yoga & Management",
            "Sc. Yoga & Consciousness",
            "Sc. Yoga Education",
            "Sc. Yoga",
            "Yoga Therapy Orientation Training For Doctors",
            "Yoga Teachers Training Course",
            "Yoga Instructor Course",
            "PhD Yoga",
            "D. Yoga & Rehabilitation",
            "Phil Counselling & Yoga Therapy"});
            this.qualificationList.Location = new System.Drawing.Point(240, 311);
            this.qualificationList.Name = "qualificationList";
            this.qualificationList.Size = new System.Drawing.Size(401, 28);
            this.qualificationList.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaiYogaTraining.Properties.Resources.user_female_alt_icon;
            this.pictureBox1.Location = new System.Drawing.Point(764, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // teacherIDList
            // 
            this.teacherIDList.Enabled = false;
            this.teacherIDList.Location = new System.Drawing.Point(529, 62);
            this.teacherIDList.Name = "teacherIDList";
            this.teacherIDList.Size = new System.Drawing.Size(112, 27);
            this.teacherIDList.TabIndex = 15;
            // 
            // TeacherEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 661);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TeacherEditForm";
            this.Text = "Sai Yoga Training - Manage Teacher";
            this.Load += new System.EventHandler(this.TeacherEditForm_Load);
            this.Controls.SetChildIndex(this.banner, 0);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox teachertxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox qualificationList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox teacherIDList;
    }
}