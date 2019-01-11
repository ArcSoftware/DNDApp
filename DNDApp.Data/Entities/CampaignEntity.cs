using System.ComponentModel.DataAnnotations;

namespace DNDApp.Data.Entities
{
    public class CampaignEntity
    {
        [Key]
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
    }
}