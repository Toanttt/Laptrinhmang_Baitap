namespace file_explorer
{
    public partial class Form1 : Form
    {
        string path = @"E:\";

        public Form1()
        {
            InitializeComponent();
            if (Directory.Exists(path))
            {
                TreeNode node = new TreeNode(path);
                treeView1.Nodes.Add(node);
                LoadExplorer(node);
            }
        }

        void LoadExplorer(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            try
            {
                var folderList = new DirectoryInfo(root.Text).GetDirectories();

                if (folderList.Length == 0)
                    return;

                foreach (DirectoryInfo item in folderList)
                {
                    if (Directory.Exists(item.FullName))
                    {
                        TreeNode node = new TreeNode(item.FullName);
                        root.Nodes.Add(node);
                        LoadExplorer(node);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}