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
    public partial class UpdateGoalorTaskForm : Form
    {

        DAL dal;

        public Account Student { get; set; }


        public UpdateGoalorTaskForm(Account student)
        {
            InitializeComponent();
            Student = student;
            dal = new DAL();

            dal.FillGoalsFromDatabase(Student);

            UpdateGoalCombobox.DataSource = dal.goals;
            UpdateGoalCombobox.DisplayMember = "Description";
            UpdateGoalCombobox.ValueMember = "GoalID";


            UpdateGoalToUpdateTaskCombobox.DataSource = dal.goals;
            UpdateGoalToUpdateTaskCombobox.DisplayMember = "Description";
            UpdateGoalToUpdateTaskCombobox.ValueMember = "GoalID";


            //De clear functie werkt niet zodra een doe
            Goal selectedGoal = (Goal)UpdateGoalCombobox.SelectedItem;

            dal.FillTaskFromDatabase(selectedGoal);
            SelectTaskToUpdatecomboBox.DataSource = dal.tasks;
            SelectTaskToUpdatecomboBox.DisplayMember = "Description";
            SelectTaskToUpdatecomboBox.ValueMember = "TaskID";
        }

        private void UpdateGoalorTaskCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Dit Toegevoegd! alleen weet niet waarom textbox niet wordt geupdate
        private void UpdateGoalorTaskForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateGoalButton_Click(object sender, EventArgs e)
        {
            Goal selectedGoal = (Goal)UpdateGoalCombobox.SelectedItem;
            Goal goal = new Goal(selectedGoal.GoalID, UpdateGoalDescriptionRichtextbox.Text, UpdateWeekGoalTextbox.Text, Student);
            dal.UpdateGoal(goal);

            UpdateGoalMessageLabel.Show();
            UpdateGoalDescriptionRichtextbox.Clear();
            UpdateWeekGoalTextbox.Clear();
        }

        private void UpdateTaskButton_Click(object sender, EventArgs e)
        {
            Task selectedTask = (Task)SelectTaskToUpdatecomboBox.SelectedItem;
            Goal selectedGoal = (Goal)UpdateGoalCombobox.SelectedItem;
            Task task = new Task(selectedTask.TaskID, UpdateTaskDescriptionRichTextBox.Text, UpdateTaskStatusTextbox.Text, selectedGoal);
            dal.UpdateTask(task);

            UpdateTaskMessageLabel.Show();
            UpdateTaskStatusTextbox.Clear();
            UpdateTaskDescriptionRichTextBox.Clear();
        }
    }
}
