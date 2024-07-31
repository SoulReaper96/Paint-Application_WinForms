using System.Drawing.Imaging;

namespace PaintApplication_Forms
{
    public partial class PaintApplication_Form : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        bool paint = false;
        Point px, py;
        Pen pen = new Pen(Color.Black, 1);
        Pen eraser = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;

        ColorDialog colorDialog = new ColorDialog();
        Color newColor;

        public PaintApplication_Form()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            bitmap = new Bitmap(PboxPaint.Width, PboxPaint.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            PboxPaint.Image = bitmap;
        }

        private void PboxPaint_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void PboxPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    graphics.DrawLine(pen, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    graphics.DrawLine(eraser, px, py);
                    py = px;
                }
            }
            PboxPaint.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void PboxPaint_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (index == 3)
            {
                graphics.DrawEllipse(pen, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                graphics.DrawRectangle(pen, cX, cY, sX, sY);
            }
            if (index == 5)
            {
                graphics.DrawLine(pen, cX, cY, x, y);
            }
        }

        private void BtnPencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void BtnEraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void BtnDrawEllipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void BtnDrawSquare_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void BtnDrawLine_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void PboxPaint_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            if (paint)
            {
                if (index == 3)
                {
                    graphics.DrawEllipse(pen, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    graphics.DrawRectangle(pen, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    graphics.DrawLine(pen, cX, cY, x, y);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            PboxPaint.Image = bitmap;
            index = 0;
        }

        private void BtnColour_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            pen.Color = colorDialog.Color;
            PickColour.BackColor = colorDialog.Color;
            newColor = colorDialog.Color;
        }

        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1F * pb.Width / pb.Width;
            float pY = 1F * pb.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void ColorPalette_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(ColorPalette, e.Location);
            PickColour.BackColor = ((Bitmap)ColorPalette.Image).GetPixel(point.X, point.Y);
            newColor = PickColour.BackColor;
            pen.Color = newColor;
        }
        
        private void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color oldColor, Color newColor)
        {
            Color cx = bm.GetPixel(x, y);

            if (cx == oldColor)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, newColor);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color newClr)
        {
            Color oldColor = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, newClr);

            if (oldColor == newClr) return;
            while (pixel.Count > 0)
            {
                Point p = (Point)pixel.Pop();
                if (p.X > 0 && p.Y > 0 && p.X < bm.Width - 1 && p.Y < bm.Height - 1)
                {
                    Validate(bm, pixel, p.X - 1, p.Y, oldColor, newClr);
                    Validate(bm, pixel, p.X, p.Y - 1, oldColor, newClr);
                    Validate(bm, pixel, p.X + 1, p.Y, oldColor, newClr);
                    Validate(bm, pixel, p.X, p.Y + 1, oldColor, newClr);
                }
            }

        }

        private void PboxPaint_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = set_point(PboxPaint, e.Location);
                Fill((Bitmap)PboxPaint.Image, point.X, point.Y, newColor);
            }
            
        }

        private void BtnFill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|Image(*.png)|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bitmap.Clone(new Rectangle(0, 0, PboxPaint.Width, PboxPaint.Height), PboxPaint.Image.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Image Saved Sucessfully!!");
            }
        }

    }
}
