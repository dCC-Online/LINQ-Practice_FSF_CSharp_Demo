using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    internal class Demo
    {

        List<Student> students;

        public Demo()
        {
            CreateData();
        }

        public void CreateData()
        {
            students = new List<Student>()
            {
                new Student("Quinn", "Baker", 3.5, new DateTime(2018, 10, 16)),
                new Student("Bob", "Johnson", 2.9, new DateTime(2021, 1, 22)),
                new Student("Charlie", "Williams", 3.5, new DateTime(2019, 9, 1)),
                new Student("Sophia", "Gonzalez", 3.2, new DateTime(2019, 5, 20)),
                new Student("Diana", "Brown", 4.0, new DateTime(2022, 3, 10)),
                new Student("Luke", "Jones", 3.7, new DateTime(2018, 12, 5)),
                new Student("Tyler", "Martinez", 3.3, new DateTime(2022, 3, 7)),
                new Student("George", "Wilson", 3.9, new DateTime(2019, 2, 14)),
                new Student("Hannah", "Davis", 3.6, new DateTime(2020, 11, 30)),
                new Student("Isaac", "Garcia", 2.9, new DateTime(2022, 1, 4)),
                new Student("Jackie", "Lee", 3.1, new DateTime(2018, 9, 23)),
                new Student("Kate", "Roberts", 3.7, new DateTime(2021, 3, 18)),
                new Student("Luke", "Nguyen", 2.8, new DateTime(2019, 8, 11)),
                new Student("Mia", "Chen", 3.3, new DateTime(2020, 5, 3)),
                new Student("Alice", "Smith", 3.8, new DateTime(2020, 8, 15)),
                new Student("Nathan", "Scott", 3.4, new DateTime(2022, 2, 19)),
                new Student("Olivia", "Clark", 3.8, new DateTime(2019, 11, 7)),
                new Student("Peter", "Kim", 2.6, new DateTime(2021, 4, 27)),
                new Student("Felicity", "Taylor", 3.2, new DateTime(2021, 6, 8)),
                new Student("Ryan", "Adams", 2.5, new DateTime(2020, 7, 2)),                
            };
        }

        public void FindStudentsWithHighGPAs()
        {
            // Standard tools
            List<Student> highGpaList = new List<Student>();
            foreach(Student student in students)
            {
                if(student.gpa >= 3.5)
                {
                    highGpaList.Add(student);
                }
            }

            // Extension methods:
            var highGpaStudents = students.Where(student => student.gpa >= 3.5);


            // Query operators:
            var highGpaStudentsQ = from student in students
                                   where student.gpa >= 3.5
                                   select student;

            Console.WriteLine();
        }

        public void FindAverageGPA()
        {
            // Standard tools
            double gpaSum = 0;
            foreach (Student student in students)
            {
                gpaSum += student.gpa;
            }
            double avgGpa = gpaSum / students.Count();


            // Extension methods:
            var averageGpa = students.Average(student => student.gpa);

            // Query operators:
            var averageGpaQ = (from student in students
                              select student.gpa).Average();

            Console.WriteLine();
        }

        public void FindStudentsEnrolledAfter2019()
        {
            // Standard tools
            int after2019Count = 0;
            foreach (var student in students)
            {
                if (student.dateEnrolled > new DateTime(2020, 1, 1))
                {
                    after2019Count++;
                }
            }

            // Extension methods:
            var recentStudentsCount = students.Count(student => student.dateEnrolled > new DateTime(2020, 1, 1));

            // Query operators:
            var recentStudentsCountQ = (from student in students
                                       where student.dateEnrolled > new DateTime(2020, 1, 1)
                                       select student).Count();

            Console.WriteLine();
        }

        public void AverageGPABefore2020()
        {
            // Standard tools
            double totalGpa = 0;
            int count = 0;
            foreach (var student in students)
            {
                if (student.dateEnrolled < new DateTime(2020, 1, 1))
                {
                    totalGpa += student.gpa;
                    count++;
                }
            }
            double avgBefore2020 = totalGpa / count;

            // Extension methods:
            var avgGpaBefore2020 = students.Where(student => student.dateEnrolled < new DateTime(2020, 1, 1))
                                           .Average(student => student.gpa);

            // Query operators:
            var avgGpaBefore2020Q = (from student in students
                                     where student.dateEnrolled < new DateTime(2020, 1, 1)
                                     select student.gpa).Average();

            Console.WriteLine();
        }

        public void NamesOfTopThreeStudents()
        {

            // Extension methods:
            var topGpaStudents = students.OrderByDescending(student => student.gpa)
                                         .Take(3)
                                         .Select(student => $"{student.firstName} {student.lastName}");

            // Query operators:
            var topGpaStudentsQ = (from student in students
                                   orderby student.gpa descending
                                   select $"{student.firstName} {student.lastName}").Take(3);

            Console.WriteLine();
        }

        public void FirstNameAStudents()
        {
            // Extension methods:
            var aStudentsCount = students.Count(student => student.firstName.StartsWith("A"));

            // Query operators:
            var aStudentsCountQ = (from student in students
                                   where student.firstName.StartsWith("A")
                                   select student).Count();

            Console.WriteLine();
        }

        public void EarliestDateofEnrollment()
        {
            //Extension method
            var latestEnrollmentDate = students.Max(student => student.dateEnrolled);

            // Query operators:
            var earliestEnrollmentDateQ = (from student in students
                                          select student.dateEnrolled).Min();

            Console.WriteLine();
        }


        
        //Find Student whose Last name comes first alphabetically
        //


    }
}
