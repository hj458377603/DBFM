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
        readonly INavigationService navigationService;

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


        #endregion


        #region Command

        public void Paly()
        {
            SongName = "似的";
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
