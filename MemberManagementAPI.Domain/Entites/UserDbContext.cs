using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MemberManagementAPI.Domain.Entites
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions option):base(option)
        {
            
        }
        public DbSet<User> User { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<Session> Session { get; set; }


    }
}
