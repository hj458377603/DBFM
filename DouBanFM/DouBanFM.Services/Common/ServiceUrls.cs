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
        /// 频道详情
        /// </summary>
        public const string ChannelDetailUrl = "http://www.douban.com/j/app/radio/people?channel={0}&app_name=radio_win_phone&version=2&type=s&sid=1563339&bid=564075032977422&client=s:mobile|y:wp7|e:NOKIA";
    }
}
