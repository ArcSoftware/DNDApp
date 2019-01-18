using DNDApp.Common.Models;

namespace DNDApp.Processors
{
    public interface IPlayerProcessor
    {
        Player GetById(int id);
        Player CreatePlayer(Player player);
    }
}