using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApi.Context;
using System.Threading.Tasks;


namespace MyApi.Controllers
{
    [ApiController]
    [Route("Monster")]
    public class MonsterController : ControllerBase
    {
        private List<Monster> Monsters = new List<Monster>();// création de notre list de player 


        private readonly ApplicationDbContext _context;

        public MonsterController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            this.Monsters.Add(new Monster("Bear"));
      

        }
        //GET
        [HttpGet]
        [Route("/GETMonster")]
        public async Task<IActionResult> Get() // recuperation de notre Player
        {
            return Ok(await _context.Monsters.ToListAsync());
        }

        //Post
        [HttpPost]
        [Route("/PostMonster")]
        public async Task<ActionResult<List<Monster>>> CreateEntity(Monster monster)
        {

            await _context.Monsters.AddAsync(monster);
            await _context.SaveChangesAsync();
            return Ok(monster);
        }

        //PUT
        [HttpPut]
        [Route("/PutMonster")]
        public async Task<ActionResult<List<Monster>>> UpdateHero(Monster request)
        {
            var monster = Monsters.Find(monster => monster.ID == request.ID);
            if (monster == null)
            {
                return BadRequest(request);
            }

            monster.name = request.name;
            monster.healthPoint = request.healthPoint;
            monster.minDamage = request.minDamage;
            monster.maxDamage = request.maxDamage;
            monster.idMonster = request.idMonster;


            await _context.SaveChangesAsync();
            return Ok(monster);

        }
        //DELETE
        [HttpDelete]
        [Route("/DeleteMonster")]
        public async Task<ActionResult<List<Monster>>> DeletePlayer(Monster request)
        {
            Monster? monster = await _context.Monsters.FirstOrDefaultAsync();
            if (monster == null)
            {
                return NotFound("Your Monster was not Found");
            }
            _context.Remove(monster);

            await _context.SaveChangesAsync();
            return Ok("The " + monster.name + " has been deleted !");
        }
    }
}











