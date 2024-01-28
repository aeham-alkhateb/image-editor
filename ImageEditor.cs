using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class ImageEditor
    {
        Bitmap b;

        public ImageEditor(string fileName)
        {
            b = new Bitmap(fileName);
        }
        public Bitmap GetBitmap()
        {
            return b;
        }

        public void DrawRectangle(int x, int y, int width, int height,bool c,bool r,Pen color)
        {
            if (r==true)
                b = TempDrawRectangle(x, y, width, height, color);
            if(c==true)
                b = TempDrawCycle(x, y, width, height, color);
        }

        public Bitmap TempDrawRectangle(int x, int y, int width, int height, Pen color)
        {
            var temp = new Bitmap(b);
            using (Graphics g = Graphics.FromImage(temp))
            {
                
                g.DrawRectangle(color,
                    x, y, width, height);
            }
            return temp;
        }
        public Bitmap TempDrawCycle(int x, int y, int width, int height, Pen color)
        {
            var temp = new Bitmap(b);
            using (Graphics g = Graphics.FromImage(temp))
            {

                g.DrawEllipse(new Pen(Color.Green),
                    x, y, width, height);
            }
            return temp;
        }




    }
}
