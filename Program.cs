
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
            ArrayList grades = new ArrayList();
            List<int> grades2 = new List<int>();
            for (int i= 0; i < 10; i++)
            {
                //randNum for grade, add to array list
                grade = (int)rnd.Next(1, 100);
                grades.Add(grade);
                grades2.Add(grade);
            }  
            for (int i=0; i< grades.Count; i++)
            {
                Console.WriteLine($"Grade {i} is {grades[i]} - ArrayList");
                //Console.WriteLine($"Grade {i} is {grades2[i]} - List");
                //total += (int)grades[i];
                total += (int) grades[i];
                if (grades2[i] > max)
                {
                    max = grades2[i];
                }
            }
            average = (double)total / (double)grades.Count;
            Console.WriteLine($"Average is: {average}");
            Console.WriteLine($"Highest grade is {max}");
            Console.ReadLine();
        }
    }
}
