namespace ScreenSound.Models;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
    double Media { get; }
}
