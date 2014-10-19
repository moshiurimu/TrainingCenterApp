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
        ResultBLL aResultBll = new ResultBLL();
        private ListViewItem lvi;
        public ResultSheetUI()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Student aStudent = anEnrollmentBll.Find(regNoTextBox.Text);
            nameTextBox.Text = aStudent.Name;
            emailTextBox.Text = aStudent.Email;
            List<Result> results = aResultBll.GetAllResult(aStudent);
            resultListView.Items.Clear();
            int scoreCount = 0;
            double total = 0, averageScore = 0;
            foreach (Result aResult in results)
            {
                string gradeLetter = MakeGradeLetter(aResult.ScorePercentage);
                total += aResult.ScorePercentage;
                lvi = new ListViewItem(aResult.ACourse.Name);
                lvi.SubItems.Add(aResult.ACourse.Title);
                lvi.SubItems.Add(aResult.ScorePercentage.ToString());
                lvi.SubItems.Add(gradeLetter);
                resultListView.Items.Add(lvi);
                scoreCount++;
            }
            averageScore = total / scoreCount;
            string averageGrade = MakeGradeLetter(averageScore);
            averageScoreTextBox.Text = averageScore.ToString();
            gradeLetterTextBox.Text = averageGrade;

        }
        private string MakeGradeLetter(double score)
        {
            return aResultBll.MakeGradeLetter(score);
        }
    }
}
