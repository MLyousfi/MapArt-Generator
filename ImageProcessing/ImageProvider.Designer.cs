namespace ImageProcessing
{
    partial class ImageProvider
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.ButtonControlManagerPanel = new System.Windows.Forms.Panel();
            this.btnClose = new ImageProcessing.MyButton();
            this.btnMaximize = new ImageProcessing.MyButton();
            this.bntMinimize = new ImageProcessing.MyButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.coor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupeBoxParent = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ResultImage = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ButtonControlManagerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupeBoxParent.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(6)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.title);
            this.panel2.Controls.Add(this.ButtonControlManagerPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1540, 59);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ImageProcessing.Properties.Resources.HalfShield;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Montserrat Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(64, 11);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(248, 33);
            this.title.TabIndex = 5;
            this.title.Text = "MapArt Generator";
            // 
            // ButtonControlManagerPanel
            // 
            this.ButtonControlManagerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonControlManagerPanel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonControlManagerPanel.Controls.Add(this.btnClose);
            this.ButtonControlManagerPanel.Controls.Add(this.btnMaximize);
            this.ButtonControlManagerPanel.Controls.Add(this.bntMinimize);
            this.ButtonControlManagerPanel.Location = new System.Drawing.Point(1392, 4);
            this.ButtonControlManagerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonControlManagerPanel.Name = "ButtonControlManagerPanel";
            this.ButtonControlManagerPanel.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.ButtonControlManagerPanel.Size = new System.Drawing.Size(147, 48);
            this.ButtonControlManagerPanel.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(25)))), ((int)(((byte)(138)))));
            this.btnClose.BackgroundImage = global::ImageProcessing.Properties.Resources.HalfShield;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.CornerRadius = 50;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(105, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.RoundCorners = ((ImageProcessing.Corners)((((ImageProcessing.Corners.TopLeft | ImageProcessing.Corners.TopRight) 
            | ImageProcessing.Corners.BottomLeft) 
            | ImageProcessing.Corners.BottomRight)));
            this.btnClose.Size = new System.Drawing.Size(27, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "✘";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(25)))), ((int)(((byte)(138)))));
            this.btnMaximize.BackgroundImage = global::ImageProcessing.Properties.Resources.HalfShield;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMaximize.CornerRadius = 50;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(57, 12);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.RoundCorners = ((ImageProcessing.Corners)((((ImageProcessing.Corners.TopLeft | ImageProcessing.Corners.TopRight) 
            | ImageProcessing.Corners.BottomLeft) 
            | ImageProcessing.Corners.BottomRight)));
            this.btnMaximize.Size = new System.Drawing.Size(27, 25);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "⬜";
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // bntMinimize
            // 
            this.bntMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(25)))), ((int)(((byte)(138)))));
            this.bntMinimize.BackgroundImage = global::ImageProcessing.Properties.Resources.HalfShield;
            this.bntMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntMinimize.CornerRadius = 50;
            this.bntMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntMinimize.ForeColor = System.Drawing.Color.White;
            this.bntMinimize.Location = new System.Drawing.Point(9, 12);
            this.bntMinimize.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bntMinimize.Name = "bntMinimize";
            this.bntMinimize.RoundCorners = ((ImageProcessing.Corners)((((ImageProcessing.Corners.TopLeft | ImageProcessing.Corners.TopRight) 
            | ImageProcessing.Corners.BottomLeft) 
            | ImageProcessing.Corners.BottomRight)));
            this.bntMinimize.Size = new System.Drawing.Size(27, 25);
            this.bntMinimize.TabIndex = 2;
            this.bntMinimize.Text = "_";
            this.bntMinimize.Click += new System.EventHandler(this.bntMinimize_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.coor);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1183, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 709);
            this.panel1.TabIndex = 5;
            // 
            // coor
            // 
            this.coor.AutoSize = true;
            this.coor.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.coor.Location = new System.Drawing.Point(6, 162);
            this.coor.Name = "coor";
            this.coor.Size = new System.Drawing.Size(58, 20);
            this.coor.TabIndex = 3;
            this.coor.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 495);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(348, 214);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Original : ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(11, 31);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(331, 175);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zoom in / out : ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::ImageProcessing.Properties.Resources.search_minus_solid;
            this.pictureBox3.Location = new System.Drawing.Point(128, 74);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ImageProcessing.Properties.Resources.search_plus_solid;
            this.pictureBox1.Location = new System.Drawing.Point(48, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.groupeBoxParent);
            this.panel3.Location = new System.Drawing.Point(1, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1181, 709);
            this.panel3.TabIndex = 4;
            // 
            // groupeBoxParent
            // 
            this.groupeBoxParent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupeBoxParent.Controls.Add(this.panel4);
            this.groupeBoxParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupeBoxParent.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupeBoxParent.ForeColor = System.Drawing.Color.White;
            this.groupeBoxParent.Location = new System.Drawing.Point(0, 0);
            this.groupeBoxParent.Margin = new System.Windows.Forms.Padding(4);
            this.groupeBoxParent.Name = "groupeBoxParent";
            this.groupeBoxParent.Padding = new System.Windows.Forms.Padding(4);
            this.groupeBoxParent.Size = new System.Drawing.Size(1181, 709);
            this.groupeBoxParent.TabIndex = 0;
            this.groupeBoxParent.TabStop = false;
            this.groupeBoxParent.Text = "Click pixel to see coordinnates : ";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.ResultImage);
            this.panel4.Location = new System.Drawing.Point(8, 32);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1165, 665);
            this.panel4.TabIndex = 2;
            // 
            // ResultImage
            // 
            this.ResultImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultImage.BackColor = System.Drawing.Color.Transparent;
            this.ResultImage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ResultImage.Location = new System.Drawing.Point(3, 0);
            this.ResultImage.Margin = new System.Windows.Forms.Padding(0);
            this.ResultImage.Name = "ResultImage";
            this.ResultImage.Size = new System.Drawing.Size(1163, 665);
            this.ResultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResultImage.TabIndex = 1;
            this.ResultImage.TabStop = false;
            this.ResultImage.Paint += new System.Windows.Forms.PaintEventHandler(this.ResultImage_Paint);
            this.ResultImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResultImage_MouseDown);
            this.ResultImage.MouseEnter += new System.EventHandler(this.ResultImage_MouseEnter);
            this.ResultImage.MouseLeave += new System.EventHandler(this.ResultImage_MouseLeave);
            this.ResultImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResultImage_MouseMove);
            this.ResultImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResultImage_MouseUp);
            this.ResultImage.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ResultImage_PreviewKeyDown);
            // 
            // ImageProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(6)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1540, 773);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ImageProvider";
            this.Text = "ImageProvider";
            this.Load += new System.EventHandler(this.ImageProvider_Load);
            this.SizeChanged += new System.EventHandler(this.ImageProvider_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageProvider_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ImageProvider_KeyUp);
            this.MouseHover += new System.EventHandler(this.ImageProvider_MouseHover);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ButtonControlManagerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupeBoxParent.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox ResultImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ButtonControlManagerPanel;
        private MyButton btnClose;
        private MyButton btnMaximize;
        private MyButton bntMinimize;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupeBoxParent;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label coor;
    }
}