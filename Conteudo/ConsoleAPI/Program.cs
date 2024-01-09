using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace ConsoleAPI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string baseUrl = "https://localhost:7148/";

            Console.WriteLine("Digite 1 para consultar e2 para cadastrar: ");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    List<Pessoa>? pessoas = new List<Pessoa>();

                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(baseUrl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json") );
                    HttpResponseMessage res = await client.GetAsync("/api/entity/pessoas");

                    if (res.IsSuccessStatusCode)
                    {
                        //pega somente o resultado da requisição -> .Result
                        var response = res.Content.ReadAsStringAsync().Result;

                        pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(response);

                        foreach(Pessoa item in pessoas)
                        {
                            Console.WriteLine(item.id + " _ " + item.nome);
                        }
                    }


                    break;
                case 2:
                    Pessoa pessoa = new Pessoa();
                    pessoa.nome = "Post na API";

                    HttpClient clientPost = new HttpClient();
                    HttpResponseMessage resPost = await clientPost.PostAsJsonAsync(
                        baseUrl + "apientity/pessoas", pessoa);

                    if (resPost.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Cadastrado com sucesso");
                    }

                    break;
            }
        }
    }
}