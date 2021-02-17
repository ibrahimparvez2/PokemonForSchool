using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestaurantLocater.Models;

namespace LearnPokemonApi.Services
{
    public class PokeApiCaller : IPokeApiCaller
    {
        private  HttpClient _httpClient {get;} 
        private IConfiguration _config {get;}
        private string PokeApiUrl {get; set;}

    public PokeApiCaller()
    {
        _httpClient = _httpClient ?? new HttpClient();
        _config =  _config ?? new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        this.PokeApiUrl = _config.GetValue<string>("PokeApiUrl");
    }

        public async Task<SpeciesType> GetSpeciesDefinition(string name)
        {
            try 
            {
                var response = await this._httpClient.GetAsync($"{PokeApiUrl}/pokemon-species/{name}");

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var speciesType = JsonConvert.DeserializeObject<SpeciesType>(responseContent);

                    return speciesType;
                }

            }

            catch(Exception e)
            {
                throw new ArgumentException(e.Message, e.InnerException);
            }


            return null;
        }
    }

}