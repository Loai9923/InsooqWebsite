

using InsooqWebsite.Domains.Cores;
using InsooqWebsite.Domains.Dtos;
using InsooqWebsite.Domains.Enum;
using InsooqWebsite.Domains.Interfaces;

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

    public Task<List<UserDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<List<User>> Search(string Name)
    {
        throw new NotImplementedException();
    }

    public Task<OpStatus> Update(UserDto user)
    {
        throw new NotImplementedException();
    }
}
