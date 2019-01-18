using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DNDApp.Data.Entities
{
    public partial class CampaignEntity : EntityBase
    {
        public CampaignEntity()
        {
            PlayerCampaign = new HashSet<PlayerCampaignEntity>();
        }

        public string CampaignName { get; set; }

        public ICollection<PlayerCampaignEntity> PlayerCampaign { get; set; }
    }
}