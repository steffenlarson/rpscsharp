using System;
using System.Threading;

namespace rpscsharp
{
  class Program
  {
    static void Main(string[] args)
    {
      bool running = true;
      while (running)
      {


        Console.Clear();

        Console.WriteLine(@"
      
      Lets Get Ready to Rumble! Rock Paper Scissors Style!
");

        Console.WriteLine(@"

      Press P to play, or Q to quit:
      If you play your choices are Rock,Paper, or Scissors
");



        ConsoleKeyInfo choice = Console.ReadKey();
        Console.WriteLine();
        if (choice.Key == ConsoleKey.P)
        {

          Console.WriteLine(@"
          Make your Choice: 
          Rock, Paper, Scissors
          ");

          string playerChoice = Console.ReadLine();

          Random rnd = new Random();
          string[] compChoice = new string[3];
          compChoice[0] = "Rock";
          compChoice[1] = "Paper";
          compChoice[2] = "Scissors";

          int cIndex = rnd.Next(compChoice.Length);

          Console.WriteLine("The computer chose " + compChoice[cIndex]);

          if (playerChoice == compChoice[cIndex])
          {
            Console.WriteLine("You Tied!");
          }
          else if (playerChoice == "Rock" && compChoice[cIndex] == "Scissors")
          {
            Console.WriteLine("You Win!");
          }
          else if (playerChoice == "Rock" && compChoice[cIndex] == "Paper")
          {
            Console.WriteLine("You Lose!");
          }
          else if (playerChoice == "Paper" && compChoice[cIndex] == "Rock")
          {
            Console.WriteLine("You Win!");
          }
          else if (playerChoice == "Paper" && compChoice[cIndex] == "Scissors")
          {
            Console.WriteLine("You Lose!");
          }
          else if (playerChoice == "Scissors" && compChoice[cIndex] == "Paper")
          {
            Console.WriteLine("You Win!");
          }
          else if (playerChoice == "Scissors" && compChoice[cIndex] == "Rock")
          {
            Console.WriteLine("You Lose!!!");
          }

          Thread.Sleep(1500);
        }
        else if (choice.Key == ConsoleKey.Q)
        {
          running = false;
        }
        else
        {
          System.Console.WriteLine("invalid command");

        }
      }
    }
  }
}
