Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Genero rock = new Genero("Rock");

Podcast poddelas = new Podcast("Youtube", "PodDelas");

Musica musica1  = new Musica(queen, "Love of my life", rock)
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody", rock)
{
    Duracao = 354,
    Disponivel = true,
};

Episodio episodio1 = new(40, 1, "Taylor Swift");

Episodio episodio2 = new Episodio(34, 2, "Ariana Grande");

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);
episodio1.AdicionarConvidados("Taylor Swift");
episodio1.AdicionarConvidados("Ed Sheeram");
episodio2.AdicionarConvidados("Ariana Grande");
poddelas.AdicionarEpisodio(episodio1);
poddelas.AdicionarEpisodio(episodio2);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();
poddelas.ExibirDetalhes();

