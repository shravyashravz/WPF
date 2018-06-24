using Microsoft.Win32;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Newtonsoft.Json;
using System.IO;
using Models.Domain;
using Models.CustomEvents;

namespace Models.Models
{

    public class App1Model:IApp1Model
    {

       // public event EventHandler _show;
        public event ResultUpdatedEventHandler OnResultUpdated;
        public List<Prediction> predictionsx { get; set; }


        public  PredictionResult brwoseForFileNameAsync()
        {
            List<Prediction> t = null ;
            string fileName = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.png; *.jpg)|*.png;*.jpg;*jpeg|All files (*.*)|*.*";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (dialog.ShowDialog() == true)
            {
                fileName = dialog.FileName;
                //  filename = fileName;
                 MakePredictionAsync(fileName);
            }
            BitmapImage bitmapimage =  new BitmapImage(new Uri(fileName));

            return new PredictionResult
            {
                ImgSrc = bitmapimage,
                predictions = t
            };
        }


        private async void MakePredictionAsync(string fileName)
        {
            string url = "https://southcentralus.api.cognitive.microsoft.com/customvision/v2.0/Prediction/90837466-4674-47b1-9907-399a4c6d4fd7/image?iterationId=8ab962d2-2c58-46d1-8145-abe8d70513d9";
            string prediction_key = "e788b57cf8754ae9ab72099fe2b0b74a";
            string content_type = "application/octet-stream";
            var file = File.ReadAllBytes(fileName);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Prediction-Key", prediction_key);

                using (var content = new ByteArrayContent(file))
                {
                    content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(content_type);
                    var response = await client.PostAsync(url, content);

                    var responseString = await response.Content.ReadAsStringAsync();

                    List<Prediction> predictions = (JsonConvert.DeserializeObject<CustomVision>(responseString)).Predictions;
                    predictionsx = predictions;
                    PredictionResultReturnedEventArgs Args = new PredictionResultReturnedEventArgs(predictions);
                    OnResultUpdated.Invoke(this, Args);


                }
            }
        }



    }
}
