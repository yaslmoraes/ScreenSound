class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Lista de episodios do Podcast {Nome}");
        foreach (var episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"Episodio: {episodio.Resumo} - Host: {Host}");
        }
        Console.WriteLine($"O Podcast {Nome} possui um total de {TotalEpisodios} episodios.");
    }
}