using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlaylistAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var songsOverTwoHundred = from song in songs where song.Plays >= "200" orderby song.Plays descending select song;
            var alternativeSongs = from song in songs where song.Genre == "Pop" orderby song.Year descending select song;
            var popSongsByYearDescending = from song in songs where song.Genre == "Alternative" orderby song.Number select song;
            var songsInFishbowl = from song in songs where song.Genre == "Pop" orderby song.WelcomeToTheFishBowl descending select song;
            var earlySongs = from song in songs where song.Genre == "Any" orderby song.Year descending select song;
            var longSongs = from song in songs where song.Genre == "Any" orderby song.Length descending select song;
            var longestSong = from song in songs where song.Genre == "Any" orderby song.Time descending select song;


            Console.WriteLine("How many songs received 200 or more plays?");
            Console.ReadLine(songsOverTwoHundred);
            

            Console.WriteLine("How many songs are in the playlist with the Genre of “Alternative”?");
            Console.ReadLine(alternativeSongs);

            Console.WriteLine("How many songs are in the playlist with the Genre of “Hip-Hop/Rap”?");
            Console.ReadLine(popSongsByYearDescending);

            Console.WriteLine("What songs are in the playlist from the album “Welcome to the Fishbowl?”");
            Console.ReadLine(songsInFishbowl);

            Console.WriteLine("What are the songs in the playlist from before 1970?");
            Console.ReadLine(earlySongs);

            Console.WriteLine("What are the song names that are more than 85 characters long?");
            Console.ReadLine(longSongs);

            Console.WriteLine("What is the longest song? (longest in Time)");
            Console.ReadLine(longestSong);

        }
    }
}
