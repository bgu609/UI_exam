using System.Windows.Input;

namespace proto.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
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
            radarView.Show();
        }
        public void ECSClick()
        {
            Views.ECSView ecsView = new Views.ECSView();
            ecsView.Show();
        }
        public void ConningClick()
        {
            Views.ConningView conningView = new Views.ConningView();
            conningView.Show();
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
