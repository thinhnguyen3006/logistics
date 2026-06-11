using Microsoft.AspNetCore.Mvc;
using LogisticsApi.Dtos;

namespace LogisticsApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet]
    public IActionResult GetUsers()
    {
        var users = new List<UserDto>
        {
            new UserDto
            {
                Id = 1,
                Name = "An",
                Age = 20
            },
            new UserDto
            {
                Id = 2,
                Name = "Bình",
                Age = 25
            },
            new UserDto
            {
                Id = 3,
                Name = "Cường",
                Age = 30
            }
        };
        return Ok(users);
    }
    [HttpPost]
    public IActionResult PostUser(CreateUserDto request)
    {
        var users = new UserDto
        {
            Id = 1,
            Name = request.Name,
            Age = request.Age
        };
        return Ok(users);
    }
}
