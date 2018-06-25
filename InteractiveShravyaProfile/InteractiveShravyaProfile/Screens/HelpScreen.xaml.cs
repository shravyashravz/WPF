using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using ViewModels;

namespace InteractiveShravyaProfile.Screens
{
    /// <summary>
    /// Interaction logic for HelpScreen.xaml
    /// </summary>
    public partial class HelpScreen : UserControl
    {

        public HelpScreen()
        {       
            InitializeComponent();
            var vm = DataContext as HelpViewModel; 
            if (vm == null) return; 
            vm.ScreenClosing += DoSomething;

        }


        //This was a killer issue audio played in the background hence the work around : Shravya
        private void DoSomething(object sender, EventArgs e)
        {
            if (MyWebBrowser != null)
            {
                MyWebBrowser.Dispose();
            }
        }

    }

}
