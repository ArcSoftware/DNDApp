using DNDApp.Common.Models;

namespace DNDApp.Processors
{
    public interface IPlayerProcessor
    {
        Player GetById(int id);
        ProcessingRequest<Player> CreatePlayer(Player player);
    }
}