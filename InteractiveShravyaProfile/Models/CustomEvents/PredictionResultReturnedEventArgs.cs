using Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CustomEvents
{
   public class PredictionResultReturnedEventArgs : EventArgs
    {
        public List<Prediction> _predictionResult {get;}

        public string _probability { get; }

        public int _confidence { get; }

        public PredictionResultReturnedEventArgs(List<Prediction> predictionResult,string probability,int confidence)
        {
            _predictionResult = predictionResult;
            _probability = probability;
            _confidence = confidence;
        }
    }
}
