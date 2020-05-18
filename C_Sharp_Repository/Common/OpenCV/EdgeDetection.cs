using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenCvSharp;

namespace Common.OpenCV
{
    class EdgeDetection
    {
        public EdgeDetection(string imagePath)
        {
            using(Mat src = new Mat(imagePath, ImreadModes.Unchanged))
            {
                using(Mat dst = src.Canny(50, 200))
                {
                    Mat file = new Mat();
                    Bitmap bit = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(src);
                    Mat matImg = OpenCvSharp.Extensions.BitmapConverter.ToMat(bit);

                    Cv2.BitwiseNot(matImg, file);
                }
            }
        }
    }
}
