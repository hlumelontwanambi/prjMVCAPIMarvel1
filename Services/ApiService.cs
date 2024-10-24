using prjMVCAPIMarvel.Models;

namespace prjMVCAPIMarvel.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TblAvenger>> GetAvengersAsync()
        {
            var response = await _httpClient.GetAsync("/users");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<TblAvenger>>();
        }

        public async Task<List<TblContact>> GetContactAsync()
        {
            var response = await _httpClient.GetAsync("/contacts");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<TblContact>>();
        }

        public async Task CreateAvengersAsync(TblAvenger newAvenger)
        {
            var response = await _httpClient.PostAsJsonAsync("/users", newAvenger);
            response.EnsureSuccessStatusCode();
        }

        public async Task CreateContactAsync(TblAvenger newContact)
        {
            var response = await _httpClient.PostAsJsonAsync("/users", newContact);
            response.EnsureSuccessStatusCode();
        }
    }
}
