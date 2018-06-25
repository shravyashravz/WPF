using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using ViewModels;
using InteractiveShravyaProfile.IOC.Navigator;
using InteractiveShravyaProfile.IOC;

namespace InteractiveShravyaProfile
{
    public delegate void PageRequestEventHandler(object sender, PageRequestEventArgs args);

    public class MainViewModel:BaseViewModel
    {
        private BaseViewModel _currentViewModel;
        private readonly INavigator _navigator;
        public MainViewModel(INavigator navigator)

        {
            _navigator = navigator;
            Initialize();

        }

        private void Initialize()
        {
            CurrentViewModel = _navigator.GetInitialViewModel();
        }

        public BaseViewModel CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                if (_currentViewModel != value)
                {
                    _currentViewModel = value;

                    OnPropertyChanged();
                }
            }
        }



        public ICommand NavigateToResume => new RelayCommand(_navigateToResume);

        private void _navigateToResume(object obj)
        {
            changeScreen(obj);
        }

        private void changeScreen(object obj)
        {
            BaseViewModel viewModel = _navigator.GetViewModelByName(obj.ToString());
            if(CurrentViewModel != viewModel)
            {
                ScreenchangeNotifications(CurrentViewModel, viewModel);
            }
        }

        private void ScreenchangeNotifications(BaseViewModel currentViewModel, BaseViewModel viewModel)
        {
            ChangeViewModel(viewModel);

        }

        private void ChangeViewModel(BaseViewModel viewModel)
        {
            ((IScreen)CurrentViewModel).OnScreenDeactivated();
             CurrentViewModel = viewModel;
            ((IScreen)CurrentViewModel).OnScreenActivated();
        }

        public ICommand NavigateToApp1 => new RelayCommand(_navigateToApp1);

        private void _navigateToApp1(object obj)
        {
            changeScreen(obj);
        }
        public ICommand NavigateToApp2 => new RelayCommand(_navigateToApp2);

        private void _navigateToApp2(object obj)
        {
            changeScreen(obj);
        }

        public ICommand NavigateToHelp => new RelayCommand(_navigateToHelp);

        private void _navigateToHelp(object obj)
        {
            changeScreen(obj);
        }
    }
}
