using Microsoft.AspNetCore.Mvc;
using LogisticsApi.Dtos;
using LogisticsApi.Services;

namespace LogisticsApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    [HttpGet("{id}")]
    public IActionResult GetUsers(int id)
    {
        // Tìm User theo id và trả về kết quả
        var users = _userService.GetUsers(id);
        return Ok(users);
    }
    [HttpPost]
    public IActionResult PostUser(CreateUserDto request)
    {
        var userDto = new UserDto
        {
            Name = request.Name,
            Age = request.Age
        };

        var result = _userService.AddUser(userDto);
        return CreatedAtAction(201,result);
    }
}
