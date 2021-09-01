using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * 
 * 
 * https://satr.codes/
 * C# 101 
 * Waleed Alotaibi
 * 
 * 
 * ********************/
namespace CSharp101Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsNum = 0;
            var StudentName = new List<string>();
            var grade = new List<double>();


            Console.WriteLine("How many students do you want to enter their grades?");
            studentsNum = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < studentsNum; i++)
            {
                Console.WriteLine("Enter the student's name No: "+ (i+1));
                StudentName.Add(Console.ReadLine());
                Console.WriteLine("Enter the student's ( "+ StudentName[i] + " ) grade: ");
                grade.Add(Convert.ToDouble(Console.ReadLine()));

            }
            Console.Write("No \t");
            Console.Write("Name \t");
            Console.Write("Grade \t");
            Console.WriteLine("Status");

            for (int i = 0; i < StudentName.Count; i++)
            {
                Console.Write((i + 1) + "\t");
                Console.Write(StudentName[i] + "\t");
                Console.Write(grade[i] + "\t");
                if (grade[i] >= 60)
                    Console.WriteLine("Passed");
                else
                    Console.WriteLine("Failed");

            }

            Console.ReadKey();

        }
    }
}
