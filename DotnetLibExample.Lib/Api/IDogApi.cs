using DotnetLibExample.App.Models;
using DotnetLibExample.Lib.Models;
using Refit;

namespace DotnetLibExample.Lib.Api
{
    public interface IDogApi
    {
        [Get("/api/breeds/list/all")]
        Task<GetBreedResponse> GetBreeds();

        [Get("/api/breed/{breed}/list")]
        Task<GetSubBreedResponse> GetSubBreeds(string breed);
    }
}