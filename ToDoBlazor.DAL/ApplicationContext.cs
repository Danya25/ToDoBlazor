using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoBlazor.DAL.Models;

namespace ToDoBlazor.DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Mission> Missions { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
    }
}
