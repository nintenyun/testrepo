using LearnCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnCore.Domain
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SYS_USER> SYS_USER { get; set; }
        public DbSet<Blog> Blog { get; set; }

        public DbSet<Position> Position { get; set; }

    }
}
