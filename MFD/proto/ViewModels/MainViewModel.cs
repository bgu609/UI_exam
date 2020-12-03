using System.Windows.Input;

namespace proto.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public bool radarstate = false;
        public bool ecsstate = false;
        public bool conningstate = false;

        private string _MFDmain = "/Resources/seaimage.jpg";
        public string MFDmain
        {
            get { return _MFDmain; }
            set
            {
                _MFDmain = value;
                RaisePropertyChanged(MFDmain);
            }
        }


        ICommand rclickCommand, eclickCommand, cclickCommand;
        public ICommand RadarClickCommand => rclickCommand ?? (rclickCommand = new RelayCommand<object>(
                o => RadarClick()
            ));
        public ICommand ECSClickCommand => eclickCommand ?? (eclickCommand = new RelayCommand<object>(
                o => ECSClick()
            ));
        public ICommand ConningClickCommand => cclickCommand ?? (cclickCommand = new RelayCommand<object>(
                o => ConningClick()
            ));

        public void RadarClick()
        {
            Views.RadarView radarView = new Views.RadarView();
            radarView.ShowDialog();
        }
        public void ECSClick()
        {
            Views.ECSView ecsView = new Views.ECSView();
            ecsView.ShowDialog();
        }
        public void ConningClick()
        {
            Views.ConningView conningView = new Views.ConningView();
            conningView.ShowDialog();
        }

        /*public bool IsClick()
        {
            return !string.IsNullOrEmpty(inFirstName) &&
                   !string.IsNullOrEmpty(inLastName) &&
                   !string.IsNullOrEmpty(inEmail) &&
                   !string.IsNullOrEmpty(inDate.ToString());
        }*/
    }
}
