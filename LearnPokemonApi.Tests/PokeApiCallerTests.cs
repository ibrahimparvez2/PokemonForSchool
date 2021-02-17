using System;
using System.Threading.Tasks;
using LearnPokemonApi.Services;
using Xunit;
using FluentAssertions;
using RestaurantLocater.Models;

namespace LearnPokemonApi.Tests
{
    public class PokeApiCAllerTests
    {
        [Fact]
        public void CanBuildPokeApiCaller()
        {
            PokeApiCaller _caller = new PokeApiCaller();
            Assert.NotNull(_caller); 
        }


        [Fact]
        public async Task WhenPokeAPiCalled_WillReturnOK()
        {
            const string name= "pikachu";
            PokeApiCaller _caller = new PokeApiCaller();
            var result = await _caller.GetSpeciesDefinition(name);

            Assert.NotNull(result);
            
            result.Should().Match<SpeciesType>((t) => t.Name == name);
        }
    }
}
