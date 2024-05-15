using ScreenSound.Models;
namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        base.Executar(artistasRegistrados);
        ExibirTituloDaOpcao("Avaliar álbum");
        Console.Write("Digite o nome do artista que deseja avaliar o álbum: ");
        string nomeDoArtista = Console.ReadLine()!;
        if (artistasRegistrados.ContainsKey(nomeDoArtista))
        {
            Artista artista = artistasRegistrados[nomeDoArtista];
            Console.WriteLine($"Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (artista.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = artista.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write($"Atribua uma nota ao álbum {tituloAlbum}: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {tituloAlbum}");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nERROR: O álbum {tituloAlbum} não foi encontrado");
                Thread.Sleep(2000);
                Console.Clear();
                Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
                Console.ReadKey();
                Console.Clear();
            }
        }
    } 
}
