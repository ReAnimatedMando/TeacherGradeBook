using System;

namespace TeacherGradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            // Create 4 instances of Student and set their property values
            Student studentOne = new Student()
            {
                Name = "Aaron",
                ID = 1
            };

            Student studentTwo = new Student()
            {
                Name = "Clara",
                ID = 2
            };

            Student studentThree = new Student()
            {
                Name = "Peter",
                ID = 3
            };

            Student studentFour = new Student()
            {
                Name = "Maddie",
                ID = 4
            };

            // add each instance of Student to students
            students.Add(studentOne);
            students.Add(studentTwo);
            students.Add(studentThree);
            students.Add(studentFour);


            // call method AddGrade two time for each student in students, with grades.
            studentOne.AddGrade(75.3);
            studentOne.AddGrade(86.9, 90.0, 65.37);

            studentTwo.AddGrade(98.4);
            studentTwo.AddGrade(93.3, 95.7, 89.0);

            studentThree.AddGrade(85.4);
            studentThree.AddGrade(76.7, 68.0, 80.0);

            studentFour.AddGrade(91.2);
            studentFour.AddGrade(90.0, 89.8, 92.5);
            
            
            // write a loop to display properties for each student in Student and display their grades
            foreach (Student student in students)
            {
                // use string interpolation to display students and grades
                Console.WriteLine($"ID: {student.ID}"); 
                Console.WriteLine($"Name: {student.Name}");
                Console.Write("Grades: ");

                foreach (double grade in student.Grades)
                {
                    Console.Write($"{grade} "); // display student grades in Grades
                }

                Console.WriteLine($"\nAverage: {student.CalculateAverageGrade():F2}"); // display average of grades in Grade
                Console.WriteLine("----------------------------------"); // separate results. I love how they did this in our last exercise
            }
        }
    }
}
