// music program
using System;
using System.IO;

namespace musicLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring variables
            Music[] music = new Music[10];
            string fileName = "musicbook.txt";
            string userArtist;
            string userSong;
            int row = 0;
            int userRating = 0;

            Console.Write("Please enter a(n) artist: ");
            userArtist = Console.ReadLine();

            Console.Write("Please enter a song by the artist: ");
            userSong = Console.ReadLine();

            Console.Write("Please enter a rating: ");
            userRating = Convert.ToInt32(Console.ReadLine());

            // reading and writing portion
            using (StreamReader sr = File.OpenText(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null && row < music.Length)
                {
                    // split parts based on a delimiter
                    string[] parts = line.Split('-');

                    // assigning parts to rows and loops through
                    if (parts.Length == 3)
                    {
                        string artist = parts[0];
                        string song = parts[1];
                        int rating = Convert.ToInt32(parts[2][0]);

                        music[row] = new Music(artist, song, rating); // stores in an array
                        row++; // increments through rows
                    }
                    // DISPLAYS ALL STUFF THAT'S OPEN Console.WriteLine(line);
                }
            }
            // Music userMusic = new Music(userArtist, userSong, userRating);
        }
    }






    class Music
    {
        // declared variables
        public string Artist { get; set; }
        public string Song { get; set; }
        public int Rating { get; set; }

        // default constructor when no values are passed
        public Music()
        {
            Artist = "";
            Song = "";
            Rating = 0;
        }

        //constructor when two values are passed
        public Music(string artist, string song, int rating)
        {
            this.Artist = artist;
            this.Song = song;
            this.Rating = rating;
        }

        // override tostring for default display
        public override string ToString()
        {
            return $"Artist: {Artist} | Song: {Song} | Rating: {Rating}";
        }

    }

    class Classical : Music
    {
        public string SongYear { get; set; }
    }
}
