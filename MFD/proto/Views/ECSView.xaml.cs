using System.Windows;
using proto.ViewModels;

namespace proto.Views
{
    /// <summary>
    /// ECSView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ECSView : Window
    {
        public ECSView()
        {
            InitializeComponent();
            this.DataContext = new ECSViewModel();
        }
    }
}
