using System.Security.Principal;
using System.Text.Json.Serialization;

namespace CsharpApiLInq.Modelos;

internal class Musica
{
    private List<string> Tonalidades = new List<string> { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
    [JsonPropertyName("song")]//atributo que representa um metadado especifico para a propiedade Nome 
    public string Nome { get; set; }
    [JsonPropertyName("artist")]
    public string Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }// o "?" é que pode ser nula 
    [JsonPropertyName("year")]
    public string AnoString { get; set; }
    public int Ano => int.Parse(AnoString);
    [JsonPropertyName("key")]
    public int Key { get; set; }
    public string Tonalidade
    {
        get
        {
            return Tonalidades[Key];
        }
    }


    public void ExibirDetalhesDamusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao / 1000}");
        Console.WriteLine($"Genero musical: {Genero}");
        Console.WriteLine($"Ano da musica: {AnoString}");
        Console.WriteLine($"Tom da música : {Tonalidade}");
    }
    /*O desafio é o seguinte: você deverá criar um método que exiba o nome de todas as 
     * músicas que estejam na tonalidade de C#, ou seja, dó sustenido.

    Lembrando que, na nossa lista do GitHub, a tonalidade que representa o C# corresponde ao índice 1. 
    Então, a ideia é que você busque todas as músicas com índice 1 e exiba apenas elas.*/
   
}
