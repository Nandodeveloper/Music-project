using ScreenSound.Models;
namespace ScreenSound.Menus;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        base.Executar(artistasRegistrados);
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("Digite o(a) artista cujo álbum deseja registrar: ");
        string nomeDoArtista = Console.ReadLine()!;
        if (artistasRegistrados.ContainsKey(nomeDoArtista))
        {
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            Artista artista = artistasRegistrados[nomeDoArtista];
            artista.AdicionarAlbum(new Album(tituloAlbum));
            Console.WriteLine($"O álbum {tituloAlbum} de {nomeDoArtista} foi registrado com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nERROR: O(a) Artista {nomeDoArtista} não foi registrado(a)");
            Thread.Sleep(2000);
            Console.Clear();
            Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
