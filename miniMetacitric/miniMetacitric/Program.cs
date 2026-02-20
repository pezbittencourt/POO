// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem vindo ao MiniMetacritic!");

var titulos = new List<Title>();

while (true)
{
    Console.WriteLine("""
        Digite a opção desejada:
        0 - Sair        
        1 - Cadastrar um novo título
        2- Ver títulos cadastrados
        """);
    var opcao = Console.ReadLine();

    void CadastrarTitulo()
    {
        Console.WriteLine("""
            Novo Cadastro!
            Se trata de um jogo, filme ou série?
            1 - Jogo
            2 - Filme
            3 - Série
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

        Console.Write("""
                Data de lançamento:
                YYYY-MM-DD
                """);
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