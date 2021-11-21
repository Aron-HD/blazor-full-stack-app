using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Controllers
{
    // api/judge
    [Route("api/[controller]")]
    [ApiController]
    public class JudgeController : ControllerBase
    {

        private readonly DataContext _context;

        public JudgeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetJudges()
        {
            // entity framework / db call should really be done in a service that implements an interface
            return base.Ok(await GetDbJudges());
        }

        private async Task<List<Judge>> GetDbJudges()
        {
            return await _context.Judges.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleJudge(int id)
        {
            var judge = await GetDbJudge(id);
            if (judge == null)
                return NotFound("Judge was not found.");
            return Ok(judge);
        }

        private async Task<Judge> GetDbJudge(int id)
        {
            return await _context.Judges.FirstOrDefaultAsync(j => j.Id == id);
        }

        [HttpPost]
        public async Task<IActionResult> CreateJudge(Judge judge)
        {
            _context.Judges.Add(judge);
            await _context.SaveChangesAsync();
            Console.WriteLine($"Created judge {judge.Id}");
            return Ok(await GetDbJudges());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ReplaceJudge(Judge judge, int id)
        {
            var dbJudge = await GetDbJudge(id);
            if (dbJudge == null)
                return NotFound("Judge was not found.");

            dbJudge.FirstName = judge.FirstName;
            dbJudge.LastName = judge.LastName;
            dbJudge.Role = judge.Role;
            dbJudge.Company = judge.Company;
            dbJudge.Bio = judge.Bio;
            dbJudge.Chair = judge.Chair;
            dbJudge.Headshot = judge.Headshot;
            dbJudge.Email = judge.Email;
            //dbJudge.Category = judge.Category;
            
            await _context.SaveChangesAsync();
            Console.WriteLine($"Updated judge {id}");
            return Ok(await GetDbJudges());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJudge(int id)
        {
            var dbJudge = await GetDbJudge(id);
            if (dbJudge == null)
                return NotFound("Judge was not found.");

            _context.Judges.Remove(dbJudge);
            await _context.SaveChangesAsync();
            Console.WriteLine($"Deleted judge {id}");
            return Ok(await GetDbJudges());
        }
    }
}
