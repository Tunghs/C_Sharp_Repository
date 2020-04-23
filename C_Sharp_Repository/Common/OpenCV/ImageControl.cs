using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenCvSharp;

namespace Common.OpenCV
{
    public class ImageControl
    {
        public Mat RoiCrop(string path, int x, int y, int roiWidth, int roiHeight)
        {
            try
            {
                Mat image = Cv2.ImRead(path, ImreadModes.Unchanged);
                Rect rect = new Rect(x, y, roiWidth, roiHeight);

                Mat dst = image.SubMat(rect);

                return dst;
            }
            catch
            {
                return null;
            }
        }

        public void GridCrop()
        {

        }
    }
}
