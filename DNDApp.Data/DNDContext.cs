using DNDApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DNDApp.Data
{
    public class DNDContext : DbContext
    {
        public DNDContext(DbContextOptions options) : base(options)
        {
        }

        //Register DB Models here
        public DbSet<PlayerEntity> Player { get; set; } 
        public DbSet<CampaignEntity> Campaign { get; set; }

    }
}