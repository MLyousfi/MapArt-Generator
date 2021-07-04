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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Yvalue = new System.Windows.Forms.Label();
            this.Xvalue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupeBoxParent = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ResultImage = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClose = new ImageProcessing.MyButton();
            this.btnMaximize = new ImageProcessing.MyButton();
            this.bntMinimize = new ImageProcessing.MyButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pickedcolorpanel = new System.Windows.Forms.Panel();
            this.proposedcolorpanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ButtonControlManagerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupeBoxParent.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImage)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(1183, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 709);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 375);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(348, 112);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordonate : ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Yvalue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Xvalue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 79);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Yvalue
            // 
            this.Yvalue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Yvalue.AutoSize = true;
            this.Yvalue.Location = new System.Drawing.Point(173, 39);
            this.Yvalue.Name = "Yvalue";
            this.Yvalue.Size = new System.Drawing.Size(0, 40);
            this.Yvalue.TabIndex = 4;
            this.Yvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Xvalue
            // 
            this.Xvalue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Xvalue.AutoSize = true;
            this.Xvalue.Location = new System.Drawing.Point(173, 0);
            this.Xvalue.Name = "Xvalue";
            this.Xvalue.Size = new System.Drawing.Size(0, 39);
            this.Xvalue.TabIndex = 3;
            this.Xvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "X value :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Y value :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(4, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(348, 137);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mincraft Colors : ";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(4, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(340, 104);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(4, 159);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(348, 208);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Colors : ";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pickedcolorpanel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.proposedcolorpanel, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.42857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(340, 175);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 89);
            this.label1.TabIndex = 5;
            this.label1.Text = "Picked color :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 86);
            this.label4.TabIndex = 6;
            this.label4.Text = "Proposed color in mincraft :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pickedcolorpanel
            // 
            this.pickedcolorpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickedcolorpanel.Location = new System.Drawing.Point(173, 3);
            this.pickedcolorpanel.Name = "pickedcolorpanel";
            this.pickedcolorpanel.Size = new System.Drawing.Size(164, 83);
            this.pickedcolorpanel.TabIndex = 7;
            this.pickedcolorpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pickedcolorpanel_Paint);
            // 
            // proposedcolorpanel
            // 
            this.proposedcolorpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proposedcolorpanel.Location = new System.Drawing.Point(173, 92);
            this.proposedcolorpanel.Name = "proposedcolorpanel";
            this.proposedcolorpanel.Size = new System.Drawing.Size(164, 80);
            this.proposedcolorpanel.TabIndex = 8;
            this.proposedcolorpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.proposedcolorpanel_Paint);
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
            this.SizeChanged += new System.EventHandler(this.ImageProvider_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageProvider_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ImageProvider_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ImageProvider_KeyUp);
            this.MouseHover += new System.EventHandler(this.ImageProvider_MouseHover);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ButtonControlManagerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupeBoxParent.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultImage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupeBoxParent;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Yvalue;
        private System.Windows.Forms.Label Xvalue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pickedcolorpanel;
        private System.Windows.Forms.Panel proposedcolorpanel;
    }
}