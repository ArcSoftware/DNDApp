using System.Collections.Generic;

namespace DNDApp.Common.Models
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        public string Name;

        public IEnumerable<Campaign> campaigns; 
    }
}