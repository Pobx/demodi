using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using DemoDI.Models;
using System.Text.Json;
using System.Collections.ObjectModel;

namespace DemoDI.Services
{
    public class PostService
    {
        private readonly HttpClient _httpClient;

        public PostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ObservableCollection<Post>> PostsAsync()
        {
            ObservableCollection<Post> result;
            var response = await _httpClient.GetAsync("/posts");

            if (!response.IsSuccessStatusCode)
            {
                return new ObservableCollection<Post>();
            }

            var contentStream = await response.Content.ReadAsStreamAsync();
            using (var streamReader = new StreamReader(contentStream))
            {
                result = await JsonSerializer.DeserializeAsync<ObservableCollection<Post>>(contentStream);
            }

            return result;
        }
    }
}

