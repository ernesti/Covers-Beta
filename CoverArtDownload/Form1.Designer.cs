namespace CoverArtDownload
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.stBar = new System.Windows.Forms.StatusStrip();
            this.errLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.statLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dlProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.loadPic = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.diropenBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pathTxt = new System.Windows.Forms.ToolStripLabel();
            this.goBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.startBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.albumLbl = new System.Windows.Forms.Label();
            this.artistLbl = new System.Windows.Forms.Label();
            this.gbPreviewAlbumArt = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tracksLst = new System.Windows.Forms.ListView();
            this.titleCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.artistCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.albumCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.скачатьОбложкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьВПроводникеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.воспроизвестиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.errTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.playBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pauseBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.stopBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.playTrackLbl = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.stBar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbPreviewAlbumArt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stBar
            // 
            this.stBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.errLbl,
            this.currentLbl,
            this.statLbl,
            this.toolStripStatusLabel1,
            this.loadPic,
            this.dlProgress});
            this.stBar.Location = new System.Drawing.Point(0, 614);
            this.stBar.Name = "stBar";
            this.stBar.Size = new System.Drawing.Size(769, 25);
            this.stBar.TabIndex = 0;
            this.stBar.Text = "statusStrip1";
            // 
            // errLbl
            // 
            this.errLbl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.errLbl.Image = global::CoverArtDownload.Properties.Resources.error;
            this.errLbl.Margin = new System.Windows.Forms.Padding(0, 3, 2, 2);
            this.errLbl.Name = "errLbl";
            this.errLbl.Size = new System.Drawing.Size(74, 20);
            this.errLbl.Text = "Ошибки";
            // 
            // currentLbl
            // 
            this.currentLbl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.currentLbl.Image = global::CoverArtDownload.Properties.Resources.music;
            this.currentLbl.Name = "currentLbl";
            this.currentLbl.Size = new System.Drawing.Size(172, 20);
            this.currentLbl.Text = "Треки не обрабатываются";
            // 
            // statLbl
            // 
            this.statLbl.Image = global::CoverArtDownload.Properties.Resources.world_go;
            this.statLbl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.statLbl.Name = "statLbl";
            this.statLbl.Size = new System.Drawing.Size(93, 20);
            this.statLbl.Text = "Загрузок нет";
            this.statLbl.Click += new System.EventHandler(this.statLbl_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(246, 20);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "   ";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // dlProgress
            // 
            this.dlProgress.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dlProgress.Name = "dlProgress";
            this.dlProgress.Size = new System.Drawing.Size(100, 19);
            // 
            // loadPic
            // 
            this.loadPic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loadPic.Image = global::CoverArtDownload.Properties.Resources.ajax_loader;
            this.loadPic.Name = "loadPic";
            this.loadPic.Size = new System.Drawing.Size(16, 20);
            this.loadPic.Text = "Progress";
            this.loadPic.ToolTipText = "Обработка…";
            this.loadPic.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Проверка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diropenBtn,
            this.toolStripSeparator2,
            this.pathTxt,
            this.startBtn,
            this.toolStripSeparator1,
            this.goBtn,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.toolStrip1.Size = new System.Drawing.Size(769, 43);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // diropenBtn
            // 
            this.diropenBtn.Image = global::CoverArtDownload.Properties.Resources.folder;
            this.diropenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.diropenBtn.Name = "diropenBtn";
            this.diropenBtn.Size = new System.Drawing.Size(93, 35);
            this.diropenBtn.Text = "Выбрать папку";
            this.diropenBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.diropenBtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // pathTxt
            // 
            this.pathTxt.Margin = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.Size = new System.Drawing.Size(0, 38);
            // 
            // goBtn
            // 
            this.goBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.goBtn.Image = global::CoverArtDownload.Properties.Resources.bullet_go;
            this.goBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(117, 35);
            this.goBtn.Text = "Сканировать папку";
            this.goBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // startBtn
            // 
            this.startBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.startBtn.Enabled = false;
            this.startBtn.Image = global::CoverArtDownload.Properties.Resources.wand;
            this.startBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(118, 35);
            this.startBtn.Text = "Загрузить обложки";
            this.startBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 38);
            // 
            // fbd
            // 
            this.fbd.ShowNewFolderButton = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbPreviewAlbumArt);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 536);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.titleLbl);
            this.groupBox1.Controls.Add(this.albumLbl);
            this.groupBox1.Controls.Add(this.artistLbl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 310);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(294, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CoverArtDownload.Properties.Resources.cd;
            this.pictureBox4.Location = new System.Drawing.Point(8, 63);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CoverArtDownload.Properties.Resources.user_gray;
            this.pictureBox3.Location = new System.Drawing.Point(8, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CoverArtDownload.Properties.Resources.music;
            this.pictureBox2.Location = new System.Drawing.Point(8, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLbl.Location = new System.Drawing.Point(26, 39);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(124, 21);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Название песни";
            // 
            // albumLbl
            // 
            this.albumLbl.AutoSize = true;
            this.albumLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albumLbl.Location = new System.Drawing.Point(27, 60);
            this.albumLbl.Name = "albumLbl";
            this.albumLbl.Size = new System.Drawing.Size(122, 17);
            this.albumLbl.TabIndex = 1;
            this.albumLbl.Text = "Название альбома";
            // 
            // artistLbl
            // 
            this.artistLbl.AutoSize = true;
            this.artistLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artistLbl.Location = new System.Drawing.Point(27, 22);
            this.artistLbl.Name = "artistLbl";
            this.artistLbl.Size = new System.Drawing.Size(86, 17);
            this.artistLbl.TabIndex = 0;
            this.artistLbl.Text = "Исполнитель";
            // 
            // gbPreviewAlbumArt
            // 
            this.gbPreviewAlbumArt.Controls.Add(this.pictureBox1);
            this.gbPreviewAlbumArt.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPreviewAlbumArt.Location = new System.Drawing.Point(0, 0);
            this.gbPreviewAlbumArt.Margin = new System.Windows.Forms.Padding(6);
            this.gbPreviewAlbumArt.Name = "gbPreviewAlbumArt";
            this.gbPreviewAlbumArt.Padding = new System.Windows.Forms.Padding(10);
            this.gbPreviewAlbumArt.Size = new System.Drawing.Size(294, 310);
            this.gbPreviewAlbumArt.TabIndex = 3;
            this.gbPreviewAlbumArt.TabStop = false;
            this.gbPreviewAlbumArt.Text = "Обложка альбома";
            this.gbPreviewAlbumArt.Enter += new System.EventHandler(this.gbPreviewAlbumArt_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = global::CoverArtDownload.Properties.Resources.ajax_loader;
            this.pictureBox1.Image = global::CoverArtDownload.Properties.Resources.albumart1;
            this.pictureBox1.InitialImage = global::CoverArtDownload.Properties.Resources.albumart;
            this.pictureBox1.Location = new System.Drawing.Point(10, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 43);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(769, 546);
            this.splitContainer1.SplitterDistance = 461;
            this.splitContainer1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tracksLst);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(451, 536);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Найденные треки";
            // 
            // tracksLst
            // 
            this.tracksLst.AllowDrop = true;
            this.tracksLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleCh,
            this.artistCh,
            this.albumCh});
            this.tracksLst.ContextMenuStrip = this.contextMenuStrip1;
            this.tracksLst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tracksLst.LargeImageList = this.imgList1;
            this.tracksLst.Location = new System.Drawing.Point(10, 23);
            this.tracksLst.MultiSelect = false;
            this.tracksLst.Name = "tracksLst";
            this.tracksLst.Size = new System.Drawing.Size(431, 503);
            this.tracksLst.SmallImageList = this.imgList1;
            this.tracksLst.TabIndex = 0;
            this.tracksLst.TileSize = new System.Drawing.Size(259, 30);
            this.tracksLst.UseCompatibleStateImageBehavior = false;
            this.tracksLst.View = System.Windows.Forms.View.List;
            this.tracksLst.SelectedIndexChanged += new System.EventHandler(this.albumsLst_SelectedIndexChanged);
            this.tracksLst.DragDrop += new System.Windows.Forms.DragEventHandler(this.tracksLst_DragDrop);
            this.tracksLst.DragEnter += new System.Windows.Forms.DragEventHandler(this.tracksLst_DragEnter);
            // 
            // titleCh
            // 
            this.titleCh.Text = "Название";
            this.titleCh.Width = 453;
            // 
            // artistCh
            // 
            this.artistCh.Text = "Исполнитель";
            // 
            // albumCh
            // 
            this.albumCh.Text = "Альбом";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скачатьОбложкуToolStripMenuItem,
            this.открытьВПроводникеToolStripMenuItem,
            this.воспроизвестиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // скачатьОбложкуToolStripMenuItem
            // 
            this.скачатьОбложкуToolStripMenuItem.Image = global::CoverArtDownload.Properties.Resources.world_go;
            this.скачатьОбложкуToolStripMenuItem.Name = "скачатьОбложкуToolStripMenuItem";
            this.скачатьОбложкуToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.скачатьОбложкуToolStripMenuItem.Text = "Скачать обложку";
            this.скачатьОбложкуToolStripMenuItem.Click += new System.EventHandler(this.скачатьОбложкуToolStripMenuItem_Click);
            // 
            // открытьВПроводникеToolStripMenuItem
            // 
            this.открытьВПроводникеToolStripMenuItem.Image = global::CoverArtDownload.Properties.Resources.folder;
            this.открытьВПроводникеToolStripMenuItem.Name = "открытьВПроводникеToolStripMenuItem";
            this.открытьВПроводникеToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.открытьВПроводникеToolStripMenuItem.Text = "Открыть в проводнике…";
            this.открытьВПроводникеToolStripMenuItem.Click += new System.EventHandler(this.открытьВПроводникеToolStripMenuItem_Click);
            // 
            // воспроизвестиToolStripMenuItem
            // 
            this.воспроизвестиToolStripMenuItem.Image = global::CoverArtDownload.Properties.Resources.control_play;
            this.воспроизвестиToolStripMenuItem.Name = "воспроизвестиToolStripMenuItem";
            this.воспроизвестиToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.воспроизвестиToolStripMenuItem.Text = "Воспроизвести";
            this.воспроизвестиToolStripMenuItem.Click += new System.EventHandler(this.воспроизвестиToolStripMenuItem_Click);
            // 
            // imgList1
            // 
            this.imgList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList1.ImageStream")));
            this.imgList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList1.Images.SetKeyName(0, "stop.png");
            this.imgList1.Images.SetKeyName(1, "accept.png");
            this.imgList1.Images.SetKeyName(2, "");
            this.imgList1.Images.SetKeyName(3, "");
            this.imgList1.Images.SetKeyName(4, "");
            this.imgList1.Images.SetKeyName(5, "icon_eq.gif");
            this.imgList1.Images.SetKeyName(6, "tick.png");
            this.imgList1.Images.SetKeyName(7, "cross.png");
            this.imgList1.Images.SetKeyName(8, "ajax-loader.gif");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Идет обработка, подождите…";
            // 
            // errTimer
            // 
            this.errTimer.Interval = 3000;
            this.errTimer.Tick += new System.EventHandler(this.errTimer_Tick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playBtn,
            this.toolStripSeparator3,
            this.pauseBtn,
            this.toolStripSeparator4,
            this.stopBtn,
            this.toolStripSeparator5,
            this.playTrackLbl,
            this.toolStripSeparator8});
            this.toolStrip2.Location = new System.Drawing.Point(0, 589);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(769, 25);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // playBtn
            // 
            this.playBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playBtn.Image = global::CoverArtDownload.Properties.Resources.control_play;
            this.playBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(23, 22);
            this.playBtn.Text = "Воспроизведение";
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // pauseBtn
            // 
            this.pauseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseBtn.Image = global::CoverArtDownload.Properties.Resources.control_pause;
            this.pauseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(23, 22);
            this.pauseBtn.Text = "Пауза";
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // stopBtn
            // 
            this.stopBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopBtn.Image = global::CoverArtDownload.Properties.Resources.control_stop;
            this.stopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(23, 22);
            this.stopBtn.Text = "Стоп";
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // playTrackLbl
            // 
            this.playTrackLbl.Name = "playTrackLbl";
            this.playTrackLbl.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 639);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.stBar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Covers Beta";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.stBar.ResumeLayout(false);
            this.stBar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbPreviewAlbumArt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stBar;
        private System.Windows.Forms.ToolStripStatusLabel errLbl;
        private System.Windows.Forms.ToolStripStatusLabel statLbl;
        private System.Windows.Forms.ToolStripProgressBar dlProgress;
        private System.Windows.Forms.ToolStripStatusLabel currentLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton diropenBtn;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.ToolStripButton goBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel pathTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView tracksLst;
        private System.Windows.Forms.ColumnHeader titleCh;
        private System.Windows.Forms.ImageList imgList1;
        private System.Windows.Forms.GroupBox gbPreviewAlbumArt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label albumLbl;
        private System.Windows.Forms.Label artistLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem скачатьОбложкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьВПроводникеToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel loadPic;
        private System.Windows.Forms.Timer errTimer;
        private System.Windows.Forms.ColumnHeader artistCh;
        private System.Windows.Forms.ColumnHeader albumCh;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton playBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton pauseBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton stopBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel playTrackLbl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem воспроизвестиToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton startBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;


    }
}

