using System.ComponentModel.DataAnnotations;

namespace DNDApp.Data.Entities
{
    public class PlayerCampaignEntity
    {
        [Key]
        public int PlayerId { get; set; }
        public int CampaignId { get; set; }
    }
}