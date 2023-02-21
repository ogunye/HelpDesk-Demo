using HelpDesk_Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk_Infrastructure.BaseRepositories
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }

        public DbSet<Equipment>? Equipment { get; set; }
        public DbSet<Problem>? Problem { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<SupportStaff>? SupportStaff { get; set; }
        public DbSet<Staff_Skills>? Staff_Skills { get; set; }
        public DbSet<Ref_Skill_Codes>? Ref_Skill_Codes { get; set; }
    }
}
