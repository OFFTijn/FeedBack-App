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
    public partial class DocentDashboard : Form
    {
        public DocentDashboard()
        {
            InitializeComponent();
        }

        private void DocentDashboarCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentOverviewButton_Click(object sender, EventArgs e)
        {
            DocentCombinationPanel.Controls.Clear();
            StudentOverviewForm studentOverview = new StudentOverviewForm() { TopLevel = false, TopMost = true };
            studentOverview.FormBorderStyle = FormBorderStyle.None;
            DocentCombinationPanel.Controls.Add(studentOverview);
            studentOverview.Show();
        }
    }
}
