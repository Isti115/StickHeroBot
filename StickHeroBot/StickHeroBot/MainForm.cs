using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace StickHeroBot
{
    public partial class MainForm : Form
    {
        public Rectangle area = new Rectangle();
        Bitmap bmp;

        public MainForm()
        {
            InitializeComponent();
        }

        private void findWindowButton_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("MirrorOp Receiver");
            Process proc = processes[0];
            IntPtr ptr = proc.MainWindowHandle;
            GetWindowRect(ptr, ref area);
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(area.Width, area.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.CopyFromScreen(area.X, area.Y, 0, 0, area.Size);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rectangle rectangle);
    }
}
