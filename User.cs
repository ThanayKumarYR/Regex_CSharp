using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblems
{
    class User
    {
        private string FirstName { get; set; }

        public User()
        {
            Add();
        }

        private void Add()
        {
            try 
            {
                Validation validate = new Validation();
                Console.WriteLine("Register the User !");
                Console.Write("Enter the First Name = ");
                string firstName = Console.ReadLine();
                firstName = firstName.Trim();
                if (validate.IsFirstName(firstName)) FirstName = firstName;
                else throw new Exception("First name is invalid, first letter should be in caps and minimum 3 alpabets should present !");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Display()
        { 
            if (FirstName != null) Console.WriteLine("User = " + FirstName);
        }
    }
}
