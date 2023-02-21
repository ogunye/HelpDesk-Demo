using Domain.Entities;
using HelDomain.Entities;
using HelpDesk.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace HelpDesk.Api.Data
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff_Skills>()
                .HasKey(ss => new { ss.StaffId, ss.SkillCode });

            modelBuilder.ApplyConfiguration(new SkillCodeConfiguration());
        }


        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Problem> Problem { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SupportStaff> SupportStaff { get; set; }
        public DbSet<Staff_Skills> Staff_Skills { get; set; }
        public DbSet<Ref_Skill_Codes> Ref_Skill_Codes { get; set; }

    }
}
