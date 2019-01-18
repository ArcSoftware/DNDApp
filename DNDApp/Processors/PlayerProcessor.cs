using System.Linq;
using DNDApp.Common.Interfaces;
using DNDApp.Common.Models;
using DNDApp.Common.Validation;
using DNDApp.Data.Entities;

namespace DNDApp.Processors
{
    public class PlayerProcessor : ProcessorBase<PlayerEntity>, IPlayerProcessor
    {
        private readonly IRepository _repo;

        public PlayerProcessor(ISingleEntityValidator<PlayerEntity> validator, IRepository repo) : base(validator, repo)
        {
            _repo = repo;
        }

        public Player GetById(int id)
        {
            return PlayerEntityToPlayer(_repo.GetItem<PlayerEntity>(
                p => p.Id == id, i => i.PlayerCampaign));
        }

        public Player CreatePlayer(Player player)
        {
            return PlayerEntityToPlayer(ProcessCreate(PlayerToPlayerEntity(player)).Result);
        }

        public static PlayerEntity PlayerToPlayerEntity(Player player)
        {
            var playerEntity = new PlayerEntity()
            {
                Id = player.Id,
                PlayerName = player.Name
            };

            return playerEntity;
        }

        public static Player PlayerEntityToPlayer(PlayerEntity playerEntity)
        {
            var player = new Player()
            {
                Id = playerEntity.Id,
                Name = playerEntity.PlayerName,
                PlayerCampaignIds = playerEntity.PlayerCampaign.Select(pc => pc.CampaignId)
            };

            return player;
        }
    }
}