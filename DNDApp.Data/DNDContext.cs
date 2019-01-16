using Microsoft.EntityFrameworkCore;

namespace DNDApp.Data
{
    public class DNDContext : DbContext
    {
        public DNDContext(DbContextOptions options) : base(options)
        {
        }

        //Register DB Models here
        public virtual DbSet<CampaignEntity> Campaign { get; set; }
        public virtual DbSet<PlayerEntity> Player { get; set; }
        public virtual DbSet<PlayerCampaignEntity> PlayerCampaign { get; set; }
    }
}