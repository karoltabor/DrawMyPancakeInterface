namespace EasyPaint
{
    partial class form1
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
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.sfdSavePic = new System.Windows.Forms.SaveFileDialog();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlFrame = new System.Windows.Forms.Panel();
            this.lblEditText = new System.Windows.Forms.Label();
            this.txtInsertText = new System.Windows.Forms.TextBox();
            this.lblFontDetails = new System.Windows.Forms.Label();
            this.cmdFont = new System.Windows.Forms.Button();
            this.lblBlack = new System.Windows.Forms.Label();
            this.lblNavy = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblColorSelected = new System.Windows.Forms.Label();
            this.lblToolSelected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBrushSize = new System.Windows.Forms.ComboBox();
            this.lblPenWidth = new System.Windows.Forms.Label();
            this.cmbPenWidth = new System.Windows.Forms.ComboBox();
            this.mnuEasyPaint = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblBrush = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.mnuEasyPaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblRed);
            this.pnlMain.Controls.Add(this.lblNavy);
            this.pnlMain.Controls.Add(this.cmbPenWidth);
            this.pnlMain.Controls.Add(this.lblPenWidth);
            this.pnlMain.Controls.Add(this.cmbBrushSize);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lblToolSelected);
            this.pnlMain.Controls.Add(this.lblLine);
            this.pnlMain.Controls.Add(this.lblBrush);
            this.pnlMain.Controls.Add(this.lblColorSelected);
            this.pnlMain.Controls.Add(this.lblColor);
            this.pnlMain.Controls.Add(this.lblBlack);
            this.pnlMain.Controls.Add(this.cmdFont);
            this.pnlMain.Controls.Add(this.lblFontDetails);
            this.pnlMain.Controls.Add(this.txtInsertText);
            this.pnlMain.Controls.Add(this.lblEditText);
            this.pnlMain.Enabled = false;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(624, 538);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlFrame
            // 
            this.pnlFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFrame.Location = new System.Drawing.Point(9, 49);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(482, 482);
            this.pnlFrame.TabIndex = 2;
            // 
            // lblEditText
            // 
            this.lblEditText.AutoSize = true;
            this.lblEditText.Location = new System.Drawing.Point(12, 6);
            this.lblEditText.Name = "lblEditText";
            this.lblEditText.Size = new System.Drawing.Size(56, 13);
            this.lblEditText.TabIndex = 0;
            this.lblEditText.Text = "Insert text:";
            // 
            // txtInsertText
            // 
            this.txtInsertText.Location = new System.Drawing.Point(75, 3);
            this.txtInsertText.Name = "txtInsertText";
            this.txtInsertText.Size = new System.Drawing.Size(255, 20);
            this.txtInsertText.TabIndex = 1;
            // 
            // lblFontDetails
            // 
            this.lblFontDetails.AutoSize = true;
            this.lblFontDetails.Location = new System.Drawing.Point(336, 6);
            this.lblFontDetails.Name = "lblFontDetails";
            this.lblFontDetails.Size = new System.Drawing.Size(100, 13);
            this.lblFontDetails.TabIndex = 2;
            this.lblFontDetails.Text = "(Arial 12pt, Regular)";
            // 
            // cmdFont
            // 
            this.cmdFont.Location = new System.Drawing.Point(512, 485);
            this.cmdFont.Name = "cmdFont";
            this.cmdFont.Size = new System.Drawing.Size(97, 23);
            this.cmdFont.TabIndex = 3;
            this.cmdFont.Text = "Select Font";
            this.cmdFont.UseVisualStyleBackColor = true;
            // 
            // lblBlack
            // 
            this.lblBlack.BackColor = System.Drawing.Color.Black;
            this.lblBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBlack.Location = new System.Drawing.Point(499, 47);
            this.lblBlack.Name = "lblBlack";
            this.lblBlack.Size = new System.Drawing.Size(23, 23);
            this.lblBlack.TabIndex = 4;
            this.lblBlack.Click += new System.EventHandler(this.lblPalette_Click);
            // 
            // lblNavy
            // 
            this.lblNavy.BackColor = System.Drawing.Color.Navy;
            this.lblNavy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNavy.Location = new System.Drawing.Point(528, 47);
            this.lblNavy.Name = "lblNavy";
            this.lblNavy.Size = new System.Drawing.Size(23, 23);
            this.lblNavy.TabIndex = 5;
            this.lblNavy.Click += new System.EventHandler(this.lblPalette_Click);
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Black;
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Location = new System.Drawing.Point(499, 185);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(110, 45);
            this.lblColor.TabIndex = 5;
            // 
            // lblColorSelected
            // 
            this.lblColorSelected.AutoSize = true;
            this.lblColorSelected.Location = new System.Drawing.Point(497, 27);
            this.lblColorSelected.Name = "lblColorSelected";
            this.lblColorSelected.Size = new System.Drawing.Size(70, 13);
            this.lblColorSelected.TabIndex = 6;
            this.lblColorSelected.Text = "Colour: Black";
            // 
            // lblToolSelected
            // 
            this.lblToolSelected.AutoSize = true;
            this.lblToolSelected.Location = new System.Drawing.Point(497, 243);
            this.lblToolSelected.Name = "lblToolSelected";
            this.lblToolSelected.Size = new System.Drawing.Size(99, 13);
            this.lblToolSelected.TabIndex = 9;
            this.lblToolSelected.Text = "tool: None selected";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(496, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Brush size:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBrushSize
            // 
            this.cmbBrushSize.FormattingEnabled = true;
            this.cmbBrushSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.cmbBrushSize.Location = new System.Drawing.Point(573, 432);
            this.cmbBrushSize.Name = "cmbBrushSize";
            this.cmbBrushSize.Size = new System.Drawing.Size(36, 21);
            this.cmbBrushSize.TabIndex = 11;
            this.cmbBrushSize.Text = "6";
            // 
            // lblPenWidth
            // 
            this.lblPenWidth.Location = new System.Drawing.Point(496, 462);
            this.lblPenWidth.Name = "lblPenWidth";
            this.lblPenWidth.Size = new System.Drawing.Size(71, 13);
            this.lblPenWidth.TabIndex = 12;
            this.lblPenWidth.Text = "Pen Width:";
            this.lblPenWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPenWidth
            // 
            this.cmbPenWidth.FormattingEnabled = true;
            this.cmbPenWidth.Location = new System.Drawing.Point(573, 459);
            this.cmbPenWidth.Name = "cmbPenWidth";
            this.cmbPenWidth.Size = new System.Drawing.Size(36, 21);
            this.cmbPenWidth.TabIndex = 13;
            this.cmbPenWidth.Text = "2";
            // 
            // mnuEasyPaint
            // 
            this.mnuEasyPaint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuEasyPaint.Location = new System.Drawing.Point(0, 0);
            this.mnuEasyPaint.Name = "mnuEasyPaint";
            this.mnuEasyPaint.Size = new System.Drawing.Size(624, 24);
            this.mnuEasyPaint.TabIndex = 4;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(180, 22);
            this.mnuFileNew.Text = "New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.Gray;
            this.picCanvas.Location = new System.Drawing.Point(10, 50);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(480, 480);
            this.picCanvas.TabIndex = 3;
            this.picCanvas.TabStop = false;
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Image = global::EasyPaint.Properties.Resources.line;
            this.lblLine.Location = new System.Drawing.Point(536, 262);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(36, 36);
            this.lblLine.TabIndex = 8;
            // 
            // lblBrush
            // 
            this.lblBrush.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBrush.Image = global::EasyPaint.Properties.Resources.brush;
            this.lblBrush.Location = new System.Drawing.Point(499, 262);
            this.lblBrush.Name = "lblBrush";
            this.lblBrush.Size = new System.Drawing.Size(36, 36);
            this.lblBrush.TabIndex = 7;
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRed.Location = new System.Drawing.Point(557, 47);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(23, 23);
            this.lblRed.TabIndex = 14;
            this.lblRed.Click += new System.EventHandler(this.lblPalette_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 561);
            this.Controls.Add(this.mnuEasyPaint);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.pnlFrame);
            this.Controls.Add(this.pnlMain);
            this.Name = "form1";
            this.Text = "EasyPaint";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.mnuEasyPaint.ResumeLayout(false);
            this.mnuEasyPaint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.SaveFileDialog sfdSavePic;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFrame;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblFontDetails;
        private System.Windows.Forms.TextBox txtInsertText;
        private System.Windows.Forms.Label lblEditText;
        private System.Windows.Forms.Label lblColorSelected;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblBlack;
        private System.Windows.Forms.Button cmdFont;
        private System.Windows.Forms.Label lblNavy;
        private System.Windows.Forms.ComboBox cmbPenWidth;
        private System.Windows.Forms.Label lblPenWidth;
        private System.Windows.Forms.ComboBox cmbBrushSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToolSelected;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblBrush;
        private System.Windows.Forms.MenuStrip mnuEasyPaint;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblRed;
    }
}

