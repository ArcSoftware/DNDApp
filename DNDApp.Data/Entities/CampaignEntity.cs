using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DNDApp.Data.Entities
{
    public partial class CampaignEntity
    {
        public CampaignEntity()
        {
            PlayerCampaign = new HashSet<PlayerCampaignEntity>();
        }

        [Key]
        public int? CampaignId { get; set; }
        public string CampaignName { get; set; }

        public ICollection<PlayerCampaignEntity> PlayerCampaign { get; set; }
    }
}