using Models.CustomEvents;
using Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Models.Interfaces
{

    public delegate void ResultUpdatedEventHandler(Object sender, PredictionResultReturnedEventArgs e);
   public interface IApp1Model
    {

        PredictionResult brwoseForFileNameAsync();

        event ResultUpdatedEventHandler OnResultUpdated;

        List<Prediction> predictionsx { get; set; }

      string AppDescription { get; set; }
    }
}
