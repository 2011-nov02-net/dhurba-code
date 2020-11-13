using System;


namespace rock_paper_scissor
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello there put your input- Rock, Scissor or Paper");
            string input = Console.ReadLine();
            //   Console.WriteLine(input);
            int sum = 0;
            string[] myArray = { "rock", "paper", "scissors" };
            string player2 = "rock";

            if (input.ToLower() == player2)
            {
                Console.WriteLine("You Won");
                sum += 1;
                Console.WriteLine($"you won {sum} times.");
            }
            else if (input.ToLower() == null || input == "")
            {
                Console.WriteLine("Please enter- either rock or paper or sissor");
                string input2 = Console.ReadLine();
                youWon(input2);

                Console.WriteLine($"you won {sum} times.");

            }
            else { Console.WriteLine("You lost, better luck next time"); }

            void youWon(string a)
            {
                if (a.ToLower() == "rock")
                {
                    Console.WriteLine("You Won");
                    sum++;
                }
                else { Console.WriteLine("You lost, better luck next time"); }
            }

        }
    }
}
