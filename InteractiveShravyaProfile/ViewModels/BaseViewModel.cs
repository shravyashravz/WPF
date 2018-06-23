using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public abstract class BaseViewModel : IDisposable,INotifyPropertyChanged
    {
        public event PageChangedRequestedEventHandler PageChangedRequested;
                
        public delegate void PageChangedRequestedEventHandler(object sender, string screenName);

        bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }
            if (disposing)
            {
            }
             disposed = true;

        }

        ~BaseViewModel()
        {
            Dispose(false);
         }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected virtual void OnPageChangeRequested(string screenname)
        {
            PageChangedRequested?.Invoke(this, screenname);
        }
    }
}
