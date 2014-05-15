using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    class Program
    {
        static List<string> Contents = File.ReadAllText("trivia.txt").Replace("\r", "").Split('\n').ToList();
        static int incorrect = 0;
        static int correct = 0;
        static bool playing = true;


        static void Main(string[] args)
        {

            Welcome();
          
            GetTriviaList();
            while (playing)
            {
                userInput();
                GameOver();
            }


            Console.ReadKey();
        }

        static void Welcome()
        {


            Console.WriteLine("Are you ready to get started?");
            var yn = Console.ReadLine();
            if (yn == "yes" || yn == "Yes")
            {
                Console.WriteLine("Lets do this!");
            }
            else if (yn == "no" || yn == "No")
            {
                Console.WriteLine("Yo, what's wrong with you?");
            }
            else
            {
                Console.WriteLine("get outta here.");
            }
        }

        static List<Trivia> GetTriviaList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Replace("\r", "").Split('\n').ToList();













            return new List<Trivia>();
        }
        static void userInput()
        {
            var randomGen = new Random();
            var realRandomGen = randomGen.Next(1, Contents.Count);
            var question = Contents[realRandomGen].Split('*')[0];
            var answer = Contents[realRandomGen].Split('*')[1];




            Console.WriteLine(question);
            var input = Console.ReadLine();
            if (input == answer)
            {

                correct++;
                Console.WriteLine("Correct: " + correct);
            }
            else
            {

                incorrect++;
                Console.WriteLine("Incorrect: " + incorrect);
                Console.WriteLine("Sorry, the actual answer is: " + answer);
            }







        }
        static void GameOver()
        {
            if (correct == 10)
            {
                Console.WriteLine("Sweet dude you win, you're a boss!");
                Console.WriteLine("Not really, you still have no life");
                playing = false;
            }
            else if (incorrect == 10)
            {
                Console.WriteLine("Wow really dude, have you accomplished anything?");
                playing = false;

            }
            








        }
        static void Category()
        {



        }

      
        

    }
}





