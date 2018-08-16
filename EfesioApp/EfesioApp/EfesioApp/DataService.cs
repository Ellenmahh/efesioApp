using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace EfesioApp
{
    public class DataService
    {
        public static async Task<dynamic> get(string queryString)
        {
            HttpClient client = new HttpClient();
            // envia a requisição GET
            //var uri = "http://localhost:8080/efesioapi/api/usuario/login";
            var response = await client.GetStringAsync(queryString);

            dynamic json = null;
            if (response != null)
            {
                // processa a resposta
                json = JsonConvert.DeserializeObject(response);
            }
            var post = json.First();
            return post;

        }
        public static async Task<dynamic> post(string queryString, string json)
        {
            // cria um novo post
            var novoPost = new LoginClass
            {
                Usuario = "teste",
                Senha = "11"
            };
            // cria o conteudo da requisição e define o tipo Json
            var novo = JsonConvert.SerializeObject(novoPost);
            var content = new StringContent(novo, Encoding.UTF8, "application/json");
            // envia a requisição POST
            var uri = "http://localhost:8080/efesioapi/api/usuario/login";

            HttpClient client = new HttpClient();
            var result = await client.PostAsync(uri, content);
            // Se ocorrer um erro lança uma exceção
            result.EnsureSuccessStatusCode();
            // processa a resposta
            var resultString = await result.Content.ReadAsStringAsync();
            var post = JsonConvert.DeserializeObject<LoginClass>(resultString);
            // exibe a saida no TextView
            return post;
        }
        
    }
}
