using System.ComponentModel.DataAnnotations;

namespace DNDApp.Data.Entities
{
    public class PlayerCampaignEntity : EntityBase
    {
        public int PlayerId { get; set; }
        public int CampaignId { get; set; }

        public CampaignEntity Campaign { get; set; }
        public PlayerEntity Player { get; set; }
    }
}