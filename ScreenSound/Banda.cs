class Banda
{
    private List<Album> albums = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"\nDiscografia da banda {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})\n");
        }
    }
}