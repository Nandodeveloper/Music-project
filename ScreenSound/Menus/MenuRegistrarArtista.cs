using ScreenSound.Models;
using OpenAI_API;
namespace ScreenSound.Menus;


internal class MenuRegistrarArtista : Menu
{
    public override void Executar(Dictionary<string, Artista> artistasRegistrados)
    {
        base.Executar(artistasRegistrados);
        ExibirTituloDaOpcao("Registro de artistas");
        Console.Write("\nDigite o nome do(a) artista que você deseja registrar: ");
        string nomeDoArtista = Console.ReadLine()!;
        Artista artista = new(nomeDoArtista);
        artistasRegistrados.Add(nomeDoArtista, artista);


        var client = new OpenAIAPI("sk-proj-ywz3SLTQtOZ8WlVCpm1yT3BlbkFJxAbu2Em458oL0iwtagt3");
        var chat = client.Chat.CreateConversation();
        chat.AppendSystemMessage($"Resuma o(a) artista {nomeDoArtista} em 1 parágrafo. Adote o estilo informal.");
        string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        artista.Resumo = resposta;


        Console.WriteLine($"O(a) Artista {nomeDoArtista} foi registrada com sucesso!");
        Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
        Console.ReadKey();
        Console.Clear();
    }
}
