using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Models.Domain
{
   public class PredictionResult
    {

       public  BitmapImage ImgSrc { get; set; }
       public  List<Prediction> predictions { get; set; }
    }
}
