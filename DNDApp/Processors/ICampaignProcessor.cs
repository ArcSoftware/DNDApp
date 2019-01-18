using DNDApp.Common.Models;

namespace DNDApp.Processors
{
    public interface ICampaignProcessor
    {
        Campaign GetById(int id);
        Campaign CreateCampaign(Campaign campaign);
    }
}