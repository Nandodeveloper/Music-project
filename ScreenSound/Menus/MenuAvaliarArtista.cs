using ScreenSound.Models;
namespace ScreenSound.Menus;

internal class MenuAvaliarArtista : Menu
{
    public override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        base.Executar(artistasRegistrados);
        ExibirTituloDaOpcao("Avalie um(a) artista");
        Console.Write("Digite o nome do(a) artista que deseja avaliar: ");
        string nomeDoArtista = Console.ReadLine()!;
        if (artistasRegistrados.ContainsKey(nomeDoArtista))
        {
            Artista artista = artistasRegistrados[nomeDoArtista];
            Console.Write($"Atribua uma nota a(o) artista {nomeDoArtista}: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            artista.AdicionarNota(nota);
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o(a) artista {nomeDoArtista}");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nERROR: O(a) artista {nomeDoArtista} não foi registrado(a)");
            Thread.Sleep(2000);
            Console.Clear();
            Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
