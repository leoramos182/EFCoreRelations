using EFCoreRelations.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreRelations.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly DataContext context;

        public CharacterController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Character>>> Get(int userId)
        {
            var response = await this.context.Character
                .Where(c => c.UserId == userId)
                .ToListAsync();

            return response;
                
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> Create(Character character)
        {
            this.context.Character.Add(character);
            await this.context.SaveChangesAsync();

            return await Get(character.UserId);

        }
    }
}
