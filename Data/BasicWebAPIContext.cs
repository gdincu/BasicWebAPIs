using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BasicWebAPI.Pages.Models;

namespace BasicWebAPI.Data
{
    public class BasicWebAPIContext : DbContext
    {
        public BasicWebAPIContext (DbContextOptions<BasicWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<BasicWebAPI.Pages.Models.Movie> Movie { get; set; }
    }
}
