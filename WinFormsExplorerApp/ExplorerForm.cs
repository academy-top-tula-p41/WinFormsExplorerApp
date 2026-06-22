namespace WinFormsExplorerApp
{
    public partial class ExplorerForm : Form
    {
        public ExplorerForm()
        {
            InitializeComponent();

            FillDrives();
        }

        private void ExplorerForm_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem viewToolStripMenuItem = new ToolStripMenuItem("View");

            ToolStripMenuItem viewLargeIconToolStripMenuItem = new ToolStripMenuItem("Large Icon");
            viewLargeIconToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.B;
            viewLargeIconToolStripMenuItem.Click += toolStripButtonViewLargeIcon_Click;
            viewToolStripMenuItem.DropDownItems.Add(viewLargeIconToolStripMenuItem);

            ToolStripMenuItem viewSmallIconToolStripMenuItem = new ToolStripMenuItem("Small Icon");
            viewSmallIconToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.S;
            viewToolStripMenuItem.DropDownItems.Add(viewSmallIconToolStripMenuItem);

            ToolStripMenuItem viewListToolStripMenuItem = new ToolStripMenuItem("List");
            viewListToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.L;
            viewToolStripMenuItem.DropDownItems.Add(viewListToolStripMenuItem);

            ToolStripMenuItem viewDetailToolStripMenuItem = new ToolStripMenuItem("Detail");
            viewDetailToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D;
            viewToolStripMenuItem.DropDownItems.Add(viewDetailToolStripMenuItem);


            menuStripMain.Items.Add(viewToolStripMenuItem);

        }

        private void FillDrives()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode driveNode = new TreeNode(drive.Name);
                    FillDirectoryNode(driveNode, drive.Name);
                    treeViewDirictories.Nodes.Add(driveNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillDirectoryNode(TreeNode parentNode, string path, bool depth = true)
        {
            try
            {
                string[] directories = Directory.GetDirectories(path);
                foreach (string directory in directories)
                {
                    TreeNode nodeDirectory = new TreeNode();
                    nodeDirectory.Text = directory.Substring(directory.LastIndexOf(@"\") + 1);
                    nodeDirectory.ImageIndex = (int)FileExtensions.Folder;
                    parentNode.Nodes.Add(nodeDirectory);

                    if (depth)
                        FillDirectoryNode(nodeDirectory, directory, false);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void FillDirectoryList(string path)
        {
            listViewDirectories.Items.Clear();

            string[] directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                ListViewItem directoryItem = new ListViewItem();
                directoryItem.Text = new DirectoryInfo(directory).Name;
                directoryItem.Tag = directory;
                directoryItem.ImageIndex = (int)FileExtensions.Folder;
                directoryItem.SubItems.Add("<Folder>");
                listViewDirectories.Items.Add(directoryItem);

            }

            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                ListViewItem fileItem = new();
                fileItem.Text = fileInfo.Name;

                string extension = fileInfo.Extension.Substring(1);
                extension = extension.Substring(0, 1).ToUpper()
                            + extension.Substring(1).ToLower();
                if (Enum.IsDefined(typeof(FileExtensions), extension))
                {
                    FileExtensions fileExtensions
                        = (FileExtensions)Enum.Parse(typeof(FileExtensions), extension);

                    fileItem.ImageIndex = (int)fileExtensions;
                }
                else
                    fileItem.ImageIndex = (int)FileExtensions.Any;
                fileItem.SubItems.Add((fileInfo.Length / 1024).ToString());

                listViewDirectories.Items.Add(fileItem);
            }
        }

        private void treeViewDirictories_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node?.Nodes.Clear();

            try
            {
                if (Directory.Exists(e.Node?.FullPath))
                {
                    FillDirectoryNode(e.Node, e.Node.FullPath);
                    FillDirectoryList(e.Node.FullPath);
                    toolStripStatusLabelInfo.Text = e.Node.FullPath;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void listViewDirectories_DoubleClick(object sender, EventArgs e)
        {
            string? directory = listViewDirectories.SelectedItems[0]?.Tag?.ToString();

            if (directory is not null)
                FillDirectoryList(directory);
        }

        private void toolStripButtonViewLargeIcon_Click(object sender, EventArgs e)
        {
            listViewDirectories.View = View.LargeIcon;
        }

        private void toolStripButtonSmallIcon_Click(object sender, EventArgs e)
        {
            listViewDirectories.View = View.SmallIcon;
        }

        private void toolStripButtonList_Click(object sender, EventArgs e)
        {
            listViewDirectories.View = View.List;
        }

        private void toolStripButtonDetail_Click(object sender, EventArgs e)
        {
            listViewDirectories.View = View.Details;
        }

        private void listViewDirectories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewDirectories.SelectedItems.Count > 0)
                toolStripStatusLabelInfo.Text = listViewDirectories.SelectedItems[0].Text;
        }
    }
}
