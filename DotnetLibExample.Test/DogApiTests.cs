using Moq;
using DotnetLibExample.Lib.Api;
using DotnetLibExample.App.Models;
using DotnetLibExample.Lib.Models;
using Newtonsoft.Json;

public class DogApiTests
{
    private readonly Mock<IDogApi> _dogApiMock;

    public DogApiTests()
    {
        _dogApiMock = new Mock<IDogApi>();
    }

    [Fact]
    public async Task GetBreeds_ShouldReturnBreeds()
    {
        var jsonString = File.ReadAllText("fixtures/breeds_mock.json");
        var fakeResponse = JsonConvert.DeserializeObject<GetBreedResponse>(jsonString);

        _dogApiMock.Setup(api => api.GetBreeds()).ReturnsAsync(fakeResponse!);

        var result = await _dogApiMock.Object.GetBreeds();

        Assert.NotNull(result);
        Assert.Equal("success", result.Status);
        Assert.True(result.Message.ContainsKey("bulldog"));
        Assert.Contains("kelpie", result.Message["australian"]);
    }

    [Fact]
    public async Task GetSubBreeds_ShouldReturnSubBreeds()
    {
        var jsonString = File.ReadAllText("fixtures/sub_breeds_mock.json");
        var fakeResponse = JsonConvert.DeserializeObject<GetSubBreedResponse>(jsonString);

        _dogApiMock.Setup(api => api.GetSubBreeds("affenpinscher")).ReturnsAsync(fakeResponse!);

        var result = await _dogApiMock.Object.GetSubBreeds("affenpinscher");

        Assert.NotNull(result);
        Assert.Equal("success", result.Status);
        Assert.Contains("walker", result.Message);
        Assert.Contains("plott", result.Message);
    }
}
