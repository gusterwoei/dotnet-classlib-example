using DotnetLibExample.Lib.Api;
using Refit;

namespace DotnetLibExample.Lib.Services
{
    public class DogService(IDogApi api)
    {
        private readonly IDogApi _api = api;

        public async Task<Dictionary<string, List<string>>> GetBreeds()
        {
            try
            {
                var response = await _api.GetBreeds();
                var breeds = response.Message;
                return breeds;
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Message);
            }
            return [];
        }

        public async Task<List<string>> GetSubBreeds(string breed)
        {
            try
            {
                var response = await _api.GetSubBreeds(breed);
                var subBreeds = response.Message;

                return subBreeds;
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Message);
            }
            return [];
        }
    }
}