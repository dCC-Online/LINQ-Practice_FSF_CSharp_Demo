using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public double gpa;
        public DateTime dateEnrolled;

        public Student(string firstName, string lastName, double gpa, DateTime dateEnrolled)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gpa = gpa;
            this.dateEnrolled = dateEnrolled;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}
