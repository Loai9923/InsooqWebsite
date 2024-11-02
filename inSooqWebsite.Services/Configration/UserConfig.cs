

using InsooqWebsite.Domains.Cores;
using Microsoft.EntityFrameworkCore;

namespace inSooqWebsite.Services.Configration;

public class UserConfig
{
    public static void UserConfigrations(ModelBuilder modelBuilder)
    {
        UserConfigrationRole(modelBuilder);
        UserConfigrationStatus(modelBuilder);
        UserConfigrationUser(modelBuilder);
    }
    public static void UserConfigrationRole(ModelBuilder modelBuilder) 
    {
        modelBuilder.Entity<Role>().HasData(new List<Role>()
            {
            new Role{Id = 1 , Name= "Manager" } ,
            new Role{Id = 2 ,Name = "Admin" } ,
            new Role{Id = 3 ,Name = "User" }
            }
            );


    }

    public static void UserConfigrationStatus(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Status>().HasData(new List<Status>()
        {
            new Status{Id = 1 ,Name ="Active" },
            new Status{Id = 2 ,Name = "Blocked"},
            new Status{Id = 3 ,Name = "Deleted" } }
        );
    
    }

    public static void UserConfigrationUser(ModelBuilder modelBuilder) 
    {
        modelBuilder.Entity<User>().HasData(new List<User>() 
        { 
           new User{Id = 1 ,Name = "Loai Shhada" , Email="Loaishhada1999@gmail.com" , Password="Admin@1234" , Phone="0798323552" ,RoleId=1 ,StatusId=1 , }    
        
        });
    }
}
