using System.Text.Json;
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
       ListaDeMusicasFavoritas = new List<Musica>();//inicia a lista como se ela estivesse vazia, pois quando chamar o metodo exibir ele vai pegar as prop da classe musca e criar uma nova lista através do metodo adicionar musca. É PRECISO FAZER ESSE NEW PARA NÃO DAR ERRO DE NULLREFERENCE 

    }
    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }
    public void ExibirMusicasPreferidas()
    {
        Console.WriteLine($"Essas são as músicas favoritas de -> {Nome}");
        foreach(var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
            
        }
        Console.WriteLine(" ");
    }
    public void GerarArquivoJson()
    {
        //SEREALIZAR A LISTA CRIADA PARA UMA STRING JSON
        string json = JsonSerializer.Serialize(new 
        #region// Esse new é um objeto sem tipo, ou seja, ele é um anonimo, ideal para essa situação, que to criando estrutura temporária 
        #endregion
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        }) ;

        //DEFINIR QUAL VAI SER O NOME DO ARQUIVO QUE O JSON VAI SER SALVO 
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        //ESCREVER A STRING JSON EM UM ARQUIVO #classe File é usada para escrever essa string em um arquivo.
        File.WriteAllText(nomeDoArquivo, json) ;

        //MOSTRA ONDE ESTÁ ESSE ARQUIVO 
        Console.WriteLine($"O arquivo json foi criado com sucesso!{Path.GetFullPath(nomeDoArquivo)}");

        //Para ver o arquivo posso abrir o vs code 
    }

}
