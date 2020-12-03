namespace proto.ViewModels
{
    public class ConningViewModel : ViewModelBase
    {
        private string _ConningPath = "/Resources/conningmain00.bmp";
        public string ConningPath
        {
            get { return _ConningPath; }
            set
            {
                _ConningPath = value;
                RaisePropertyChanged(ConningPath);
            }
        }
    }
}
