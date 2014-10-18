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
    public partial class ResultSheetUI : Form
    {
        EnrollmentBLL anEnrollmentBll = new EnrollmentBLL();
        public ResultSheetUI()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Student aStudent = anEnrollmentBll.Find(regNoTextBox.Text);
            nameTextBox.Text = aStudent.Name;
            emailTextBox.Text = aStudent.Email;
        }
    }
}
