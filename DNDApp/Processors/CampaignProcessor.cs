using System.Linq;
using DNDApp.Common.Interfaces;
using DNDApp.Common.Models;
using DNDApp.Common.Validation;
using DNDApp.Data.Entities;

namespace DNDApp.Processors
{
    public class CampaignProcessor : ProcessorBase<CampaignEntity>, ICampaignProcessor
    {
        private readonly IRepository _repo;

        public CampaignProcessor(IValidator<CampaignEntity> validator, IRepository repo) 
            : base(validator, repo)
        {
            _repo = repo;
        }

        public Campaign GetById(int id)
        {
            return CampaignEntityToCampaign(_repo.GetItem<CampaignEntity>(
                c => c.CampaignId == id, i => i.PlayerCampaign));
        }

        private Campaign CampaignEntityToCampaign(CampaignEntity campaignEntity)
        {
            var campaign = new Campaign()
            {
                Id = campaignEntity.CampaignId,
                Name = campaignEntity.CampaignName,
                CampaignPlayersIds = campaignEntity.PlayerCampaign.Select(cp => cp.CampaignId)
            };

            return campaign;
        }
    }
}
