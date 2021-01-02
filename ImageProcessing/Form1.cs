using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessing.ImageProcessingFunction;

namespace ImageProcessing
{
    struct DivisionCoefficient
    {
        int X;
        int Y;
    }
    public partial class Form1 : Form
    {
        bool IsMax = false;
        private Size InitSize;
        bool AllTextFull = false;
        List<MyButton> RadioButtons = new List<MyButton>();
        Color PinkColor = Color.FromArgb(237, 25, 138);
        int XDivisionCoefission = 128;
        int YDivisionCoefission = 128;
        int multipleBy = 10;
        Rectangle m_rectangle = new Rectangle(0, 0, 0, 0);

        Bitmap SourceBitmap, original;
        int[] coordinnates = {0,0,0,0};

        public Form1()
        {
            InitializeComponent();
            INIT_SCREEN();
        }

        private void INIT_SCREEN()
        {
            
            InitSize = this.Size;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            RadioButtons.Add(C1);
            RadioButtons.Add(C2);
            RadioButtons.Add(C3);
            RadioButtons.Add(C4);
            uploadBtnPanel.Location = new Point((panel4.Width / 2) - (uploadBtnPanel.Width / 2), (panel4.Height / 2) - (uploadBtnPanel.Height / 2));
            ProgressBar.Width = 0;
            clearPb.BackColor = Color.Transparent;
            clearPb.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Dictionary<Color, int> dictColors = new Dictionary<Color, int>();
        public Color GetDominantColor(Bitmap image,int startX, int startY, int width, int height)
        {

            Color resColor = Color.White;
            
            for (int x = startX; x < (startX + width); x++)
            {
                for (int y = startY; y < (startY + height); y++)
                {
                    Color color = image.GetPixel(x, y);
                    if (!dictColors.ContainsKey(color))
                    {
                        dictColors.Add(color, 0);
                    }
                    else
                    {
                        dictColors[color]++;
                    }

                   
                }
            }
            var res = dictColors.Take(1);
            return resColor;
        }
        

       

        void resetProgressBar()
        {
        }

        public Task ProcessData(Bitmap image , IProgress<PrigressReport> progress)
        {
            int pictureBoxWidth = XDivisionCoefission* multipleBy;
            int pictureBoxHeight = YDivisionCoefission * multipleBy;
            Bitmap bm = new Bitmap(pictureBoxWidth, pictureBoxHeight);
            int to = XDivisionCoefission * YDivisionCoefission;
            
            int index = 1;
            var progressReport = new PrigressReport();
            
                return Task.Run(() =>
                {
                    using (Graphics gr = Graphics.FromImage(bm))
                    {

                        gr.SmoothingMode = SmoothingMode.AntiAlias;
                        for (int i = 0; i < XDivisionCoefission; i++)
                        {
                            for (int j = 0; j < YDivisionCoefission; j++)
                            {
                                progressReport.PercentComplete = index++ * 100 / to;
                                progress.Report(progressReport);
                                Color PixelColor = GetDominantColor_fusion(image,
                                                    image.Width / XDivisionCoefission * i,
                                                    image.Height / YDivisionCoefission * j,
                                                    image.Width / XDivisionCoefission,
                                                    image.Height / YDivisionCoefission);


                                SolidBrush brush = new SolidBrush(PixelColor);
                                Rectangle rect = new Rectangle((pictureBoxWidth / XDivisionCoefission) * i,
                                    (pictureBoxHeight / YDivisionCoefission) * j,
                                    pictureBoxWidth / XDivisionCoefission,
                                    pictureBoxHeight / YDivisionCoefission);
                                gr.FillRectangle(brush, rect);

                            }
                        }

                        

                    }


                    SourceBitmap = bm;
                    
                });

            
        }

        Bitmap Resizing(Bitmap bm)
        {
            if (bm == null) return null;
            if (bm.Width % XDivisionCoefission == 0 && bm.Height % YDivisionCoefission == 0) return bm;
            int newsizeHeight, newsizeWidth;
            if (bm.Width % XDivisionCoefission < 0.5f)
            {
                newsizeWidth = (bm.Width / XDivisionCoefission) * XDivisionCoefission;
            }else
            {
                newsizeWidth = (bm.Width / XDivisionCoefission + 1) * XDivisionCoefission;
            }
            if (bm.Height % YDivisionCoefission < 0.5f)
            {
                newsizeHeight = (bm.Height / YDivisionCoefission) * YDivisionCoefission;
            }
            else
            {
                newsizeHeight = (bm.Height / YDivisionCoefission + 1) * YDivisionCoefission;
            }
            Bitmap resized = new Bitmap(bm, new Size(newsizeWidth, newsizeHeight));
            return resized;
        }

        Color GetDominantColor_fusion(Bitmap image,int startX, int startY, int width, int height)
        {
            //Used for tally
            int r = 0;
            int g = 0;
            int b = 0;

            int total = 0;

            for (int x = startX; x < (startX + width); x++)
            {
                for (int y = startY; y < (startY + height); y++)
                {
                    Color clr = image.GetPixel(x, y);

                    r += clr.R;
                    g += clr.G;
                    b += clr.B;

                    total++;
                }
            }

            //Calculate average
            r /= total;
            g /= total;
            b /= total;

            return Color.FromArgb(r, g, b);
        }


      
        private void button1_Click(object sender, EventArgs e)
        {
            string imageLocation = "";

            try
            {

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png|JPEG files(*.jpeg)|*.jpeg";
                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    dragHerePanel.Visible = false;
                    uploadBtnPanel.Visible = false;
                    clearPb.Visible = true;

                    SourceBitmap = Resizing(new Bitmap(imageLocation));
                    pictureBox1.Image = SourceBitmap;
                    original = SourceBitmap;
                    if(AllTextFull)
                        myButton2.Enabled = true;
                    SetTxtFocus();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CheckIntEnter()
        {
            
        }
        void SetTxtFocus()
        {
            if (Xx.Text == "" || !int.TryParse(Xx.Text, out int m))
            {
                Xx.Focus();
                return;
            }
            else if (Xsec.Text == "" || !int.TryParse(Xsec.Text, out int n))
            {
                Xsec.Focus();
                return;
            }
            else if (Yy.Text == "" || !int.TryParse(Yy.Text, out int o))
            {
                Yy.Focus();
                return;
            }
            else if (Ysec.Text == "" || !int.TryParse(Ysec.Text, out int p))
            {
                Ysec.Focus();
                return;
            }
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            SetTxtFocus();
           if (CheckCoordinnateValue())
           {
                var progress = new Progress<PrigressReport>();
                //loadingPanel.Visible = true;
                progress.ProgressChanged += (o, report) =>
                {
                    myButton2.Text = report.PercentComplete.ToString() + " %";
                    ProgressBar.Width = (report.PercentComplete * this.Width)/100;
                    //progressBar.Update();
                    
                };
               
                await ProcessData(SourceBitmap, progress);
                myButton2.Text = "Generat";
                ProgressBar.Width = 0;
                //loadingPanel.Visible = false;

                ImageProvider imageProvider = new ImageProvider(SourceBitmap,original , coordinnates, multipleBy , XDivisionCoefission, YDivisionCoefission);
                imageProvider.Show();
            }else
            {
                MessageBox.Show("Invalid coordinates", "One or multiple coordinates are false.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        bool CheckCoordinnateValue()
        {
                if(!int.TryParse(Xx.Text, out int m) ||
                    !int.TryParse(Xsec.Text, out int n) ||
                        !int.TryParse(Yy.Text, out int o) ||
                            !int.TryParse(Ysec.Text, out int p))
                {
                    return false;
                }
                coordinnates[0] = Convert.ToInt32(Xx.Text);
                coordinnates[1] = Convert.ToInt32(Yy.Text);
                coordinnates[2] = Convert.ToInt32(Xsec.Text);
                coordinnates[3] = Convert.ToInt32(Ysec.Text);
            
           return (Math.Abs(Convert.ToInt32(Xsec.Text) - Convert.ToInt32(Xx.Text)) == XDivisionCoefission - 1 && Math.Abs(Convert.ToInt32(Ysec.Text) - Convert.ToInt32(Yy.Text)) == YDivisionCoefission - 1);
           
        }

        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (IsMax)
            {

                FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.Size = InitSize;
                this.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2));

                IsMax = false;
            }
            else
            {

                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Left = Top = 0;
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;

                IsMax = true;
            }
        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void RadioButtonManager(string buttonName)
        {
            
            switch (buttonName)
            {
                case "C1":
                    XDivisionCoefission = 128;
                    YDivisionCoefission = 128;
                    pictureBox1.Image = Resizing(SourceBitmap);
                    break;
                case "C2":
                    XDivisionCoefission = 256;
                    YDivisionCoefission = 256;
                    pictureBox1.Image = Resizing(SourceBitmap);
                    break;
                case "C3":
                    XDivisionCoefission = 384;
                    YDivisionCoefission = 384;
                    pictureBox1.Image = Resizing(SourceBitmap);
                    break;
                case "C4":
                    XDivisionCoefission = 512;
                    YDivisionCoefission = 256;
                    pictureBox1.Image = Resizing(SourceBitmap);
                    break;
                default:
                    break;
            }
        }
        
       
        void ChangeRadioBtnColor(MyButton btn)
        {
            foreach (var button in RadioButtons)
            {
                if (button == btn) button.BackColor = PinkColor;
                else button.BackColor = Color.White;
            }
        }
        private void RadioButtonChecker(object sender, EventArgs e)
        {
            MyButton checkeddBtn = sender as MyButton;
            ChangeRadioBtnColor(checkeddBtn);
            RadioButtonManager(checkeddBtn.Name);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            
            uploadBtnPanel.Location = new Point((panel4.Width / 2) - (uploadBtnPanel.Width / 2) , (panel4.Height / 2) - (uploadBtnPanel.Height / 2));
            
        }

        private void Xx_TextChanged(object sender, EventArgs e)
        {
            if(Xx.Text != "" && Xsec.Text != "" && Yy.Text != "" && Ysec.Text != "")
            {
                AllTextFull = true;
                if(pictureBox1.Image != null)
                {
                    myButton2.Enabled = true;
                }
            }
            else
            {
                AllTextFull = false;
                myButton2.Enabled = false;
            }
           
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if(files.Length > 0)
            {
                if(files.Length > 1)
                {
                    MessageBox.Show(this, "Only one file allowed", "HalfShield Exception", MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                }
               
                if (Path.GetExtension(files[0]) == ".png" || Path.GetExtension(files[0]) == ".jpg" || Path.GetExtension(files[0]) == ".jpeg")
                {
                    dragHerePanel.Visible = false;
                    uploadBtnPanel.Visible = false;
                    clearPb.Visible = true;

                    SourceBitmap = Resizing(new Bitmap(files[0]));
                    pictureBox1.Image = SourceBitmap;
                    original = SourceBitmap;
                    if (AllTextFull)
                        myButton2.Enabled = true;
                    SetTxtFocus();

                }
            }
            dragHerePanel.Visible = false;
            btnPanel.Visible = true;
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                dragHerePanel.Visible = true;
                btnPanel.Visible = false;
            }
        }

        private void pictureBox1_DragLeave(object sender, EventArgs e)
        {

            dragHerePanel.Visible = false;
            btnPanel.Visible = true;
        }

        

        private void clearPb_Click(object sender, EventArgs e)
        {
            
            if(pictureBox1.Image != null)
            {
                pictureBox1.Image = null;
                uploadBtnPanel.Visible = true;
                clearPb.Visible = false;
            }
            myButton2.Enabled = false;
            
        }

        
    }
}
