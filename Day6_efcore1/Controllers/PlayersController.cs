
using Day6_efcore1.Dtos.Reuqests;
using Day6_efcore1.Services.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace Day6_efcore1.Controllers;

// https:localhost:5000/api/players/add
[Route("api/[controller]")]
[ApiController]

// Dependency Injection (Constructor Args Injection)
public class PlayersController : ControllerBase
{
    private readonly PlayerService _playerService;

    public PlayersController(PlayerService playerService)
    {
        _playerService = playerService;
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody] CreatePlayerRequestDto requestDto)
    {
        var response = _playerService.Add(requestDto);
        if(response.StatusCode == System.Net.HttpStatusCode.Created)
        {
            return Created("/",response);
        }
        return BadRequest(response);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById([FromQuery] int id)
    {
        var response = _playerService.GetById(id);
        if(response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            return Ok(response);
        }

        if(response.StatusCode== System.Net.HttpStatusCode.NotFound)
        {
            return NotFound(response);
        }

        return BadRequest(response);
    }

    [HttpDelete("delete")]
    public IActionResult Delete([FromQuery] int id)
    {
        var response = _playerService.Delete(id);
        if(response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            return Ok(response);
        }

        if(response.StatusCode == System.Net.HttpStatusCode.NotFound) {
            return NotFound(response);
        }

        return BadRequest(response);

    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var response = _playerService.GetList();
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            return Ok(response);
        }
        return BadRequest(response);
    }

}
