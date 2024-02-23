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
    public partial class FeedbackForm : Form
    {
        DAL dal;
        public Account Student { get; set; }

        /* public Goal Goal { get; set; }*/
        public FeedbackForm(/*Goal goal*/Account student)
        {
            InitializeComponent();
            dal = new DAL();
            Student = student;

          
            
            

/*
            dal.FillFeedbackFromDatabase(goal);
            foreach (Feedback feedback in dal.feedbacks)
            {
                Console.WriteLine(feedback.FeedbackID);
            }

            // Hier zeg je tegen datagridview dat zijn source de lijst met goals is en zeg je welke properties hij ophaalt uit de lijst goals
            FeedbackGoalDatagridview.DataSource = dal.feedbacks.Select(g => new
            {
                g.FeedbackID,
                g.Goal.GoalID,
            }).ToList();
            FeedbackGoalDatagridview.AutoGenerateColumns = true;*/
        }

        private void CreateTimeButton_Click(object sender, EventArgs e)
        {
            CRUDFeedbackPanel.Controls.Clear();
            CreateFeedbackForm createfeedbackform = new CreateFeedbackForm(Student, FeedbackGoalDatagridview) { TopLevel = false, TopMost = true };
            createfeedbackform.FormBorderStyle = FormBorderStyle.None;
            CRUDFeedbackPanel.Controls.Add(createfeedbackform);
            createfeedbackform.Show();
        }

        private void UpdateTimeButton_Click(object sender, EventArgs e)
        {
           
        }

        private void FeedbackGoalDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
