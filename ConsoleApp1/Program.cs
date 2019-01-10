using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] answers = new string[5];
            string answer1 = "";
            string answer2 = "";
            string answer3 = "";
            string answer4 = "";
            string answer5 = "";
            int score = 0;
            

            Console.WriteLine("Write carefully the next 7 questions and pick the correct answer for each case");
            Console.WriteLine("Who won the 1991 Italy World Cup?");
            Console.WriteLine("A: Germany.");
            Console.WriteLine("B: Italy");
            Console.WriteLine("C: Argentina");
            Console.WriteLine("D: Brazil");

            //getting the input form the console
            Console.WriteLine("Enter your answer: ");
            answer1 = Console.ReadLine();
            answer1 = answer1.ToLower();

            
            //checking if the answer is correct or not
            if (answer1 == "a")
            {
                Console.WriteLine("correct");
                score++;
            } else
            {
                Console.WriteLine("incorrect");
            }

            Console.WriteLine("Who won the 1994 USA World Cup?");
            Console.WriteLine("E: Germany.");
            Console.WriteLine("F: Italy");
            Console.WriteLine("G: Argentina");
            Console.WriteLine("H: Brazil");

            //getting the input form the console
            Console.WriteLine("Enter your answer: ");
            answer2 = Console.ReadLine();

            //checking if the answer is correct or not
            if (answer2 == "h")
            {
                Console.WriteLine("correct");
                score++;
            }
            else
            {
                Console.WriteLine("incorrect");
            }

            Console.WriteLine("Who won the 1998 France World Cup?");
            Console.WriteLine("I: Italy");
            Console.WriteLine("J: Croatia");
            Console.WriteLine("K: France");
            Console.WriteLine("L: Brazil");

            //getting the input form the console
            Console.WriteLine("Enter your answer: ");
            answer3 = Console.ReadLine();

            //checking if the answer is correct or not
            if (answer3 == "k")
            {
                Console.WriteLine("correct");
                score++;
            }
            else
            {
                Console.WriteLine("incorrect");
            }

            Console.WriteLine("Who won the 2002 Korea & Japan World Cup?");
            Console.WriteLine("M: Corea");
            Console.WriteLine("N: Germany");
            Console.WriteLine("O: Belgium");
            Console.WriteLine("P: Brazil");

            //getting the input form the console
            Console.WriteLine("Enter your answer: ");
            answer4 = Console.ReadLine();

            //checking if the answer is correct or not
            if (answer4 == "p")
            {
                Console.WriteLine("correct");
                score++;
            }
            else
            {
                Console.WriteLine("incorrect");
            }

            Console.WriteLine("Who won the 2006 Germany World Cup?");
            Console.WriteLine("Q: Italy");
            Console.WriteLine("R: Germany");
            Console.WriteLine("S: France");
            Console.WriteLine("T: Brazil");

            //getting the input form the console
            Console.WriteLine("Enter your answer: ");
            answer5 = Console.ReadLine();

            //checking if the answer is correct or not
            if (answer5 == "q")
            {
                Console.WriteLine("correct");
                score++;
            }
            else
            {
                Console.WriteLine("incorrect");
            }

            Console.WriteLine(score);

            Console.ReadKey();
        }
    }
}
