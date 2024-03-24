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
        private string MobileNumber { get; set; }

        private string Password { get; set; }

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

                //Console.Write("Enter the First Name = ");
                //string firstName = Console.ReadLine();
                //firstName = firstName.Trim();
                //if (validate.IsName(firstName)) FirstName = firstName;
                //else throw new Exception("First name is invalid, first letter should be in caps and minimum 3 alpabets should present !");

                //Console.Write("Enter the Last Name = ");
                //string lastName = Console.ReadLine();
                //lastName = lastName.Trim();
                //if (validate.IsName(lastName)) LastName = lastName;
                //else throw new Exception("Last name is invalid, first letter should be in caps and minimum 3 alpabets should present !");

                //Console.Write("Enter the email = ");
                //string email = Console.ReadLine();
                //email = email.Trim();
                //if (validate.IsEmail(email)) Email = email;
                //else throw new Exception("Email is invalid, email has 3 mandatory parts(abc,bl and co) and 2 optional (xyz & in) with precise @ and . positions!");

                //Console.Write("Enter the mobile number = ");
                //string number = Console.ReadLine();
                //number = number.Trim();
                //if (validate.IsNumber(number)) MobileNumber = number;
                //else throw new Exception("Mobile number is invalid,Country code followed by space and 10 digit number");

                Console.Write("Enter the password = ");
                string password = Console.ReadLine();
                password = password.Trim();
                if (validate.IsPassword(password)) Password = password;
                else throw new Exception("Password is invalid,\nRule 1: Must contain minimum 8 charcters !\nRule 2: Should have at least 1 Upper Case !\nRule 3: Should have at least 1 digit !\nRule 4: Should have at exactly one special character !");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Display()
        {
            if (FirstName != null && LastName != null && Email != null && MobileNumber != null && Password != null) Console.WriteLine("User = " + FirstName + " " + LastName + " " + Email + " " + MobileNumber + " " + Password);
        }
    }
}

