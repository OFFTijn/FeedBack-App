using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackApplicatieFutureFlow
{
    public partial class StudentDashboard : Form
    {
        public Account Student { get; set; }

        public StudentDashboard(Account student)
        {
            InitializeComponent();
            Student = student;
        }

        private void LoginScreenCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentGoalButton_Click(object sender, EventArgs e)
        {
            StudentCombinationPanel.Controls.Clear();
            GoalOverviewForm goalOverview = new GoalOverviewForm(Student) { TopLevel = false, TopMost = true };
            goalOverview.FormBorderStyle = FormBorderStyle.None;
            StudentCombinationPanel.Controls.Add(goalOverview);
            goalOverview.Show();
        }

        private void TimeRegistrationButton_Click(object sender, EventArgs e)
        {
            StudentCombinationPanel.Controls.Clear();
            FeedbackForm timeRegistration = new FeedbackForm(Student) { TopLevel = false, TopMost = true };
            timeRegistration.FormBorderStyle = FormBorderStyle.None;
            StudentCombinationPanel.Controls.Add(timeRegistration);
            timeRegistration.Show();
        }

        private void ReflectionButton_Click(object sender, EventArgs e)
        {
            StudentCombinationPanel.Controls.Clear();
            ReflectionForm reflectionWindow = new ReflectionForm() { TopLevel = false, TopMost = true };
            reflectionWindow.FormBorderStyle = FormBorderStyle.None;
            StudentCombinationPanel.Controls.Add(reflectionWindow);
            reflectionWindow.Show();
        }

        private void StudentCombinationPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
