using ScreenSound.Models;
namespace ScreenSound.Menus;

internal class MenuRegistroDeArtistas : Menu
{
    public override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        base.Executar(artistasRegistrados);
        ExibirTituloDaOpcao("Artistas Registrados");

        foreach (string artista in artistasRegistrados.Keys)
        {
            Console.WriteLine($"Artista: {artista}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Thread.Sleep(500);
        Console.Clear();
    }
}
