using System.Collections.Generic;

namespace DNDApp.Common.Models
{
    public class Player : DNDObjectBase
    {
        public Player()
        {
        }

        public IEnumerable<Campaign> PlayerCampaigns { get; set; }
//        public IEnumerable<Charactors> Charactors { get; set; }
    }
}