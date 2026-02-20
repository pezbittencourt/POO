// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao MiniMetacritic!");

var titulos = new List<Title>();

while (true)
{
    Console.WriteLine("""

        ________________________________
        Digite a opção desejada:
        0 - Sair        
        1 - Cadastrar um novo título
        2- Ver títulos cadastrados
        ________________________________
        """);
    var opcao = Console.ReadLine();

    void CadastrarTitulo()
    {
        Console.WriteLine("""
            Novo Cadastro!
            _________________________________________
            Se trata de um jogo, filme ou série?
            1 - Jogo
            2 - Filme
            3 - Série
            _________________________________________
            """);
        var cadastro = Console.ReadLine();
        Title novoTitulo;
        switch (cadastro)
        {
            case "1":
                Console.WriteLine("Cadastrando um novo jogo...");
                var jogo = new Game();

                Console.WriteLine("Digite a plataforma do jogo:");
                jogo.Plataforma = Console.ReadLine();

                novoTitulo = jogo;
                break;

            case "2":
                Console.WriteLine("Cadastrando um novo filme...");
                var filme = new Movie();

                Console.WriteLine("Qual a duração do filme, em minutos?");
                filme.duration = int.Parse(Console.ReadLine());

                novoTitulo = filme;
                break;


            case "3":
                Console.WriteLine("Cadastrando uma nova série...");
                var serie = new TvShow();

                Console.WriteLine("Qual a duração de cada episódio, em minutos?");
                serie.duration = int.Parse(Console.ReadLine());

                novoTitulo = serie;
                break;


            default:
                Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                return;
        }

        Console.WriteLine("Digite o título:");
        var nome = Console.ReadLine();

        Console.WriteLine("Data de lançamento: (YYYY - MM - DD)");
        var dataLancamento = Console.ReadLine();

        Console.WriteLine("Nota dos críticos");
        var MetaScore = Console.ReadLine();

        Console.WriteLine("Nota dos usuários");
        var UserScore = Console.ReadLine();

        novoTitulo.Name = nome;
        novoTitulo.ReleaseDate = DateTime.Parse(dataLancamento);
        novoTitulo.MetaScore = int.Parse(MetaScore);
        novoTitulo.UserScore = int.Parse(UserScore);

        titulos.Add(novoTitulo);

        Console.WriteLine("Título cadastrado com sucesso!");
    }

    void ListarTitulos()
    {
        if (titulos.Count == 0)
        {
            Console.WriteLine("Nenhum título cadastrado.");
            return;
        }

        Console.WriteLine("===== TÍTULOS CADASTRADOS =====");

        foreach (var titulo in titulos)
        {
            titulo.Exibir(); // Polimorfismo acontecendo aqui
        }
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
            ListarTitulos();
            break;
        default:
            Console.WriteLine("Opção inválida. Por favor, tente novamente.");
            break;
    }
}