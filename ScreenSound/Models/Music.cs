namespace ScreenSound.Models;

internal class Music
{
    List<string> Artistas = new();
    public Music(Artista artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Artista Artista { get; }
    public string Feats => string.Join(", ", Artistas);
    public void AdicionarFeat(string feats)
    {
        Artistas.Add(feats);
    }
    public int duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida =>
        $"A música {Nome} pertence ao artista {Artista}";
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Música: {Nome} feat.{Artistas}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Música dispnível no plano\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano plus\n");
        }
    }
}