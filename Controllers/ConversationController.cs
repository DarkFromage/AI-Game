using AI_Game.APIServices;
using AI_Game.NPCs;
using Microsoft.AspNetCore.Mvc;
using AI_Game.ContextManagement;

namespace AI_Game.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversationController : ControllerBase
    {
        private readonly IContextAgent _contextAgent;
        private readonly IApiService _apiService;
        private readonly INpc _npc;

        public ConversationController(IContextAgent contextAgent, IApiService apiService, INpc npc)
        {
            _contextAgent = contextAgent;
            _apiService = apiService;
            _npc = npc;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserMessage userMessage)
        {
            if (userMessage == null || string.IsNullOrWhiteSpace(userMessage.Input))
            {
                return BadRequest("Input message is required.");
            }

            //var previousContext = _contextAgent.GetContext(_npc.Name, userMessage.Input);
            //var userInput = $"{previousContext}User: {userMessage.Input}\n";
            var response = await _apiService.GetAgentResponseAsync(_npc.Name, userMessage.Input);

            return Ok(new { response.Response });
        }


        public class UserMessage
        {
            public required string Input { get; set; }
        }
    }

}
