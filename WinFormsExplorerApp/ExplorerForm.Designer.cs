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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorerForm));
            menuStripMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButtonNewFile = new ToolStripButton();
            toolStripButtonDeleteFile = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonViewLargeIcon = new ToolStripButton();
            toolStripButtonSmallIcon = new ToolStripButton();
            toolStripButtonList = new ToolStripButton();
            toolStripButtonDetail = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelInfo = new ToolStripStatusLabel();
            splitContainerExplorer = new SplitContainer();
            treeViewDirictories = new TreeView();
            listViewDirectories = new ListView();
            menuStripMain.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
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
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonNewFile, toolStripButtonDeleteFile, toolStripSeparator1, toolStripButtonViewLargeIcon, toolStripButtonSmallIcon, toolStripButtonList, toolStripButtonDetail });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(812, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
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
            // 
            // toolStripButtonSmallIcon
            // 
            toolStripButtonSmallIcon.Image = (Image)resources.GetObject("toolStripButtonSmallIcon.Image");
            toolStripButtonSmallIcon.ImageTransparentColor = Color.Magenta;
            toolStripButtonSmallIcon.Name = "toolStripButtonSmallIcon";
            toolStripButtonSmallIcon.Size = new Size(82, 22);
            toolStripButtonSmallIcon.Text = "Small Icon";
            // 
            // toolStripButtonList
            // 
            toolStripButtonList.Image = (Image)resources.GetObject("toolStripButtonList.Image");
            toolStripButtonList.ImageTransparentColor = Color.Magenta;
            toolStripButtonList.Name = "toolStripButtonList";
            toolStripButtonList.Size = new Size(45, 22);
            toolStripButtonList.Text = "List";
            // 
            // toolStripButtonDetail
            // 
            toolStripButtonDetail.Image = (Image)resources.GetObject("toolStripButtonDetail.Image");
            toolStripButtonDetail.ImageTransparentColor = Color.Magenta;
            toolStripButtonDetail.Name = "toolStripButtonDetail";
            toolStripButtonDetail.Size = new Size(57, 22);
            toolStripButtonDetail.Text = "Detail";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInfo });
            statusStrip1.Location = new Point(0, 518);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(812, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelInfo
            // 
            toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            toolStripStatusLabelInfo.Size = new Size(118, 17);
            toolStripStatusLabelInfo.Text = "toolStripStatusLabel1";
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
            treeViewDirictories.Location = new Point(0, 0);
            treeViewDirictories.Name = "treeViewDirictories";
            treeViewDirictories.Size = new Size(268, 467);
            treeViewDirictories.TabIndex = 0;
            // 
            // listViewDirectories
            // 
            listViewDirectories.Dock = DockStyle.Fill;
            listViewDirectories.Location = new Point(0, 0);
            listViewDirectories.Name = "listViewDirectories";
            listViewDirectories.Size = new Size(536, 467);
            listViewDirectories.TabIndex = 0;
            listViewDirectories.UseCompatibleStateImageBehavior = false;
            // 
            // ExplorerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 540);
            Controls.Add(splitContainerExplorer);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStripMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripMain;
            Name = "ExplorerForm";
            Text = "Explorer";
            Load += ExplorerForm_Load;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonNewFile;
        private ToolStripButton toolStripButtonDeleteFile;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonViewLargeIcon;
        private ToolStripButton toolStripButtonSmallIcon;
        private ToolStripButton toolStripButtonList;
        private ToolStripButton toolStripButtonDetail;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelInfo;
        private SplitContainer splitContainerExplorer;
        private TreeView treeViewDirictories;
        private ListView listViewDirectories;
    }
}
