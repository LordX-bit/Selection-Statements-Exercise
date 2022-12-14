using System.Runtime.InteropServices;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create Guessing Game

            //var r = new Random();
            //var favNumber = r.Next(0, 1001);
            //int userInput;
            //var counter = 0;
            //do { 


            //Console.WriteLine("Pick a number from 1 - 1000");

            // userInput = int.Parse(Console.ReadLine());

            //    if (userInput < favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is too low");



            //    }
            //    else if (userInput > favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is too high ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("you guessed it!");
            //    }
            //    counter++;
            //    Console.WriteLine($"You have guessed {counter} time");

            //} while (userInput != favNumber);   
            Console.WriteLine("What is your favorite subject?");
            string subject = Console.ReadLine();
            switch (subject.ToLower())
            {
                case "math":
                case "calculus":
                    Console.WriteLine("I hate  Math");
                    break;
                case "scinece":
                case "physics":
                    Console.WriteLine("I love Scinece");
                    break;
                case "science":
                    Console.WriteLine("PE is the best!!");
                    break;
                case "pe":
                    break;
                    Console.WriteLine("History is fun");
                    break;
                case "history":
                    Console.WriteLine("History is fun.");
                    break;
                case "english":
                case "writing":
                    Console.WriteLine("English is boring");
                    break;
                    default:
                    Console.WriteLine("I don't know that subject");
                    break;
            }
        }
    }
}



//refrences
//Console.WriteLine($"{userInput} is too low");

           
                 // else if (userInput > favNumber) ;

   // Console.WriteLine("{userInput} is to high");
    
              //  else
        
            //Console.WriteLine("You guessed it!");