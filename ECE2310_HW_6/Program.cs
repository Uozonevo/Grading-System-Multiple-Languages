using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_HW_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declarations
            int students = 26;
            string[] name = new string[students];
            int[] score = new int[students];

            //input student name and score
            for(int i=0; i<students; i++) 
            {
                Console.Write($"Please enter the name of student {i + 1}: ");
                name[i] = Console.ReadLine();

                bool valid = false;
                while(!valid) 
                {
                    Console.Write($"Please enter the exam score for {name[i]}: ");
                    if(int.TryParse(Console.ReadLine(), out int score1))
                    {
                        score[i] = score1;
                        valid = true;
                    }
                    else 
                    {
                        Console.WriteLine("Invalid input. Please input a valid score.");
                    }
                }
            }

            //display student information
            Console.WriteLine("\nName\t\tScore");
            for(int i=1; i<students; i++) 
            {
                Console.WriteLine($"{name[i]}\t\t{score[i]}");
            }

            //find student with highest score
            int highest = score[0];
            string highestStudent = name[0];

            for(int j=1; j<students; j++) 
            {
                if (score[j] > highest)
                {
                    highest = score[j];
                    highestStudent = name[j];
                }
            }

            //calculate average
            int total = 0;
            for(int k=0; k<students; k++)
            {
                total += score[k];
            }
            double average = (double)total / (double)students;

            //students with above average score
            int aboveAverage = 0;
            for(int k=0;k<students; k++)
            {
                if (score[k] > average)
                {
                    aboveAverage++;
                }
            }
                        
            Console.WriteLine($"\n{highestStudent} has the highest score {highest} in the class.");
            Console.WriteLine($"\nThe average score of the class is {average}");
            Console.WriteLine($"\n{aboveAverage} students are above average score.");
            Console.ReadLine();
        }
    }
}
