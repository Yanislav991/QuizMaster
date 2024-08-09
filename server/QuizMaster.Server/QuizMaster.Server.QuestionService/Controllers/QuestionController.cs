using Microsoft.AspNetCore.Mvc;
using QuizMaster.Server.QuestionService.Models;

namespace QuizMaster.Server.QuestionService.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class QuestionController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<QuestionDTO>>> Get()
        {
            return Ok(new List<QuestionDTO> {
                new QuestionDTO() {
                     Id = 1,
                     QuestionText = "test"
                }
            });
        }
    }
}
