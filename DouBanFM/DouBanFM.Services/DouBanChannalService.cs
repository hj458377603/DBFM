using DouBanFM.Entities;
using DouBanFM.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouBanFM.Services
{
    public class DouBanChannalService
    {
        public async Task<ChannelsResult> GetAllChannels()
        {
            HttpHelper httpHelper = new HttpHelper();
            return await httpHelper.HttpGetRequest<ChannelsResult>(ServiceUrls.ChannelsUrl);
        }
    }
}
