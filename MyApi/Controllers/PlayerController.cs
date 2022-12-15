using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApi.Context;
namespace MyApi.Controllers
{

    [ApiController]
    [Route("Player")]
    public class PlayerController : ControllerBase
    {

        private List<Player> Players = new List<Player>();// création de notre list de player 




        private readonly ApplicationDbContext _context;

        public PlayerController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            this.Players.Add(new Player("Player"));
        }
        //GET
        [HttpGet]
        [Route("/GetPlayer")]
        public async Task<IActionResult> Get() // recuperation de notre Player
        {
            return Ok(await _context.Players.ToListAsync());
        }


        //POST
        [HttpPost]
        [Route("/PostPlayer")]
        public async Task<ActionResult<List<Player>>> CreateEntity(Player player)
        {

            await _context.Players.AddAsync(player);
            await _context.SaveChangesAsync();
            return Ok(player);
        }

        //PUT
        [HttpPut]
        [Route("/PutPlayer")]
        public async Task<ActionResult<List<Player>>> UpdatePlayer(Player request)
        {
            var player = Players.Find(player => player.ID == request.ID);
            if (player == null)
            {
                return BadRequest(request);
            }

            player.name = request.name;
            player.healthPoint = request.healthPoint;
            player.minDamage = request.minDamage;
            player.maxDamage = request.maxDamage;
            player.lvl = request.lvl;
            player.exp = request.exp;
            player.nbrKill= request.nbrKill;


            await _context.SaveChangesAsync();
            return Ok(player);

        }
        
        //DELETE
        [HttpDelete]
        [Route("/DeletePlayer")]
        public async Task<ActionResult<List<Player>>> DeletePlayer( Player request)
        {
            Player? player = await _context.Players.FirstOrDefaultAsync();
            if (player == null)
            {
                return NotFound("Your Player was not Found");
            }
            _context.Remove(player);

            await _context.SaveChangesAsync();
            return Ok("The " + player.name + " has been deleted !");
        }

    }
}











