using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DevCard_MVC.Models;

namespace DevCard_MVC.Data
{
    public class DevCard_MVCContext : DbContext
    {
        public DevCard_MVCContext (DbContextOptions<DevCard_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<DevCard_MVC.Models.Project> Project { get; set; }

        public DbSet<DevCard_MVC.Models.Article> Article { get; set; }
    }
}
