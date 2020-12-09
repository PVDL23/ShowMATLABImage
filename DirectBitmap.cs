using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace ShowMATLABImage
{
    /// <summary>
    /// Draw directly to a bitmap's surface
    /// by setting and getting pixel colors 
    /// to and from a byte array (RGBA)
    /// <see cref="https://stackoverflow.com/questions/24701703/c-sharp-faster-alternatives-to-setpixel-and-getpixel-for-bitmaps-for-windows-f#34801225"/>
    /// </summary>
    public class DirectBitmap : IDisposable
    {
        public Bitmap Bitmap { get; private set; }
        public byte[] Bits { get; private set; }
        public bool Disposed { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        protected GCHandle BitsHandle { get; private set; }

        public DirectBitmap(int width, int height)
        {
            Width = width;
            Height = height;
            Bits = new byte[width * height * 4];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppRgb, BitsHandle.AddrOfPinnedObject());
        }

        public void SetBytes(byte[] data)
        {
            data.CopyTo(Bits, 0);
        }

        public void SetPixel(int x, int y, Color colour)
        {
            int index = (x + (y * Width)) * 4;
            byte[] argb = BitConverter.GetBytes(colour.ToArgb());
            for (int i = 0; i < 4; i++)
            {
                Bits[index + i] = argb[i];
            }
        }

        public Color GetPixel(int x, int y)
        {
            int index = (x + (y * Width)) * 4;
            Color result = Color.FromArgb(
                Bits[index + 0],
                Bits[index + 1],
                Bits[index + 2],
                Bits[index + 3]
            );

            return result;
        }

        public void Dispose()
        {
            if (Disposed) return;
            Disposed = true;
            Bitmap.Dispose();
            BitsHandle.Free();
        }
    }
}
