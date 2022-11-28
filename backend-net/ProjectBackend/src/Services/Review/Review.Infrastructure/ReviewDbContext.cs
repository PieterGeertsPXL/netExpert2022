using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Review.Domain;

namespace Review.Infrastructure
{
    internal class ReviewDbContext : DbContext
    {
        public DbSet<RatableItem> retableItems { get; set; }
        public DbSet<Rating> ratings { get; set; }
        public DbSet<Domain.Review> reviews { get; set; }

        public ReviewDbContext(DbContextOptions options) : base(options) { }
    }
}
