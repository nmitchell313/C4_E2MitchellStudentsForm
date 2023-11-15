namespace StudentsFormDemo
{
    partial class Form1
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
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txbStudentID = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbProgramming = new System.Windows.Forms.RadioButton();
            this.rbWebDesign = new System.Windows.Forms.RadioButton();
            this.rbIT = new System.Windows.Forms.RadioButton();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.cbxCIS101 = new System.Windows.Forms.CheckBox();
            this.cbxCIS102 = new System.Windows.Forms.CheckBox();
            this.cbxCIS103 = new System.Windows.Forms.CheckBox();
            this.cbxCIS104 = new System.Windows.Forms.CheckBox();
            this.txbScore1 = new System.Windows.Forms.TextBox();
            this.txbScore2 = new System.Windows.Forms.TextBox();
            this.txbScore3 = new System.Windows.Forms.TextBox();
            this.txbScore4 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(37, 44);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(97, 20);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(37, 80);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(96, 20);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(37, 113);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(95, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txbStudentID
            // 
            this.txbStudentID.Location = new System.Drawing.Point(176, 41);
            this.txbStudentID.Name = "txbStudentID";
            this.txbStudentID.Size = new System.Drawing.Size(209, 26);
            this.txbStudentID.TabIndex = 3;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(176, 74);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(209, 26);
            this.txbFirstName.TabIndex = 4;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(176, 107);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(209, 26);
            this.txbLastName.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIT);
            this.groupBox1.Controls.Add(this.rbWebDesign);
            this.groupBox1.Controls.Add(this.rbProgramming);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Major";
            // 
            // rbProgramming
            // 
            this.rbProgramming.AutoSize = true;
            this.rbProgramming.Location = new System.Drawing.Point(6, 39);
            this.rbProgramming.Name = "rbProgramming";
            this.rbProgramming.Size = new System.Drawing.Size(164, 29);
            this.rbProgramming.TabIndex = 0;
            this.rbProgramming.TabStop = true;
            this.rbProgramming.Text = "Programming";
            this.rbProgramming.UseVisualStyleBackColor = true;
            // 
            // rbWebDesign
            // 
            this.rbWebDesign.AutoSize = true;
            this.rbWebDesign.Location = new System.Drawing.Point(7, 75);
            this.rbWebDesign.Name = "rbWebDesign";
            this.rbWebDesign.Size = new System.Drawing.Size(155, 29);
            this.rbWebDesign.TabIndex = 1;
            this.rbWebDesign.TabStop = true;
            this.rbWebDesign.Text = "Web Design";
            this.rbWebDesign.UseVisualStyleBackColor = true;
            // 
            // rbIT
            // 
            this.rbIT.AutoSize = true;
            this.rbIT.Location = new System.Drawing.Point(6, 111);
            this.rbIT.Name = "rbIT";
            this.rbIT.Size = new System.Drawing.Size(57, 29);
            this.rbIT.TabIndex = 2;
            this.rbIT.TabStop = true;
            this.rbIT.Text = "IT";
            this.rbIT.UseVisualStyleBackColor = true;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourses.Location = new System.Drawing.Point(492, 44);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(93, 25);
            this.lblCourses.TabIndex = 7;
            this.lblCourses.Text = "Courses";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.Location = new System.Drawing.Point(668, 44);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(80, 25);
            this.lblScores.TabIndex = 8;
            this.lblScores.Text = "Scores";
            // 
            // cbxCIS101
            // 
            this.cbxCIS101.AutoSize = true;
            this.cbxCIS101.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCIS101.Location = new System.Drawing.Point(465, 74);
            this.cbxCIS101.Name = "cbxCIS101";
            this.cbxCIS101.Size = new System.Drawing.Size(100, 24);
            this.cbxCIS101.TabIndex = 9;
            this.cbxCIS101.Text = "CIS 101";
            this.cbxCIS101.UseVisualStyleBackColor = true;
            // 
            // cbxCIS102
            // 
            this.cbxCIS102.AutoSize = true;
            this.cbxCIS102.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCIS102.Location = new System.Drawing.Point(465, 109);
            this.cbxCIS102.Name = "cbxCIS102";
            this.cbxCIS102.Size = new System.Drawing.Size(100, 24);
            this.cbxCIS102.TabIndex = 10;
            this.cbxCIS102.Text = "CIS 102";
            this.cbxCIS102.UseVisualStyleBackColor = true;
            // 
            // cbxCIS103
            // 
            this.cbxCIS103.AutoSize = true;
            this.cbxCIS103.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCIS103.Location = new System.Drawing.Point(465, 141);
            this.cbxCIS103.Name = "cbxCIS103";
            this.cbxCIS103.Size = new System.Drawing.Size(100, 24);
            this.cbxCIS103.TabIndex = 11;
            this.cbxCIS103.Text = "CIS 103";
            this.cbxCIS103.UseVisualStyleBackColor = true;
            // 
            // cbxCIS104
            // 
            this.cbxCIS104.AutoSize = true;
            this.cbxCIS104.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCIS104.Location = new System.Drawing.Point(465, 173);
            this.cbxCIS104.Name = "cbxCIS104";
            this.cbxCIS104.Size = new System.Drawing.Size(100, 24);
            this.cbxCIS104.TabIndex = 12;
            this.cbxCIS104.Text = "CIS 104";
            this.cbxCIS104.UseVisualStyleBackColor = true;
            // 
            // txbScore1
            // 
            this.txbScore1.Location = new System.Drawing.Point(648, 72);
            this.txbScore1.Name = "txbScore1";
            this.txbScore1.Size = new System.Drawing.Size(100, 26);
            this.txbScore1.TabIndex = 13;
            // 
            // txbScore2
            // 
            this.txbScore2.Location = new System.Drawing.Point(648, 107);
            this.txbScore2.Name = "txbScore2";
            this.txbScore2.Size = new System.Drawing.Size(100, 26);
            this.txbScore2.TabIndex = 14;
            // 
            // txbScore3
            // 
            this.txbScore3.Location = new System.Drawing.Point(648, 139);
            this.txbScore3.Name = "txbScore3";
            this.txbScore3.Size = new System.Drawing.Size(100, 26);
            this.txbScore3.TabIndex = 15;
            // 
            // txbScore4
            // 
            this.txbScore4.Location = new System.Drawing.Point(648, 171);
            this.txbScore4.Name = "txbScore4";
            this.txbScore4.Size = new System.Drawing.Size(100, 26);
            this.txbScore4.TabIndex = 16;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(41, 337);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(132, 48);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(465, 210);
            this.txbResult.Multiline = true;
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(392, 175);
            this.txbResult.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(869, 397);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txbScore4);
            this.Controls.Add(this.txbScore3);
            this.Controls.Add(this.txbScore2);
            this.Controls.Add(this.txbScore1);
            this.Controls.Add(this.cbxCIS104);
            this.Controls.Add(this.cbxCIS103);
            this.Controls.Add(this.cbxCIS102);
            this.Controls.Add(this.cbxCIS101);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.txbStudentID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStudentID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txbStudentID;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbIT;
        private System.Windows.Forms.RadioButton rbWebDesign;
        private System.Windows.Forms.RadioButton rbProgramming;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.CheckBox cbxCIS101;
        private System.Windows.Forms.CheckBox cbxCIS102;
        private System.Windows.Forms.CheckBox cbxCIS103;
        private System.Windows.Forms.CheckBox cbxCIS104;
        private System.Windows.Forms.TextBox txbScore1;
        private System.Windows.Forms.TextBox txbScore2;
        private System.Windows.Forms.TextBox txbScore3;
        private System.Windows.Forms.TextBox txbScore4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txbResult;
    }
}

