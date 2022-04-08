
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures___ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare var
            double average;
            int grade = 0;
            int total = 0;
            int max = 0;
            Random rnd = new Random();
            //instantiate array list and list
            
            //ArrayList grades = new ArrayList();
            List<int> gradesList = new List<int>();
            for (int i= 0; i < 10; i++)
            {
                //randNum for grade, add to array list
                grade = (int)rnd.Next(1, 100);
                //grades.Add(grade);
                gradesList.Add(grade);
            }  
            for (int i=0; i< gradesList.Count; i++)
            {
                Console.WriteLine($"Grade {i} is {gradesList[i]}");
                //Console.WriteLine($"Grade {i} is {grades2[i]} - List");
                //total += (int)grades[i];
                total += gradesList[i];
                if (gradesList[i] > max)
                {
                    //max = (int)grades[i];
                    max = gradesList[i];
                }
            }
            average = (double) total / (double) gradesList.Count;
            Console.WriteLine($"Average is: {average}");
            Console.WriteLine($"Highest grade is {max}");
            Console.ReadLine();
        }
    }
}
