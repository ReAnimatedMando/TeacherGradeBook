using System;

namespace TeacherGradeBook;

public class Student
{
    // create properties that will give the Student blueprint their characteristics
    public string Name { get; set; }
    public int ID { get; set; }

    public List<double> Grades { get; set; } = new List<double>(); // initialize a list that will be populated with student grades

    // create a method to add student grades to your list
    public void AddGrade(double grade)
    {
        Grades.Add(grade); // use Add method to add grade to Grades List
    }
    
    // create a method that can take any number of parameters and add them to your list. method overloading?
    public void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades); // use AddRange method to add grades to Grades List
    }
    
    // create a method that will calculate the average grade of the class
    public double CalculateAverageGrade()
    {
        double averageGrade = Grades.Average(); // find the average of grades in Grades List and store it in a variable
        if (Grades.Count == 0) // if Grades List is empty
        {
            return 0; // output zero
        }

        return averageGrade; // otherwise, return averageGrade
    }
}

