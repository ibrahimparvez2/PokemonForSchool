using System;
using System.Threading.Tasks;
using RestaurantLocater.Models;

namespace LearnPokemonApi.Services
{
    public interface IPokeApiCaller
    {
        Task<SpeciesType> GetSpeciesDefinition(string name);
    }

}