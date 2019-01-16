using System.Collections.Generic;

namespace DNDApp.Common.Models
{
    public class CampaignEntity
    {
        public CampaignEntity()
        {
        }

        public IEnumerable<Player> CampaignPlayers { get; set; }
    }
}
