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
        private string LastName { get; set; } 
        private string Email { get; set; }

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
                if (validate.IsName(firstName)) FirstName = firstName;
                else throw new Exception("First name is invalid, first letter should be in caps and minimum 3 alpabets should present !");

                Console.Write("Enter the Last Name = ");
                string lastName = Console.ReadLine();
                lastName = lastName.Trim();
                if (validate.IsName(lastName)) LastName = lastName;
                else throw new Exception("Last name is invalid, first letter should be in caps and minimum 3 alpabets should present !");

                Console.Write("Enter the email = ");
                string email = Console.ReadLine();
                email = email.Trim();
                if (validate.IsEmail(email)) Email = email;
                else throw new Exception("Email is invalid, email has 3 mandatory parts(abc,bl and co) and 2 optional (xyz & in) with precise @ and . positions!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Display()
        { 
            if (FirstName != null && LastName !=null) Console.WriteLine("User = " + FirstName + " " + LastName);
        }
    }
}
