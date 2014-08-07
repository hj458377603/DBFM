using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;
using DouBanFM.Services;
using System.Threading.Tasks;
using DouBanFM.Entities;
using System.Collections.ObjectModel;

namespace DouBanFM
{
    public class MainPageViewModel : Screen
    {
        #region 字段

        private DouBanChannalService douBanChannalService = new DouBanChannalService();
        private readonly INavigationService navigationService;

        private const string btnFavImageUrl = "Assets/Images/fav.png";
        private const string btnUnFavImageUrl = "Assets/Images/unfav.png";
        private const string btnPlayImageUrl = "Assets/Images/play.png";
        private const string btnPauseImageUrl = "Assets/Images/pause.png";

        #endregion

        #region 属性

        private string songName;
        public string SongName
        {
            get
            {
                return songName;
            }
            set
            {
                songName = value;
                NotifyOfPropertyChange(() => SongName);
            }
        }

        private ObservableCollection<Channel> channalList;

        public ObservableCollection<Channel> ChannalList
        {
            get
            {
                return channalList;
            }
            set
            {
                channalList = value;
                NotifyOfPropertyChange(() => ChannalList);
            }
        }

        private string playImage = btnPlayImageUrl;

        public string PlayImage
        {
            get { return playImage; }
            set
            {
                playImage = value;
                NotifyOfPropertyChange(() => PlayImage);
            }
        }

        private string favImage=btnUnFavImageUrl;

        public string FavImage
        {
            get { return favImage; }
            set
            {
                favImage = value;
                NotifyOfPropertyChange(() => FavImage);
            }
        }


        #endregion

        #region 事件

        public void Paly()
        {
            SongName = "似的";

            // 按钮图片
            if (PlayImage == btnPlayImageUrl)
            {
                PlayImage = btnPauseImageUrl;
            }
            else
            {
                PlayImage = btnPlayImageUrl;
            }
        }

        public void Fav()
        {
            // 按钮图片
            if (FavImage == btnFavImageUrl)
            {
                FavImage = btnUnFavImageUrl;
            }
            else
            {
                FavImage = btnFavImageUrl;
            }
        }

        #endregion

        #region 构造方法

        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        #endregion

        #region 重写

        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await GetAllChannels();
        }

        #endregion

        #region 方法

        private async Task GetAllChannels()
        {
            ChannelsResult result = await douBanChannalService.GetAllChannels();
            if (result != null)
            {
                ChannalList = result.Channels;
            }
        }

        #endregion
    }
}
