using System.ComponentModel.DataAnnotations;

namespace DNDApp.Data.Entities
{
    public abstract class EntityBase
    {
        [Key]
        public int? Id { get; set; }
    }
}