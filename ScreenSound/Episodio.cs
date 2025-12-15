class Episodio
{
    private List<string> convidados = new List<string>();
    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

    public int Duracao { get; set; }
    public int Ordem { get; set; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";
    public string Titulo { get; set; }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}