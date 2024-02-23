namespace FeedbackApplicatieFutureFlow
{
    public partial class LoginScreenForm : Form
    {
        DAL dal;

        public LoginScreenForm()
        {
            InitializeComponent();
            dal = new DAL();
        }



        private void LoginScreenCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            // lijst met alle accounts --> hierover zoeken of wat in de textbox ingevoerd is overeenkomt met de informatie in database!
            dal.FindAccounts();

            string username = UsernameTextbox.Text;
            string password = PasswordTextbox.Text;

            foreach (Account account in dal.accounts)
            {
                if (username == account.Username && password == account.Password)
                {

                    //WrongInlogMessageLabel.Hide();
                    PasswordTextbox.Clear();
                    UsernameTextbox.Clear();

                    using(StudentDashboard studentDashboard = new StudentDashboard(account))
                    {
                        if (studentDashboard.ShowDialog() == DialogResult.OK)
                        {
                            
                        }
                    }
                }


               // docent account
               else if (username == "2" && password == "2")
               {
                    //WrongInlogMessageLabel.Hide();
                    UsernameTextbox.Clear();
                    PasswordTextbox.Clear();

                    using (DocentDashboard docentDashboard = new DocentDashboard())
                   {
                       if (docentDashboard.ShowDialog() == DialogResult.OK)
                       {
                            
                       }
                   }
               }

                else
                {
                    PasswordTextbox.Clear();
                    UsernameTextbox.Clear();
                    WrongInlogMessageLabel.Show();
                }

            }
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            CreateStudentPanel.Show();
        }

        private void CancelCreateStudentButton_Click(object sender, EventArgs e)
        {
            CreateStudentPanel.Hide();
        }

        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            Account studentAccount = new Account(0, CreateFirstnameTextbox.Text, CreateLastnameTextbox.Text, CreateEmailTextbox.Text, 
                CreateUsernameTextbox.Text, CreatePasswordTextbox.Text, "Leerling");

            dal.CreateStudentAccount(studentAccount);
            CreateStudentMessageLabel.Show();

            CreateFirstnameTextbox.Clear();
            CreateLastnameTextbox.Clear();
            CreateEmailTextbox.Clear();
            CreateUsernameTextbox.Clear();
            CreatePasswordTextbox.Clear();


        }

        private void LoginScreenForm_Shown(object sender, EventArgs e)
        {
            WrongInlogMessageLabel.Hide();
        }
    }
}