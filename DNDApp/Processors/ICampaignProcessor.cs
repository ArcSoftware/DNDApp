using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNDApp.Common.Models;

namespace DNDApp.Processors
{
    public interface ICampaignProcessor
    {
        Campaign GetById(int id);
    }
}
