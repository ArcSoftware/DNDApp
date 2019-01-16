using System.Linq;
using DNDApp.Common.Interfaces;
using DNDApp.Common.Models;
using DNDApp.Common.Validation;
namespace DNDApp.Processors
{
    public class PlayerProcessor : ProcessorBase<PlayerEntity>, IPlayerProcessor
    {
        private readonly IRepository _repo;
        private ProcessingRequest<Player> _request = new ProcessingRequest<Player>();

        public PlayerProcessor(IValidator<PlayerEntity> validator, IRepository repo) : base(validator, repo)
        {
            _repo = repo;
        }

        public ProcessingRequest<Player> GetById(int id)
        {
            //var player = PlayerEntityToPlayer(_repo.GetItem<PlayerEntity>(p => p.PlayerId == id));

            //Get Player Campaigns
            var playerCampaigns = _repo.GetItemsWithInclude<PlayerCampaignEntity>
                (p => p.PlayerId == id, i => i.Campaign, i => i.Player);

            foreach (var campaign in playerCampaigns)
            {
                //player.PlayerCampaignIds.Append(campaign.CampaignId); 
            }

            //_request.Item = player;

            return _request;
        }

        public ProcessingRequest<Player> CreatePlayer(Player player)
        {
            var playerEntity = PlayerToPlayerEntity(player);
            var playerEntityRO = ProcessCreate(playerEntity).Result;

            _request = new ProcessingRequest<Player>()
            {
                IsValid = playerEntityRO.IsValid,
                Item = PlayerEntityToPlayer(playerEntityRO.Item),
                Messages = playerEntityRO.Messages
            };

            return _request;
        }

        private PlayerEntity PlayerToPlayerEntity(Player player)
        {
            var playerEntity = new PlayerEntity()
            {
                PlayerId = player.Id,
                PlayerName = player.Name
            };

            return playerEntity;
        }

        private Player PlayerEntityToPlayer(PlayerEntity playerEntity)
        {
            var player = new Player()
            {
                Id = playerEntity.PlayerId,
                Name = playerEntity.PlayerName
            };

            return player;
        }
    }
}