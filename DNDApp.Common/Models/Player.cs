using System.Collections.Generic;

namespace DNDApp.Common.Models
{
    public class Player : DNDObjectBase
    {
        public Player()
        {
        }

        public IEnumerable<int> PlayerCampaignIds { get; set; }
//        public IEnumerable<Charactors> Charactors { get; set; }
    }
}