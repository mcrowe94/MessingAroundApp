using System;

namespace MessingAroundApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Where are you from?");
            var from = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("What's your favorite show?");
            var show = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Do you play video games?");
            var games = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("If yes, what's your favorite game?");
            var game = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("What's your favorite hobby?");
            var hobby = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"Your name is {name}! You're from {from}, you are {age}! " +
                $"You enjoy watching {show}! " +
                $"When you're not watching TV, you enjoy playing {game}! " +
                $"If you're not playing games, you're spending your free time {hobby}!"); 
                

           
             




        }
    }
}
