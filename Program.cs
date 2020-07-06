using System;
using System.Collections.Generic;
using System.Threading;
namespace rockGame
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.Write("hello! what is your name?");
      System.Diagnostics.Process.Start("say", ("Hello, what is your name?"));
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! do you want to play rock, paper, scissors, lizard, spock?");
      System.Diagnostics.Process.Start("say", ($"Hello {name} do you want to play"));
      bool valid = false;
      ConsoleColor foreColor = Console.ForegroundColor;
      Random rand = new Random();
      int wins = 0;
      int losses = 0;
      string[] gameChoices = { "rock", "paper", "scissors", "lizard", "spock" };
      while (!valid)
      {
        Console.WriteLine("\nContinue? (y/n)");
        Console.WriteLine("\nif you choose n you will lose all saved wins/losses");
        char choice = Console.ReadKey().KeyChar;
        if (choice == 'y')
        {
          Thread.Sleep(100);
          Console.Clear();
          string greeting = "You will Never WIN!!";
          if (wins == 0)
          {
            System.Diagnostics.Process.Start("say", ("you will never win!!"));
            for (int i = 0; i < greeting.Length; i++)
            {
              Console.Write(greeting[i]);
              Thread.Sleep(50);
            }
            Console.WriteLine("");
          }
          if (wins > losses)
          {
            System.Diagnostics.Process.Start("say", ("again"));
          }
          if (losses > wins)
          {
            System.Diagnostics.Process.Start("say", ("loser"));
          }
          Console.ForegroundColor = ConsoleColor.DarkGreen;
          Console.WriteLine($"wins: {wins}");
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine($"losses: {losses}");
          Console.ForegroundColor = foreColor;
          Console.WriteLine("make your choice! \n rock, paper, scissors, lizard, or spock!");
          string PChoice = Console.ReadLine().ToLower();
          int GIndex = rand.Next(gameChoices.Length);
          Console.WriteLine("computer chose {0}", gameChoices[GIndex]);
          if (gameChoices[GIndex] == PChoice)
          {
            Thread.Sleep(500);
            Console.WriteLine("tie Game");
            System.Diagnostics.Process.Start("say", ("wow...so original"));
          }
          if (gameChoices[GIndex] == "rock" && PChoice == "paper")
          {
            Thread.Sleep(500);
            Console.WriteLine("paper covers rock!");
            Console.WriteLine("wins:" + ++wins);
            System.Diagnostics.Process.Start("say", ("How"));
          }
          if (gameChoices[GIndex] == "rock" && PChoice == "spock")
          {
            Thread.Sleep(500);
            Console.WriteLine("spock vaporizes rock");
            Console.WriteLine("wins:" + ++wins);
            System.Diagnostics.Process.Start("say", ("How"));

          }
          if (gameChoices[GIndex] == "paper" && PChoice == "scissors")
          {
            Thread.Sleep(500);
            Console.WriteLine("scissors cuts paper!");
            Console.WriteLine("wins:" + ++wins);
            System.Diagnostics.Process.Start("say", ("How"));
          }
          if (gameChoices[GIndex] == "paper" && PChoice == "lizard")
          {
            Thread.Sleep(500);
            Console.WriteLine("lizard eats paper!");
            Console.WriteLine("wins:" + ++wins);
            System.Diagnostics.Process.Start("say", ("How"));
          }
          if (gameChoices[GIndex] == "scissors" && PChoice == "rock")
          {
            Thread.Sleep(500);
            Console.WriteLine("rock breaks scissors");
            Console.WriteLine("wins:" + ++wins);
            System.Diagnostics.Process.Start("say", ("How"));
          }
          if (gameChoices[GIndex] == "scissors" && PChoice == "spock")
          {
            Thread.Sleep(500);
            Console.WriteLine("spock smashes scissors");
            Console.WriteLine("wins:" + ++wins);
            System.Diagnostics.Process.Start("say", ("How"));
          }
          if (gameChoices[GIndex] == "lizard" && PChoice == "rock")
          {
            Thread.Sleep(500);
            Console.WriteLine("rock crushes lizard");
            Console.WriteLine("wins:" + ++wins);
            System.Diagnostics.Process.Start("say", ("How"));
          }
          if (gameChoices[GIndex] == "lizard" && PChoice == "scissors")
          {
            Thread.Sleep(500);
            Console.WriteLine("scissors decapitates lizard!");
            Console.WriteLine("wins:" + ++wins);
            System.Diagnostics.Process.Start("say", ("How"));
          }
          if (gameChoices[GIndex] == "spock" && PChoice == "lizard")
          {
            Thread.Sleep(500);
            Console.WriteLine("lizard poisons spock");
            Console.WriteLine("wins:" + ++wins);
            System.Diagnostics.Process.Start("say", ("How"));
          }
          if (gameChoices[GIndex] == "spock" && PChoice == "paper")
          {
            Thread.Sleep(500);
            Console.WriteLine("paper disproves spock!");
            Console.WriteLine("wins:" + ++wins);
            System.Diagnostics.Process.Start("say", ("How"));
          }
          if (gameChoices[GIndex] == "rock" && PChoice == "scissors")
          {
            Thread.Sleep(500);
            Console.WriteLine("rock breaks scissors");
            Console.WriteLine("losses:" + ++losses);
            System.Diagnostics.Process.Start("say", ("ha ha"));


          }
          if (gameChoices[GIndex] == "rock" && PChoice == "lizard")
          {
            Thread.Sleep(500);
            Console.WriteLine("rock crushes lizard!");
            Console.WriteLine("losses:" + ++losses);
            System.Diagnostics.Process.Start("say", ("ha ha"));


          }
          if (gameChoices[GIndex] == "paper" && PChoice == "rock")
          {
            Thread.Sleep(500);
            Console.WriteLine("paper covers rock!");
            Console.WriteLine("losses:" + ++losses);
            System.Diagnostics.Process.Start("say", ("ha ha"));

          }
          if (gameChoices[GIndex] == "paper" && PChoice == "spock")
          {
            Thread.Sleep(500);
            Console.WriteLine("paper disproves spock!");
            Console.WriteLine("losses:" + ++losses);
            System.Diagnostics.Process.Start("say", ("ha ha"));

          }
          if (gameChoices[GIndex] == "scissors" && PChoice == "paper")
          {
            Thread.Sleep(500);
            Console.WriteLine("scissors cuts paper!");
            Console.WriteLine("losses:" + ++losses);
            System.Diagnostics.Process.Start("say", ("ha ha"));

          }
          if (gameChoices[GIndex] == "scissors" && PChoice == "lizard")
          {
            Thread.Sleep(500);
            Console.WriteLine("scissors decapitates lizard!");
            Console.WriteLine("losses:" + ++losses);
            System.Diagnostics.Process.Start("say", ("ha ha"));

          }
          if (gameChoices[GIndex] == "lizard" && PChoice == "spock")
          {
            Thread.Sleep(500);
            Console.WriteLine("lizard poisons spock!");
            Console.WriteLine("losses:" + ++losses);
            System.Diagnostics.Process.Start("say", ("ha ha"));

          }
          if (gameChoices[GIndex] == "lizard" && PChoice == "paper")
          {
            Thread.Sleep(500);
            Console.WriteLine("lizard eats paper!");
            Console.WriteLine("losses:" + ++losses);
            System.Diagnostics.Process.Start("say", ("ha ha"));

          }
          if (gameChoices[GIndex] == "spock" && PChoice == "rock")
          {
            Thread.Sleep(500);
            Console.WriteLine("spock vaporizes rock!");
            Console.WriteLine("losses:" + ++losses);
            System.Diagnostics.Process.Start("say", ("ha ha"));

          }
          if (gameChoices[GIndex] == "spock" && PChoice == "scissors")
          {
            Thread.Sleep(500);
            Console.WriteLine("spock smashes scissors!");
            Console.WriteLine("losses:" + ++losses);
            System.Diagnostics.Process.Start("say", ("ha ha"));

          }
          Console.WriteLine();
          Thread.Sleep(500);
        }
        if (choice == 'n')
        {
          Console.WriteLine("");
          valid = true;
        }
        else
        {
          Console.WriteLine("");
          Console.WriteLine("invalid entry");
        }
      }
    }
  }
}
