namespace CsharpApiLInq.Modelos;
/*Essa classe estou criando pois quero transformar as informações que tenho no meu arquivo c# em json
  */
internal class MusicasPreferidas
{
    public  string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public MusicasPreferidas(string? nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>() ;

    }
    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }
    public void ExibirMusicasPreferidas()
    {
        Console.WriteLine($"essas são as músicas favoritas de -> {Nome}");
        foreach(var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"= {musica.Nome} de {musica.Artista}");
        }
    }
}
