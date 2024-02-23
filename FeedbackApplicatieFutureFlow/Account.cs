using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApplicatieFutureFlow
{
    public class Account
    {
        public int AccountID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }

        public Account(int accountID, string firstName, string lastName, string email, string username, string password, string accountType)
        {
            AccountID = accountID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Username = username;
            Password = password;
            AccountType = accountType;
        }




        // Relationship: 0 of meerdere goals


    }
}
