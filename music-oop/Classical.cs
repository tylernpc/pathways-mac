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