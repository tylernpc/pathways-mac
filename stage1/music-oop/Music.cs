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