using CsharpApiLInq.Modelos;
using System.Text.Json;
//recurso para fazer requisições, não usamos o ":" pois vamos usar esse recurso so dentro do using //quando a chave fecha, liberamos o recurso objeto client 
using (HttpClient client = new HttpClient())
{
    try 
    { 
    string resposta =await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.jso");
    Console.WriteLine(resposta);
        #region deserialização
        //Preciso ACESSAR as propriedades que estão na classe Musica,
        //mas nesse caso estao em json e para isso eu faço uma conversão de json para
        //C# e essa conversão é a deserialização
        #endregion
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);// vai pegar o o meu jso que está na string RESPOSTA e ai converter ele (deserialize) para uma lista do tipo da classe MUSICA e joar para a var musicas 
        musicas[10].ExibirDetalhesDamusica();
    }
    catch (Exception ex) 
    { Console.WriteLine($"Temos um problema: {ex.Message}"); }
     //pegar o json para apontar para a classe musica 
}


#region ANOTAÇÕES AULAS 
/*REQUISIÇÃO
 * acessa o endpoint (o endereço)
 *Quando eu clico no link eu faço a requisição
    -await: ESPERA A TASK SER CONCLUIDA E DAI PEGA O RESULTADO E JOGA NA VARIAVEL 
    -GetStringAsync: pega os dados em formato string e o Async é pq não sei a quantdade 
    de coisa que vamos receber, como queremos receber tudo, TEM QUE COLOCAR POIS SE NÃO RECEBE SÓ UMA PARTE E PASSA TUDO O RESTO  
 */
/*TRY CATCH
    -Como podem acontecer mudanças no decorrer do projeto, é eficiente lançar uma TENTATIVA, caso não de certo 
ele cai NA CAIXA de aviso/exceção. ~~Isso é o try(tentativa) catch(caixa)~~
    -O bloco try-catch é essencial para lidar com erros em um programa. e protege o código que pode gerar problemas,
ermitindo capturar e tratar as exceções que ocorrem.Sem o try-catch, o programa poderia travar e mostrar mensagens 
de erro confusas para o usuário,deixando o programa em um estado ruim.
 */
/*SERIALIZAR/DESERIALIZAR
    SERIALIZAR= pega um objeto e tansforma num fluxo de bites 
    DESERIALIZAR= pega o fluxo de de bytes e tansforma em um objeto 
 
 */
#endregion