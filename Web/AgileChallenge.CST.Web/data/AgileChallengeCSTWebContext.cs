using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using AgileChallenge.CST.Web.data;

namespace AgileChallenge.CST.Web.data
{
    public class AgileChallengeCSTWebContext : DbContext 
    {
        /* Define a DbSet for each entity of the application */

        public AgileChallengeCSTWebContext()
        {
        }
        public AgileChallengeCSTWebContext CreateDbContext(string[] args)
        {
            throw new NotImplementedException();
        }

        public DbSet<Subject> Subjects { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;initial catalog=Challenge02DB;user id=sa;password=test1234");
        }

        public AgileChallengeCSTWebContext(DbContextOptions<AgileChallengeCSTWebContext> options)
            : base(options)
        {
        }

        public DbSet<AgileChallenge.CST.Web.data.Address> Address { get; set; }
        
        
    }
}
