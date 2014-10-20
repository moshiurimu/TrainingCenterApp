using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingCenterApp.BLL;
using TrainingCenterApp.DAL.DAO;

namespace TrainingCenterApp.UI
{
    public partial class ResultEntryUI : Form
    {
        private ResultBLL aResultBll = new ResultBLL();
        private EnrollmentBLL anEnrollmentBll = new EnrollmentBLL();
        private Result aResult;
        private Student aStudent;
        public ResultEntryUI()
        {
            InitializeComponent();
            GetAllCourseInComboBox();
        }
        private void findButton_Click(object sender, EventArgs e)
        {
            aStudent = anEnrollmentBll.Find(regNoTextBox.Text);
            nameTextBox.Text = aStudent.Name;
            emailTextBox.Text = aStudent.Email;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            aResult = new Result();
            aResult.StudentId = aStudent.Id;
            aResult.AStudent = aStudent;
            aResult.ACourse = (Course)courseComboBox.SelectedItem;
            aResult.CourseId = aResult.ACourse.Id;
            aResult.ScorePercentage = Convert.ToDouble(scoreTextBox.Text);
            aResult.DateTime = resultPublishDateTimePicker.Value;
            string msg = aResultBll.Add(aResult);
            MessageBox.Show(msg);
        }
        private void GetAllCourseInComboBox()
        {
            List<Course> courses = anEnrollmentBll.GetAllCourse();
            foreach (Course aCourse in courses)
            {
                courseComboBox.Items.Add(aCourse);
            }
            courseComboBox.DisplayMember = "Name";
            courseComboBox.ValueMember = "Id";
        }
        private void viewResultSheetButton_Click(object sender, EventArgs e)
        {
            ResultSheetUI aResultSheetUi = new ResultSheetUI();
            aResultSheetUi.ShowDialog();
        }
    }
}
