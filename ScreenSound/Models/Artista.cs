namespace ScreenSound.Models;

internal class Artista : IAvaliavel
{
    private List<Album> ListaDeAlbuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();
    public Artista(string name)
    {
        Nome = name;
    }
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public string? Resumo { get; set; }
    public List<Album> Albuns => ListaDeAlbuns;
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
    public string Nome { get; }
    public void AdicionarAlbum(Album album)
    {
        ListaDeAlbuns.Add(album);
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"\nDiscografia do artista: {Nome}");
        foreach (Album album in ListaDeAlbuns)
        {
            Console.WriteLine($"\nÁlbum: {album.Nome} ({album.DuracaoTotal}s)");
        }
    }
}