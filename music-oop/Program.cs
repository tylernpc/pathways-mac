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
            string userAlbum;
            int row = 0;
            int userRating = 0;

            Console.Write("Please enter a(n) artist: ");
            userArtist = Console.ReadLine();

            Console.Write("Please enter a album by the artist: ");
            userAlbum = Console.ReadLine();

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
                        string album = parts[1];
                        int rating = Convert.ToInt32(parts[2][0]);

                        music[row] = new Music(artist, album, rating); // stores in an array
                        row++; // increments through rows
                    }
                    // DISPLAYS ALL STUFF THAT'S OPEN Console.WriteLine(line);
                }
            }
            // Music userMusic = new Music(userArtist, userAlbum, userRating);
        }
    }



    // music class
    class Music
    {
        // declared variables
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Rating { get; set; }

        // default constructor when no values are passed
        public Music()
        {
            Artist = "";
            Album = "";
            Rating = 0;
        }

        //constructor when two values are passed
        public Music(string artist, string album, int rating)
        {
            this.Artist = artist;
            this.Album = album;
            this.Rating = rating;
        }

        // override tostring for default display
        public override string ToString()
        {
            return $"Artist: {Artist} | Album: {Album} | Rating: {Rating}";
        }

    }



    // classical music class + base
    class Classical : Music
    {
        // declared variables
        public string AlbumYear { get; set; }

        // default constructor when no values are passed
        public Classical()
        {
            AlbumYear = "";
        }

        // constructor when a value is passed
        public Classical(string albumYear)
        {
            this.AlbumYear = albumYear;
        }

        public override string ToString()
        {
            return $"Album Year: {AlbumYear}";
        }
    }
}
