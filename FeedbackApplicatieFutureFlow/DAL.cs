using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApplicatieFutureFlow
{
    internal class DAL
    {
        string connectionstring = "Data Source=LAPTOP-NC4S9U73;Initial Catalog=FeedbackApplicatie;Integrated Security=True";
        
        
        /*Data Source = Laptop_Tijn; Initial Catalog = FeedbackApplicatie; Integrated Security = True*/

        // Lijst van goals
        public List<Goal> goals = new List<Goal>();

        // Lijst van taken
        public List<Task> tasks = new List<Task>();

        // Lijst van opmerkingen
        public List<Feedback> feedbacks = new List<Feedback>();

        // Lijst van accounts
        public List<Account> accounts = new List<Account>();



        // Doelen verhalen uit database bij een bepaald account
        public void FillGoalsFromDatabase(Account account)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string sql = "SELECT * " +
                    "FROM GOAL " +
                    "JOIN ACCOUNT ON GOAL.AccountID = @accountid" +
                    " WHERE ACCOUNT.AccountID = @accountid;";

                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@accountid", account.AccountID);
                    //command.Parameters.AddWithValue("@Lastname", studentAccount.LastName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Lees de doelen en voeg deze toe aan de lijst
                            Goal goal = new Goal(reader.GetInt32(0), reader.GetString(2), reader.GetString(3), account);

                            goals.Add(goal);
                        }
                    }
                }
            }
        }


        // Taken verhalen uit database bij een bepaald goal
        public void FillTaskFromDatabase(Goal goal)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string sql = "SELECT * " +
                    "FROM TASK " +
                    "JOIN GOAL ON TASK.GoalID = @GoalID " +
                    "WHERE GOAL.GoalID = @GoalID;";

                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@GoalID", goal.GoalID);
                    //command.Parameters.AddWithValue("@Lastname", studentAccount.LastName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Lees de doelen en voeg deze toe aan de lijst
                            Task task = new Task(reader.GetInt32(0), reader.GetString(2), reader.GetString(3), goal);

                            tasks.Add(task);
                        }
                    }
                }
            }
        }

        // Feedback verhalen uit database bij een bepaald goal
        public void FillFeedbackFromDatabase(Goal goal)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string sql = "SELECT * " +
                    "FROM FEEDBACK " +
                    "JOIN GOAL ON FEEDBACK.GoalID = @GoalID " +
                    "WHERE GOAL.GoalID = @GoalID;";

                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@GoalID", goal.GoalID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Lees de doelen en voeg deze toe aan de lijst
                            Feedback feedback = new Feedback(reader.GetInt32(0), reader.GetString(2), reader.GetString(3),
                                reader.GetString(4), goal);

                            feedbacks.Add(feedback);
                        }
                    }
                }
            }
        }

        // Accounts vinden in de database
        public void FindAccounts()
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string sql = "SELECT *" +
                    "FROM ACCOUNT";

                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Account account = new Account(reader.GetInt32(0), reader.GetString(1),
                                reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));

                            accounts.Add(account);
                        }
                    }
                }
            }
        }

        // Account aanmaken voor student
        public void CreateStudentAccount(Account studentAccount)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string sql = "INSERT INTO ACCOUNT (Firstname, LastName, Email, Username, Password, AccountType) VALUES (@Firstname, @LastName, @Email, @Username, @Password, @AccountType)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Firstname", studentAccount.FirstName);
                    command.Parameters.AddWithValue("@Lastname", studentAccount.LastName);
                    command.Parameters.AddWithValue("@Email", studentAccount.Email);
                    command.Parameters.AddWithValue("@Username", studentAccount.Username);
                    command.Parameters.AddWithValue("@Password", studentAccount.Password);
                    command.Parameters.AddWithValue("@AccountType", studentAccount.AccountType);
                    command.ExecuteNonQuery();
                }
            }
            FindAccounts();
        }

        // Aanmaken van een doel
        public void CreateGoal(Goal goal)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string sql = "INSERT INTO GOAL (Description, Week, AccountID) VALUES (@Description, @Week, @AccountID);";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Description", goal.Description);
                    command.Parameters.AddWithValue("@Week", goal.Week);
                    command.Parameters.AddWithValue("@AccountID", goal.Account.AccountID); //vertaalslag van OBJECT NAAR 'DATABASETAAL'

                    command.ExecuteNonQuery();
                }
            }
        }


        // Aanmaken van een taak
        public void CreateTask(Task task)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string sql = "INSERT INTO TASK (Description, Status, GoalID) VALUES (@Description, @Status, @GoalID);";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Description", task.Description);
                    command.Parameters.AddWithValue("@Status", task.Status);
                    command.Parameters.AddWithValue("@GoalID", task.Goal.GoalID);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Aanmaken van feedback
        public void CreateFeedback(Feedback feedback)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string sql = "INSERT INTO FEEDBACK (GoalID, Description, FeedbackType, ProfessorName) VALUES (@GoalID, @Description, @FeedbackType, @ProfessorName);";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@GoalID", feedback.Goal.GoalID); 
                    command.Parameters.AddWithValue("@Description", feedback.Description);
                    command.Parameters.AddWithValue("@FeedbackType", feedback.FeedbackType);
                    command.Parameters.AddWithValue("@ProfessorName", feedback.ProfessorName);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Verwijderen van een doel
        public void DeleteGoal(int goalId)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string sql = "DELETE GOAL WHERE GoalID = @GoalID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@GoalID", goalId);
                    command.ExecuteNonQuery();
                }
            }
        }


        /*//
        public void FillComboBoxWithGoals(ComboBox taskCombobox, TextBox weekTextbox, RichTextBox descriptionTextbox)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string sql = "SELECT * FROM GOAL;";
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            taskCombobox.Items.Add(reader.GetString(2));   
                            
                            string week = reader.GetString(3);
                            string description = reader.GetString(2);

                            weekTextbox.Text = week;
                            descriptionTextbox.Text = description;
                        }
                    }
                }
            }
        }*/

        // Doelen weergeven bij combobox op basis van een account(ACCOUNT NOG TOEVOEGEN)
        public void FillUpdateComboBoxWithGoals(ComboBox taskCombobox)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string sql = "SELECT * FROM GOAL;";
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            taskCombobox.Items.Add(reader.GetString(2));
                        }
                    }
                }
            }
        }

        public void UpdateGoal(Goal goal)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string sql = "UPDATE GOAL SET Week = @Week, Description = @Description WHERE GoalID = @GoalID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Week", goal.Week);
                    command.Parameters.AddWithValue("@Description", goal.Description);
                    command.Parameters.AddWithValue("@GoalID", goal.GoalID);
                    command.ExecuteReader();
                }
            }
        }

        public void UpdateTask(Task task)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string sql = "UPDATE Task SET GoalID = @GoalID, Description = @Description, Status = @Status WHERE TaskID = @TaskID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@GoalID", task.Goal.GoalID);
                    command.Parameters.AddWithValue("@Description", task.Description);
                    command.Parameters.AddWithValue("@Status", task.Status);
                    command.Parameters.AddWithValue("@TaskID", task.TaskID);
                    command.ExecuteReader();
                }
            }
        }

        public void UpdateFeedback(Feedback feedback)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string sql = "UPDATE FEEDBACK SET GoalID = @GoalID, Description = @Description, FeedbackType = @FeedbackType, ProfessorName = ProfessorName;";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@GoalID", feedback.Goal.GoalID); 
                    command.Parameters.AddWithValue("@Description", feedback.Description);
                    command.Parameters.AddWithValue("@FeedbackType", feedback.FeedbackType);
                    command.Parameters.AddWithValue("@ProfessorName", feedback.ProfessorName);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
