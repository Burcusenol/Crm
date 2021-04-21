using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class CrmContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CRM;Trusted_Connection=true");

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Identity> Identities { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Relation> Relations { get; set; }
        public DbSet<TcCard> TcCards { get; set; }
    }
}
