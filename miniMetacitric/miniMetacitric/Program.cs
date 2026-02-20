// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao MiniMetacritic!");

var titulos = new List<Title>();
var novoJogo = new Game();

while (true)
{
    Console.WriteLine("""
        Digite a opção desejada:
        0 - Sair        
        1 - Cadastrar um novo jogo
        2- Ver títulos cadastrados
        """);
    var opcao = Console.ReadLine();

    void CadastrarTitulo()
    {
        Console.WriteLine("Novo Cadastro!");
        Console.WriteLine("Digite o nome do jogo:");
        var nome = Console.ReadLine();

        Console.Write("""
                Data de lançamento:
                YYYY-MM-DD
                """);
        var dataLancamento = Console.ReadLine();

        Console.WriteLine("Nota dos críticos");
        var MetaScore = Console.ReadLine();

        Console.WriteLine("Nota dos usuários");
        var UserScore = Console.ReadLine();

        titulos.Add(new()
        {
            Name = nome,
            ReleaseDate = DateTime.Parse(dataLancamento),
            MetaScore = int.Parse(MetaScore),
            UserScore = int.Parse(UserScore)
        });

        Console.WriteLine("Jogo cadastrado com sucesso!");
    }


    switch (opcao)
    {
        case "0":
            Console.WriteLine("Saindo do programa...");
            Environment.Exit(0);
            break;

            case "1":
            CadastrarTitulo();
            break;

            case "2":
            Console.WriteLine($"Títulos cadastrados:");
            titulos.ForEach(titulos => Console.WriteLine(titulos.Name));
            break;
        default:
            Console.WriteLine("Opção inválida. Por favor, tente novamente.");
            break;
    }
}