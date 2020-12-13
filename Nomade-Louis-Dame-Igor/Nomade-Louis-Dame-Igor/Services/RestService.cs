using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Nomade_Louis_Dame_Igor.Models;

namespace Nomade_Louis_Dame_Igor.Services
{ 
    public class RestService
    {
        WeatherData _wd;
        HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<WeatherData> GetWeatherData(string query)
        {
            WeatherData weatherData = null;
            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    weatherData = JsonConvert.DeserializeObject<WeatherData>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\t\tERROR {0}", ex.Message);
            }

            return weatherData;
        }
       public async Task<WeatherData> OnGetWeatherButtonClicked(string Nom)
        {
            if (!string.IsNullOrWhiteSpace(Nom))
            {
                _wd = await GetWeatherData(GenerateRequestUri(Nom));
               
            }
            return _wd;
        }

        string GenerateRequestUri(string NomVille)
        {
            string requestUri = "https://api.openweathermap.org/data/2.5/weather";
            requestUri += $"?q={NomVille}";
            requestUri += "&units=imperial"; // or units=metric
            requestUri += $"&APPID={"f4a721b2c4e45874d98535c0a347ec36"}";
            return requestUri;
        }
    }
}
