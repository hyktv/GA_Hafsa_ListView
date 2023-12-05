using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Hafsa_ListView
{
    internal class Student
    {
        string _firstName;
        string _lastName;
        string _idNumber;
        Random rand = new Random();

        // Have properties
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string IdNumber { get => _idNumber; set => _idNumber = value; }

        // Constructor
        public Student(string firstName, string lastName) 
        {
            _firstName = firstName;
            _lastName = lastName;
            _idNumber = rand.Next(100000000, 1000000000).ToString();
        }


    }
}
