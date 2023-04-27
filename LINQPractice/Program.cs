namespace LINQPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.FindStudentsWithHighGPAs();
            demo.FindAverageGPA();
            demo.FindStudentsEnrolledAfter2019();
            demo.AverageGPABefore2020();
            demo.NamesOfTopThreeStudents();
            demo.FirstNameAStudents();
            demo.EarliestDateofEnrollment();
        }
    }
}