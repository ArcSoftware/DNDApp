using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DNDApp
{
    public partial class PlayerEntity
    {
        public PlayerEntity()
        {
            PlayerCampaign = new HashSet<PlayerCampaignEntity>();
        }

        [Key]
        public int? PlayerId { get; set; }
        public string PlayerName { get; set; }

        public ICollection<PlayerCampaignEntity> PlayerCampaign { get; set; }
    }
}
