using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouBanFM.Services.Common
{
    public class ServiceUrls
    {
        /// <summary>
        /// 频道列表
        /// </summary>
        public const string ChannelsUrl = "http://www.douban.com/j/app/radio/channels?client=s:mobile|y:wp7|e:NOKIA";

        /// <summary>
        /// 热门频道
        /// </summary>
        public const string HotChannelsUrl = "http://api.douban.com/v2/fm/hot_channels?apikey=01620243a8d2134d042606cafa7639e7&from=s:mobile|y:wp8|f:1|e:NOKIA&start=0&limit=6";

        /// <summary>
        /// 
        /// </summary>
        public const string RecentChannelsUrl = "http://api.douban.com/v2/fm/recent_channels?from=s:mobile|y:wp8|f:1|e:NOKIA&apikey=01620243a8d2134d042606cafa7639e7&start=0&limit=20&bid=0966919428187851";

        /// <summary>
        /// 频道详情
        /// </summary>
        public const string ChannelDetailUrl = "http://www.douban.com/j/app/radio/people?channel={0}&app_name=radio_win_phone&version=2&type=s&sid=1563339&bid=564075032977422&client=s:mobile|y:wp7|e:NOKIA";
    }
}
