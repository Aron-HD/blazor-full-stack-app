using BlazorApp.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Client.Services
{
    public interface IJudgeService
    {
        event Action OnChange;
        List<Judge> Judges { get; set; }
        Task<List<Judge>> GetJudges();
        Task<Judge> GetJudge(int id);
        Task<List<Judge>> CreateJudge(Judge judge);
        Task<List<Judge>> ReplaceJudge(Judge judge, int id);
    }
}
