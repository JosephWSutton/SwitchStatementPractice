using System;

namespace SelectionStatementPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your user name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is your favorite subject in school");
            string favSub = Console.ReadLine();
            SubList(favSub, userName); 
        }
        public static void SubList(string favSub, string userName)
        {
            switch (favSub.ToLower())
            {
                case "math":
                    Console.WriteLine("Nerd");
                    break;
                case "english":
                    Console.WriteLine("To be or not to be, what a swell guy");
                    break;
                case "history":
                    Console.WriteLine($"Mr. {userName}, tear down this wall");
                    break;
                default:
                    Console.WriteLine("Where do you go to school, Hogwarts??");
                    break;

            }
        }

    }
}
