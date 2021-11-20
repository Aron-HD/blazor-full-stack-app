using BlazorApp.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorApp.Client.Services
{
    public class JudgeService : IJudgeService
    {
        private readonly HttpClient _httpClient;

        public JudgeService(HttpClient httpClient) 
        {
            _httpClient = httpClient;
        }

        public List<Judge> Judges { get; set; } = new();

        public event Action OnChange;

        public async Task<List<Judge>> CreateJudge(Judge judge)
        {
            var result = await _httpClient.PostAsJsonAsync("api/judge", judge);
            Judges = await result.Content.ReadFromJsonAsync<List<Judge>>();
            OnChange.Invoke();
            return Judges;
        }

        public async Task<List<Judge>> DeleteJudge(int id)
        {
            var result = await _httpClient.DeleteAsync($"api/judge/{id}");
            Judges = await result.Content.ReadFromJsonAsync<List<Judge>>();
            OnChange.Invoke();
            return Judges;
        }

        public async Task<Judge> GetJudge(int id)
        {
            return await _httpClient.GetFromJsonAsync<Judge>($"api/judge/{id}");
        }

        public async Task<List<Judge>> GetJudges()
        {
            Judges = await _httpClient.GetFromJsonAsync<List<Judge>>("api/judge");
            return Judges;
        }

        public async Task<List<Judge>> ReplaceJudge(Judge judge, int id)
        {
            var result = await _httpClient.PutAsJsonAsync($"api/judge/{id}", judge);
            Judges = await result.Content.ReadFromJsonAsync<List<Judge>>();
            OnChange.Invoke();
            return Judges;
        }
    }
}
