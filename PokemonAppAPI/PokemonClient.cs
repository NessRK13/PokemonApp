using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokemonAppAPI
{
    public class PokemonClient
    {
        private static readonly HttpClient _client;

        static PokemonClient()
        {
            _client = new HttpClient();
        }

        /// <summary>
        /// Returns a single Pokemons data using Id
        /// </summary>
        /// <returns></returns>
        public async Task<PokemonResponse> GetPokemon(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a single Pokemons data using name
        /// </summary>
        /// <returns></returns>
        public async Task<PokemonResponse> GetPokemon(string name)
        {
            throw new NotImplementedException();
        }
    }
}
