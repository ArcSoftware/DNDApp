using System.Collections.Generic;

namespace DNDApp.Common.Models
{
    public class Campaign : DNDObjectBase
    {
        public Campaign()
        {
        }

        public IEnumerable<int> CampaignPlayersIds { get; set; }
    }
}
