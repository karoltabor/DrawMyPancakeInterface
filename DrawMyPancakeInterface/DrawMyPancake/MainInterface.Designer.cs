namespace DrawMyPancake
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.middlePanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pnlPresetsButtons = new System.Windows.Forms.Panel();
            this.pnlAddText = new System.Windows.Forms.Panel();
            this.pnlBitmap = new System.Windows.Forms.Panel();
            this.clrDialog = new System.Windows.Forms.ColorDialog();
            this.sfdSavePic = new System.Windows.Forms.SaveFileDialog();
            this.ofdLoadPic = new System.Windows.Forms.OpenFileDialog();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.btnPreset = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnSpiral = new System.Windows.Forms.Button();
            this.btnHeart = new System.Windows.Forms.Button();
            this.btnSmiley = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlAddTextBg = new System.Windows.Forms.Panel();
            this.tbText = new System.Windows.Forms.TextBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.pnlLeft.SuspendLayout();
            this.middlePanel.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.pnlPresetsButtons.SuspendLayout();
            this.pnlAddText.SuspendLayout();
            this.pnlBitmap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlAddTextBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(171)))), ((int)(((byte)(225)))));
            this.pnlLeft.Controls.Add(this.btnSettings);
            this.pnlLeft.Controls.Add(this.btnSave);
            this.pnlLeft.Controls.Add(this.btnOpen);
            this.pnlLeft.Controls.Add(this.btnClear);
            this.pnlLeft.Controls.Add(this.btnText);
            this.pnlLeft.Controls.Add(this.btnPen);
            this.pnlLeft.Controls.Add(this.btnPreset);
            this.pnlLeft.Controls.Add(this.btnMenu);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeft.MaximumSize = new System.Drawing.Size(200, 0);
            this.pnlLeft.MinimumSize = new System.Drawing.Size(200, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 881);
            this.pnlLeft.TabIndex = 0;
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.Transparent;
            this.middlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.middlePanel.ColumnCount = 1;
            this.middlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.middlePanel.Controls.Add(this.pnlCenter, 0, 1);
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlePanel.Location = new System.Drawing.Point(0, 0);
            this.middlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Padding = new System.Windows.Forms.Padding(200, 0, 0, 0);
            this.middlePanel.RowCount = 2;
            this.middlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.263823F));
            this.middlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.73618F));
            this.middlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.middlePanel.Size = new System.Drawing.Size(1604, 881);
            this.middlePanel.TabIndex = 2;
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.Transparent;
            this.pnlCenter.Controls.Add(this.pnlPresetsButtons);
            this.pnlCenter.Controls.Add(this.pbLogo);
            this.pnlCenter.Controls.Add(this.pnlAddText);
            this.pnlCenter.Controls.Add(this.pnlBitmap);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(200, 11);
            this.pnlCenter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1404, 870);
            this.pnlCenter.TabIndex = 1;
            // 
            // pnlPresetsButtons
            // 
            this.pnlPresetsButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(116)))), ((int)(((byte)(185)))));
            this.pnlPresetsButtons.Controls.Add(this.btnTriangle);
            this.pnlPresetsButtons.Controls.Add(this.btnSquare);
            this.pnlPresetsButtons.Controls.Add(this.btnSpiral);
            this.pnlPresetsButtons.Controls.Add(this.btnHeart);
            this.pnlPresetsButtons.Controls.Add(this.btnSmiley);
            this.pnlPresetsButtons.Location = new System.Drawing.Point(0, 80);
            this.pnlPresetsButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPresetsButtons.Name = "pnlPresetsButtons";
            this.pnlPresetsButtons.Size = new System.Drawing.Size(173, 450);
            this.pnlPresetsButtons.TabIndex = 0;
            this.pnlPresetsButtons.Visible = false;
            // 
            // pnlAddText
            // 
            this.pnlAddText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlAddText.Controls.Add(this.pnlAddTextBg);
            this.pnlAddText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddText.Location = new System.Drawing.Point(0, 0);
            this.pnlAddText.Name = "pnlAddText";
            this.pnlAddText.Size = new System.Drawing.Size(1404, 870);
            this.pnlAddText.TabIndex = 3;
            // 
            // pnlBitmap
            // 
            this.pnlBitmap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlBitmap.Controls.Add(this.picCanvas);
            this.pnlBitmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBitmap.Location = new System.Drawing.Point(0, 0);
            this.pnlBitmap.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBitmap.Name = "pnlBitmap";
            this.pnlBitmap.Size = new System.Drawing.Size(1404, 870);
            this.pnlBitmap.TabIndex = 6;
            this.pnlBitmap.Visible = false;
            // 
            // ofdLoadPic
            // 
            this.ofdLoadPic.FileName = "openFileDialog1";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(171)))), ((int)(((byte)(225)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 630);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSettings.Size = new System.Drawing.Size(200, 90);
            this.btnSettings.TabIndex = 17;
            this.btnSettings.Text = "     Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.SelectTool);
            this.btnSettings.MouseHover += new System.EventHandler(this.menuButton_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(171)))), ((int)(((byte)(225)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(0, 540);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(200, 90);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "   Save File";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.SelectTool);
            this.btnSave.MouseHover += new System.EventHandler(this.menuButton_MouseHover);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(171)))), ((int)(((byte)(225)))));
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(0, 450);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOpen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOpen.Size = new System.Drawing.Size(200, 90);
            this.btnOpen.TabIndex = 13;
            this.btnOpen.Text = "     Open File";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.SelectTool);
            this.btnOpen.MouseHover += new System.EventHandler(this.menuButton_MouseHover);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(171)))), ((int)(((byte)(225)))));
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(0, 360);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClear.Size = new System.Drawing.Size(200, 90);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "     Clear Field";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.SelectTool);
            this.btnClear.MouseHover += new System.EventHandler(this.menuButton_MouseHover);
            // 
            // btnText
            // 
            this.btnText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(171)))), ((int)(((byte)(225)))));
            this.btnText.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnText.FlatAppearance.BorderSize = 0;
            this.btnText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnText.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.btnText.ForeColor = System.Drawing.Color.White;
            this.btnText.Image = ((System.Drawing.Image)(resources.GetObject("btnText.Image")));
            this.btnText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnText.Location = new System.Drawing.Point(0, 270);
            this.btnText.Margin = new System.Windows.Forms.Padding(0);
            this.btnText.Name = "btnText";
            this.btnText.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnText.Size = new System.Drawing.Size(200, 90);
            this.btnText.TabIndex = 12;
            this.btnText.Text = "   Add Text";
            this.btnText.UseVisualStyleBackColor = false;
            this.btnText.Click += new System.EventHandler(this.SelectTool);
            this.btnText.MouseHover += new System.EventHandler(this.menuButton_MouseHover);
            // 
            // btnPen
            // 
            this.btnPen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(171)))), ((int)(((byte)(225)))));
            this.btnPen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPen.FlatAppearance.BorderSize = 0;
            this.btnPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPen.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.btnPen.ForeColor = System.Drawing.Color.White;
            this.btnPen.Image = ((System.Drawing.Image)(resources.GetObject("btnPen.Image")));
            this.btnPen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPen.Location = new System.Drawing.Point(0, 180);
            this.btnPen.Margin = new System.Windows.Forms.Padding(0);
            this.btnPen.Name = "btnPen";
            this.btnPen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPen.Size = new System.Drawing.Size(200, 90);
            this.btnPen.TabIndex = 4;
            this.btnPen.Text = "  Pentool";
            this.btnPen.UseVisualStyleBackColor = false;
            this.btnPen.Click += new System.EventHandler(this.SelectTool);
            this.btnPen.MouseHover += new System.EventHandler(this.menuButton_MouseHover);
            // 
            // btnPreset
            // 
            this.btnPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(171)))), ((int)(((byte)(225)))));
            this.btnPreset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPreset.FlatAppearance.BorderSize = 0;
            this.btnPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreset.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.btnPreset.ForeColor = System.Drawing.Color.White;
            this.btnPreset.Image = ((System.Drawing.Image)(resources.GetObject("btnPreset.Image")));
            this.btnPreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreset.Location = new System.Drawing.Point(0, 90);
            this.btnPreset.Margin = new System.Windows.Forms.Padding(0);
            this.btnPreset.Name = "btnPreset";
            this.btnPreset.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPreset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPreset.Size = new System.Drawing.Size(200, 90);
            this.btnPreset.TabIndex = 15;
            this.btnPreset.Text = "           Load Preset";
            this.btnPreset.UseVisualStyleBackColor = false;
            this.btnPreset.Click += new System.EventHandler(this.SelectTool);
            this.btnPreset.MouseHover += new System.EventHandler(this.menuButton_MouseHover);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(171)))), ((int)(((byte)(225)))));
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMenu.Size = new System.Drawing.Size(200, 90);
            this.btnMenu.TabIndex = 18;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.SelectTool);
            this.btnMenu.MouseHover += new System.EventHandler(this.menuButton_MouseHover);
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(116)))), ((int)(((byte)(185)))));
            this.btnTriangle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTriangle.FlatAppearance.BorderSize = 0;
            this.btnTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriangle.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.btnTriangle.ForeColor = System.Drawing.Color.White;
            this.btnTriangle.Image = ((System.Drawing.Image)(resources.GetObject("btnTriangle.Image")));
            this.btnTriangle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTriangle.Location = new System.Drawing.Point(0, 360);
            this.btnTriangle.Margin = new System.Windows.Forms.Padding(0);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTriangle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTriangle.Size = new System.Drawing.Size(173, 90);
            this.btnTriangle.TabIndex = 9;
            this.btnTriangle.Text = "       Triangle";
            this.btnTriangle.UseVisualStyleBackColor = false;
            this.btnTriangle.Click += new System.EventHandler(this.SelectPreset);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(116)))), ((int)(((byte)(185)))));
            this.btnSquare.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSquare.FlatAppearance.BorderSize = 0;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.btnSquare.ForeColor = System.Drawing.Color.White;
            this.btnSquare.Image = ((System.Drawing.Image)(resources.GetObject("btnSquare.Image")));
            this.btnSquare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSquare.Location = new System.Drawing.Point(0, 270);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(0);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSquare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSquare.Size = new System.Drawing.Size(173, 90);
            this.btnSquare.TabIndex = 8;
            this.btnSquare.Text = "     Square";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.SelectPreset);
            // 
            // btnSpiral
            // 
            this.btnSpiral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(116)))), ((int)(((byte)(185)))));
            this.btnSpiral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpiral.FlatAppearance.BorderSize = 0;
            this.btnSpiral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpiral.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.btnSpiral.ForeColor = System.Drawing.Color.White;
            this.btnSpiral.Image = ((System.Drawing.Image)(resources.GetObject("btnSpiral.Image")));
            this.btnSpiral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpiral.Location = new System.Drawing.Point(0, 180);
            this.btnSpiral.Margin = new System.Windows.Forms.Padding(0);
            this.btnSpiral.Name = "btnSpiral";
            this.btnSpiral.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSpiral.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSpiral.Size = new System.Drawing.Size(173, 90);
            this.btnSpiral.TabIndex = 7;
            this.btnSpiral.Text = "  Spiral";
            this.btnSpiral.UseVisualStyleBackColor = false;
            this.btnSpiral.Click += new System.EventHandler(this.SelectPreset);
            // 
            // btnHeart
            // 
            this.btnHeart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(116)))), ((int)(((byte)(185)))));
            this.btnHeart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHeart.FlatAppearance.BorderSize = 0;
            this.btnHeart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeart.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.btnHeart.ForeColor = System.Drawing.Color.White;
            this.btnHeart.Image = ((System.Drawing.Image)(resources.GetObject("btnHeart.Image")));
            this.btnHeart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeart.Location = new System.Drawing.Point(0, 90);
            this.btnHeart.Margin = new System.Windows.Forms.Padding(0);
            this.btnHeart.Name = "btnHeart";
            this.btnHeart.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHeart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHeart.Size = new System.Drawing.Size(173, 90);
            this.btnHeart.TabIndex = 6;
            this.btnHeart.Text = " Heart";
            this.btnHeart.UseVisualStyleBackColor = false;
            this.btnHeart.Click += new System.EventHandler(this.SelectPreset);
            // 
            // btnSmiley
            // 
            this.btnSmiley.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(116)))), ((int)(((byte)(185)))));
            this.btnSmiley.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSmiley.FlatAppearance.BorderSize = 0;
            this.btnSmiley.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmiley.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.btnSmiley.ForeColor = System.Drawing.Color.White;
            this.btnSmiley.Image = ((System.Drawing.Image)(resources.GetObject("btnSmiley.Image")));
            this.btnSmiley.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSmiley.Location = new System.Drawing.Point(0, 0);
            this.btnSmiley.Margin = new System.Windows.Forms.Padding(0);
            this.btnSmiley.Name = "btnSmiley";
            this.btnSmiley.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSmiley.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSmiley.Size = new System.Drawing.Size(173, 90);
            this.btnSmiley.TabIndex = 5;
            this.btnSmiley.Text = "  Smiley";
            this.btnSmiley.UseVisualStyleBackColor = false;
            this.btnSmiley.Click += new System.EventHandler(this.SelectPreset);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(1404, 151);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlAddTextBg
            // 
            this.pnlAddTextBg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAddTextBg.BackgroundImage")));
            this.pnlAddTextBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlAddTextBg.Controls.Add(this.tbText);
            this.pnlAddTextBg.Location = new System.Drawing.Point(159, 260);
            this.pnlAddTextBg.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAddTextBg.Name = "pnlAddTextBg";
            this.pnlAddTextBg.Size = new System.Drawing.Size(920, 297);
            this.pnlAddTextBg.TabIndex = 5;
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(162)))), ((int)(((byte)(76)))));
            this.tbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 120F);
            this.tbText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(115)))), ((int)(((byte)(44)))));
            this.tbText.Location = new System.Drawing.Point(145, 58);
            this.tbText.Margin = new System.Windows.Forms.Padding(0);
            this.tbText.MaxLength = 6;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(650, 186);
            this.tbText.TabIndex = 2;
            this.tbText.Text = "HELLO!";
            this.tbText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(197)))));
            this.picCanvas.Image = global::PanelTesting.Properties.Resources.DMP_Bitmap;
            this.picCanvas.Location = new System.Drawing.Point(145, 260);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(0);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(733, 524);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.middlePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draw My Pancake";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.pnlLeft.ResumeLayout(false);
            this.middlePanel.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlPresetsButtons.ResumeLayout(false);
            this.pnlAddText.ResumeLayout(false);
            this.pnlBitmap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlAddTextBg.ResumeLayout(false);
            this.pnlAddTextBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.TableLayoutPanel middlePanel;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.ColorDialog clrDialog;
        public System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.SaveFileDialog sfdSavePic;
        private System.Windows.Forms.OpenFileDialog ofdLoadPic;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPreset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlAddText;
        private System.Windows.Forms.Panel pnlBitmap;
        private System.Windows.Forms.Panel pnlAddTextBg;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Panel pnlPresetsButtons;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnSpiral;
        private System.Windows.Forms.Button btnHeart;
        private System.Windows.Forms.Button btnSmiley;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

