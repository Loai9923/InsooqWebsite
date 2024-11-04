

using InsooqWebsite.Domains.Cores;
using InsooqWebsite.Domains.Dtos;
using InsooqWebsite.Domains.Enum;
using InsooqWebsite.Domains.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace inSooqWebsite.Services;

public class UserServices : IUser
{
    private readonly InSooqDbContext _context;
    public UserServices(InSooqDbContext context)
    {
        _context = context;
    }
    public async Task<OpStatus> Add(UserDto user)
    {
      
        try
        {
            if (user == null)
            {
                return OpStatus.error;
            }
            else
            {
                var NewUser = new User()
                {
                    Name = user.Name,
                    Email = user.Email,
                    Password = user.Password,
                    Phone = user.Phone,
                    RoleId = 3 ,
                    StatusId = 1 ,

                };

                await _context.Users.AddAsync(NewUser);
                await _context.SaveChangesAsync();
                return OpStatus.success;
            }

        }
        catch 
        {
            throw;        
        }
    }

    public Task<OpStatus> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<User> Get(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ViewUserDto>> GetAll()
    {
        try 
        {
            var list = await _context.Users
                .Include(q=>q.Role).Include(q=>q.Status).Select(q=>new ViewUserDto() 
                { 
                 Name=q.Name,
                 Email=q.Email,
                 Phone=q.Phone,
                 RoleName = q.Role.Name,
                 StatusName  = q.Status.Name,
                
                })
                .ToListAsync();
            
            return list;
        }
        catch 
        {
        throw ;
        }
    }

    public async Task<List<ViewUserDto>> Search(string Name)
    {
        try
        {
            var list = await _context.Users
                .Include(q => q.Role)
                .Include(q => q.Status)
                .Where(q => q.Name == Name)
                .Select(q => new ViewUserDto()
                {
                    Name = q.Name,
                    Email = q.Email,
                    Phone = q.Phone,
                    RoleName = q.Role.Name,
                    StatusName = q.Status.Name,

                })
                .ToListAsync();
   

            return list;
        }
        catch
        {
            throw;
        }
    }

    public Task<OpStatus> Update(UserDto user)
    {
        throw new NotImplementedException();
    }
}
