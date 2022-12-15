using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApi.Context;
using System.Threading.Tasks;


namespace MyApi.Controllers
{
    [ApiController]
    [Route("Entity")]
    public class EntityController : ControllerBase
    {
        private List<Entity> Entitys = new List<Entity>();// création de notre list de player 


        private readonly ApplicationDbContext _context;

        public EntityController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            this.Entitys.Add(new Entity("Player"));

        }

        [HttpGet]
        public async Task<IActionResult> Get() // recuperation de notre Player
        {
            return Ok(await _context.Entitys.ToListAsync());
        }
        [HttpPost]
        public async Task <ActionResult<List<Entity>>> CreateEntity( Entity entity)
        {

            await _context.Entitys.AddAsync(entity);
            await _context.SaveChangesAsync();
            return Ok(entity);
        }
        [HttpPut]
        public async Task<ActionResult<List<Entity>>> UpdateHero(Entity request)
        {
            var entity = Entitys.Find(entity => entity.ID == request.ID);
            if (entity == null)
            {
                return BadRequest(request);
            }

            entity.name = request.name;
            entity.healthPoint = request.healthPoint;
            entity.minDamage = request.minDamage;
            entity.maxDamage = request.maxDamage;

            await _context.SaveChangesAsync();
            return Ok(entity);
           
        }
    }
}











