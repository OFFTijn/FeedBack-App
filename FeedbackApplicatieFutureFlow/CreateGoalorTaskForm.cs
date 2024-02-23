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
    public partial class CreateGoalorTaskForm : Form
    {
        public Account Student { get; set; }
        DAL dal;

        public CreateGoalorTaskForm(Account student)
        {
            InitializeComponent();
            Student = student;
            dal = new DAL();

            dal.FillGoalsFromDatabase(Student);

            TaskCombobox.DataSource = dal.goals;
            TaskCombobox.DisplayMember = "Description";
            TaskCombobox.ValueMember = "GoalID";

        }

        private void CreateGoalorTaskCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateGoalButton_Click(object sender, EventArgs e)
        {
            CreateGoalPanel.Visible = true;
        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            CreateTaskPanel.Visible = true;
        }

        private void SubmitGoalButton_Click(object sender, EventArgs e)
        {

            Goal goal = new Goal(0, CreateGoalDescriptionRichTextBox.Text, GoalWeekTextbox.Text, Student);
            dal.CreateGoal(goal);

            CreateGoalDescriptionRichTextBox.Clear();
            GoalWeekTextbox.Clear();
            CreateGoalMessageLabel.Show();

        }

        private void CreateGoalorTaskCloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateGoalButton_Click_1(object sender, EventArgs e)
        {
            CreateGoalPanel.Show();
        }

        private void CreateTaskButton_Click_1(object sender, EventArgs e)
        {
            CreateTaskPanel.Show();
        }

        private void TaskCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void CreateTaskpanelButton_Click(object sender, EventArgs e)
        { 
            Goal selectedGoal = (Goal)TaskCombobox.SelectedItem;

           /* int goalId = selectedGoal.GoalID;*/
           
            Task task = new Task(0, CreateTaskDescriptionRichTextBox.Text, "Nog doen", selectedGoal);
            dal.CreateTask(task);

            CreateTaskDescriptionRichTextBox.Clear();
            CreateTaskMessageLabel.Show();

        }
    }
}
