namespace PanelTesting
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btnPresetFreeDraw = new System.Windows.Forms.Button();
            this.btnPresetSpiral = new System.Windows.Forms.Button();
            this.btnPresetHeart = new System.Windows.Forms.Button();
            this.btnPresetTriangle = new System.Windows.Forms.Button();
            this.btnPresetCircle = new System.Windows.Forms.Button();
            this.btnPresetSquare = new System.Windows.Forms.Button();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.middlePanel = new System.Windows.Forms.TableLayoutPanel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.clrDialog = new System.Windows.Forms.ColorDialog();
            this.sfdSavePic = new System.Windows.Forms.SaveFileDialog();
            this.ofdLoadPic = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.middlePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.78698F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.21302F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.Controls.Add(this.leftPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rightPanel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.middlePanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 549);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.AutoScroll = true;
            this.leftPanel.Controls.Add(this.btnPresetFreeDraw);
            this.leftPanel.Controls.Add(this.btnPresetSpiral);
            this.leftPanel.Controls.Add(this.btnPresetHeart);
            this.leftPanel.Controls.Add(this.btnPresetTriangle);
            this.leftPanel.Controls.Add(this.btnPresetCircle);
            this.leftPanel.Controls.Add(this.btnPresetSquare);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(3, 3);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(121, 543);
            this.leftPanel.TabIndex = 0;
            // 
            // btnPresetFreeDraw
            // 
            this.btnPresetFreeDraw.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPresetFreeDraw.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPresetFreeDraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPresetFreeDraw.Location = new System.Drawing.Point(0, 500);
            this.btnPresetFreeDraw.Name = "btnPresetFreeDraw";
            this.btnPresetFreeDraw.Size = new System.Drawing.Size(104, 100);
            this.btnPresetFreeDraw.TabIndex = 5;
            this.btnPresetFreeDraw.Text = "PRESET FREE DRAW";
            this.btnPresetFreeDraw.UseVisualStyleBackColor = true;
            this.btnPresetFreeDraw.Click += new System.EventHandler(this.btnPresetFreeDraw_Click);
            // 
            // btnPresetSpiral
            // 
            this.btnPresetSpiral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPresetSpiral.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPresetSpiral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPresetSpiral.Location = new System.Drawing.Point(0, 400);
            this.btnPresetSpiral.Name = "btnPresetSpiral";
            this.btnPresetSpiral.Size = new System.Drawing.Size(104, 100);
            this.btnPresetSpiral.TabIndex = 4;
            this.btnPresetSpiral.Text = "PRESET    Spiraal";
            this.btnPresetSpiral.UseVisualStyleBackColor = true;
            this.btnPresetSpiral.Click += new System.EventHandler(this.btnPresetSpiral_Click);
            // 
            // btnPresetHeart
            // 
            this.btnPresetHeart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPresetHeart.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPresetHeart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPresetHeart.Location = new System.Drawing.Point(0, 300);
            this.btnPresetHeart.Name = "btnPresetHeart";
            this.btnPresetHeart.Size = new System.Drawing.Size(104, 100);
            this.btnPresetHeart.TabIndex = 3;
            this.btnPresetHeart.Text = "PRESET  Hartje";
            this.btnPresetHeart.UseVisualStyleBackColor = true;
            this.btnPresetHeart.Click += new System.EventHandler(this.btnPresetHeart_Click);
            // 
            // btnPresetTriangle
            // 
            this.btnPresetTriangle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPresetTriangle.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPresetTriangle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPresetTriangle.Location = new System.Drawing.Point(0, 200);
            this.btnPresetTriangle.Name = "btnPresetTriangle";
            this.btnPresetTriangle.Size = new System.Drawing.Size(104, 100);
            this.btnPresetTriangle.TabIndex = 2;
            this.btnPresetTriangle.Text = "PRESET   Driehoek";
            this.btnPresetTriangle.UseVisualStyleBackColor = true;
            this.btnPresetTriangle.Click += new System.EventHandler(this.btnPresetTriangle_Click);
            // 
            // btnPresetCircle
            // 
            this.btnPresetCircle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPresetCircle.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPresetCircle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPresetCircle.Location = new System.Drawing.Point(0, 100);
            this.btnPresetCircle.Name = "btnPresetCircle";
            this.btnPresetCircle.Size = new System.Drawing.Size(104, 100);
            this.btnPresetCircle.TabIndex = 1;
            this.btnPresetCircle.Text = "PRESET    Cirkel";
            this.btnPresetCircle.UseVisualStyleBackColor = true;
            this.btnPresetCircle.Click += new System.EventHandler(this.btnPresetCircle_Click);
            // 
            // btnPresetSquare
            // 
            this.btnPresetSquare.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPresetSquare.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresetSquare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPresetSquare.Location = new System.Drawing.Point(0, 0);
            this.btnPresetSquare.Name = "btnPresetSquare";
            this.btnPresetSquare.Size = new System.Drawing.Size(104, 100);
            this.btnPresetSquare.TabIndex = 0;
            this.btnPresetSquare.Text = "PRESET  Vierkant";
            this.btnPresetSquare.UseVisualStyleBackColor = true;
            this.btnPresetSquare.Click += new System.EventHandler(this.btnPresetSquare_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.btnStart);
            this.rightPanel.Controls.Add(this.btnDelete);
            this.rightPanel.Controls.Add(this.btnLoad);
            this.rightPanel.Controls.Add(this.btnSave);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(679, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(118, 543);
            this.rightPanel.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(66)))));
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(0, 300);
            this.btnStart.Name = "btnStart";
            this.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStart.Size = new System.Drawing.Size(118, 100);
            this.btnStart.TabIndex = 6;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(42)))));
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(0, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(118, 100);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(116)))), ((int)(((byte)(185)))));
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(0, 100);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLoad.Size = new System.Drawing.Size(118, 100);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(171)))), ((int)(((byte)(225)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(118, 100);
            this.btnSave.TabIndex = 3;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // middlePanel
            // 
            this.middlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.middlePanel.ColumnCount = 1;
            this.middlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.middlePanel.Controls.Add(this.topPanel, 0, 0);
            this.middlePanel.Controls.Add(this.panel1, 0, 1);
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlePanel.Location = new System.Drawing.Point(130, 3);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.RowCount = 2;
            this.middlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.31123F));
            this.middlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.68877F));
            this.middlePanel.Size = new System.Drawing.Size(543, 543);
            this.middlePanel.TabIndex = 2;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topPanel.BackgroundImage")));
            this.topPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(537, 87);
            this.topPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.picCanvas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 444);
            this.panel1.TabIndex = 1;
            // 
            // picCanvas
            // 
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCanvas.Location = new System.Drawing.Point(0, 0);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(537, 444);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            // 
            // ofdLoadPic
            // 
            this.ofdLoadPic.FileName = "openFileDialog1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "mainForm";
            this.Text = "Draw My Pancake";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.middlePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button btnPresetFreeDraw;
        private System.Windows.Forms.Button btnPresetSpiral;
        private System.Windows.Forms.Button btnPresetHeart;
        private System.Windows.Forms.Button btnPresetTriangle;
        private System.Windows.Forms.Button btnPresetCircle;
        private System.Windows.Forms.Button btnPresetSquare;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel middlePanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog clrDialog;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.SaveFileDialog sfdSavePic;
        private System.Windows.Forms.OpenFileDialog ofdLoadPic;
    }
}

