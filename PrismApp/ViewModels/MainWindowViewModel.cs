using Prism.Mvvm;

namespace PrismApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Unity Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
