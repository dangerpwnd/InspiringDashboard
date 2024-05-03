using Microsoft.AspNetCore.Components;

namespace InspiringDash.ArtService
{
    [Inject]
    public class ArtService : IArtService
    {   
        private readonly HttpClient _httpClient;
        const string _baseURL = "";
        const string _artEndpoint = "";
        const string _host = "";
        const string _key = "";

        public ArtService(HttpClient httpClient)
        {
            @inject 
            _httpClient = httpClient;
        }
        public Task<List<Artwork>> GetArtworksAsync() {
            _httpClient.BaseAddress = new Uri(_baseURL);
            _httpClient.DefaultRequestHeaders.Add();
            _httpClient.DefaultRequestHeaders.Add();
        }
    }
}
