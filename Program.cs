using System;

namespace RhythmsGonnaGetYou
{
    class Program
    {

        static void BannerMessage(string message)
        {
            //  Create a greeting and a goodbye: BannerMessage();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine();

        }


        //static void 
        static void Main(string[] args)
        {

            var userHasChosenToExit = false;

            while (userHasChosenToExit == false)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                BannerMessage("~~~~~~ CH RECORDS ~~~~~~");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("MENU OPTIONS:");
                Console.WriteLine("ARTISTS - View all artists");
                Console.WriteLine("ALBUMS - View all albums");
                Console.WriteLine("SONGS - View all songs");
                Console.WriteLine("CONTRACTS - Signed or Unsigned Artists");
                Console.WriteLine("ADD - Add new artists, albums, or songs");
                Console.WriteLine("EXIT - Exit the application");
                Console.WriteLine();
                Console.WriteLine("What would you like to use? ");
                var choice = Console.ReadLine().ToUpper().Trim();
                if (choice == "EXIT")
                {
                    userHasChosenToExit = true;
                }
                switch (choice)
                {
                    // case "ARTISTS":







                }













            }












        }
    }
}
