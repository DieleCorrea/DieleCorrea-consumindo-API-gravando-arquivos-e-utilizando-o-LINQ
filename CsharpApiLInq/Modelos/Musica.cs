using System.Security.Principal;
using System.Text.Json.Serialization;

namespace CsharpApiLInq.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]//atributo que representa um metadado especifico para a propiedade Nome 
    public string Nome { get; set; }
    [JsonPropertyName("artist")]
    public string Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set;}// o "?" é que pode ser nula 

    public void ExibirDetalhesDamusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao /1000}");
        Console.WriteLine($"Genero musical: {Genero}");
    }
}
