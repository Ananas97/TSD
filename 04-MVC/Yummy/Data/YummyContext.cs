using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Yummy.Models;

namespace Yummy.Data
{
    public class YummyContext : DbContext
    {
        public YummyContext(DbContextOptions<YummyContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipe { get; set; }
    }
}
