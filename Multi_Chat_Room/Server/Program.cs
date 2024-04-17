using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< Updated upstream:Multi_Chat_Room/Server/Program.cs
            Application.Run(new Server());
=======
            Application.Run(new MultiplayerWindow()); // Run the MultiplayerForm instead of the default form
>>>>>>> Stashed changes:Tetris-wf/Program.cs
        }
    }
}
