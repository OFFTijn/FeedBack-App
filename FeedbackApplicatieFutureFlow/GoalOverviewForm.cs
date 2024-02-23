using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackApplicatieFutureFlow
{
    public partial class GoalOverviewForm : Form
    {

        DAL dal;

        public Account Student { get; set; }

        public GoalOverviewForm(Account student)
        {
            InitializeComponent();
            dal = new DAL();
            Student = student;

            // Grid vullen met doelen
            dal.FillGoalsFromDatabase(student);
            foreach (Goal goal in dal.goals)
            {
                Console.WriteLine(goal.GoalID);
            }

            // Hier zeg je tegen datagridview dat zijn source de lijst met goals is en zeg je welke properties hij ophaalt uit de lijst goals
            GoalDatagridview.DataSource = dal.goals.Select(g => new
            {
                g.GoalID,
                g.Description,
                g.Week,
                g.Account.AccountID,
                g.Account.FirstName,
                g.Account.LastName
            }).ToList();
            GoalDatagridview.AutoGenerateColumns = true;



            /* // Grid vullen met taken
             dal.FillTaskFromDatabase(goal);
             foreach (Task task in dal.tasks)
             {
                 Console.WriteLine(task.TaskID);
             }

             // Hier zeg je tegen datagridview dat zijn source de lijst met tasks is en zeg je welke properties hij ophaalt uit de lijst tasks
             TaskDatagridview.DataSource = dal.tasks.Select(g => new
             {
                 g.TaskID,
                 g.Description,
                 g.Status
             }).ToList();
             TaskDatagridview.AutoGenerateColumns = true;*/

        }

        private void GoalOverviewForm_Load(object sender, EventArgs e)
        {
            /*// Hier haal je uit de database alle informatie op dat je in die functie hebt aangeduid
            dal.FillGoalsFromDatabase(Student);

            // Hier zeg je tegen datagridview dat zijn source de lijst met goals is en zeg je welke properties hij ophaalt uit de lijst goals
            GoalDatagridview.DataSource = dal.goals.Select(g => new
            {
                g.GoalID,
                g.Description,
                g.Account.FirstName,
                g.Account.LastName
            }).ToList();
            GoalDatagridview.AutoGenerateColumns = true;*/
        }

        private void GoalDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateGoalorTaskButton_Click(object sender, EventArgs e)
        {
            using (CreateGoalorTaskForm createGoalorTaskForm = new CreateGoalorTaskForm(Student))
            {
                if (createGoalorTaskForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void CreateGoalorTaskButton_Click_1(object sender, EventArgs e)
        {
            using (CreateGoalorTaskForm createGoalorTaskForm = new CreateGoalorTaskForm(Student))
            {
                if (createGoalorTaskForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void UpdateGoalButton_Click(object sender, EventArgs e)
        {
            using (UpdateGoalorTaskForm updateGoalorTaskform = new UpdateGoalorTaskForm(Student))
            {
                if (updateGoalorTaskform.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void DeleteGoalButton_Click(object sender, EventArgs e)
        {

            // Stap 1: Kijken of er een rij is geslecteerd.
            if (GoalDatagridview.SelectedRows.Count == 0)
            {

                string mistakemessage = "Er is geen rij geselecteerd om te verwijderen";
                string mistakecaption = "Foutmelding";
                MessageBoxButtons mistakebuttons = MessageBoxButtons.OK;


                // Displays the MessageBox.
                MessageBox.Show(mistakemessage, mistakecaption, mistakebuttons);

                // stopt de uitvoering van de functie(uit de button click) en gaat terug naar het hoofdprogramma
                return;
            }

            // Stap 2: Bevestiging vragen
            string confirmationmessage = "Weet je zeker dat je de geselecteerde rij wilt verwijderen?";
            string confirmationcaption = "Confirmatie doel verwijderen";
            MessageBoxButtons confirmationbuttons = MessageBoxButtons.YesNo;
            DialogResult confirmationresult;

            // Displays the MessageBox.
            confirmationresult = MessageBox.Show(confirmationmessage, confirmationcaption, confirmationbuttons);

            if (confirmationresult == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            // Stap 3: Rij verwijderen
            foreach (DataGridViewRow selectedrow in GoalDatagridview.SelectedRows)
            {
                var x = Int32.Parse(selectedrow.Cells[0].Value.ToString());
                dal.DeleteGoal(x);
            }

            /*// Stap 4: Verversen van doelengrid
            dal.FillGoalsFromDatabase(Student); // dit werkt niet??*/
        }

        private void GoalDatagridview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            /* // Hier heb je je ID gevonden en gestopt in een variabele --> deze converten naar een een string en dan int*/
            var selectedRow = ((dynamic)GoalDatagridview.Rows[e.RowIndex].DataBoundItem);

            // Als selectedROW geen collection bevat --> gooi exception die returned naar main program

            var goalId = selectedRow.GoalID;
            var description = selectedRow.Description;
            var week = selectedRow.Week;

            Goal g = new Goal(goalId, description, week, Student);

            // Taken ophalen bij geselecteerde doel
            dal.FillTaskFromDatabase(g);

            // Hier zeg je tegen datagridview dat zijn source de lijst met goals is en zeg je welke properties hij ophaalt uit de lijst goals
            TaskDatagridview.DataSource = dal.tasks.Select(g => new
            {
                g.TaskID,
                g.Description,
                g.Status,
            }).ToList();
            TaskDatagridview.AutoGenerateColumns = true;
            // EEN TAAK WORDT TOEGEVOEGD BIJ KLIKKEN RIJ --> HOE VOORKOMEN?

        }
    }
}
