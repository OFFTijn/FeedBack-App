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
    public partial class CreateFeedbackForm : Form
    {
        DAL dal;
        public Account Student { get; set; }
        public DataGridView FeedbackGoalDatagridview { get; set; }
        bool firstSelectionChanged = false;

        public CreateFeedbackForm(Account student, DataGridView FeedbackGoalDatagridview)
        {
            InitializeComponent();
            this.FeedbackGoalDatagridview = FeedbackGoalDatagridview;
            dal = new DAL();
            Student = student;

            dal.FillGoalsFromDatabase(Student);

            FeedbackGoalComboBox.DataSource = dal.goals;
            FeedbackGoalComboBox.DisplayMember = "Description";
            FeedbackGoalComboBox.ValueMember = "GoalID";

            Goal selectedGoal = (Goal)FeedbackGoalComboBox.SelectedItem;
            dal.FillFeedbackFromDatabase(selectedGoal);
            FeedbackcomboBox.DataSource = dal.feedbacks;
            FeedbackcomboBox.DisplayMember = "Description";
            FeedbackcomboBox.ValueMember = "FeedbackID";
        }

        private void FeedbackGoalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (!firstSelectionChanged)
            {
                firstSelectionChanged = true;
                return;
            }

            Goal g = dal.goals[FeedbackGoalComboBox.SelectedIndex];

            dal.FillFeedbackFromDatabase(g);
            /*MessageBox.Show("TEST");*/

            FeedbackGoalDatagridview.DataSource = dal.feedbacks.Select(g => new
            {
                g.Description,
                g.FeedbackType,
                g.ProfessorName
            }).ToList();
            FeedbackGoalDatagridview.AutoGenerateColumns = true;
        }

        private void CreateFeedbackButton_Click(object sender, EventArgs e)
        {
            Goal selectedGoal = (Goal)FeedbackGoalComboBox.SelectedItem;
            Feedback feedback = new Feedback(0, FeedbackRichtextbox.Text, FeedbacksortTextbox.Text, TeacherFeedbackTextbox.Text, selectedGoal);
            dal.CreateFeedback(feedback);

            AddFeedbackMessageLabel.Show();
            FeedbackRichtextbox.Clear();
            FeedbacksortTextbox.Clear();
            TeacherFeedbackTextbox.Clear();    
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Feedback selectedFeedback = (Feedback)FeedbackcomboBox.SelectedItem;
            Goal selectedGoal = (Goal)FeedbackGoalComboBox.SelectedItem;
            Feedback feedback = new Feedback(selectedFeedback.FeedbackID, FeedbackRichtextbox.Text, FeedbacksortTextbox.Text, TeacherFeedbackTextbox.Text, selectedGoal);
            dal.UpdateFeedback(feedback);

            ChangeFeedbackMessageLabel.Show();

            FeedbacksortTextbox.Clear();
            FeedbackRichtextbox.Clear();
            TeacherFeedbackTextbox.Clear();
        }
    }
}
