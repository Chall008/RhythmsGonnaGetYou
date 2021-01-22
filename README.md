## Problem:

- We are starting a record label company named ”Record Company Name”. We need to create an app that stores our bands,albums and songs data.

C R U D

- Create: Create Albums, Songs, & Bands
- Read: View the Bands, Albums, and Albums of Specific Bands
- Update: Release a Band from Contract and Resign a Band
- Delete: Not Deleting any information from the Database

## EXAMPLES:

Jams has released Artist Clutch from their 4 yr contract.

Jams signed The Killers, they have 6 albums.

View a list of all of Jams Albums.

Clutch added a digital release of Track 4 on the Album Elephant Riders
Black Flags discography.

Artist 7 Seconds has signed with Jams.
7 Seconds has 11 Albums with a total of 96 Tracks.

CH Records has signed the band Nirvana. Nirvana has 2 albums and plans to release two more songs.

CH Records signed two more bands, Cookie Monsters & White Lightning. White Lightning just added a new song to their album “Prohibition” called “This drinks for you”. Even though Cookie Monsters is new signed, they already have 2 studio albums.

CH Records is not happy with the Chunky Boyz and plans to drop their contract

## DATA:

SQL:
Create a database in SQL called “RhythmsGonnaGetYou”
Create table for Bands, Albums, and Songs.
Tie them together thru Id
INSERT INTO those databases random generated bands, albums, and songs.

VS CODE:
Create a “Welcome to (Record Label Name).
Create a class for: Bands, Albums, Songs, and Context.
Create menu options:

    Albums - View all albums.
    Bands - View all bands.
    Songs - View all songs.
    Contract - Update contracts to sign or drop.
    Add- Bands, Songs, Albums.
    EXIT- Exit the app.

## ALGORITHM:

SQL

RhythmsGonnaGetYou> SELECT _ FROM "Songs";
+------+---------------+---------------------+------------+-----------+
| Id | TrackNumber | Title | Duration | AlbumId |
|------+---------------+---------------------+------------+-----------|
| 1 | 5 | Midsummer Madness | 04:41:00 | <null> |
| 2 | 2 | Peach Jam | 02:42:00 | <null> |
| 3 | 12 | La La Lost You | 03:20:00 | <null> |
| 4 | 10 | Fashion Killa | 03:56:00 | <null> |
| 5 | 8 | Wild for the Nights | 03:33:00 | <null> |
| 6 | 5 | Ray Charles | 02:48:00 | <null> |
| 7 | 9 | Tequila Little Time | 03:27:00 | <null> |
| 8 | 15 | Bar Downtown | 03:24:00 | <null> |
| 9 | 11 | Dynamite | 03:19:00 | <null> |
+------+---------------+---------------------+------------+-----------+
SELECT 9
Time: 0.012s
RhythmsGonnaGetYou> SELECT _ FROM "Artists";
+------+-------------+-------------------+-------------------+----------------+------------+---------------+----------------------+
| Id | Name | CountryOfOrigin | NumberOfMembers | Website | IsSigned | ContactName | ContactPhoneNumber |
|------+-------------+-------------------+-------------------+----------------+------------+---------------+----------------------|
| 1 | ASAP Rocky | United States | 1 | asapmob.com | True | Rocky | 8135550000 |
| 2 | Chiddy Bang | United States | 2 | chiddybang.com | False | Chiddy | 7275550000 |
| 3 | Jon Pardi | United States | 1 | jonpardi.com | True | Jon | 6965550000 |
| 4 | BTS | South Korea | 7 | bts.com | True | Vee | 23123456 |
| 5 | 88 Rising | Asia | 14 | 88rising.com | True | Rich Brian | 937555123456 |
+------+-------------+-------------------+-------------------+----------------+------------+---------------+----------------------+
SELECT 5
Time: 0.012s
RhythmsGonnaGetYou>
RhythmsGonnaGetYou> SELECT \* FROM "Albums";
+------+----------------------+--------------+---------------+------------+
| Id | Title | IsExplicit | ReleaseDate | ArtistId |
|------+----------------------+--------------+---------------+------------|
| 1 | LONG.LIVE.ASAP | True | 2013-01-05 | <null> |
| 2 | Breakfast | True | 2012-02-21 | <null> |
| 3 | Heartache Medication | False | 2019-09-27 | <null> |
| 4 | Head in the Clouds | True | 2018-07-20 | <null> |
| 5 | Head in the Clouds 2 | True | 2019-10-11 | <null> |
+------+----------------------+--------------+---------------+------------+
SELECT 5

VS CODE:
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL

class Program
{
static void BannerMessage(string message)
{
// Create a greeting and a goodbye: BannerMessage();

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine(message);
    Console.WriteLine();
    Console.WriteLine();

}
}

Create a class for: Bands, Albums, Songs, and Context.

class Artists
{
public int Id {get; set; }
public string Name {get; set; }
public string CountryOfOrigin {get; set; }
public int NumberOfMembers {get; set; }
public string Website {get; set; }
public bool IsSigned {get; set; }
public string ContactName {get; set; }
public int ContactPhoneNumber {get; set; }

//after you add album into dbcontext
public int AlbumId {get; set;}
public Album Album {get; set; }
//after you add song into dbcontext
public int

}

class RhythmsGonnaGetYouContext : DbContext
{
public Dbset<Artist> Artists {get; set; }

public Dbset<Album> Albums {get; set; }

public Dbset<Song> Songs {get; set; }

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
optionsBuidlder.UseNpgsql("server=localhost;database=RhythmsGonnaGetYou");

}

}

class Albums
{
public int Id {get; set; }
public string Title {get; set;}
public bool IsExplicit {get; set;}
public DateTime ReleaseDate {get; set; }
public int ArtistId {get; set; }

//create the class then add to context

}

class Songs
{
public int Id {get; set;}
public int TrackNumber {get; set;}
public string {get; set;}
public //I don't know how to add duration//
public int AlbumId {get; set;}

//create the dbcontext after the class is built

}
Create menu options:

    View - View bands, albums, songs

    OR

    Artists - View all Artist
    Albums - View all Albums
    Songs - View all Songs
    Contracts - Update contracts to sign or drop.
    Add -
    EXIT- Exit the app.

      var userHasChosenToExit = false;

      while (userHasChosenToExit == false)
        {
          Console.ForegroundColor = ConsoleColor.Blue;
          BannerMessage("Welcome to First Bank Of Suncoast!!! ");
          Console.WriteLine();
          Console.WriteLine();
          Console.WriteLine("MENU OPTIONS:");
          Console.WriteLine("ARTISTS - View all artists");
          Console.WriteLine("ALBUMS - View all albums");
          Console.WriteLine("SONGS - View all songs);
          Console.WriteLine("CONTRACTS - );
          Console.WriteLine("ADD - Add new artists, albums, or songs");
          Console.WriteLine("EXIT - Exit the application");
          Console.WriteLine();
          Console.WriteLine("What would you like to use? ");

            var choice = Console.ReadLine().ToUpper().Trim();
               if (choice == "EXIT")
                  {
                    userHasChosenToEXIT = true;
                  }
        }
