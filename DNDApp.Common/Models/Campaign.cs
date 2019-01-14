using System.Collections.Generic;

namespace DNDApp.Common.Models
{
    public class Campaign
    {
        public Campaign()
        {
        }

        public IEnumerable<Player> CampaignPlayers { get; set; }
    }
}
