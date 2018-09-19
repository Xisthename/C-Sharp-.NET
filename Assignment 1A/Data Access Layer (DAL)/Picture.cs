using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer__DAL_
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-09-12
    /// </summary>
    public class Picture
    {
        /// <summary>
        /// Delecering necessary variable
        /// </summary>
        public Image Image { get; set;}

        public Picture(string fileName)
        {
            ReadInImage(fileName);
        }

        /// <summary>
        /// Clears the data of the variable image
        /// </summary>
        public void ClearImage()
        {
            Image = null;
        }

        /// <summary>
        /// Tries to read an image from a specific path
        /// </summary>
        public void ReadInImage(String path)
        {
            try
            {
                using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    Image = Image.FromStream(stream);
                }
                Image = Picture.ResizeImage(Image, 64, 64);
            }
            catch { }
        }

        /// <summary>
        /// Resize the image to the specified width and height
        /// </summary>
        /// <param name="image">The image to resize</param>
        /// <param name="width">The width to resize to</param>
        /// <param name="height">The height to resize to</param>
        /// <returns>The resized image</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }
    }
}
