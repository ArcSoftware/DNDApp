using System.Collections.Generic;

namespace DNDApp.Common.Models
{
    public class Player : DNDObjectBase
    {
        public Player()
        {
            PlayerCampaignIds = new List<int>();
        }

        public IEnumerable<int> PlayerCampaignIds { get; set; }
    }
}