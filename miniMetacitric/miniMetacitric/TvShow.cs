public class TvShow : Title
{
    public int duration { get; set; }

    public override void Exibir()
    {
        base.Exibir();
        Console.WriteLine($"Duração: {duration} minutos");
    }
}
