using Newtonsoft.Json;
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

            _client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");
        }

        /// <summary>
        /// Returns a single Pokemons data using Id
        /// </summary>
        /// <returns></returns>
        public async Task<PokemonResponse> GetPokemon(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException("id must be higher then 0");

            HttpResponseMessage response = await _client.GetAsync($"{id}");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                PokemonResponse result = JsonConvert.DeserializeObject<PokemonResponse>(data);
                return result;
            }
            else
                return null;
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
