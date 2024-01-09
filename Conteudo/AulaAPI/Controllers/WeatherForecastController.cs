using Microsoft.AspNetCore.Mvc;

namespace AulaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        [Route("nome")]
        public string MeuNome()
        {
            return "Gabriel Castagna Henrique";
        }

        [HttpGet]
        [Route("idade")]
        public string MeuIdade()
        {
            return "24 anos";
        }

        [HttpPost]
        [Route("informenome")]
        public string RecebeNome([FromBody] string nome)
        {
            return "Nome: " + nome;
        }

        [HttpPost]
        [Route("informenomeidade")]
        public string RecebeNomeIdade([FromBody] string nome, int idade)
        {
            if(idade > 17)
            {
                return nome + " é maior de idade!";
            }
            return nome + " é menor de idade";
        }

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}