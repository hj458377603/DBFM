using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;

namespace DouBanFM
{
    public class MainPageViewModel : Screen 
    {
        readonly INavigationService navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
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
                NotifyOfPropertyChange(() =>SongName);
            }
        }

        public void Paly() 
        {
            SongName = "似的";
        }
    }
}
