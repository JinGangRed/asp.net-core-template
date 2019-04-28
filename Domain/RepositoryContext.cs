using Domain.DBModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace Domain
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
