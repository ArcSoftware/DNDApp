using System.ComponentModel.DataAnnotations;

namespace DNDApp
{
    public partial class PlayerCampaignEntity
    {
        [Key]
        public int? Id { get; set; }
        public int PlayerId { get; set; }
        public int CampaignId { get; set; }

        public CampaignEntity Campaign { get; set; }
        public PlayerEntity Player { get; set; }
    }
}
