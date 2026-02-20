public class Title
{
    public string Name { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int MetaScore { get; set; }
    public int UserScore { get; set; }

    public virtual void Exibir()
    {
        Console.WriteLine($"""
            {Name}
            
          Lançamento: {ReleaseDate:yyyy-MM-dd}
          MetaScore: {MetaScore}
          UserScore: {UserScore}
          """);
    }
}
