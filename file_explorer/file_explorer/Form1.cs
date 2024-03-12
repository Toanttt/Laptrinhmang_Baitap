using System.Text;

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
                LoadExplorer(node, false);
            }
            treeView1.BeforeExpand += new TreeViewCancelEventHandler(treeView1_BeforeExpand);
        }

        void LoadExplorer(TreeNode root, bool loadSubDirs)
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
                        if (loadSubDirs)
                        {
                            LoadExplorer(node, false);
                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            LoadExplorer(node, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Get the selected node
            TreeNode node = e.Node;

            // Get the full path of the node
            string path = node.FullPath;

            // Generate a temporary HTML file
            string htmlFile = Path.Combine(Path.GetTempPath(), "temp.html");

            // Create a StringBuilder for the HTML content
            StringBuilder html = new StringBuilder();

            // Start the HTML document
            html.AppendLine("<html><body>");

            // Add a header
            html.AppendLine("<h1>" + path + "</h1>");

            // List the subdirectories
            foreach (string dir in Directory.GetDirectories(path))
            {
                html.AppendLine("<p><a href='file:///" + dir.Replace("\\", "/") + "'>" + Path.GetFileName(dir) + "</a></p>");
            }

            // List the files
            foreach (string file in Directory.GetFiles(path))
            {
                html.AppendLine("<p><a href='file:///" + file.Replace("\\", "/") + "'>" + Path.GetFileName(file) + "</a></p>");
            }

            // End the HTML document
            html.AppendLine("</body></html>");

            // Write the HTML file
            File.WriteAllText(htmlFile, html.ToString());

            // Navigate the WebView2 to the temporary HTML file
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.Navigate("file:///" + htmlFile.Replace("\\", "/"));
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }
}