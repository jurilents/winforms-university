namespace JustMyFinderLab8
{
    internal enum NodeType
    {
        None,
        File,
        Directory
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillDriveNodes();
        }

        private NodeType selectedNodeType;
        private TreeNode selectedNode;

        private string SelectedNodeBaseDir => Path.GetDirectoryName(selectedNode.FullPath)!;


        private void renameButton_Click(object sender, EventArgs e)
        {
            if (selectedNode == null)
                return;

            try
            {
                if (selectedNodeType == NodeType.Directory)
                {
                    Directory.Move(selectedNode.FullPath, Path.Combine(SelectedNodeBaseDir, textBox.Text));
                }
                else if (selectedNodeType == NodeType.File)
                {
                    File.Move(selectedNode.FullPath, Path.Combine(SelectedNodeBaseDir, textBox.Text));
                }

                RefreshTreeView();
            }
            catch (Exception ex) { }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedNode == null)
                return;

            try
            {
                if (selectedNodeType == NodeType.Directory)
                {
                    Directory.Delete(selectedNode.FullPath);
                }
                else if (selectedNodeType == NodeType.File)
                {
                    File.Delete(selectedNode.FullPath);
                }

                RefreshTreeView();
            }
            catch (Exception ex) { }
        }

        private void createDirButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedNodeType == NodeType.Directory)
                {
                    Directory.CreateDirectory(Path.Combine(selectedNode.FullPath, textBox.Text));
                }
                else if (selectedNodeType == NodeType.File)
                {
                    Directory.CreateDirectory(Path.Combine(SelectedNodeBaseDir, textBox.Text));
                }

                RefreshTreeView();
            }
            catch (Exception ex) { }
        }

        private void createTextFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedNodeType == NodeType.Directory)
                {
                    File.CreateText(Path.Combine(selectedNode.FullPath, textBox.Text));
                }
                else if (selectedNodeType == NodeType.File)
                {
                    File.CreateText(Path.Combine(SelectedNodeBaseDir, textBox.Text));
                }

                RefreshTreeView();
            }
            catch (Exception ex) { }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            RefreshTreeView();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            RefreshTreeView();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            FillDriveNodes();
        }


        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            RefreshTreeView(e);
        }

        private void treeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node == null)
                return;

            selectedNode = e.Node;
            textBox.Text = e.Node.Text;
            if (textBox.Text.Contains('.'))
            {
                typeOutput.Text = "file";
                selectedNodeType = NodeType.File;
            }
            else
            {
                typeOutput.Text = "directory";
                selectedNodeType = NodeType.Directory;
            }

            RefreshTreeView(e);
        }

        private void FillDriveNodes()
        {
            try
            {
                foreach (var drive in DriveInfo.GetDrives())
                {
                    var driveNode = new TreeNode(drive.Name);
                    FillTreeNode(driveNode, drive.Name);
                    treeView.Nodes.Add(driveNode);
                }
            }
            catch (Exception ex) { }
        }

        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (var dir in dirs)
                {
                    var dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception ex) { }
        }

        private void RefreshTreeView(TreeViewCancelEventArgs e)
        {
            var filter = searchTextBox.Text;
            e.Node.Nodes.Clear();
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    var dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            var di = new DirectoryInfo(dirs[i]);
                            if (string.IsNullOrWhiteSpace(filter) || di.Name.Contains(filter))
                            {
                                var dirNode = new TreeNode(di.Name);
                                FillTreeNode(dirNode, dirs[i]);
                                e.Node.Nodes.Add(dirNode);
                            }
                        }
                    }

                    var files = Directory.GetFiles(e.Node.FullPath);
                    if (files.Length != 0)
                    {
                        for (int i = 0; i < files.Length; i++)
                        {
                            var fi = new FileInfo(files[i]);
                            if (string.IsNullOrWhiteSpace(filter) || fi.Name.Contains(filter))
                            {
                                var fileNode = new TreeNode(fi.Name);
                                FillTreeNode(fileNode, files[i]);
                                e.Node.Nodes.Add(fileNode);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void RefreshTreeView()
        {
            treeView.Nodes.Clear();
            var rootNode = new TreeNode(pathTextBox.Text);
            FillTreeNode(rootNode, pathTextBox.Text);
            treeView.Nodes.Add(rootNode);
        }
    }
}