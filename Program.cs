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
                Console.WriteLine("ARTISTS- View all artists");
                Console.WriteLine("ALBUMS - View all albums");
                Console.WriteLine("SONGS - View all songs");
                Console.WriteLine("UNSIGNED - All our unsigned artists");
                Console.WriteLine("RELEASE - Release an artist");
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
                        //show all the artists by name and show all the info assoctiated with that artist.


                        artists.OrderBy(artistName => artistName.Name);
                        Console.WriteLine();
                        Console.WriteLine("Here are all our artists!");
                        Console.WriteLine();
                        foreach (var artist in artists)
                        {
                            Console.WriteLine($"Artist name: {artist.Name}");
                            Console.WriteLine($"From: {artist.CountryOfOrigin}");
                            Console.WriteLine($"{artist.NumberOfMembers} member/members");
                            Console.WriteLine($"Website: {artist.Website}");
                            Console.WriteLine($"Contact: {artist.ContactName} {artist.ContactPhoneNumber}");
                            Console.WriteLine($"Genre: {artist.Style}");

                        }
                        //ask the user if they want to add an artist
                        //if "yes" then prompt user to fill out the proper info
                        //if "no" return to menu
                        Console.WriteLine();
                        Console.WriteLine("Would you like to add a new artist, yes or no?");
                        var option = Console.ReadLine().ToUpper().Trim();
                        if (option == "yes")
                        {
                            //this is how we add an artist(s)
                            var newArtist = new Artists
                            {
                                Name =
                            CountryOfOrigin =
                            NumberOfMembers =
                            Website =
                            ContactName =
                            ContactNumber =
                            };


                        }


                        break;

                    case "ALBUMS":

                        //show the collection of albums ordered by release date
                        //ask user if they want to add an album
                        //if "yes" then have the user fill out album info
                        //if "no" return to menu
                        albums.OrderBy(albumsDate => albumsDate.ReleaseDate);
                        Console.WriteLine();
                        Console.WriteLine("This is our collection of albums!");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Would you like to add an album, yes or no?");
                        var yesOrNo = Console.ReadLine().ToUpper().Trim();
                        if (yesOrNo == "yes")
                        {
                            //add a new album
                            var newAlbum = new Albums
                            {
                                Title =
                                IsExplicit =
                                ReleaseDate =
                                ArtistId =
                            };

                        }

                        break;

                    case "SONGS":
                        //show the user all the songs order by  track number, title, and duration
                        songs.OrderBy(songTitle => songTitle.Title);
                        Console.WriteLine();
                        Console.WriteLine("Here are all your songs!");
                        foreach (var song in songs)
                        {
                            Console.WriteLine($" Track number{song.TrackNumber}, title{song.Title}, and duration{song.Duration}.");



                        }


                        break;

                    case "UNSIGNED":
                        // show all the unsigned artist 
                        //ask the user if they want to sign any of the artist
                        //console.WriteLine("Would you like to sign one of these artists?");
                        //var signArtist = Console.ReadLine().ToUpper().Trim();
                        //if = "yes"
                        //Console.WriteLine("Which of these artists would you like to sign?")
                        //Consol.ReadLine():
                        //not sure how to tie in the artist to user choice.
                        // if = "no" then return to menu
                        //update the the unsigned artists to reflect user choice
                        // var existingArtist= context.Artists.FirstOrDefault(band => band.Name == )
                        // if (existingArtist != null) 
                        // {
                        // context.Artist.Remove(existingArtist);
                        // context.SaveChanges();
                        // };

                        break;






                }














            }












        }
    }
}
