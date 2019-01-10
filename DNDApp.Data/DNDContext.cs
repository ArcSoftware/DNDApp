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
        public DbSet<PlayerEntity> Players { get; set; } 
        public DbSet<CampaignEntity> Campaigns { get; set; }

    }
}