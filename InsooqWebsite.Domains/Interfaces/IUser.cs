
using InsooqWebsite.Domains.Cores;
using InsooqWebsite.Domains.Dtos;
using InsooqWebsite.Domains.Enum;

namespace InsooqWebsite.Domains.Interfaces;

public interface IUser
{
    Task<OpStatus> Add(UserDto user);

    Task<OpStatus> Update(UserDto user);

    Task<OpStatus> Delete(int id);

    Task<User> Get(int id);

    Task<List<UserDto>> GetAll ();

    Task<List<User>> Search(string Name );






}
