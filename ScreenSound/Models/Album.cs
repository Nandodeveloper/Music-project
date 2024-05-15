namespace ScreenSound.Models;

internal class Album : IAvaliavel
{
    private List<Music> ListaDeMusicas = new List<Music>();
    private List<Avaliacao> notas = new();

    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => ListaDeMusicas.Sum(m => m.duracao);
    public void AdicionarMusica(Music musica)
    {
        ListaDeMusicas.Add(musica);
    }
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    } 
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"\nLista de músicas do álbum: {Nome}\n");
        foreach (var musica in ListaDeMusicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
            Console.WriteLine($"Artista: {musica.Artista.Nome}, {musica.Feats}");
            Console.WriteLine($"Duração: {musica.duracao}\n");
        }
        Console.WriteLine($"Este Álbum possui uma duração total de {DuracaoTotal} segundos");
        Console.WriteLine("--------------------------------------------------------------------------------");
    }
}