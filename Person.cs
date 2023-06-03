using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket2
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Date { get; set; }

        public Person(string firstName, string lastName, string email, string phone, DateTime date)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Date = date;
        }
    }
}
