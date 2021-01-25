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

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine();

        }
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
                Console.WriteLine("ARTISTS - View all signed artists");
                Console.WriteLine("ADD ARTIST - Add a new artist.");
                Console.WriteLine("ARTIST ALBUMS - View an artist and their albums!");
                Console.WriteLine("ALL ALBUMS - View all albums");
                Console.WriteLine("ADD ALBUM - Add a new album");
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
                        var viewArtists = context.Artists.Where(Artist => Artist.IsSigned);
                        viewArtists.OrderBy(artistOrder => artistOrder.Name);
                        Console.WriteLine();
                        Console.WriteLine("Here are all our artists!");
                        Console.WriteLine();

                        foreach (var artist in viewArtists)
                        {
                            Console.WriteLine($"Artist name: {artist.Name}");

                        }
                        break;


                    case "ADD ARTIST":


                        var newArtist = new Artist();
                        Console.WriteLine();
                        Console.WriteLine("What's the name of the new artist?");
                        var userAddsArtist = Console.ReadLine();
                        Console.WriteLine($"Where is {userAddsArtist}from?");
                        var userAddsCountry = Console.ReadLine();
                        Console.WriteLine($"How many members are with {userAddsArtist}?");
                        var userAddsMembers = int.Parse(Console.ReadLine());
                        Console.WriteLine("What is their website?");
                        var userAddsWebsite = Console.ReadLine();
                        Console.WriteLine($"Is {userAddsArtist} signed?");
                        var userSigned = Console.ReadLine();
                        if (userSigned == "yes")
                        {
                            newArtist.IsSigned = true;

                        }
                        else
                        {
                            newArtist.IsSigned = false;

                        }
                        Console.WriteLine($"Can I get a contact name for {userAddsArtist}?");
                        var userContactName = Console.ReadLine();
                        Console.WriteLine($"Can I also get a contact phone number for {userAddsArtist}");
                        var userContactPhone = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Lastly, what is {userAddsArtist}'s style?");
                        var userStyle = Console.ReadLine();
                        Console.WriteLine($"Thank you for adding {userAddsArtist} to CH Records!");

                        newArtist.Name = userAddsArtist;
                        newArtist.CountryOfOrigin = userAddsCountry;
                        newArtist.NumberOfMembers = userAddsMembers;
                        newArtist.Website = userAddsWebsite;
                        newArtist.ContactName = userContactName;
                        newArtist.ContactPhoneNumber = userContactPhone;
                        newArtist.Style = userStyle;

                        context.Artists.Add(newArtist);
                        context.SaveChanges();

                        break;


                    // case "ARTIST ALBUMS":
                    // // capture a string 
                    // // compare a list of strings to the list of Artist
                    // // look albums that this artist can contain
                    // // build upon that 

                    // var artistAndAlbums = context.Artists.FirstOrDefault(artist => artist.Name);
                    // Console.WriteLine();
                    // Console.WriteLine("Which artist are you looking for?");
                    // var userInput = Console.ReadLine();


                    case "ALL ALBUMS":

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

                        var newAlbum = new Album();
                        Console.WriteLine();
                        Console.WriteLine("What is the name of the new album?");
                        var albumName = Console.ReadLine();
                        Console.WriteLine($"Is {albumName} explict?");
                        var albumExplicit = Console.ReadLine();
                        if (albumExplicit == "yes")
                        {
                            newAlbum.IsExplicit = true;

                        }
                        else
                        {
                            newAlbum.IsExplicit = false;

                        }
                        Console.WriteLine($"When was {albumName} released? ");
                        var albumReleased = Console.ReadLine();
                        Console.WriteLine($"Who is the {albumName} by?");
                        var newAlbumArtist = context.Artists.FirstOrDefault(artist => artist.Name == Console.ReadLine());

                        newAlbum.Title = albumName;
                        newAlbum.ReleaseDate = albumReleased;
                        newAlbum.ArtistId = newAlbumArtist.Id;

                        context.Albums.Add(newAlbum);
                        context.SaveChanges();


                        break;

                    case "SONGS":

                        var allSongs = context.Songs.Include(song => song.Album).ThenInclude(Album => Album.Artist);
                        Console.WriteLine();
                        Console.WriteLine("Here are all your songs!");
                        Console.WriteLine();
                        foreach (var song in allSongs)
                        {
                            Console.WriteLine($" Song title: {song.Title} ");
                            Console.WriteLine($" Artist: {song.Album.Artist.Name} ");
                            Console.WriteLine($" Album: { song.Album.Title} ");

                        }


                        break;


                    case "ADD SONGS":

                        var newAddedSong = new Song();
                        Console.WriteLine();
                        Console.WriteLine("Can I get the title of the new song?");
                        var newTitle = Console.ReadLine();
                        Console.WriteLine($"How long is {newTitle}?");
                        var newDuration = Console.ReadLine();
                        Console.WriteLine("What is the tracknumber?");
                        var newTrackNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Which album does {newTitle} belong to?");
                        var newSongAlbum = context.Albums.FirstOrDefault(album => album.Title == Console.ReadLine());


                        newAddedSong.Title = newTitle;
                        newAddedSong.Duration = newDuration;
                        newAddedSong.TrackNumber = newTrackNumber;
                        newAddedSong.AlbumId = newSongAlbum.Id;


                        context.Songs.Add(newAddedSong);
                        context.SaveChanges();


                        break;

                    case "UNSIGNED":

                        var viewAUnsignedArtists = context.Artists.Where(Artist => Artist.IsSigned == false);
                        Console.WriteLine();
                        Console.WriteLine("Take a look at our up and coming artists!");
                        Console.WriteLine();
                        foreach (var artist in viewAUnsignedArtists)
                        {

                            Console.WriteLine($"Name {artist.Name}");

                        }

                        break;
                    case "RELEASE":

                        Console.WriteLine("What is the artist name you would like to release?");
                        var releasedName = Console.ReadLine();
                        var existingArtist = context.Artists.FirstOrDefault(artist => artist.Name == releasedName);
                        existingArtist.IsSigned = false;
                        context.SaveChanges();


                        break;


                    default:
                        break;


                }


                BannerMessage("~~~~~~ Thanks for visiting CH Records! ~~~~~~");


            }

        }

    }

}
