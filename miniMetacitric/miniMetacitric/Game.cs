public class Game : Title
{
    public string Plataforma { get; set; }

    public override void Exibir()
    {
        base.Exibir();
        Console.WriteLine($"Plataforma: {Plataforma}");
    }
}