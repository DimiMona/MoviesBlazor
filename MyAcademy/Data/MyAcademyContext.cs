using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyAcademy.Models;

namespace MyAcademy.Data
{
    public class MyAcademyContext : DbContext
    {
        public MyAcademyContext (DbContextOptions<MyAcademyContext> options)
            : base(options)
        {
        }

        public DbSet<MyAcademy.Models.Direction> Direction { get; set; } = default!;
        public DbSet<MyAcademy.Models.Discipline> Discipline { get; set; } = default!;
        public DbSet<MyAcademy.Models.Group> Group { get; set; } = default!;
        public DbSet<MyAcademy.Models.Students> Students { get; set; } = default!;
        public DbSet<MyAcademy.Models.Teacher> Teacher { get; set; } = default!;
    }
}
