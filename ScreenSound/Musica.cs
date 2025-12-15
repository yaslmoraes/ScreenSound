class Musica
{
    public Musica(Banda artista, string nome, Genero genero)
    {
        Artista = artista;
        Nome = nome;
        Genero = genero;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; }
    public string DescricaoResumida =>
        $"A musica {Nome} pertence a banda {Artista.Nome}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duracao: {Duracao}");
        Console.WriteLine($"Genero: {Genero.Nome}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano.\n");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}
