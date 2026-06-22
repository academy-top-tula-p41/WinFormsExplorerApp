namespace WinFormsExplorerApp
{
    partial class ExplorerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorerForm));
            menuStripMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            toolStripButtonNewFile = new ToolStripButton();
            toolStripButtonDeleteFile = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonViewLargeIcon = new ToolStripButton();
            toolStripButtonSmallIcon = new ToolStripButton();
            toolStripButtonList = new ToolStripButton();
            toolStripButtonDetail = new ToolStripButton();
            statusStrip = new StatusStrip();
            toolStripStatusLabelInfo = new ToolStripStatusLabel();
            splitContainerExplorer = new SplitContainer();
            treeViewDirictories = new TreeView();
            imageListIcons16 = new ImageList(components);
            listViewDirectories = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderSize = new ColumnHeader();
            imageListIcons64 = new ImageList(components);
            imageListIcons32 = new ImageList(components);
            menuStripMain.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerExplorer).BeginInit();
            splitContainerExplorer.Panel1.SuspendLayout();
            splitContainerExplorer.Panel2.SuspendLayout();
            splitContainerExplorer.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(812, 24);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, deleteToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(149, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            deleteToolStripMenuItem.Size = new Size(149, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(146, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(149, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButtonNewFile, toolStripButtonDeleteFile, toolStripSeparator1, toolStripButtonViewLargeIcon, toolStripButtonSmallIcon, toolStripButtonList, toolStripButtonDetail });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(812, 25);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonNewFile
            // 
            toolStripButtonNewFile.Image = (Image)resources.GetObject("toolStripButtonNewFile.Image");
            toolStripButtonNewFile.ImageTransparentColor = Color.Magenta;
            toolStripButtonNewFile.Name = "toolStripButtonNewFile";
            toolStripButtonNewFile.Size = new Size(72, 22);
            toolStripButtonNewFile.Text = "New File";
            // 
            // toolStripButtonDeleteFile
            // 
            toolStripButtonDeleteFile.Image = (Image)resources.GetObject("toolStripButtonDeleteFile.Image");
            toolStripButtonDeleteFile.ImageTransparentColor = Color.Magenta;
            toolStripButtonDeleteFile.Name = "toolStripButtonDeleteFile";
            toolStripButtonDeleteFile.Size = new Size(81, 22);
            toolStripButtonDeleteFile.Text = "Delete File";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripButtonViewLargeIcon
            // 
            toolStripButtonViewLargeIcon.Image = (Image)resources.GetObject("toolStripButtonViewLargeIcon.Image");
            toolStripButtonViewLargeIcon.ImageTransparentColor = Color.Magenta;
            toolStripButtonViewLargeIcon.Name = "toolStripButtonViewLargeIcon";
            toolStripButtonViewLargeIcon.Size = new Size(82, 22);
            toolStripButtonViewLargeIcon.Text = "Large Icon";
            toolStripButtonViewLargeIcon.Click += toolStripButtonViewLargeIcon_Click;
            // 
            // toolStripButtonSmallIcon
            // 
            toolStripButtonSmallIcon.Image = (Image)resources.GetObject("toolStripButtonSmallIcon.Image");
            toolStripButtonSmallIcon.ImageTransparentColor = Color.Magenta;
            toolStripButtonSmallIcon.Name = "toolStripButtonSmallIcon";
            toolStripButtonSmallIcon.Size = new Size(82, 22);
            toolStripButtonSmallIcon.Text = "Small Icon";
            toolStripButtonSmallIcon.Click += toolStripButtonSmallIcon_Click;
            // 
            // toolStripButtonList
            // 
            toolStripButtonList.Image = (Image)resources.GetObject("toolStripButtonList.Image");
            toolStripButtonList.ImageTransparentColor = Color.Magenta;
            toolStripButtonList.Name = "toolStripButtonList";
            toolStripButtonList.Size = new Size(45, 22);
            toolStripButtonList.Text = "List";
            toolStripButtonList.Click += toolStripButtonList_Click;
            // 
            // toolStripButtonDetail
            // 
            toolStripButtonDetail.Image = (Image)resources.GetObject("toolStripButtonDetail.Image");
            toolStripButtonDetail.ImageTransparentColor = Color.Magenta;
            toolStripButtonDetail.Name = "toolStripButtonDetail";
            toolStripButtonDetail.Size = new Size(57, 22);
            toolStripButtonDetail.Text = "Detail";
            toolStripButtonDetail.Click += toolStripButtonDetail_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInfo });
            statusStrip.Location = new Point(0, 518);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(812, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelInfo
            // 
            toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            toolStripStatusLabelInfo.Size = new Size(0, 17);
            // 
            // splitContainerExplorer
            // 
            splitContainerExplorer.BorderStyle = BorderStyle.FixedSingle;
            splitContainerExplorer.Dock = DockStyle.Fill;
            splitContainerExplorer.Location = new Point(0, 49);
            splitContainerExplorer.Name = "splitContainerExplorer";
            // 
            // splitContainerExplorer.Panel1
            // 
            splitContainerExplorer.Panel1.Controls.Add(treeViewDirictories);
            // 
            // splitContainerExplorer.Panel2
            // 
            splitContainerExplorer.Panel2.Controls.Add(listViewDirectories);
            splitContainerExplorer.Size = new Size(812, 469);
            splitContainerExplorer.SplitterDistance = 270;
            splitContainerExplorer.TabIndex = 3;
            // 
            // treeViewDirictories
            // 
            treeViewDirictories.Dock = DockStyle.Fill;
            treeViewDirictories.ImageIndex = 0;
            treeViewDirictories.ImageList = imageListIcons16;
            treeViewDirictories.Location = new Point(0, 0);
            treeViewDirictories.Name = "treeViewDirictories";
            treeViewDirictories.SelectedImageIndex = 0;
            treeViewDirictories.Size = new Size(268, 467);
            treeViewDirictories.TabIndex = 0;
            treeViewDirictories.BeforeExpand += treeViewDirictories_BeforeExpand;
            treeViewDirictories.BeforeSelect += treeViewDirictories_BeforeExpand;
            // 
            // imageListIcons16
            // 
            imageListIcons16.ColorDepth = ColorDepth.Depth32Bit;
            imageListIcons16.ImageStream = (ImageListStreamer)resources.GetObject("imageListIcons16.ImageStream");
            imageListIcons16.TransparentColor = Color.Transparent;
            imageListIcons16.Images.SetKeyName(0, "FOLDER.png");
            imageListIcons16.Images.SetKeyName(1, "ANY.png");
            imageListIcons16.Images.SetKeyName(2, "CPP.png");
            imageListIcons16.Images.SetKeyName(3, "CS.png");
            imageListIcons16.Images.SetKeyName(4, "CSS.png");
            imageListIcons16.Images.SetKeyName(5, "EXCEL.png");
            imageListIcons16.Images.SetKeyName(6, "HTML.png");
            imageListIcons16.Images.SetKeyName(7, "JPG.png");
            imageListIcons16.Images.SetKeyName(8, "JS.png");
            imageListIcons16.Images.SetKeyName(9, "PDF.png");
            imageListIcons16.Images.SetKeyName(10, "PNG.png");
            imageListIcons16.Images.SetKeyName(11, "POWER POINT.png");
            imageListIcons16.Images.SetKeyName(12, "TXT.png");
            imageListIcons16.Images.SetKeyName(13, "WORD.png");
            // 
            // listViewDirectories
            // 
            listViewDirectories.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderSize });
            listViewDirectories.Dock = DockStyle.Fill;
            listViewDirectories.LargeImageList = imageListIcons64;
            listViewDirectories.Location = new Point(0, 0);
            listViewDirectories.Name = "listViewDirectories";
            listViewDirectories.Size = new Size(536, 467);
            listViewDirectories.SmallImageList = imageListIcons16;
            listViewDirectories.StateImageList = imageListIcons16;
            listViewDirectories.TabIndex = 0;
            listViewDirectories.UseCompatibleStateImageBehavior = false;
            listViewDirectories.View = View.List;
            listViewDirectories.SelectedIndexChanged += listViewDirectories_SelectedIndexChanged;
            listViewDirectories.DoubleClick += listViewDirectories_DoubleClick;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 200;
            // 
            // columnHeaderSize
            // 
            columnHeaderSize.Text = "Size";
            columnHeaderSize.Width = 160;
            // 
            // imageListIcons64
            // 
            imageListIcons64.ColorDepth = ColorDepth.Depth32Bit;
            imageListIcons64.ImageStream = (ImageListStreamer)resources.GetObject("imageListIcons64.ImageStream");
            imageListIcons64.TransparentColor = Color.Transparent;
            imageListIcons64.Images.SetKeyName(0, "FOLDER.png");
            imageListIcons64.Images.SetKeyName(1, "ANY.png");
            imageListIcons64.Images.SetKeyName(2, "CPP.png");
            imageListIcons64.Images.SetKeyName(3, "CS.png");
            imageListIcons64.Images.SetKeyName(4, "CSS.png");
            imageListIcons64.Images.SetKeyName(5, "EXCEL.png");
            imageListIcons64.Images.SetKeyName(6, "HTML.png");
            imageListIcons64.Images.SetKeyName(7, "JPG.png");
            imageListIcons64.Images.SetKeyName(8, "JS.png");
            imageListIcons64.Images.SetKeyName(9, "PDF.png");
            imageListIcons64.Images.SetKeyName(10, "PNG.png");
            imageListIcons64.Images.SetKeyName(11, "POWER POINT.png");
            imageListIcons64.Images.SetKeyName(12, "TXT.png");
            imageListIcons64.Images.SetKeyName(13, "WORD.png");
            // 
            // imageListIcons32
            // 
            imageListIcons32.ColorDepth = ColorDepth.Depth32Bit;
            imageListIcons32.ImageStream = (ImageListStreamer)resources.GetObject("imageListIcons32.ImageStream");
            imageListIcons32.TransparentColor = Color.Transparent;
            imageListIcons32.Images.SetKeyName(0, "FOLDER.png");
            imageListIcons32.Images.SetKeyName(1, "ANY.png");
            imageListIcons32.Images.SetKeyName(2, "CPP.png");
            imageListIcons32.Images.SetKeyName(3, "CS.png");
            imageListIcons32.Images.SetKeyName(4, "CSS.png");
            imageListIcons32.Images.SetKeyName(5, "EXCEL.png");
            imageListIcons32.Images.SetKeyName(6, "HTML.png");
            imageListIcons32.Images.SetKeyName(7, "JPG.png");
            imageListIcons32.Images.SetKeyName(8, "JS.png");
            imageListIcons32.Images.SetKeyName(9, "PDF.png");
            imageListIcons32.Images.SetKeyName(10, "PNG.png");
            imageListIcons32.Images.SetKeyName(11, "POWER POINT.png");
            imageListIcons32.Images.SetKeyName(12, "TXT.png");
            imageListIcons32.Images.SetKeyName(13, "WORD.png");
            // 
            // ExplorerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 540);
            Controls.Add(splitContainerExplorer);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStripMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripMain;
            Name = "ExplorerForm";
            Text = "Explorer";
            Load += ExplorerForm_Load;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            splitContainerExplorer.Panel1.ResumeLayout(false);
            splitContainerExplorer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerExplorer).EndInit();
            splitContainerExplorer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStrip toolStrip;
        private ToolStripButton toolStripButtonNewFile;
        private ToolStripButton toolStripButtonDeleteFile;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonViewLargeIcon;
        private ToolStripButton toolStripButtonSmallIcon;
        private ToolStripButton toolStripButtonList;
        private ToolStripButton toolStripButtonDetail;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabelInfo;
        private SplitContainer splitContainerExplorer;
        private TreeView treeViewDirictories;
        private ListView listViewDirectories;
        private ImageList imageListIcons16;
        private ImageList imageListIcons64;
        private ImageList imageListIcons32;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderSize;
    }
}
