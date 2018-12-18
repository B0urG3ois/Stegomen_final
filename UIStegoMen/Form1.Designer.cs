namespace UIStegoMen
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo_stegomen = new System.Windows.Forms.PictureBox();
            this.loginFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.aboutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.decryptButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.encryptButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.header = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.loginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbLine = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nimEga = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nimLul = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nimSep = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nimRizki = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nimHans = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEga = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLul = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSep = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRizki = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblHans = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblLine = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnEncrypt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDecrypt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblPwEn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTextEn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnBrowseEn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.textBox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCheckId = new Bunifu.Framework.UI.BunifuThinButton2();
            this.textBox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_stegomen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.logo_stegomen);
            this.panel1.Controls.Add(this.loginFlatButton);
            this.panel1.Controls.Add(this.aboutButton);
            this.panel1.Controls.Add(this.decryptButton);
            this.panel1.Controls.Add(this.encryptButton);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 730);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logo_stegomen
            // 
            this.logo_stegomen.Image = ((System.Drawing.Image)(resources.GetObject("logo_stegomen.Image")));
            this.logo_stegomen.Location = new System.Drawing.Point(64, 23);
            this.logo_stegomen.Name = "logo_stegomen";
            this.logo_stegomen.Size = new System.Drawing.Size(161, 118);
            this.logo_stegomen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_stegomen.TabIndex = 6;
            this.logo_stegomen.TabStop = false;
            // 
            // loginFlatButton
            // 
            this.loginFlatButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.loginFlatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.loginFlatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginFlatButton.BorderRadius = 0;
            this.loginFlatButton.ButtonText = "                 ID Line";
            this.loginFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginFlatButton.DisabledColor = System.Drawing.Color.Gray;
            this.loginFlatButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFlatButton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginFlatButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("loginFlatButton.Iconimage")));
            this.loginFlatButton.Iconimage_right = null;
            this.loginFlatButton.Iconimage_right_Selected = null;
            this.loginFlatButton.Iconimage_Selected = null;
            this.loginFlatButton.IconMarginLeft = 15;
            this.loginFlatButton.IconMarginRight = 0;
            this.loginFlatButton.IconRightVisible = true;
            this.loginFlatButton.IconRightZoom = 0D;
            this.loginFlatButton.IconVisible = true;
            this.loginFlatButton.IconZoom = 50D;
            this.loginFlatButton.IsTab = true;
            this.loginFlatButton.Location = new System.Drawing.Point(0, 149);
            this.loginFlatButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.loginFlatButton.Name = "loginFlatButton";
            this.loginFlatButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.loginFlatButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.loginFlatButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.loginFlatButton.selected = false;
            this.loginFlatButton.Size = new System.Drawing.Size(348, 42);
            this.loginFlatButton.TabIndex = 5;
            this.loginFlatButton.Text = "                 ID Line";
            this.loginFlatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginFlatButton.Textcolor = System.Drawing.Color.Silver;
            this.loginFlatButton.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFlatButton.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aboutButton.BorderRadius = 0;
            this.aboutButton.ButtonText = "                 About Us";
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutButton.DisabledColor = System.Drawing.Color.Gray;
            this.aboutButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Iconcolor = System.Drawing.Color.Transparent;
            this.aboutButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("aboutButton.Iconimage")));
            this.aboutButton.Iconimage_right = null;
            this.aboutButton.Iconimage_right_Selected = null;
            this.aboutButton.Iconimage_Selected = null;
            this.aboutButton.IconMarginLeft = 17;
            this.aboutButton.IconMarginRight = 0;
            this.aboutButton.IconRightVisible = true;
            this.aboutButton.IconRightZoom = 0D;
            this.aboutButton.IconVisible = true;
            this.aboutButton.IconZoom = 40D;
            this.aboutButton.IsTab = true;
            this.aboutButton.Location = new System.Drawing.Point(0, 265);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.aboutButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.aboutButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.aboutButton.selected = false;
            this.aboutButton.Size = new System.Drawing.Size(348, 37);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.Text = "                 About Us";
            this.aboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.Textcolor = System.Drawing.Color.Silver;
            this.aboutButton.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.decryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.decryptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.decryptButton.BorderRadius = 0;
            this.decryptButton.ButtonText = "                 Extract";
            this.decryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decryptButton.DisabledColor = System.Drawing.Color.Gray;
            this.decryptButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptButton.Iconcolor = System.Drawing.Color.Transparent;
            this.decryptButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("decryptButton.Iconimage")));
            this.decryptButton.Iconimage_right = null;
            this.decryptButton.Iconimage_right_Selected = null;
            this.decryptButton.Iconimage_Selected = null;
            this.decryptButton.IconMarginLeft = 17;
            this.decryptButton.IconMarginRight = 0;
            this.decryptButton.IconRightVisible = true;
            this.decryptButton.IconRightZoom = 0D;
            this.decryptButton.IconVisible = true;
            this.decryptButton.IconZoom = 40D;
            this.decryptButton.IsTab = true;
            this.decryptButton.Location = new System.Drawing.Point(0, 228);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.decryptButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.decryptButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.decryptButton.selected = false;
            this.decryptButton.Size = new System.Drawing.Size(348, 37);
            this.decryptButton.TabIndex = 3;
            this.decryptButton.Text = "                 Extract";
            this.decryptButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.decryptButton.Textcolor = System.Drawing.Color.Silver;
            this.decryptButton.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptButton.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.encryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.encryptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.encryptButton.BorderRadius = 0;
            this.encryptButton.ButtonText = "                 Hide";
            this.encryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encryptButton.DisabledColor = System.Drawing.Color.Gray;
            this.encryptButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptButton.Iconcolor = System.Drawing.Color.Transparent;
            this.encryptButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("encryptButton.Iconimage")));
            this.encryptButton.Iconimage_right = null;
            this.encryptButton.Iconimage_right_Selected = null;
            this.encryptButton.Iconimage_Selected = null;
            this.encryptButton.IconMarginLeft = 17;
            this.encryptButton.IconMarginRight = 0;
            this.encryptButton.IconRightVisible = true;
            this.encryptButton.IconRightZoom = 0D;
            this.encryptButton.IconVisible = true;
            this.encryptButton.IconZoom = 40D;
            this.encryptButton.IsTab = true;
            this.encryptButton.Location = new System.Drawing.Point(0, 191);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.encryptButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.encryptButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.encryptButton.selected = false;
            this.encryptButton.Size = new System.Drawing.Size(348, 37);
            this.encryptButton.TabIndex = 2;
            this.encryptButton.Text = "                 Hide";
            this.encryptButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.encryptButton.Textcolor = System.Drawing.Color.Silver;
            this.encryptButton.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptButton.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(308, 20);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(18, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1280, 38);
            this.header.TabIndex = 1;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1241, 6);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 20;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 21);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(42, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(91, 21);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "StegoMen";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // loginButton
            // 
            this.loginButton.ActiveBorderThickness = 1;
            this.loginButton.ActiveCornerRadius = 20;
            this.loginButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.loginButton.ActiveForecolor = System.Drawing.Color.White;
            this.loginButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.loginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginButton.BackgroundImage")));
            this.loginButton.ButtonText = "LogIn";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.loginButton.IdleBorderThickness = 1;
            this.loginButton.IdleCornerRadius = 20;
            this.loginButton.IdleFillColor = System.Drawing.Color.White;
            this.loginButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.loginButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.loginButton.Location = new System.Drawing.Point(380, 391);
            this.loginButton.Margin = new System.Windows.Forms.Padding(5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(181, 41);
            this.loginButton.TabIndex = 0;
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginButton.Visible = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // tbLine
            // 
            this.tbLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLine.BackColor = System.Drawing.Color.White;
            this.tbLine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLine.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbLine.ForeColor = System.Drawing.Color.Black;
            this.tbLine.HintForeColor = System.Drawing.Color.Empty;
            this.tbLine.HintText = "";
            this.tbLine.isPassword = false;
            this.tbLine.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbLine.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tbLine.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbLine.LineThickness = 3;
            this.tbLine.Location = new System.Drawing.Point(194, 311);
            this.tbLine.Margin = new System.Windows.Forms.Padding(6);
            this.tbLine.Name = "tbLine";
            this.tbLine.Size = new System.Drawing.Size(565, 35);
            this.tbLine.TabIndex = 1;
            this.tbLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLine.Visible = false;
            this.tbLine.OnValueChanged += new System.EventHandler(this.tbLine_OnValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nimEga);
            this.panel2.Controls.Add(this.nimLul);
            this.panel2.Controls.Add(this.nimSep);
            this.panel2.Controls.Add(this.nimRizki);
            this.panel2.Controls.Add(this.nimHans);
            this.panel2.Controls.Add(this.lblEga);
            this.panel2.Controls.Add(this.lblLul);
            this.panel2.Controls.Add(this.lblSep);
            this.panel2.Controls.Add(this.lblRizki);
            this.panel2.Controls.Add(this.lblHans);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lblLine);
            this.panel2.Controls.Add(this.btnEncrypt);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnDecrypt);
            this.panel2.Controls.Add(this.lblPwEn);
            this.panel2.Controls.Add(this.lblTextEn);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.btnBrowseEn);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btnCheckId);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.tbLine);
            this.panel2.Controls.Add(this.loginButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(348, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 730);
            this.panel2.TabIndex = 2;
            // 
            // nimEga
            // 
            this.nimEga.AutoSize = true;
            this.nimEga.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nimEga.ForeColor = System.Drawing.Color.White;
            this.nimEga.Location = new System.Drawing.Point(546, 639);
            this.nimEga.Name = "nimEga";
            this.nimEga.Size = new System.Drawing.Size(131, 22);
            this.nimEga.TabIndex = 34;
            this.nimEga.Text = "00000019178";
            this.nimEga.Visible = false;
            // 
            // nimLul
            // 
            this.nimLul.AutoSize = true;
            this.nimLul.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nimLul.ForeColor = System.Drawing.Color.White;
            this.nimLul.Location = new System.Drawing.Point(550, 585);
            this.nimLul.Name = "nimLul";
            this.nimLul.Size = new System.Drawing.Size(131, 22);
            this.nimLul.TabIndex = 33;
            this.nimLul.Text = "00000018136";
            this.nimLul.Visible = false;
            // 
            // nimSep
            // 
            this.nimSep.AutoSize = true;
            this.nimSep.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nimSep.ForeColor = System.Drawing.Color.White;
            this.nimSep.Location = new System.Drawing.Point(550, 531);
            this.nimSep.Name = "nimSep";
            this.nimSep.Size = new System.Drawing.Size(131, 22);
            this.nimSep.TabIndex = 32;
            this.nimSep.Text = "00000017966";
            this.nimSep.Visible = false;
            // 
            // nimRizki
            // 
            this.nimRizki.AutoSize = true;
            this.nimRizki.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nimRizki.ForeColor = System.Drawing.Color.White;
            this.nimRizki.Location = new System.Drawing.Point(550, 478);
            this.nimRizki.Name = "nimRizki";
            this.nimRizki.Size = new System.Drawing.Size(131, 22);
            this.nimRizki.TabIndex = 31;
            this.nimRizki.Text = "00000014826";
            this.nimRizki.Visible = false;
            // 
            // nimHans
            // 
            this.nimHans.AutoSize = true;
            this.nimHans.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nimHans.ForeColor = System.Drawing.Color.White;
            this.nimHans.Location = new System.Drawing.Point(550, 426);
            this.nimHans.Name = "nimHans";
            this.nimHans.Size = new System.Drawing.Size(131, 22);
            this.nimHans.TabIndex = 30;
            this.nimHans.Text = "00000013581";
            this.nimHans.Visible = false;
            // 
            // lblEga
            // 
            this.lblEga.AutoSize = true;
            this.lblEga.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEga.ForeColor = System.Drawing.Color.White;
            this.lblEga.Location = new System.Drawing.Point(278, 639);
            this.lblEga.Name = "lblEga";
            this.lblEga.Size = new System.Drawing.Size(236, 22);
            this.lblEga.TabIndex = 29;
            this.lblEga.Text = "Ega Pamungkas Susanto";
            this.lblEga.Visible = false;
            // 
            // lblLul
            // 
            this.lblLul.AutoSize = true;
            this.lblLul.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLul.ForeColor = System.Drawing.Color.White;
            this.lblLul.Location = new System.Drawing.Point(319, 587);
            this.lblLul.Name = "lblLul";
            this.lblLul.Size = new System.Drawing.Size(138, 22);
            this.lblLul.TabIndex = 28;
            this.lblLul.Text = "Lulu Luthfiana";
            this.lblLul.Visible = false;
            // 
            // lblSep
            // 
            this.lblSep.AutoSize = true;
            this.lblSep.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSep.ForeColor = System.Drawing.Color.White;
            this.lblSep.Location = new System.Drawing.Point(277, 531);
            this.lblSep.Name = "lblSep";
            this.lblSep.Size = new System.Drawing.Size(232, 22);
            this.lblSep.TabIndex = 27;
            this.lblSep.Text = "Septiyan Mudhiya Sadid";
            this.lblSep.Visible = false;
            // 
            // lblRizki
            // 
            this.lblRizki.AutoSize = true;
            this.lblRizki.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRizki.ForeColor = System.Drawing.Color.White;
            this.lblRizki.Location = new System.Drawing.Point(303, 478);
            this.lblRizki.Name = "lblRizki";
            this.lblRizki.Size = new System.Drawing.Size(171, 22);
            this.lblRizki.TabIndex = 26;
            this.lblRizki.Text = "Rizki Dwijaya Sakti";
            this.lblRizki.Visible = false;
            // 
            // lblHans
            // 
            this.lblHans.AutoSize = true;
            this.lblHans.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHans.ForeColor = System.Drawing.Color.White;
            this.lblHans.Location = new System.Drawing.Point(282, 426);
            this.lblHans.Name = "lblHans";
            this.lblHans.Size = new System.Drawing.Size(214, 22);
            this.lblHans.TabIndex = 25;
            this.lblHans.Text = "Hansrenee Willysandro";
            this.lblHans.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(241, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(465, 341);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.ForeColor = System.Drawing.Color.White;
            this.lblLine.Location = new System.Drawing.Point(434, 280);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(70, 22);
            this.lblLine.TabIndex = 24;
            this.lblLine.Text = "ID Line";
            this.lblLine.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.ActiveBorderThickness = 1;
            this.btnEncrypt.ActiveCornerRadius = 20;
            this.btnEncrypt.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEncrypt.ActiveForecolor = System.Drawing.Color.White;
            this.btnEncrypt.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnEncrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEncrypt.BackgroundImage")));
            this.btnEncrypt.ButtonText = "Encrypt";
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEncrypt.IdleBorderThickness = 1;
            this.btnEncrypt.IdleCornerRadius = 20;
            this.btnEncrypt.IdleFillColor = System.Drawing.Color.White;
            this.btnEncrypt.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEncrypt.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEncrypt.Location = new System.Drawing.Point(367, 582);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(5);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(226, 48);
            this.btnEncrypt.TabIndex = 23;
            this.btnEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEncrypt.Visible = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(194, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.ActiveBorderThickness = 1;
            this.btnDecrypt.ActiveCornerRadius = 20;
            this.btnDecrypt.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDecrypt.ActiveForecolor = System.Drawing.Color.White;
            this.btnDecrypt.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnDecrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecrypt.BackgroundImage")));
            this.btnDecrypt.ButtonText = "Decrypt";
            this.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDecrypt.IdleBorderThickness = 1;
            this.btnDecrypt.IdleCornerRadius = 20;
            this.btnDecrypt.IdleFillColor = System.Drawing.Color.White;
            this.btnDecrypt.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDecrypt.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDecrypt.Location = new System.Drawing.Point(367, 582);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(5);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(226, 48);
            this.btnDecrypt.TabIndex = 18;
            this.btnDecrypt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDecrypt.Visible = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblPwEn
            // 
            this.lblPwEn.AutoSize = true;
            this.lblPwEn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwEn.ForeColor = System.Drawing.Color.White;
            this.lblPwEn.Location = new System.Drawing.Point(50, 508);
            this.lblPwEn.Name = "lblPwEn";
            this.lblPwEn.Size = new System.Drawing.Size(95, 22);
            this.lblPwEn.TabIndex = 12;
            this.lblPwEn.Text = "Password";
            this.lblPwEn.Visible = false;
            // 
            // lblTextEn
            // 
            this.lblTextEn.AutoSize = true;
            this.lblTextEn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextEn.ForeColor = System.Drawing.Color.White;
            this.lblTextEn.Location = new System.Drawing.Point(68, 447);
            this.lblTextEn.Name = "lblTextEn";
            this.lblTextEn.Size = new System.Drawing.Size(46, 22);
            this.lblTextEn.TabIndex = 11;
            this.lblTextEn.Text = "Text";
            this.lblTextEn.Visible = false;
            this.lblTextEn.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(41, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(116, 22);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID Receiver";
            this.lblID.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.HintForeColor = System.Drawing.Color.Empty;
            this.textBox3.HintText = "";
            this.textBox3.isPassword = false;
            this.textBox3.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBox3.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.textBox3.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBox3.LineThickness = 3;
            this.textBox3.Location = new System.Drawing.Point(194, 503);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(565, 33);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.HintForeColor = System.Drawing.Color.Empty;
            this.textBox2.HintText = "";
            this.textBox2.isPassword = false;
            this.textBox2.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBox2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.textBox2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBox2.LineThickness = 3;
            this.textBox2.Location = new System.Drawing.Point(194, 441);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(565, 33);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Visible = false;
            // 
            // btnBrowseEn
            // 
            this.btnBrowseEn.ActiveBorderThickness = 1;
            this.btnBrowseEn.ActiveCornerRadius = 20;
            this.btnBrowseEn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnBrowseEn.ActiveForecolor = System.Drawing.Color.White;
            this.btnBrowseEn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnBrowseEn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnBrowseEn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowseEn.BackgroundImage")));
            this.btnBrowseEn.ButtonText = "Browse";
            this.btnBrowseEn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseEn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseEn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnBrowseEn.IdleBorderThickness = 1;
            this.btnBrowseEn.IdleCornerRadius = 20;
            this.btnBrowseEn.IdleFillColor = System.Drawing.Color.White;
            this.btnBrowseEn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnBrowseEn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnBrowseEn.Location = new System.Drawing.Point(51, 363);
            this.btnBrowseEn.Margin = new System.Windows.Forms.Padding(5);
            this.btnBrowseEn.Name = "btnBrowseEn";
            this.btnBrowseEn.Size = new System.Drawing.Size(84, 41);
            this.btnBrowseEn.TabIndex = 6;
            this.btnBrowseEn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowseEn.Visible = false;
            this.btnBrowseEn.Click += new System.EventHandler(this.btnBrowseEn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.HintForeColor = System.Drawing.Color.Empty;
            this.textBox1.HintText = "";
            this.textBox1.isPassword = false;
            this.textBox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.textBox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBox1.LineThickness = 3;
            this.textBox1.Location = new System.Drawing.Point(194, 371);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(565, 33);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // btnCheckId
            // 
            this.btnCheckId.ActiveBorderThickness = 1;
            this.btnCheckId.ActiveCornerRadius = 20;
            this.btnCheckId.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCheckId.ActiveForecolor = System.Drawing.Color.White;
            this.btnCheckId.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCheckId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCheckId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckId.BackgroundImage")));
            this.btnCheckId.ButtonText = "Check ID";
            this.btnCheckId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCheckId.IdleBorderThickness = 1;
            this.btnCheckId.IdleCornerRadius = 20;
            this.btnCheckId.IdleFillColor = System.Drawing.Color.White;
            this.btnCheckId.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCheckId.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCheckId.Location = new System.Drawing.Point(1323, 13);
            this.btnCheckId.Margin = new System.Windows.Forms.Padding(5);
            this.btnCheckId.Name = "btnCheckId";
            this.btnCheckId.Size = new System.Drawing.Size(84, 41);
            this.btnCheckId.TabIndex = 3;
            this.btnCheckId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheckId.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.HintForeColor = System.Drawing.Color.Empty;
            this.textBox4.HintText = "";
            this.textBox4.isPassword = false;
            this.textBox4.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBox4.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.textBox4.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBox4.LineThickness = 3;
            this.textBox4.Location = new System.Drawing.Point(194, 23);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(565, 33);
            this.textBox4.TabIndex = 2;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.Visible = false;
            this.textBox4.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_stegomen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton encryptButton;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton decryptButton;
        private Bunifu.Framework.UI.BunifuFlatButton aboutButton;
        private Bunifu.Framework.UI.BunifuFlatButton loginFlatButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbLine;
        private Bunifu.Framework.UI.BunifuThinButton2 loginButton;
        private System.Windows.Forms.PictureBox logo_stegomen;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBrowseEn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCheckId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPwEn;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTextEn;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDecrypt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEncrypt;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLine;
        private Bunifu.Framework.UI.BunifuCustomLabel nimEga;
        private Bunifu.Framework.UI.BunifuCustomLabel nimLul;
        private Bunifu.Framework.UI.BunifuCustomLabel nimSep;
        private Bunifu.Framework.UI.BunifuCustomLabel nimRizki;
        private Bunifu.Framework.UI.BunifuCustomLabel nimHans;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEga;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLul;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSep;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRizki;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHans;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

