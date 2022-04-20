using System;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person employee = new Person(
                "Linda", 30, "6757657657", GenderEnum.Female);

            //  employee.

            Student student = new Student("Allan", 36, "67657657", "3455454", GenderEnum.NonBinary);
            
            Console.WriteLine("Student Name: " + student.Name);
            Console.WriteLine("Student Number: " + student.StudentNumber);

            Console.WriteLine("Employee Name: " + employee.Name);
            //            Console.WriteLine("Employee Number: " + employee.StudentNumber);
            Console.WriteLine("Can do Future Lab: " + student.IsElegibleForFutureLab());
        
        //employee.is
        }
    }
}
