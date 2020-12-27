using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace ImageProcessing
{
    public partial class ImageProvider : Form
    {

        // field
        Color purpule = Color.FromArgb(9, 6, 33, 1);
        Cursor zoomin = new Cursor(Application.StartupPath + "\\Cursors\\ZoomIn.ico");
        int[] coordinnates;
        int multipCoefficient;
        int XD, YD;
        RectangleF HilightRect = new RectangleF(0, 0, 0, 0);
        Size parentSize;
        Size initSize;

        Size MinSize, MaxSize;

        public ImageProvider(Bitmap image,Bitmap original, int[] cor, int multipleBy , int xd , int yd)
        {
            InitializeComponent();
            coordinnates = cor;
            multipCoefficient = multipleBy;
            ResultImage.Image = image;
            parentSize = ResultImage.Parent.Size;
            pictureBox4.Image = original;
            initSize = image.Size;
            
            setPictureBoxSize();
            //MessageBox.Show(ResultImage.Width.ToString() + " " + ResultImage.Height.ToString());
            XD = xd;
            YD = yd;
            INIT_SCREEN();
        }
        private void INIT_SCREEN()
        {

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            title.Text = XD.ToString() + " X " + YD.ToString();
            ResultImage.MouseWheel += ResultImage_MouseWheel; 
        }

        private void ResultImage_MouseWheel(object sender, MouseEventArgs e)
        {
            if(e.Delta != 0)
            {
                Point pictureBoxPoint = ResultImage.PointToClient(this.PointToScreen(e.Location));
                ZoomScroll(pictureBoxPoint, e.Delta > 0);
            }
        }


        
        public const float s_dScrollValue = 0.1f;

        
        private void ZoomScroll(Point location, bool zoomIn)
        {

            //ResultImage.Location = location; new Point(location.X,location.Y);
            if (zoomIn)
            {
                if(ResultImage.Width < MaxSize.Width)
                {
                    ResultImage.Width *= 2;
                    ResultImage.Height *= 2;
                }
                else
                {
                    ResultImage.Width = MaxSize.Width;
                    ResultImage.Height = MaxSize.Height;
                }
            }else
            {
                if(ResultImage.Width > MinSize.Width )
                {
                    ResultImage.Width /= 2;
                    ResultImage.Height /= 2;
                }
                else
                {
                    ResultImage.Width = MinSize.Width;
                    ResultImage.Height = MinSize.Height;
                }
            }

            CentreControlInGroupBox(ResultImage);



        }

        
       
        Point point;
        int x, y , previousX, previousY;
        private void ResultImage_MouseDown(object sender, MouseEventArgs me)
        {
            
            Image b = ResultImage.Image;
            
            
            if (me.Button == MouseButtons.Left)
            {
                if(Control.ModifierKeys == Keys.Alt)
                {
                    
                }
                else
                {
                    if (coordinnates[2] - coordinnates[0] > 0)
                    {
                        if (coordinnates[3] - coordinnates[1] > 0)
                        {

                            x = coordinnates[0] + (b.Width / multipCoefficient) * me.X / ResultImage.Width;
                            y = coordinnates[1] + (b.Height / multipCoefficient) * me.Y / ResultImage.Height;
                        }
                        else
                        {
                            x = coordinnates[0] + (b.Width / multipCoefficient) * me.X / ResultImage.Width;
                            y = coordinnates[1] - (b.Height / multipCoefficient) * me.Y / ResultImage.Height;
                        }

                    }
                    else
                    {
                        if (coordinnates[3] - coordinnates[1] > 0)
                        {
                            x = coordinnates[0] - (b.Width / multipCoefficient) * me.X / ResultImage.Width;
                            y = coordinnates[1] + (b.Height / multipCoefficient) * me.Y / ResultImage.Height;
                        }
                        else
                        {
                            x = coordinnates[0] - (b.Width / multipCoefficient) * me.X / ResultImage.Width;
                            y = coordinnates[1] - (b.Height / multipCoefficient) * me.Y / ResultImage.Height;
                        }
                    }
                    MessageBox.Show(ResultImage.Size + " /// " + coordinnates[0] + " - (" + b.Width + " / " + multipCoefficient + ") * " + me.X + " / " + ResultImage.Width + " = " + String.Format("X={0}, Y={1}", x, y));

                }

            }
            else if (me.Button == MouseButtons.Right && ResultImage.Width != MinSize.Width)
            {
                ResultImage.Cursor = Cursors.NoMove2D;
                point = me.Location;
            }

            //int x = (b.Width / 5) * me.X / (ResultImage.Width - (ResultImage.Width - b.Width)) + 1;
            //int y = (b.Height / 5) * me.Y / (ResultImage.Height - (ResultImage.Height - b.Height)) + 1;
        }

        private void ImageProvider_SizeChanged(object sender, EventArgs e)
        {
            if(!initSize.IsEmpty)
            {
                ResultImage.Parent.BackColor = Color.Red;
                setPictureBoxSize();
                CentreControlInGroupBox(ResultImage);
            }
            
        }

        private void setPictureBoxSize()
        {
            if(initSize.Width > initSize.Height)
                ResultImage.Size = new Size(ResultImage.Parent.Width, (initSize.Height * ResultImage.Parent.Width) / initSize.Width);
            else
                ResultImage.Size = new Size((initSize.Width * ResultImage.Parent.Height) / initSize.Height,ResultImage.Parent.Height);

            MinSize = ResultImage.Size;

            MaxSize = new Size(MinSize.Width * 4, MinSize.Height * 4);
        }
        private void CentreControlInGroupBox(PictureBox theControl)
        {
            // Find the centre point of the Group Box
            int groupBoxCentreWidth = theControl.Parent.Width / 2;
            int groupBoxCentreHeight = theControl.Parent.Height / 2;

            // Find the centre point of the Control to be positioned/added
            int controlCentreWidth = theControl.Width / 2;
            int controlCentreHeight = theControl.Height / 2;

            // Set the Control to be at the centre of the Group Box by
            // off-setting the Controls Left/Top from the Group Box centre
            theControl.Left = groupBoxCentreWidth - controlCentreWidth;
            theControl.Top = groupBoxCentreHeight - controlCentreHeight;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (ResultImage.Size.Width < initSize.Width )
            {
                ResultImage.Size = new Size(ResultImage.Size.Width * 2, ResultImage.Size.Height * 2);
            }
            
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (ResultImage.Size.Width > initSize.Width )
            {
                ResultImage.Size = new Size(ResultImage.Size.Width / 2, ResultImage.Size.Height / 2);
            }
        }

        private void ResultImage_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           MessageBox.Show(e.KeyCode.ToString());
           
        }

     

        private void ResultImage_MouseUp(object sender, MouseEventArgs e)
        {
            ResultImage.Cursor = Cursors.Cross;
            if (ResultImage.Width == MinSize.Width) return;
            if (ResultImage.Bounds.X > 0) ResultImage.Bounds = new Rectangle(0,ResultImage.Bounds.Y, ResultImage.Bounds.Width, ResultImage.Bounds.Height);
            else if(ResultImage.Bounds.X < (ResultImage.Parent.Bounds.Width - ResultImage.Bounds.Width)) ResultImage.Bounds = new Rectangle((ResultImage.Parent.Bounds.Width - ResultImage.Bounds.Width), ResultImage.Bounds.Y, ResultImage.Bounds.Width, ResultImage.Bounds.Height);
            if (ResultImage.Bounds.Y > 0) ResultImage.Bounds = new Rectangle(ResultImage.Bounds.X, 0, ResultImage.Bounds.Width, ResultImage.Bounds.Height);
            else if (ResultImage.Bounds.Y < (ResultImage.Parent.Bounds.Height - ResultImage.Bounds.Height)) ResultImage.Bounds = new Rectangle(ResultImage.Bounds.X , (ResultImage.Parent.Bounds.Height - ResultImage.Bounds.Height), ResultImage.Bounds.Width, ResultImage.Bounds.Height);

        }
        float lastx, lasty;
        float myY = 0, myX = 0;
        private void ResultImage_MouseMove(object sender, MouseEventArgs me)
        {
            //HilightRect.Location = new Point(me.Location.X - (HilightRect.Width / 2), me.Location.Y - (HilightRect.Height / 2));
            float height = (float)Decimal.Divide(ResultImage.Width, XD);
            float width = (float)Decimal.Divide(ResultImage.Height, YD);
            float myX = ((float)Decimal.Divide(me.Location.X, (decimal)Decimal.Divide(ResultImage.Width, XD)) * (float)Decimal.Divide(ResultImage.Width, XD)) - (float)Decimal.Divide((decimal)width, 2);
            float myY = ((float)Decimal.Divide(me.Location.Y, (decimal)Decimal.Divide(ResultImage.Height, YD)) * (float)Decimal.Divide(ResultImage.Height, YD)) - (float)Decimal.Divide((decimal)height, 2);
            
            HilightRect = new RectangleF(myX, myY, height,width);
            coor.Text = me.Location.ToString() + "\n  ((" +  me.Location.X + " / (" + ResultImage.Width +"/"+ XD+")) * -->" + (float)Decimal.Divide(ResultImage.Width, XD) +" \n " + (float)Decimal.Divide(me.Location.X, (decimal)Decimal.Divide(ResultImage.Width, XD)) * (float)Decimal.Divide(ResultImage.Width, XD);

            if (HilightRect.Right > ResultImage.Width)
            {
                HilightRect.X = ResultImage.Width - HilightRect.Width;
            }
            if (HilightRect.Top < 0)
            {
                HilightRect.Y = 0;
            }
            if (HilightRect.Left < 0)
            {
                HilightRect.X = 0;
            }
            if (HilightRect.Bottom > ResultImage.Height)
            {
                HilightRect.Y = ResultImage.Height - HilightRect.Height;
            }
            ResultImage.Invalidate();
            

            if (ResultImage.Cursor == Cursors.NoMove2D)
            {
               ResultImage.Left += me.X - point.X;
               ResultImage.Top += me.Y - point.Y;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void ImageProvider_Load(object sender, EventArgs e)
        {

        }

        private void ImageProvider_KeyDown(object sender, KeyEventArgs e) 
        {
           
            if (e.KeyCode == Keys.Menu &&  this.ResultImage.Bounds.Contains(this.PointToClient(Cursor.Position)))
            {
                ResultImage.Cursor = zoomin;
                

            }
        }

        

        private void ImageProvider_MouseHover(object sender, EventArgs e)
        {
           
            return;
            if (this.ResultImage.Bounds.Contains(this.PointToClient(Cursor.Position)))
            {
                coor.Text = "cursor in";
            }
            else
            {
                coor.Text = "cursor out";
            }
        }

        private void ResultImage_MouseEnter(object sender, EventArgs e)
        {
            coor.Text = "cursor in";
        }

        

        private void ResultImage_MouseLeave(object sender, EventArgs e)
        {
            coor.Text = "cursor out";
        }

        private void ResultImage_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(new SolidBrush(Color.RoyalBlue), HilightRect);
        }

        private void ImageProvider_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Menu)
            {
                ResultImage.Cursor = Cursors.Cross;
            }
        }

       

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
