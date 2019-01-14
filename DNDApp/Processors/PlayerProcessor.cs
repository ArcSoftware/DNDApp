using System.Linq;
using System.Threading.Tasks;
using DNDApp.Common.Interfaces;
using DNDApp.Common.Models;
using DNDApp.Common.Validation;
using DNDApp.Data.Entities;

namespace DNDApp.Processors
{
    public class PlayerProcessor : ProcessorBase<Player>
    {
        private readonly IRepository _repo;
        private PlayerEntity _dbo = null;
        private ProcessingRequest<Player> _request = new ProcessingRequest<Player>();

        public PlayerProcessor(IValidator<Player> validator, IRepository repo) : base(validator, repo)
        {
            _repo = repo;
        }

        public Player GetPlayerById(int id)
        {
            _dbo = _repo.GetItem<PlayerEntity>(p => p.PlayerId == id);

            return GetPlayerInfo(); 
        }

        public Player GetByPlayerName(string name)
        {
            _dbo = _repo.GetItem<PlayerEntity>(p => p.PlayerName == name);

            return GetPlayerInfo(); 
        }

        public override ProcessingRequest<Player> GetById(Player model)
        {
            _dbo = _repo.GetItem<PlayerEntity>(p => p.PlayerId == model.Id);
            _request.Item = GetPlayerInfo();

            return _request;
        }

        public Task<ProcessingRequest<Player>> CreatePlayer(Player player)
        {
            return ProcessCreate(player); 
        }

        private Player GetPlayerInfo()
        {
            

            var player = new Player()
            {
                Name = _dbo.PlayerName,
                Id = _dbo.PlayerId
            };

//            //Get Player Campaigns
//            var playerCampaigns = _repo.GetItems<PlayerCampaignEntity>(p => p.PlayerId == player.Id);
//            player.PlayerCampaigns = playerCampaigns.Select(campaign => _repo.GetItems<CampaignEntity>(
//                c => c.CampaignId == campaign.CampaignId).FirstOrDefault());

            return player;
        }


    }
}
