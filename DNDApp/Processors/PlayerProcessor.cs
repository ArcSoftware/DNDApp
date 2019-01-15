using System.Linq;
using System.Threading.Tasks;
using DNDApp.Common.Interfaces;
using DNDApp.Common.Models;
using DNDApp.Common.Validation;
using DNDApp.Data.Entities;

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
            var player = PlayerEntityToPlayer(_repo.GetItem<PlayerEntity>(p => p.PlayerId == id));

            //Get Player Campaigns
            //var playerCampaigns = _repo.GetItems<PlayerCampaignEntity>(p => p.PlayerId == player.Id);
            //player.PlayerCampaignIds = playerCampaigns.Select(campaign => _repo.GetItems<CampaignEntity>(
            //c => c.CampaignId == campaign.CampaignId).FirstOrDefault().CampaignId);

            _request.Item = player;

            return _request;
        }

        public async Task<ProcessingRequest<Player>> CreatePlayer(Player player)
        {
            var playerEntity = PlayerToPlayerEntity(player);
            _request.Item = PlayerEntityToPlayer(ProcessCreate(playerEntity).Result.Item);
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