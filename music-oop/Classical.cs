// classical music class + base
class Classical : Music
{
    // declared variables
    public string AlbumYear { get; set; }

    // default constructor when no values are passed
    public Classical()
    {
        AlbumYear = "";
        Artist = "";
        Album = "";
        Rating = 0;
    }

    // constructor when a value is passed
    public Classical(string albumYear, string artist, string album, int rating)
    {
        this.AlbumYear = albumYear;
        this.Artist = artist;
        this.Album = album;
        this.Rating = rating;
    }

    public override string ToString()
    {
        return $"Album Year: {AlbumYear} | Artist: {Artist} | Album: {Album} | Rating: {Rating}";
    }
}