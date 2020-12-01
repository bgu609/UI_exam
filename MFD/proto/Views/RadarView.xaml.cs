using System.Windows;
using proto.ViewModels;

namespace proto.Views
{
    /// <summary>
    /// RadarView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class RadarView : Window
    {
        public RadarView()
        {
            InitializeComponent();
            this.DataContext = new RadarViewModel();
        }

        private void Window_Closed(object sender, System.EventArgs e)
        {
            
        }
    }
}
