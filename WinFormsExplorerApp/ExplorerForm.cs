namespace WinFormsExplorerApp
{
    public partial class ExplorerForm : Form
    {
        public ExplorerForm()
        {
            InitializeComponent();
        }

        private void ExplorerForm_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem viewToolStripMenuItem = new ToolStripMenuItem("View");

            ToolStripMenuItem viewLargeIconToolStripMenuItem = new ToolStripMenuItem("Large Icon");
            viewLargeIconToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.B;
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
    }
}
