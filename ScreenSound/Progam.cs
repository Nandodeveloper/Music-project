using ScreenSound;
using ScreenSound.Models;
using ScreenSound.Menus;
using OpenAI_API;
using OpenAI_API.Moderation;
using System.Runtime.Intrinsics.X86;

//Usando API do ChatGPT para resposta
//Não vai ser usada pois está com erro de requisição

//var client = new OpenAIAPI("sk-proj-yDgTrFLmjqHnTBU7BJmbT3BlbkFJbmqGVwxJYuZq9OrsirCm");
//OpenAI_API.Chat.Conversation chat = client.Chat.CreateConversation();
//chat.AppendSystemMessage("Faça um resumo de um parágrafo sobre o artista Matuê, utilizando uma norma informal");
//string resposta = await chat.GetResponseFromChatbotAsync();
//Console.WriteLine(resposta);

void ExibirLogo()
{
  Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
  Console.WriteLine("Boas vindas ao Screen Sound 2.0!");

}
void ExibirOpcoesDoMenu()
{
  ExibirLogo();
  Console.WriteLine("\nDigite 1 para registrar um(a) artista");
  Console.WriteLine("Digite 2 para registrar o álbum de um artista");
  Console.WriteLine("Digite 3 para avaliar álbum de um artista");
  Console.WriteLine("Digite 4 mostrar todos os artistas");
  Console.WriteLine("Digite 5 para avaliar um(a) artista");
  Console.WriteLine("Digite 6 para exibir os detalhes de um artista");
  Console.WriteLine("Digite -1 para sair");

  Console.Write("\nDigite a sua opção: ");
  Dictionary<string, Artista> artistasRegistrados = new Dictionary<string, Artista>();
  Dictionary<int, Menu> opcoes = new();
  opcoes.Add(1, new MenuRegistrarArtista());
  opcoes.Add(2, new MenuRegistrarAlbum());
  opcoes.Add(3, new MenuAvaliarAlbum());
  opcoes.Add(4, new MenuRegistroDeArtistas());
  opcoes.Add(5, new MenuAvaliarArtista());
  opcoes.Add(6, new MenuExibirDetalhes());
  opcoes.Add(-1, new MenuSair());   
  opcoes.Add(default, new MenuSair());
  string opcaoEscolhida = Console.ReadLine()!;
  int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(artistasRegistrados);
    }
    if (opcaoEscolhidaNumerica > 0 && opcaoEscolhidaNumerica == -1)
    {
        ExibirOpcoesDoMenu();

    }else if (opcaoEscolhidaNumerica == -1)
    {
        return;
    }else
    {
        Console.WriteLine($"A opção escolhida ({opcaoEscolhidaNumerica}) é inválida!");
    }
}
ExibirOpcoesDoMenu();