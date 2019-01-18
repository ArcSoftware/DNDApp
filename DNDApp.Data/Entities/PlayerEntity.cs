using System.Collections.Generic;

namespace DNDApp.Data.Entities
{
    public class PlayerEntity : EntityBase
    {
        public PlayerEntity()
        {
            PlayerCampaign = new HashSet<PlayerCampaignEntity>();
        }

        public string PlayerName { get; set; }

        public ICollection<PlayerCampaignEntity> PlayerCampaign { get; set; }
    }
}