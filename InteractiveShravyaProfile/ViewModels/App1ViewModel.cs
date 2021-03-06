﻿using Models.Domain;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace ViewModels
{
    public class App1ViewModel : BaseViewModel, IScreen
    {
        public string ScreenName => ScreenNames.App1Screen;




        private IApp1Model _app1Model;

        public App1ViewModel(IApp1Model app1Model)
        {
            _app1Model = app1Model;
        }



        public void OnScreenActivated()
        {
            _app1Model.OnResultUpdated += _app1Model_OnResultUpdated1;
        }

        private void _app1Model_OnResultUpdated1(object sender, Models.CustomEvents.PredictionResultReturnedEventArgs e)
        {
            Predictions = e._predictionResult;
            Probability = e._probability;
            Confidence = e._confidence;
        }

        public void OnScreenDeactivated()
        {
            _app1Model.OnResultUpdated -= _app1Model_OnResultUpdated1;
        }


        private BitmapImage _imgSrc;
        public BitmapImage ImgSrc
        {
            get
            {

                return _imgSrc;
            }

            set
            {
                if (_imgSrc != value)
                {
                    _imgSrc = value;
                    OnPropertyChanged();
                }

            }
        }

        private string _probability;

        public string Probability
        {
            get
            {

                return _probability;
            }
            set
            {
                _probability = value;
                OnPropertyChanged();
            }
        }

        private int _confidence;

        public int Confidence
        {
            get { return _confidence; }
            set
            {
                _confidence = value;
                OnPropertyChanged();
            }
        }





        private string _contextName = null;

        public string ContextName
        {
            get
            {
                if (_contextName == null)
                {
                    _contextName = _app1Model.AppDescription;
                }
                return _contextName;
            }
            set { _contextName = value; }
        }

        public ICommand BrowseFile => new RelayCommand(_browseFile);


        private IEnumerable<Prediction> _predictions;
        public IEnumerable<Prediction> Predictions
        {
            get
            {
                return _predictions;
            }
            set
            {
                if (_predictions != value)
                {
                    _predictions = value;
                    OnPropertyChanged();
                }
            }
        }
        private void _browseFile(object obj)
        {
            ImgSrc = _app1Model.brwoseForFileNameAsync().ImgSrc;
        }
    }
}
