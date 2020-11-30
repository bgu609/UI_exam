using System;
using System.Windows;
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
            MessageBox.Show("radar click");
        }
        public void ECSClick()
        {
            MessageBox.Show("ECS click");
        }
        public void ConningClick()
        {
            MessageBox.Show("Conning click");
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
