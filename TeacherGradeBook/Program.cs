using System;

namespace TeacherGradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

        List<Student> students = new List<Student>();

        var studentOne = new Student()
        {
            Name = "Aaron"
        };

        var studentTwo = new Student()
        {
            Name = "Clara"
        };

        var studentThree = new Student()
        {
            Name = "Peter"
        };

        var studentFour = new Student()
        {
            Name = "Maddie"
        };

        students.Add(studentOne);
        students.Add(studentTwo);
        students.Add(studentThree);
        students.Add(studentFour);
    }
}
}
