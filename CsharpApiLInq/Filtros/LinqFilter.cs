using CsharpApiLInq.Modelos;

namespace CsharpApiLInq.Filtros;

internal class LinqFilter
{
    //não precisa dar new para usar 
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGeneosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();  
        //pegos a minha lista musica e seleciono somente o genero onde mostro de modo distindo
        //transformando em uma lista . Distinct = se aparecer mais de uma vez o mesmo tipo de genero,
        //ele mostra so um
       
        foreach (var genero in todosOsGeneosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero))
            .Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artstas por gênero musical >>> {genero}");
        foreach( var artista  in artistasPorGeneroMusical) 
        { Console.WriteLine($"-{artista}"); }
    }
    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
    public static void FiltrarMusicasPorAno(List<Musica> musicas, string anoDaMusica)
    {
        var musicasPorAno = musicas.Where(musica => musica.AnoString!.Equals(anoDaMusica)).Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"Exibindos as musicas mais tocadas de: {anoDaMusica}");
        foreach( var item in musicasPorAno)
        {
            Console.WriteLine($"-{item}");
        }
    }

}
