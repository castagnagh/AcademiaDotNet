using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace CA_CosumirAPI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int op = 0;
            string baseUrl = "https://localhost:7148/";
            string token = "";

            do
            {
            Console.WriteLine("Digite 1 para solicitar o token e 2 para consumir o endpoint 1");
            op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Usuario usuario = new Usuario();
                        Console.WriteLine("Digite o login");
                        usuario.login = Console.ReadLine();
                        Console.WriteLine("Digite a senha");
                        usuario.senha = Console.ReadLine();

                        HttpClient clientToken = new HttpClient();
                        clientToken.DefaultRequestHeaders.Accept.Clear();
                        clientToken.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                        HttpResponseMessage restToken =
                            clientToken.PostAsJsonAsync(baseUrl + "api/entity/autenticar", usuario).Result;

                        if (restToken.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            token = restToken.Content.ReadAsStringAsync().Result;
                            Console.WriteLine("Token: " + token);
                        }
                        else
                        {
                            Console.WriteLine(restToken.StatusCode);
                        }
                        break;
                    case 2:
                        HttpClient client = new HttpClient();
                        client.BaseAddress = new Uri(baseUrl);
                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));
                        client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", token.Replace("\"", ""));

                        HttpResponseMessage responde = await client.GetAsync("api/entity/pessoas");

                        if (responde.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            string retorno = responde.Content.ReadAsStringAsync().Result;
                            Console.WriteLine("Retorno: " + retorno);
                        }
                        else
                        {
                            Console.WriteLine(responde.StatusCode);
                        }
                        break;
                }
            } while (op != 0);
        }
    }
}