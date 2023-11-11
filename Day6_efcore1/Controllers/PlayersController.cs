using AutoMapper;
using Day6_efcore1.Context;
using Day6_efcore1.Dtos.Reuqests;
using Day6_efcore1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day6_efcore1.Controllers;

// https:localhost:5000/api/players/add
[Route("api/[controller]")]
[ApiController]

// Dependency Injection (Constructor Args Injection)
public class PlayersController : ControllerBase
{
    private readonly BaseDbContext _context;
    private IMapper _mapper;

    public PlayersController(BaseDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody] CreatePlayerRequestDto requestDto)
    {
        // oyuncu eklerken Add() metodu sadece bellekte tutar
        // SaveChanges() metodu veri tabanına yansıtır.


        Player player = _mapper.Map<Player>(requestDto);


        _context.Players.Add(player);
        _context.SaveChanges();
        return Ok();

    }
    [HttpGet("getall")]

    public IActionResult GetAllPlayers()
    {
        // Tüm oyuncuları listeleyen metod
        var players = _context.Players.ToList();
        return Ok(players);

    }

    [HttpDelete("delete")]
    public IActionResult Delete([FromQuery] int id)
    {
        var player = _context.Players.SingleOrDefault(x => x.Id.Equals(id));
        if (player == null)
        {
            return BadRequest("Aradığınız id ye ait oyuncu bulunamadı");
        }
        _context.Players.Remove(player);
        _context.SaveChanges();

        return Ok();
    }


    [HttpPut("update")]
    public IActionResult Update([FromBody] Player player)
    {
        var updatePlayer = _context.Players.SingleOrDefault(x=> x.Id== player.Id);

        if (updatePlayer == null) 
        {
            return BadRequest("Aradığınız id ye ait oyuncu bulunamadı");
        }

        updatePlayer.TeamName = player.TeamName;
        updatePlayer.Id = player.Id;
        updatePlayer.BranchName = player.BranchName;
        updatePlayer.Price= player.Price;
        updatePlayer.Name = player.Name;
        updatePlayer.Age = player.Age;


        _context.SaveChanges();

        return Ok(player);
    }

}
