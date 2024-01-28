namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuBtnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnOpen2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBtnControl = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBtnMerg = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtMergRatio = new System.Windows.Forms.ToolStripTextBox();
            this.BtnSelectColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnMergImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBtnFast = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnGray1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnGray2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnGray3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnDarker = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtDarker = new System.Windows.Forms.ToolStripTextBox();
            this.BtnLighter = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtLighter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnRed = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBtnSlow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnToGray = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnToGray2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnToDark = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnToLight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnToRed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnOpen = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblImageInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.Undo = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblUndo = new System.Windows.Forms.ToolStripStatusLabel();
            this.Redo = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblRedo = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowBox = new System.Windows.Forms.Panel();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblColorInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ShowBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuBtnFile,
            this.MnuBtnControl,
            this.MnuBtnMerg,
            this.MnuBtnFast,
            this.MnuBtnSlow,
            this.shapeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(661, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuBtnFile
            // 
            this.MnuBtnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnOpen2,
            this.BtnSave,
            this.BtnClose});
            this.MnuBtnFile.Name = "MnuBtnFile";
            this.MnuBtnFile.Size = new System.Drawing.Size(44, 24);
            this.MnuBtnFile.Text = "&File";
            this.MnuBtnFile.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // BtnOpen2
            // 
            this.BtnOpen2.Name = "BtnOpen2";
            this.BtnOpen2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.BtnOpen2.Size = new System.Drawing.Size(173, 26);
            this.BtnOpen2.Text = "&Open";
            this.BtnOpen2.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.BtnSave.Size = new System.Drawing.Size(173, 26);
            this.BtnSave.Text = "&Save";
            this.BtnSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.BtnClose.Size = new System.Drawing.Size(173, 26);
            this.BtnClose.Text = "&Close";
            this.BtnClose.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // MnuBtnControl
            // 
            this.MnuBtnControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnUndo,
            this.BtnRedo,
            this.rotateToolStripMenuItem});
            this.MnuBtnControl.Name = "MnuBtnControl";
            this.MnuBtnControl.Size = new System.Drawing.Size(70, 24);
            this.MnuBtnControl.Text = "&Control";
            // 
            // BtnUndo
            // 
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.BtnUndo.Size = new System.Drawing.Size(216, 26);
            this.BtnUndo.Text = "&Undo";
            this.BtnUndo.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // BtnRedo
            // 
            this.BtnRedo.Name = "BtnRedo";
            this.BtnRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.BtnRedo.Size = new System.Drawing.Size(216, 26);
            this.BtnRedo.Text = "&Redo";
            this.BtnRedo.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // MnuBtnMerg
            // 
            this.MnuBtnMerg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtMergRatio,
            this.BtnSelectColor,
            this.toolStripSeparator4,
            this.BtnMergImage});
            this.MnuBtnMerg.Name = "MnuBtnMerg";
            this.MnuBtnMerg.Size = new System.Drawing.Size(56, 24);
            this.MnuBtnMerg.Text = "&Merg";
            // 
            // TxtMergRatio
            // 
            this.TxtMergRatio.Name = "TxtMergRatio";
            this.TxtMergRatio.Size = new System.Drawing.Size(100, 27);
            this.TxtMergRatio.Text = "50";
            this.TxtMergRatio.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // BtnSelectColor
            // 
            this.BtnSelectColor.Name = "BtnSelectColor";
            this.BtnSelectColor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.BtnSelectColor.Size = new System.Drawing.Size(251, 26);
            this.BtnSelectColor.Text = "Select &Color";
            this.BtnSelectColor.Click += new System.EventHandler(this.colorToolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(248, 6);
            // 
            // BtnMergImage
            // 
            this.BtnMergImage.Name = "BtnMergImage";
            this.BtnMergImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.BtnMergImage.Size = new System.Drawing.Size(251, 26);
            this.BtnMergImage.Text = "&Merg With Image";
            this.BtnMergImage.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // MnuBtnFast
            // 
            this.MnuBtnFast.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnGray1,
            this.BtnGray2,
            this.BtnGray3,
            this.toolStripSeparator1,
            this.BtnDarker,
            this.BtnLighter,
            this.toolStripSeparator2,
            this.BtnRed,
            this.BtnBlue,
            this.BtnGreen});
            this.MnuBtnFast.Name = "MnuBtnFast";
            this.MnuBtnFast.Size = new System.Drawing.Size(46, 24);
            this.MnuBtnFast.Text = "&Fast";
            // 
            // BtnGray1
            // 
            this.BtnGray1.Name = "BtnGray1";
            this.BtnGray1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.BtnGray1.Size = new System.Drawing.Size(216, 26);
            this.BtnGray1.Text = "&Gray 1";
            this.BtnGray1.Click += new System.EventHandler(this.gray1ToolStripMenuItem_Click);
            // 
            // BtnGray2
            // 
            this.BtnGray2.Name = "BtnGray2";
            this.BtnGray2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.BtnGray2.Size = new System.Drawing.Size(216, 26);
            this.BtnGray2.Text = "&Gray 2";
            this.BtnGray2.Click += new System.EventHandler(this.gray2ToolStripMenuItem_Click);
            // 
            // BtnGray3
            // 
            this.BtnGray3.Name = "BtnGray3";
            this.BtnGray3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.BtnGray3.Size = new System.Drawing.Size(216, 26);
            this.BtnGray3.Text = "&Gray 3";
            this.BtnGray3.Click += new System.EventHandler(this.BtnGray3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // BtnDarker
            // 
            this.BtnDarker.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtDarker});
            this.BtnDarker.Name = "BtnDarker";
            this.BtnDarker.Size = new System.Drawing.Size(216, 26);
            this.BtnDarker.Text = "&Darker";
            this.BtnDarker.Click += new System.EventHandler(this.darkerToolStripMenuItem_Click_1);
            // 
            // TxtDarker
            // 
            this.TxtDarker.Name = "TxtDarker";
            this.TxtDarker.Size = new System.Drawing.Size(100, 27);
            this.TxtDarker.Text = "50";
            this.TxtDarker.Click += new System.EventHandler(this.toolStripTextBox1_Click_1);
            // 
            // BtnLighter
            // 
            this.BtnLighter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtLighter});
            this.BtnLighter.Name = "BtnLighter";
            this.BtnLighter.Size = new System.Drawing.Size(216, 26);
            this.BtnLighter.Text = "&Lighter";
            this.BtnLighter.Click += new System.EventHandler(this.LighterBtn_Click);
            // 
            // TxtLighter
            // 
            this.TxtLighter.Name = "TxtLighter";
            this.TxtLighter.Size = new System.Drawing.Size(100, 27);
            this.TxtLighter.Text = "50";
            this.TxtLighter.Click += new System.EventHandler(this.toolStripTextBox1_Click_2);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // BtnRed
            // 
            this.BtnRed.Name = "BtnRed";
            this.BtnRed.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.BtnRed.Size = new System.Drawing.Size(216, 26);
            this.BtnRed.Text = "&Red";
            this.BtnRed.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // BtnBlue
            // 
            this.BtnBlue.Name = "BtnBlue";
            this.BtnBlue.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.BtnBlue.Size = new System.Drawing.Size(216, 26);
            this.BtnBlue.Text = "&Blue";
            this.BtnBlue.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // BtnGreen
            // 
            this.BtnGreen.Name = "BtnGreen";
            this.BtnGreen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.BtnGreen.Size = new System.Drawing.Size(216, 26);
            this.BtnGreen.Text = "&Green";
            this.BtnGreen.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // MnuBtnSlow
            // 
            this.MnuBtnSlow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.BtnToGray,
            this.BtnToGray2,
            this.toolStripMenuItem2,
            this.BtnToDark,
            this.BtnToLight,
            this.toolStripSeparator3,
            this.BtnToRed});
            this.MnuBtnSlow.Name = "MnuBtnSlow";
            this.MnuBtnSlow.Size = new System.Drawing.Size(53, 24);
            this.MnuBtnSlow.Text = "&Slow";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // BtnToGray
            // 
            this.BtnToGray.Name = "BtnToGray";
            this.BtnToGray.Size = new System.Drawing.Size(216, 26);
            this.BtnToGray.Text = "To Gray";
            this.BtnToGray.Click += new System.EventHandler(this.toGrayToolStripMenuItem_Click);
            // 
            // BtnToGray2
            // 
            this.BtnToGray2.Name = "BtnToGray2";
            this.BtnToGray2.Size = new System.Drawing.Size(216, 26);
            this.BtnToGray2.Text = "&To Gray+";
            this.BtnToGray2.Click += new System.EventHandler(this.toGrqyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 6);
            // 
            // BtnToDark
            // 
            this.BtnToDark.Name = "BtnToDark";
            this.BtnToDark.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.BtnToDark.Size = new System.Drawing.Size(216, 26);
            this.BtnToDark.Text = "&Darker";
            this.BtnToDark.Click += new System.EventHandler(this.glowToolStripMenuItem_Click);
            // 
            // BtnToLight
            // 
            this.BtnToLight.Name = "BtnToLight";
            this.BtnToLight.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.BtnToLight.Size = new System.Drawing.Size(216, 26);
            this.BtnToLight.Text = "&Lighter";
            this.BtnToLight.Click += new System.EventHandler(this.lighterToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(213, 6);
            // 
            // BtnToRed
            // 
            this.BtnToRed.Name = "BtnToRed";
            this.BtnToRed.Size = new System.Drawing.Size(216, 26);
            this.BtnToRed.Text = "&Red";
            this.BtnToRed.Click += new System.EventHandler(this.colorFastToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnOpen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(661, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnOpen
            // 
            this.BtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpen.Image")));
            this.BtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(73, 28);
            this.BtnOpen.Text = "Open";
            this.BtnOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblImageInfo,
            this.Undo,
            this.LblUndo,
            this.Redo,
            this.LblRedo,
            this.lblColorInfo,
            this.lblColor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(661, 25);
            this.statusStrip1.TabIndex = 2;
            // 
            // lblImageInfo
            // 
            this.lblImageInfo.Name = "lblImageInfo";
            this.lblImageInfo.Size = new System.Drawing.Size(35, 20);
            this.lblImageInfo.Text = "info";
            // 
            // Undo
            // 
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(48, 20);
            this.Undo.Text = "Undo:";
            // 
            // LblUndo
            // 
            this.LblUndo.Name = "LblUndo";
            this.LblUndo.Size = new System.Drawing.Size(17, 20);
            this.LblUndo.Text = "0";
            this.LblUndo.Click += new System.EventHandler(this.lblColorInfo_Click);
            // 
            // Redo
            // 
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(47, 20);
            this.Redo.Text = "Redo:";
            // 
            // LblRedo
            // 
            this.LblRedo.Name = "LblRedo";
            this.LblRedo.Size = new System.Drawing.Size(17, 20);
            this.LblRedo.Text = "0";
            this.LblRedo.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // ShowBox
            // 
            this.ShowBox.AutoScroll = true;
            this.ShowBox.Controls.Add(this.PicBox);
            this.ShowBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowBox.Location = new System.Drawing.Point(0, 57);
            this.ShowBox.Margin = new System.Windows.Forms.Padding(4);
            this.ShowBox.Name = "ShowBox";
            this.ShowBox.Size = new System.Drawing.Size(661, 437);
            this.ShowBox.TabIndex = 3;
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(0, 0);
            this.PicBox.Margin = new System.Windows.Forms.Padding(4);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(156, 100);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            this.PicBox.Click += new System.EventHandler(this.PicBox_Click);
            this.PicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicBox_MouseDown);
            this.PicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.PicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicBox_MouseUp);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rotateToolStripMenuItem.Text = "Rotate";
            this.rotateToolStripMenuItem.Click += new System.EventHandler(this.rotateToolStripMenuItem_Click);
            // 
            // lblColorInfo
            // 
            this.lblColorInfo.Name = "lblColorInfo";
            this.lblColorInfo.Size = new System.Drawing.Size(46, 20);
            this.lblColorInfo.Text = "color:";
            this.lblColorInfo.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // lblColor
            // 
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(0, 20);
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.cycleToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.shapeToolStripMenuItem.Text = "Shape";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // cycleToolStripMenuItem
            // 
            this.cycleToolStripMenuItem.Name = "cycleToolStripMenuItem";
            this.cycleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cycleToolStripMenuItem.Text = "cycle";
            this.cycleToolStripMenuItem.Click += new System.EventHandler(this.cycleToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 519);
            this.Controls.Add(this.ShowBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Image Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ShowBox.ResumeLayout(false);
            this.ShowBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuBtnFile;
        private System.Windows.Forms.ToolStripMenuItem BtnOpen2;
        private System.Windows.Forms.ToolStripMenuItem BtnClose;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnOpen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblImageInfo;
        private System.Windows.Forms.ToolStripStatusLabel LblUndo;
        private System.Windows.Forms.ToolStripStatusLabel LblRedo;
        private System.Windows.Forms.Panel ShowBox;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.ToolStripMenuItem MnuBtnSlow;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem BtnToGray;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MnuBtnControl;
        private System.Windows.Forms.ToolStripMenuItem BtnUndo;
        private System.Windows.Forms.ToolStripMenuItem BtnToGray2;
        private System.Windows.Forms.ToolStripMenuItem BtnToDark;
        private System.Windows.Forms.ToolStripMenuItem BtnToLight;
        private System.Windows.Forms.ToolStripMenuItem BtnRedo;
        private System.Windows.Forms.ToolStripMenuItem BtnToRed;
        private System.Windows.Forms.ToolStripMenuItem MnuBtnMerg;
        private System.Windows.Forms.ToolStripTextBox TxtMergRatio;
        private System.Windows.Forms.ToolStripMenuItem BtnSelectColor;
        private System.Windows.Forms.ToolStripMenuItem BtnMergImage;
        private System.Windows.Forms.ToolStripMenuItem MnuBtnFast;
        private System.Windows.Forms.ToolStripMenuItem BtnGray1;
        private System.Windows.Forms.ToolStripMenuItem BtnGray2;
        private System.Windows.Forms.ToolStripMenuItem BtnGray3;
        private System.Windows.Forms.ToolStripMenuItem BtnDarker;
        private System.Windows.Forms.ToolStripTextBox TxtDarker;
        private System.Windows.Forms.ToolStripMenuItem BtnLighter;
        private System.Windows.Forms.ToolStripTextBox TxtLighter;
        private System.Windows.Forms.ToolStripMenuItem BtnRed;
        private System.Windows.Forms.ToolStripMenuItem BtnSave;
        private System.Windows.Forms.ToolStripMenuItem BtnBlue;
        private System.Windows.Forms.ToolStripMenuItem BtnGreen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel Undo;
        private System.Windows.Forms.ToolStripStatusLabel Redo;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblColorInfo;
        private System.Windows.Forms.ToolStripStatusLabel lblColor;
        private System.Windows.Forms.ToolStripMenuItem shapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cycleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
    }
}

