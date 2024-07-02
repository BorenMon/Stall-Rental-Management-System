using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Stall_Rental_Management_System.Helpers
{
    public static class ImageHelper
    {
        public static Stream CompressImage(string filePath, int width = 800, int height = 800)
        {
            var compressedStream = new MemoryStream();
            using (var originalImage = Image.FromFile(filePath))
            {
                // Resize the image if it's larger than a certain size (e.g., 800x800)
                var resizedImage = ResizeImage(originalImage, width, height);

                var encoderParameters = new EncoderParameters(1)
                {
                    Param = { [0] = new EncoderParameter(Encoder.Quality, 25L) } // Set quality to 25 for higher compression
                };
                var jpegEncoder = GetEncoder(ImageFormat.Jpeg);

                resizedImage.Save(compressedStream, jpegEncoder, encoderParameters);
                compressedStream.Position = 0; // Reset the stream position to the beginning
            }
            return compressedStream;
        }

        private static Image ResizeImage(Image originalImage, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / originalImage.Width;
            var ratioY = (double)maxHeight / originalImage.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(originalImage.Width * ratio);
            var newHeight = (int)(originalImage.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            using (var graphics = Graphics.FromImage(newImage))
            {
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            var codecs = ImageCodecInfo.GetImageDecoders();
            foreach (var codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}