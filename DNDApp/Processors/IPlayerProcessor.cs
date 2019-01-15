using System.Threading.Tasks;
using DNDApp.Common.Models;

namespace DNDApp.Processors
{
    public interface IPlayerProcessor
    {
        ProcessingRequest<Player> GetById(int id);
        Task<ProcessingRequest<Player>> CreatePlayer(Player player);
    }
}