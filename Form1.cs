using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        Bitmap b;
        ImageEditor ee;


        Stack<Bitmap> undoStack = new Stack<Bitmap>();
        Stack<Bitmap> redoStack = new Stack<Bitmap>();

        public Form1()
        {
           
            InitializeComponent();
        }



        //open file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Images|*.jpg;*.jpen;*.png";
            if (o.ShowDialog() != DialogResult.OK)
                return;
            ee = new ImageEditor(o.FileName);

            b = ee.GetBitmap();
            PicBox.Image = b;
        }

      //read write bytes

        byte[] Readbytes()
        {
            byte[] bytes = new byte[b.Width * b.Height * 4];
            var data =
            b.LockBits(
                new Rectangle(0, 0, b.Width, b.Height)
                , System.Drawing.Imaging.ImageLockMode.ReadOnly,
                b.PixelFormat



                );
            Marshal.Copy(data.Scan0,bytes,0,bytes.Length);
            b.UnlockBits(data);
            return bytes;



        }
        void writebytes(byte[] bytes)
        {
            var data =
            b.LockBits(
                new Rectangle(0, 0, b.Width, b.Height)
                , System.Drawing.Imaging.ImageLockMode.WriteOnly,
                b.PixelFormat
                );

            Marshal.Copy(bytes, 0,data.Scan0, bytes.Length);
            b.UnlockBits(data);

        }






        //close
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }



        //control


        private void AddToUndoStack()
        {
            undoStack.Push(b.Clone() as Bitmap);
            
        }
        private void AddToRedoStack()
        {
           
        }


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (redoStack.Count == 0)
                return;

            b = redoStack.Pop();
            undoStack.Push(b);
            PicBox.Image = b;

        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undoStack.Count == 0)
                return;

            b = undoStack.Pop();
            redoStack.Push(b);
            PicBox.Image = b;
        }

        

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
       
        
        //merg
            //color
        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == null) return;
            AddToUndoStack();
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

                var r = float.Parse(TxtMergRatio.Text)/100;
                var bytes = Readbytes();
                for (int i = 0; i < bytes.Length; i += 4)
                {
                    bytes[i + 0] = (byte)(bytes[i + 0] * (1 - r) + c.Color.B * r);
                    bytes[i + 1] = (byte)(bytes[i + 1] * (1 - r) + c.Color.G * r);
                    bytes[i + 2] = (byte)(bytes[i + 2] * (1 - r) + c.Color.R * r);

                } 
                writebytes((bytes));
                PicBox.Image = b;
                        
                        
            }


        }
            //image
        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

                AddToUndoStack();
                var b2 = new Bitmap(o.FileName);
                b2 =new Bitmap(b2);
                var r = float.Parse(TxtMergRatio.Text) / 100;
                for (int x = 0; x < b2.Width && x<b.Width; x++) {
                    for (int y = 0; y < b2.Height && y < b.Height; y++)
                    {

                        var c =b.GetPixel(x, y);
                        var c2 =b2.GetPixel(x, y);
                        var newColor = Color.FromArgb(
                            (int)(c.R*(1 - r)+ c2.R*r),
                            (int)(c.G*(1 - r)+ c2.R*r),
                            (int)(c.B*(1 - r)+ c2.R*r)
                            );
                        b.SetPixel(x, y, newColor);
                    }
                
                
                
                }
            }
        
        
        
        
        }
        //slow

            
            //to gray
        private void toGrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (b == null) return;

            AddToUndoStack();
            for (int x = 0; x < b.Width; x++)
                for (int y = 0; y < b.Height; y++)
                {
                    var c = b.GetPixel(x, y);
                    int gray = (c.R + c.B + c.G) / 3;
                    b.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }

            PicBox.Refresh();
        }
            //gray2
        private void toGrqyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    var C = b.GetPixel(x, y);
                    var max1 = Math.Max(C.R, C.G);
                    var max2 = Math.Max(max1, C.B);
                    var min = Math.Min(C.R, C.B);
                    var min1 = Math.Min(min, C.G);
                    var sum = (min1 + max2) / 2;
                    Color newColor = Color.FromArgb(sum, sum, sum);
                    b.SetPixel(x, y, newColor);


                }

                PicBox.Refresh();

            }

        }

            //darker
        private void glowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    var C = b.GetPixel(x, y);
                    Color newColor = Color.FromArgb(Convert.ToInt32(C.R * 0.7), (int)(C.G * 0.7), (int)(C.B * 0.7));
                    b.SetPixel(x, y, newColor);


                }

                PicBox.Refresh();

            }
        }

            //lighter
        private void lighterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    var C = b.GetPixel(x, y);
                    Color newColor = Color.FromArgb(Convert.ToInt32(C.R + (255 - C.R) * 0.7), (int)(C.G + (255 - C.G) * 0.7), (int)(C.B + (255 - C.B) * 0.7));
                    b.SetPixel(x, y, newColor);


                }

                PicBox.Refresh();

            }
        }

            //red
        private void colorFastToolStripMenuItem_Click(object sender, EventArgs e)
        {

            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    var C = b.GetPixel(x, y);
                    Color newColor = Color.FromArgb(C.R, 0, 0);
                    b.SetPixel(x, y, newColor);


                }

                PicBox.Refresh();

            }
        }



        //fast
            //to gray
        private void gray1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (b == null) return;
            AddToUndoStack();
            var bytes = Readbytes();
            int gray;

            for (int i = 0; i < bytes.Length; i += 4)
            {
                gray=( (bytes[i + 0]) +(bytes[i + 1]) +(bytes[i+2]))/3;
                // bytes[i+3];//alpha
                bytes[i + 0] = (byte)gray;
                bytes[i + 1] = (byte)gray;
                bytes[i + 2] = (byte)gray;


            }



            writebytes(bytes);
            PicBox.Image = b;
        }
            //to gray2
        private void gray2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (b == null) return;
            AddToUndoStack();
            var bytes = Readbytes();
           

            for (int i = 0; i < bytes.Length; i += 4)
            {
                var max1 = Math.Max((bytes[i + 2]), (bytes[i + 1]));
                var max2 = Math.Max(max1, (bytes[i + 0]));
                var min1 = Math.Max((bytes[i + 2]), (bytes[i + 1]));
                var min2 = Math.Max(min1, (bytes[i + 0]));
                var sum = (min2 + max2) / 2;
               
                // bytes[i+3];//alpha
                bytes[i + 0] = (byte)sum;
                bytes[i + 1] = (byte)sum;
                bytes[i + 2] = (byte)sum;


            }



            writebytes(bytes);
            PicBox.Image = b;

        }

            //darker
        private void darkerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (b == null) return;
            AddToUndoStack();
            var bytes = Readbytes();
            var r = float.Parse(TxtDarker.Text) *0.01;

            for (int i = 0; i < bytes.Length; i += 4)
            {
                // bytes[i+3];//alpha
                bytes[i + 0] = (byte)(bytes[i + 0] * r);
                bytes[i + 1] = (byte)(bytes[i + 1] * r);
                bytes[i + 2] = (byte)(bytes[i + 2] * r);


            }



            writebytes(bytes);
            PicBox.Image = b;

        }
            //Lighter
        private void LighterBtn_Click(object sender, EventArgs e)
        {
            if(b == null) return;
            AddToUndoStack();
            var bytes = Readbytes();
            var r = float.Parse(TxtLighter.Text) * 0.01;

            for (int i = 0; i < bytes.Length; i += 4)
            {
                // bytes[i+3];//alpha
                bytes[i + 0] = (byte)(bytes[i + 0] +(255-bytes[i + 0]) * r);
                bytes[i + 1] = (byte)(bytes[i + 1] + (255-bytes[i + 1] ) * r);
                bytes[i + 2] = (byte)(bytes[i + 2] + (255-bytes[i + 2] ) * r);


            }



            writebytes(bytes);
            PicBox.Image = b;

        }

            //red
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (b == null) return;
            AddToUndoStack();
            var bytes = Readbytes();

            for (int i = 0; i < bytes.Length; i += 4)
            {
                bytes[i + 0] = 0;//blue
                bytes[i + 1] = 0;//grean
                                 //bytes[i+2]=0;//red
                                 // bytes[i+3];//alpha



            }



            writebytes(bytes);
            PicBox.Image = b;
        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click_2(object sender, EventArgs e)
        {

        }
        //save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog o = new SaveFileDialog();
            o.Title = "Select Image";
            o.Filter = "Images|*.jpg;*.jpen;*.png";
            if (o.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;


            string message = "Are you sure you want to save this?";
            string title = "Confirm Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                b.Save(o.FileName);
               
            }
            else
            {
                Close();
            }
           
        }
            //green
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (b == null) return;
            AddToUndoStack();
            var bytes = Readbytes();

            for (int i = 0; i < bytes.Length; i += 4)
            {
                bytes[i + 0] = 0;//blue
               // bytes[i + 1] = 0;//grean
                bytes[i+2]=0;//red
                                 // bytes[i+3];//alpha



            }



            writebytes(bytes);
            PicBox.Image = b;
        }
            //blue
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (b == null) return;
            AddToUndoStack();
            var bytes = Readbytes();

            for (int i = 0; i < bytes.Length; i += 4)
            {
                //bytes[i + 0] = 0;//blue
                bytes[i + 1] = 0;//grean
                bytes[i+2]=0;//red
                                 // bytes[i+3];//alpha

            }
            writebytes(bytes);
            PicBox.Image = b;
        }
            //Gray3
        private void BtnGray3_Click(object sender, EventArgs e)
        {
            if (b == null) return;
            AddToUndoStack();
            var bytes = Readbytes();
            var r = float.Parse(TxtLighter.Text) * 0.01;

            for (int i = 0; i < bytes.Length; i += 4)
            {
                // bytes[i+3];//alpha
                var y = (bytes[i + 2] * 0.299) + (bytes[i + 1] * 0.578) + (bytes[i + 0] * 0.114 );
                var u = 0.492 * (bytes[i + 0] - y);
                var v = 0.877 * (bytes[i + 2] - y);

                bytes[i + 0] = (byte)(y);
                bytes[i + 1] = (byte)(y);
                bytes[i + 2] = (byte)(y);


            }



            writebytes(bytes);
            PicBox.Image = b;
        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            long c = Convert.ToInt64(redoStack.Count());
            LblRedo.Text = Convert.ToString(c);
            statusStrip1.Refresh();


        }

        private void lblColorInfo_Click(object sender, EventArgs e)
        {
            long c = Convert.ToInt64(undoStack.Count());
            LblUndo.Text= Convert.ToString(c);
            statusStrip1.Refresh();
        }


        int startX, startY;
        bool mousedown = false;
        bool cycle = false;
        bool rectangle = true;
        Pen color;
        Bitmap temp;



        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (b == null)
                return;
           

            if (!mousedown)
                return;


            PicBox.Image = ee.TempDrawRectangle(Math.Min(startX, e.X),
                    Math.Min(startY, e.Y),
                    Math.Abs(e.X - startX),
                    Math.Abs(e.Y - startY),color
                    );
            //temp = new Bitmap(b);
            //using (Graphics g = Graphics.FromImage(temp))
            //{
            //    g.DrawRectangle(new Pen(Color.Green),
            //        Math.Min(startX, e.X),
            //        Math.Min(startY, e.Y),
            //        Math.Abs(e.X - startX),
            //        Math.Abs(e.Y - startY)
            //        );
            //}
            ////b = b1;
            //pictureBox1.Image = temp;

        }

        private void PicBox_MouseUp(object sender, MouseEventArgs e)
        {

            if (mousedown)
            {
                mousedown = false;
                ee.DrawRectangle(Math.Min(startX, e.X),
                        Math.Min(startY, e.Y),
                        Math.Abs(e.X - startX),
                        Math.Abs(e.Y - startY), cycle,rectangle,color
                        );
                PicBox.Image = ee.GetBitmap();
            }
        }

        private void PicBox_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            startX = e.X;
            startY = e.Y;

        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cycle = false;
            rectangle = true;
        }

        private void cycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cycle = true;
            rectangle = false;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                 color=new Pen(c.Color);


            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void PicBox_Click(object sender, EventArgs e)
        {

        }

        //rotate
        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var b1 = new Bitmap(b);
            using (Graphics g = Graphics.FromImage(b1))
            {
                g.Clear(Color.Black);
                g.TranslateTransform(b1.Width / 2, b1.Height / 2);
                g.RotateTransform(60);
                double r = 0.5;

                g.DrawImage(b,
                    (int)(-b.Width / 2 * r),
                    (int)(-b.Height / 2 * r),
                    (int)(b.Width * r),
                    (int)(b.Height * r));
                //g.DrawRectangle(new Pen(Color.Magenta), -150, -150, 300, 300);
            }
            b = b1;
            PicBox.Image = b1;
        }
    }
}
