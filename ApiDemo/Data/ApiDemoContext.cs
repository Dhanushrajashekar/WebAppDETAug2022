using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiDemo.Models;
using APIDemo.Models;

namespace ApiDemo.Data
{
    public class ApiDemoContext : DbContext
    {
        public ApiDemoContext (DbContextOptions<ApiDemoContext> options)
            : base(options)
        {
        }

        public DbSet<ApiDemo.Models.User> User { get; set; } = default!;

        public DbSet<APIDemo.Models.TodoItem>? TodoItem { get; set; }
    }
}
