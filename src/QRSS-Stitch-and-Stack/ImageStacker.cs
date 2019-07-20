using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QRSS_Stitch_and_Stack
{
    class ImageStacker
    {
        public List<string> imagePaths = new List<string>();

        public ImageStacker()
        {
        }

        public void Add(string imagePath)
        {
            imagePaths.Add(imagePath);
        }

        public void Add(string[] imagePaths)
        {
            this.imagePaths.AddRange(imagePaths);
        }
        
        public void Clear()
        {
            imagePaths.Clear();
        }

        public bool AllBitmapsAreSameSize()
        {
            Bitmap firstBmp = new Bitmap(imagePaths[0]);
            for (int i = 1; i < imagePaths.Count; i++)
            {
                Bitmap thisBmp = new Bitmap(imagePaths[i]);
                if (thisBmp.Width != firstBmp.Width)
                    return false;
                if (thisBmp.Height != firstBmp.Height)
                    return false;
            }
            return true;
        }
        public Bitmap GetResultSingle(int index)
        {
            Console.WriteLine("creating single image result");
            Bitmap bmp = new Bitmap(imagePaths[index]);
            return bmp;
        }
        private byte[] BitmapToBytes(Bitmap bmp)
        {
            int bytesPerPixel = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;
            byte[] bytes = new byte[bmp.Width * bmp.Height * bytesPerPixel];
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadOnly, bmp.PixelFormat);
            //byte[] bytes = new byte[bmpData.Stride * bmp.Height * bytesPerPixel];
            Marshal.Copy(bmpData.Scan0, bytes, 0, bytes.Length);
            bmp.UnlockBits(bmpData);
            return bytes;
        }
        private Bitmap BitmapFromBytes(byte[] bytes, Size size, PixelFormat format = PixelFormat.Format8bppIndexed)
        {
            Bitmap bmp = new Bitmap(size.Width, size.Height, format);
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);
            Marshal.Copy(bytes, 0, bmpData.Scan0, bytes.Length);
            bmp.UnlockBits(bmpData);
            return bmp;
        }

        public Bitmap GetResultStackMax()
        {
            Console.WriteLine($"creating maximum projection of {this.imagePaths.Count} images...");
            Bitmap bmpFirst = new Bitmap(imagePaths[0]);
            byte[] bytesResult = BitmapToBytes(bmpFirst);
            for (int imageIndex = 1; imageIndex < imagePaths.Count; imageIndex++)
            {
                byte[] bytesImage = BitmapToBytes(new Bitmap(imagePaths[imageIndex]));
                for (int i = 0; i < bytesImage.Length; i++)
                    if (bytesImage[i] > bytesResult[i])
                        bytesResult[i] = bytesImage[i];
            }

            return BitmapFromBytes(bytesResult, bmpFirst.Size, bmpFirst.PixelFormat);
        }

        public Bitmap GetResultStackMean()
        {
            Console.WriteLine($"creating mean projection of {imagePaths.Count} images...");
            Bitmap bmpFirst = new Bitmap(imagePaths[0]);

            byte[] bytesResult = BitmapToBytes(bmpFirst);
            int[] bytesSum = new int[bytesResult.Length];

            for (int imageIndex = 0; imageIndex < imagePaths.Count; imageIndex++)
            {
                byte[] bytesImage = BitmapToBytes(new Bitmap(imagePaths[imageIndex]));
                for (int i = 0; i < bytesImage.Length; i++)
                    bytesSum[i] += bytesImage[i];
            }

            for (int i = 0; i < bytesSum.Length; i++)
                bytesResult[i] = (byte)(bytesSum[i] / imagePaths.Count);

            return BitmapFromBytes(bytesResult, bmpFirst.Size, bmpFirst.PixelFormat);
        }
    }
}
