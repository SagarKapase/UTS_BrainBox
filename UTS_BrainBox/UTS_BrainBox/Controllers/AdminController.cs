using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UTS_BrainBox.Client.DBOperations;
using UTS_BrainBox.Client.Entities;
using UTS_BrainBox.Client.Entities.Admin;
using UTS_BrainBox.Entities;

namespace UTS_BrainBox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private BBDbContext _dbContext;
        public AdminController(BBDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("create-quiz")]
        public async Task<CreateQuizzes?> CreateQuiz([FromBody] CreateQuizzes quizData)
        {
            // Add quiz data to the DbContext
            var quizEntry = await _dbContext.AllQuizzes.AddAsync(quizData);

            // Save changes to the database
            await _dbContext.SaveChangesAsync();

            // Return the full inserted quiz data (including generated ID)
            return quizEntry.Entity;
        }
        [HttpGet("all-quizzes")]
        public async Task<ActionResult<List<CreateQuizzes>>> GetAllQuizzes()
        {
            var quizzes = await _dbContext.AllQuizzes.ToListAsync();
            return Ok(quizzes);
        }

    }
}
