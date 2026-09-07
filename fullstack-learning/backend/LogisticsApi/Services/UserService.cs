using LogisticsApi.Dtos;
using LogisticsApi.Data;
using LogisticsApi.Entities;

namespace LogisticsApi.Services;

public class UserService
{
    // Constructor 
    private readonly LogisticsDbContext _context;
    public UserService(LogisticsDbContext context)
    {
        _context = context;
    }

    public UserDto GetUsers(int id)
    {
        // Lấy  bảng Users từ cơ sở dữ liệu và chuyển đổi sang danh sách UserDto
        // Where() sẽ lọc các User có Id bằng id được truyền vào
       var users = _context.Users.Where(user => user.Id == id).Select(user => new UserDto
       {
        Id = user.Id,
        Name = user.Name,
        Age = user.Age,
       }).FirstOrDefault();
       // FirstOrDefault() sẽ trả về phần tử đầu tiên hoặc null nếu không có phần tử nào phù hợp
       // ToList() sẽ chuyển đổi kết quả truy vấn thành danh sách UserDto
       return users;
    }
    public User AddUser(UserDto userDto)
    {
        // Tạo User từ UserDto và thêm vào cơ sở dữ liệu
        var user = new User
        {
            Name = userDto.Name,
            Age = userDto.Age
        };
        // Thêm người dùng mới vào cơ sở dữ liệu
        _context.Users.Add(user);
        // Lưu các thay đổi vào cơ sở dữ liệu
        _context.SaveChanges();

        return new UserDto
        {
            Id = user.Id,
            Name = user.Name,
            Age = user.Age
        };
    }
}