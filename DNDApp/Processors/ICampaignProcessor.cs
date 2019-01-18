using DNDApp.Common.Models;
using DNDApp.Data.Entities;

namespace DNDApp.Processors
{
    public interface ICampaignProcessor
    {
        Campaign GetById(int id);
        Campaign CreateCampaign(Campaign campaign);
        PlayerCampaignEntity AddPlayerToCampaign(Campaign campaign, Player player);
    }
}