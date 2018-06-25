using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModels
{
    public class HelpViewModel : BaseViewModel, IScreen
    {
        public event EventHandler ScreenClosing;

        private IHelpModel _helpModel;
        public HelpViewModel(IHelpModel helpModel)
        {
            _helpModel = helpModel;
        }
        public string ScreenName => ScreenNames.HelpScreen;

        public void OnScreenActivated()
        {

           
            //  throw new NotImplementedException();
        }

        public void OnScreenDeactivated()
        {
            Deactivate(true);
            //throw new NotImplementedException();
        }


        private bool _isClosing = false;
        public bool IsClosing
        {
            get { return _isClosing; }
            set
            {
                _isClosing = value;
                OnPropertyChanged();
                ScreenClosing?.Invoke(this, EventArgs.Empty);
                
            }
        }

        public void Deactivate(bool close)
        {
            IsClosing = close;
        }

        private string _contextName="Video Documentation to speed up things.";

        public string ContextName
        {
            get { return _contextName; }
            set { _contextName = value; }
        }

        public ICommand Open => new RelayCommand(_open);

        private void _open(object obj)
        {
            throw new NotImplementedException();
        }

        public ICommand DoSome => new RelayCommand(_dosome);

        private void _dosome(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
