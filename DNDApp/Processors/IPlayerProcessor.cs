using DNDApp.Common.Models;
using DNDApp.Data.Entities;

namespace DNDApp.Processors
{
    public interface IPlayerProcessor
    {
        ProcessingRequest<Player> GetById(int id);
        ProcessingRequest<Player> CreatePlayer(Player player);
    }
}