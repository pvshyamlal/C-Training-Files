using System;

namespace CollegeApp
{
    abstract class Student
    {
        public string Name;
        public string RollNumber;

        public Student(string name, string rollNumber)
        {
            Name = name;
            RollNumber = rollNumber;
        }

        public abstract void CalculatePercentage(int totalMarks, int obtainedMarks);
    }

    class CollegeStudent : Student
    {
        public CollegeStudent(string name, string rollNumber) : base(name, rollNumber)
        {
        }

        public override void CalculatePercentage(int totalMarks, int obtainedMarks)
        {
            double percentage = ((double)obtainedMarks / totalMarks) * 100;
            Console.WriteLine("Name: " + Name + "\nRoll Number: " + RollNumber + "\nPercentage: " + percentage + "%");
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Student Name: "+Name+", Roll Number: "+RollNumber);
        }

        public void DisplayAge(int age)
        {
            Console.WriteLine("Student Age: "+age);
        }
    }

    static class StudentInfo
    {
        public static void DisplayCourses(string[] courses)
        {
            Console.WriteLine("Courses Enrolled:");
            foreach (var course in courses)
            {
                Console.WriteLine("- "+course);
            }
        }

        public static void DisplayBacklogs(int backlogs)
        {
            Console.WriteLine("Number of Backlogs: "+backlogs);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No.of Students");
            int num = int.Parse(Console.ReadLine());
            for(int i=0;i<num;i++){
                Console.WriteLine("Enter Student Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Roll Number: ");
                string rollNumber = Console.ReadLine();
                CollegeStudent student1 = new CollegeStudent(rollNumber, name);
                student1.DisplayDetails();
                student1.CalculatePercentage(500, 450);
                student1.DisplayAge(20);
                StudentInfo.DisplayCourses(new string[] { "C#", "Java", "Python" });
                StudentInfo.DisplayBacklogs(0);
        }
    }
}
}
