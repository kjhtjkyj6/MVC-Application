using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Application.Models;

namespace MVC_Application.Data
{
    public class MVC_ApplicationContext : DbContext
    {
        public MVC_ApplicationContext (DbContextOptions<MVC_ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Application.Models.Movie> Movie { get; set; }
    }
}
