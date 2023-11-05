using CsharpApiLInq.Modelos;

namespace CsharpApiLInq.Filtros;

internal class LinqFilter
{
    //não precisa dar new para usar 
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGeneosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();  //pegos a minha lista musica e seleciono somente o genero onde mostro de modo distindo transformando em uma lista . Distinct = se aparecer mais de uma vez o mesmo tipo de genero, ele mostra so um
        foreach (var genero in todosOsGeneosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

}
