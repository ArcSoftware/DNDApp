using System.Linq;
using DNDApp.Common.Interfaces;
using DNDApp.Common.Models;
using DNDApp.Common.Validation;
using DNDApp.Data.Entities;
using DNDApp.Validation.Validators;

namespace DNDApp.Processors
{
    public class CampaignProcessor : ProcessorBase<CampaignEntity>, ICampaignProcessor
    {
        private readonly IRepository _repo;

        public CampaignProcessor(ISingleEntityValidator<CampaignEntity> validator, IRepository repo) 
            : base(validator, repo)
        {
            _repo = repo;
        }

        public Campaign GetById(int id)
        {
            return CampaignEntityToCampaign(_repo.GetItem<CampaignEntity>(
                c => c.Id == id, i => i.PlayerCampaign));
        }

        public Campaign CreateCampaign(Campaign campaign)
        {
            return CampaignEntityToCampaign(ProcessCreate(CampaignToCampaignEntity(campaign)).Result); 
        }

        public PlayerCampaignEntity AddPlayerToCampaign(Campaign campaign, Player player)
        {
            var joinValidator = new JoinM2MValidator<CampaignEntity, PlayerEntity, PlayerCampaignEntity>(_repo);
            return Join(joinValidator, CampaignToCampaignEntity(campaign), new PlayerEntity {Id = player.Id}).Result;
        }

        public static CampaignEntity CampaignToCampaignEntity(Campaign campaign)
        {
            var campaignEntity = new CampaignEntity()
            {
                Id = campaign.Id,
                CampaignName = campaign.Name,
            };

            return campaignEntity;
        }

        public static Campaign CampaignEntityToCampaign(CampaignEntity campaignEntity)
        {
            var campaign = new Campaign()
            {
                Id = campaignEntity.Id,
                Name = campaignEntity.CampaignName,
                CampaignPlayersIds = campaignEntity.PlayerCampaign.Select(cp => cp.CampaignId)
            };

            return campaign;
        }
    }
}
