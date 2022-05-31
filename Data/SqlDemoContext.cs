using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SqlDemo.Models;

namespace SqlDemo.Data
{
    public class SqlDemoContext : DbContext
    {
        public SqlDemoContext (DbContextOptions<SqlDemoContext> options)
            : base(options)
        {
        }

        public DbSet<SqlDemo.Models.Comment>? Comment { get; set; }
    }
}
