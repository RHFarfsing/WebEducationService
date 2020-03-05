using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebEducationService.Models;

namespace WebEducationService.Data
{
    public class EdDbContext : DbContext {
        public EdDbContext(DbContextOptions<EdDbContext> options)
            : base(options) {
        }

        public DbSet<Major> Majors { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder model) {
            model.Entity<Student>(e => {
                e.HasKey(x => x.Id);
                e.Property(x => x.Firstname).HasMaxLength(30).IsRequired();
                e.Property(x => x.Lastname).HasMaxLength(30).IsRequired();
                e.Property(x => x.SAT);
                e.Property(x => x.GPA);
                e.HasOne(x => x.Major).WithMany(x => x.Students).HasForeignKey(x => x.MajorId).OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}

