using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenCvSharp;

namespace Common.OpenCV
{
    public class ImageConvert
    {
        public ImageConvert()
        {

        }

        public unsafe Mat ChangePixelValue(string path, int srcPixelValue, int trgPixelValue)
        {
            Mat image = Cv2.ImRead(path, ImreadModes.Unchanged);

            byte* data = (byte*)image.DataPointer;
            for (int y = 0; y < image.Rows; ++y)
            {
                for (int x = 0; x < image.Cols; ++x)
                {
                    if (data[y * image.Step() + x * image.ElemSize()] == (byte)srcPixelValue)
                        data[y * image.Step() + x * image.ElemSize()] = (byte)trgPixelValue;
                }
            }

            return image;
        }
    }
}
