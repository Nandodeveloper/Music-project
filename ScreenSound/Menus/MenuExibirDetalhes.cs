using ScreenSound.Models;
using System.Runtime;
namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        base.Executar(artistasRegistrados);
        ExibirTituloDaOpcao("Exibir detalhes do(a) artista");
        Console.Write("\nDigite o nome do(a) artista que deseja exibir os detalhes de notas: ");
        string nomeDoArtista = Console.ReadLine()!;
        if (artistasRegistrados.ContainsKey(nomeDoArtista))
        {
            Artista artista = artistasRegistrados[nomeDoArtista];
            Console.WriteLine(artista.Resumo);
            Console.WriteLine($"\n A média do(a) artista {nomeDoArtista} é: {artista.Media}.");
            Console.WriteLine($"\nDiscografia do artista: {artista.Nome}");
            foreach (Album album in artista.Albuns)
            {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
            }
            Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("O(a) artista digitado(a) não está registrado(a)");
            Thread.Sleep(2000);
            Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
            Console.ReadKey();
            Console.Clear();

        }
    }
}