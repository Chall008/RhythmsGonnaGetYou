using System;
using System.Collections.Generic;

namespace RhythmsGonnaGetYou
{
    class Program
    {
        // static List<Artist> Artists(List<Artist> artists)
        // {
        //   foreach


        // }
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

                BannerMessage("~~~~~~ CH RECORDS ~~~~~~");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("MENU OPTIONS:");
                Console.WriteLine("ARTIST- View all artists");
                Console.WriteLine("ALBUMS - View all albums");
                Console.WriteLine("SONGS - View all songs");
                Console.WriteLine("EXIT - Exit the application");
                Console.WriteLine();
                Console.WriteLine("Please chose one.");
                var choice = Console.ReadLine().ToUpper().Trim();
                if (choice == "EXIT")
                {
                    userHasChosenToExit = true;
                }
                switch (choice)
                {
                    case "ARTISTS":

                        artist.OrderBy(artistName => artistName.Name);
                        Console.WriteLine();
                        Console.WriteLine("Here are all our artists!");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Would you like to add a new artist, yes or no?);
                        var option = Console.ReadLine().ToUpper().Trim();
                        if (option == "yes")



                            break;

                    case "ALBUMS":


                        albums.OrderBy(albumsDate => albumsDate.ReleaseDate);
                        Console.WriteLine();
                        Console.WriteLine("This is our collection of albums!");



                        break;

                    case "SONGS":

                        songs.OrderBy( => artistName.Name);
                        Console.WriteLine();
                        Console.WriteLine("Here are all our artists!");


                        break;

                    case "CONTRACTS":

                        break;

                    case "ADD":

                        Console.WriteLine("Would you like to add an Artist, Album, or Song? ");
                        Console.ReadLine();

                        break;




                }














            }












        }
    }
}
