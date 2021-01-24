using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            var context = new RhythmsGonnaGetYouContext();

            var userHasChosenToExit = false;

            while (userHasChosenToExit == false)
            {

                BannerMessage("~~~~~~ CH RECORDS ~~~~~~");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("MENU OPTIONS:");
                Console.WriteLine("ARTISTS - View all artists");
                Console.WriteLine("ADD ARTIST - Add a new artist.");
                Console.WriteLine("ALBUMS - View all albums");
                Console.WriteLine("ADD ALBUMS - Add a new album");
                Console.WriteLine("SONGS - View all songs");
                Console.WriteLine("ADD SONGS - Add a new song");
                Console.WriteLine("UNSIGNED - Take a look at our unsigned artists");
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
                        var viewArtists = context.Artists;
                        viewArtists.OrderBy(artistOrder => artistOrder.Name);
                        Console.WriteLine();
                        Console.WriteLine("Here are all our artists!");
                        Console.WriteLine();
                        foreach (var artist in viewArtists)
                        {
                            Console.WriteLine($"Artist name: {artist.Name}");

                        }
                        //ask the user if they want to add an artist
                        //if "yes" then prompt user to fill out the proper info
                        //if "no" return to menu
                        // Console.WriteLine();
                        // Console.WriteLine("Would you like to add a new artist, y/n?");
                        // var option = Console.ReadLine().ToUpper().Trim()

                        break;


                    case "ADD ARTIST":
                        break;
                    // //     var newArtist = new Artists
                    // //     {
                    // //         Name =
                    // //     CountryOfOrigin =
                    // //     NumberOfMembers =
                    // //     Website =
                    // //     ContactName =
                    // //     ContactNumber =
                    // //     };
                    // //     context.Bands.Add(newBand);
                    // //     context.SaveChanges();

                    case "ALBUMS":

                        //show the collection of albums ordered by release date
                        //ask user if they want to add an album
                        //if "yes" then have the user fill out album info
                        //if "no" return to menu

                        var viewAlbums = context.Albums.Include(Album => Album.Artist);
                        viewAlbums.OrderBy(albumsDate => albumsDate.ReleaseDate);
                        Console.WriteLine();
                        Console.WriteLine("This is our collection of albums!");
                        Console.WriteLine();
                        foreach (var album in viewAlbums)
                        {

                            Console.WriteLine($" Album {album.Title} by {album.Artist.Name}");



                        }

                        break;
                    case "ADD ALBUM":
                        //     var newAlbum = new Albums
                        //     {
                        //         Title =
                        //         IsExplicit =
                        //         ReleaseDate =
                        //         ArtistId =
                        //     };
                        //     context.Albums.Add(newAlbums);
                        //     context.SaveChanges();




                        break;

                    case "SONGS":

                        // // var allSongs = context.Songs.Include(song => song.Album).ThenInclude(Album => Album.Artist);
                        // // allSongs.OrderBy(songOrders => songOrders.TrackNumber);
                        // Console.WriteLine();
                        // Console.WriteLine("Here are all your songs!");
                        // // Console
                        // // foreach (var song in allSongs)
                        // // {
                        // //     Console.WriteLine($" Song title: {song.Title} ");
                        // //     Console.WriteLine($" Artist: {song.Album.Artist.Name} ");
                        // //     Console.WriteLine($" Album: { song.Album.Title} ");

                        // // }


                        break;


                    case "ADD SONGS":

                        //     var newSong = new Songs
                        //     {
                        //         Title =
                        //         IsExplicit =
                        //         ReleaseDate =
                        //         ArtistId =
                        //     };
                        //     context.Albums.Add(newAlbums);
                        //     context.SaveChanges();


                        break;

                    case "UNSIGNED":


                        break;
                    case "RELEASE":


                        // var existingArtist= context.Artists.FirstOrDefault(band => band.Name == )
                        // if (existingArtist != null) 
                        // {
                        // context.Artist.Remove(existingArtist);
                        // context.SaveChanges();
                        // };

                        break;


                    default:
                        break;

                }






            }

        }

    }

}
