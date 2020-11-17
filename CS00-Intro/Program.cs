using System;

namespace SampleProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Who are you?");
            var name = Console.ReadLine();
            Console.WriteLine("Fuck you, " + name + "!");

            Console.WriteLine("How many days did you live?");
            int ageInDays = Convert.ToInt32(Console.ReadLine());
            int years = ageInDays / 365;
            int months = (ageInDays - years * 365) / 12;
            int days = (ageInDays - years * 365) % 30;

            Console.WriteLine("You are " + years + " years " + months + 
                              " months " + days+ " days old.");

            if (years < 18)
            {  
                Console.WriteLine("Filthy zoomer.");
            }
            else
            {
                for (int i = 0; i < 10; i++)
                    Console.Write(i + " ");
                Console.WriteLine("\n Congratulations! You have stoped being a brat!");
            }

        }
    }
}
