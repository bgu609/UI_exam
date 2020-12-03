namespace proto.ViewModels
{
    public class ECSViewModel : ViewModelBase
    {
        private string _ECSPath = "/Resources/ecsmain00.bmp";
        public string ECSPath
        {
            get { return _ECSPath; }
            set
            {
                _ECSPath = value;
                RaisePropertyChanged(ECSPath);
            }
        }
    }
}
