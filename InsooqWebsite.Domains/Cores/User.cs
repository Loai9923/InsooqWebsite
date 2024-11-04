

using System.Text.Json.Serialization;

namespace InsooqWebsite.Domains.Cores;

public class User
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string Phone { get; set; }

    public int? RoleId { get; set; }

    
    public Role Role { get; set; }

    public int? StatusId { get; set; }
   
    public Status Status { get; set; }

    public DateTime CreateDate { get; set; } = DateTime.Now;




}
