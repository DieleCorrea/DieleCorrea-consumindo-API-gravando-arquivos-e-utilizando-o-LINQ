using CsharpApiLInq;
using CsharpApiLInq.Filtros;
using CsharpApiLInq.Modelos;
using System.Text.Json;
//recurso para fazer requisições, não usamos o ":" pois vamos usar esse recurso so dentro do using //quando a chave fecha, liberamos o recurso objeto client 
using (HttpClient client = new HttpClient())
{
    
    try 
    { 
    string resposta =await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    Console.WriteLine(resposta);
        #region deserialização
        //Preciso ACESSAR as propriedades que estão na classe Musica,
        //mas nesse caso estao em json e para isso eu faço uma conversão de json para
        //C# e essa conversão é a deserialização
        #endregion
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;// vai pegar o o meu jso que está na string RESPOSTA e ai converter ele (deserialize) para uma lista do tipo da classe MUSICA e joar para a var musicas 
        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
    }
    catch (Exception ex) 
    { Console.WriteLine($"Temos um problema: {ex.Message}");
        //pegar o json para apontar para a classe musica 
    }
}


