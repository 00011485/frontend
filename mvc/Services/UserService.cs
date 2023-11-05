using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json; // Use your preferred JSON serializer
using mvc.Models;
using System.Collections.Generic;


namespace mvc
{
    public class UserService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UserService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            var client = _httpClientFactory.CreateClient("wiut"); // Use the name you specified in ConfigureServices
            var response = await client.GetAsync("api/users");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<User>>(content);
            }

            return null;
        }
    }
}
