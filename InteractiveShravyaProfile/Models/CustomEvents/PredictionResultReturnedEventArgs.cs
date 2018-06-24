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

        public PredictionResultReturnedEventArgs(List<Prediction> predictionResult)
        {
            _predictionResult = predictionResult;
        }
    }
}
