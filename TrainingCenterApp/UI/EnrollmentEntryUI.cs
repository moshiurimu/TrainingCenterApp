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
        public EnrollmentEntryUI()
        {
            InitializeComponent();
            GetAllCourseInComboBox();
            courseComboBox.DisplayMember = "Name";
            courseComboBox.ValueMember = "Id";
        }
        private void findButton_Click(object sender, EventArgs e)
        {

        }
        private void GetAllCourseInComboBox()
        {
            List<Course> courses = anEnrollmentBll.GetAllCourse();
            foreach (Course aCourse in courses)
            {
                courseComboBox.Items.Add(aCourse);
            }
        }
    }
}
