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
                        // split the txt file into three parts
                        string artist = parts[0];
                        string album = parts[1];
                        int rating = Convert.ToInt32(parts[2][0]);

                        // stores everything in an array, then increments through rows
                        music[row] = new Music(artist, album, rating);
                        row++;
                    }
                    // DISPLAYS THE OPEN FILE Console.WriteLine(line);
                }
            } // end of loading portion


            // checks if space is available
            bool freeSpace = false;

            for (row = 0; row < music.Length; row++)
            {
                if (music[row] == null)
                {
                    // spot found
                    freeSpace = true;

                    // prompt user for a(n) entry
                    Console.Write("Please enter a(n) artist: ");
                    userArtist = Console.ReadLine();

                    Console.Write("Please enter a album by the artist: ");
                    userAlbum = Console.ReadLine();

                    Console.Write("Please enter a rating: ");
                    userRating = Convert.ToInt32(Console.ReadLine());

                    /*  // This does the same exact thing as the music[row] = new Music. Just takes a little bit more steps
                    Music userMusic = new Music(userArtist, userAlbum, userRating);
                    music[row] = userMusic;
                    */
                    music[row] = new Music(userArtist, userAlbum, userRating);
                    break;
                }
            }
            if (!freeSpace)
            {
                Console.WriteLine("Sorry, there's no space available.");
            }
            foreach (var item in music)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
