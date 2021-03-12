using System;

namespace ConsoleApp1
{
    class Student
    {
        String name;
        int rollNo;
        int age;
        int division;

        void printStudent()
        {
            Console.WriteLine("Name of Student:\t\t" + name);
            Console.WriteLine("Roll Number of Student:\t\t" + rollNo);
            Console.WriteLine("Age of Student:\t\t\t" + age);
            Console.WriteLine("Division of Student:\t\t" + division);
        }

        Student(string passedName, int passedRollNo, int passedAge, int passedDivision)
        {
            name = passedName;
            rollNo = passedRollNo;
            age = passedAge;
            division = passedDivision;
            printStudent();
        }

               static void Main(string[] args)
        {

            Student sunit = new Student("sunit", 10, 38, 4);
            Student sameer = new Student("sameer", 11, 35, 5);
            Student utkarsh = new Student("utkarsh", 10, 36, 6);


        }
    }
}
