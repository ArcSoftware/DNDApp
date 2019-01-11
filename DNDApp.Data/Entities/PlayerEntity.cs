using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DNDApp.Data.Entities
{
    public class PlayerEntity
    {
        [Key]
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
    }
}