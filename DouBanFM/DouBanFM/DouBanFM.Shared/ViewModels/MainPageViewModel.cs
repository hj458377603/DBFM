using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;
using DouBanFM.Services;
using System.Threading.Tasks;
using DouBanFM.Entities;

namespace DouBanFM
{
    public class MainPageViewModel : Screen
    {
        private DouBanChannalService douBanChannalService = new DouBanChannalService();
        readonly INavigationService navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await GetAllChannels();
        }

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

        public void Paly()
        {
            SongName = "似的";
        }


        #region 方法

        private async Task GetAllChannels()
        {
            ChannelsResult result = await douBanChannalService.GetAllChannels();
            if (result != null)
            {

            }
        }

        #endregion
    }
}
