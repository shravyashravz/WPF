using Models.Domain;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
  public class ResumeViewModel : BaseViewModel, IScreen
    {

        private IResumeModel _resumeModel;
        public ResumeViewModel(IResumeModel resumeModel)
        {
            _resumeModel = resumeModel;

        }
        public string ScreenName => ScreenNames.ResumeScreen;

        public void OnScreenActivated()
        {
        }

        public void OnScreenDeactivated()
        {
            throw new NotImplementedException();
        }

        private string _contextName="Resume";

        public string ContextName
        {
            get { return _contextName; }
            set { _contextName = value; }
        }

        private Details _resumeDetails ;

        public  Details ResumeDetails
        {
            get
            {
                if (_resumeDetails==null)
                {
                    _resumeDetails = _resumeModel.GetDetails();
                   
                }

                return _resumeDetails;
            }
            set {
                _resumeDetails = value;
                OnPropertyChanged();
            }
        }


    }
}
