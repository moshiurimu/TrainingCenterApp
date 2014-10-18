namespace TrainingCenterApp.UI
{
    partial class EnrollmentEntryUI
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
            this.emrolledCourseGroupBox = new System.Windows.Forms.GroupBox();
            this.emrolledCourseDataGridView = new System.Windows.Forms.DataGridView();
            this.courseEmrollmentGroupBox = new System.Windows.Forms.GroupBox();
            this.enrollmenDtateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.regnoTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emrollButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.emrolledCourseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emrolledCourseDataGridView)).BeginInit();
            this.courseEmrollmentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // emrolledCourseGroupBox
            // 
            this.emrolledCourseGroupBox.Controls.Add(this.emrolledCourseDataGridView);
            this.emrolledCourseGroupBox.Location = new System.Drawing.Point(12, 164);
            this.emrolledCourseGroupBox.Name = "emrolledCourseGroupBox";
            this.emrolledCourseGroupBox.Size = new System.Drawing.Size(518, 189);
            this.emrolledCourseGroupBox.TabIndex = 1;
            this.emrolledCourseGroupBox.TabStop = false;
            this.emrolledCourseGroupBox.Text = "Emrolled Course";
            // 
            // emrolledCourseDataGridView
            // 
            this.emrolledCourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emrolledCourseDataGridView.Location = new System.Drawing.Point(16, 19);
            this.emrolledCourseDataGridView.Name = "emrolledCourseDataGridView";
            this.emrolledCourseDataGridView.Size = new System.Drawing.Size(485, 160);
            this.emrolledCourseDataGridView.TabIndex = 0;
            // 
            // courseEmrollmentGroupBox
            // 
            this.courseEmrollmentGroupBox.Controls.Add(this.enrollmenDtateTimePicker);
            this.courseEmrollmentGroupBox.Controls.Add(this.courseComboBox);
            this.courseEmrollmentGroupBox.Controls.Add(this.emailTextBox);
            this.courseEmrollmentGroupBox.Controls.Add(this.nameTextBox);
            this.courseEmrollmentGroupBox.Controls.Add(this.regnoTextBox);
            this.courseEmrollmentGroupBox.Controls.Add(this.label);
            this.courseEmrollmentGroupBox.Controls.Add(this.label4);
            this.courseEmrollmentGroupBox.Controls.Add(this.label3);
            this.courseEmrollmentGroupBox.Controls.Add(this.label2);
            this.courseEmrollmentGroupBox.Controls.Add(this.label1);
            this.courseEmrollmentGroupBox.Controls.Add(this.emrollButton);
            this.courseEmrollmentGroupBox.Controls.Add(this.findButton);
            this.courseEmrollmentGroupBox.Location = new System.Drawing.Point(12, 3);
            this.courseEmrollmentGroupBox.Name = "courseEmrollmentGroupBox";
            this.courseEmrollmentGroupBox.Size = new System.Drawing.Size(518, 155);
            this.courseEmrollmentGroupBox.TabIndex = 0;
            this.courseEmrollmentGroupBox.TabStop = false;
            this.courseEmrollmentGroupBox.Text = "Course Emrollment";
            // 
            // enrollmenDtateTimePicker
            // 
            this.enrollmenDtateTimePicker.Location = new System.Drawing.Point(159, 123);
            this.enrollmenDtateTimePicker.Name = "enrollmenDtateTimePicker";
            this.enrollmenDtateTimePicker.Size = new System.Drawing.Size(228, 20);
            this.enrollmenDtateTimePicker.TabIndex = 4;
            // 
            // courseComboBox
            // 
            this.courseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(159, 93);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(228, 21);
            this.courseComboBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(159, 67);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(228, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(159, 41);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(228, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // regnoTextBox
            // 
            this.regnoTextBox.Location = new System.Drawing.Point(159, 15);
            this.regnoTextBox.Name = "regnoTextBox";
            this.regnoTextBox.Size = new System.Drawing.Size(133, 20);
            this.regnoTextBox.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(55, 123);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(84, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Emrollment Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reg No";
            // 
            // emrollButton
            // 
            this.emrollButton.Location = new System.Drawing.Point(410, 121);
            this.emrollButton.Name = "emrollButton";
            this.emrollButton.Size = new System.Drawing.Size(75, 23);
            this.emrollButton.TabIndex = 5;
            this.emrollButton.Text = "Enroll";
            this.emrollButton.UseVisualStyleBackColor = true;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(312, 12);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            // 
            // EnrollmentEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 356);
            this.Controls.Add(this.emrolledCourseGroupBox);
            this.Controls.Add(this.courseEmrollmentGroupBox);
            this.Name = "EnrollmentEntryUI";
            this.Text = "EnrollmentEntryUI";
            this.emrolledCourseGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emrolledCourseDataGridView)).EndInit();
            this.courseEmrollmentGroupBox.ResumeLayout(false);
            this.courseEmrollmentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox emrolledCourseGroupBox;
        private System.Windows.Forms.DataGridView emrolledCourseDataGridView;
        private System.Windows.Forms.GroupBox courseEmrollmentGroupBox;
        private System.Windows.Forms.DateTimePicker enrollmenDtateTimePicker;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox regnoTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button emrollButton;
        private System.Windows.Forms.Button findButton;
    }
}