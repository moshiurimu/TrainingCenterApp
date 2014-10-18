namespace TrainingCenterApp.UI
{
    partial class ResultSheetUI
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
            this.StudentInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.AvarageScoreTextBox = new System.Windows.Forms.TextBox();
            this.gradeLetterTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.regnoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.StudentInformationGroupBox.SuspendLayout();
            this.resultGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentInformationGroupBox
            // 
            this.StudentInformationGroupBox.Controls.Add(this.AvarageScoreTextBox);
            this.StudentInformationGroupBox.Controls.Add(this.gradeLetterTextBox);
            this.StudentInformationGroupBox.Controls.Add(this.label);
            this.StudentInformationGroupBox.Controls.Add(this.label4);
            this.StudentInformationGroupBox.Controls.Add(this.emailTextBox);
            this.StudentInformationGroupBox.Controls.Add(this.nameTextBox);
            this.StudentInformationGroupBox.Controls.Add(this.regnoTextBox);
            this.StudentInformationGroupBox.Controls.Add(this.label3);
            this.StudentInformationGroupBox.Controls.Add(this.label2);
            this.StudentInformationGroupBox.Controls.Add(this.label1);
            this.StudentInformationGroupBox.Controls.Add(this.findButton);
            this.StudentInformationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.StudentInformationGroupBox.Name = "StudentInformationGroupBox";
            this.StudentInformationGroupBox.Size = new System.Drawing.Size(510, 106);
            this.StudentInformationGroupBox.TabIndex = 0;
            this.StudentInformationGroupBox.TabStop = false;
            this.StudentInformationGroupBox.Text = "Student Information";
            // 
            // AvarageScoreTextBox
            // 
            this.AvarageScoreTextBox.Location = new System.Drawing.Point(374, 25);
            this.AvarageScoreTextBox.Name = "AvarageScoreTextBox";
            this.AvarageScoreTextBox.Size = new System.Drawing.Size(119, 20);
            this.AvarageScoreTextBox.TabIndex = 4;
            // 
            // gradeLetterTextBox
            // 
            this.gradeLetterTextBox.Location = new System.Drawing.Point(374, 52);
            this.gradeLetterTextBox.Name = "gradeLetterTextBox";
            this.gradeLetterTextBox.Size = new System.Drawing.Size(119, 20);
            this.gradeLetterTextBox.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(302, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 13);
            this.label.TabIndex = 12;
            this.label.Text = "Grade Letter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Avarage Score(%)";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(72, 79);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(211, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(72, 51);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(211, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // regnoTextBox
            // 
            this.regnoTextBox.Location = new System.Drawing.Point(72, 25);
            this.regnoTextBox.Name = "regnoTextBox";
            this.regnoTextBox.Size = new System.Drawing.Size(89, 20);
            this.regnoTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reg No";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(179, 22);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.dataGridView);
            this.resultGroupBox.Location = new System.Drawing.Point(12, 124);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(510, 164);
            this.resultGroupBox.TabIndex = 1;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Result";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(11, 22);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(487, 130);
            this.dataGridView.TabIndex = 0;
            // 
            // ResultSheetUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 300);
            this.Controls.Add(this.StudentInformationGroupBox);
            this.Controls.Add(this.resultGroupBox);
            this.Name = "ResultSheetUI";
            this.Text = "ResultSheetUI";
            this.StudentInformationGroupBox.ResumeLayout(false);
            this.StudentInformationGroupBox.PerformLayout();
            this.resultGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StudentInformationGroupBox;
        private System.Windows.Forms.TextBox AvarageScoreTextBox;
        private System.Windows.Forms.TextBox gradeLetterTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox regnoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}