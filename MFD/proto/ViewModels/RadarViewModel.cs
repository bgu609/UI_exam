namespace proto.ViewModels
{
    public class RadarViewModel : ViewModelBase
    {
        private string _RadarPath = "/Resources/radarmain00.bmp";
        public string RadarPath
        {
            get { return _RadarPath; }
            set
            {
                _RadarPath = value;
                RaisePropertyChanged(RadarPath);
            }
        }
    }
}
