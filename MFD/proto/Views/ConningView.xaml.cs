using System.Windows;
using proto.ViewModels;

namespace proto.Views
{
    /// <summary>
    /// ConningView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ConningView : Window
    {
        public ConningView()
        {
            InitializeComponent();
            this.DataContext = new ConningViewModel();
        }
    }
}
