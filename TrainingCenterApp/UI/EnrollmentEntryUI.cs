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
    public partial class EnrollmentEntryUI : Form
    {
        private EnrollmentBLL anEnrollmentBll = new EnrollmentBLL();
        private Enrollment anEnrollment;
        private Student aStudent;

        public EnrollmentEntryUI()
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

        private void enrollButton_Click(object sender, EventArgs e)
        {
            anEnrollment = new Enrollment();
            anEnrollment.DateTime = enrollmentDtateTimePicker.Value;
            anEnrollment.AStudent = aStudent;
            anEnrollment.ACourse = (Course) courseComboBox.SelectedItem;
            string msg=anEnrollmentBll.Enroll(anEnrollment);
            MessageBox.Show(msg);
            enrolledCourseListView.Items.Clear();
            enrolledCourseListView.Items.Add(anEnrollmentBll.lvi);
            

        }
    }
}
