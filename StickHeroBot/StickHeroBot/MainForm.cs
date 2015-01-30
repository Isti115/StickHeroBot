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

        int d;

        static Timer t = new Timer();
        static Timer rt = new Timer();

        //object sndr;
        //EventArgs ue;

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

            bmp.Save(@"C:\Users\isti\Desktop\test.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            int b = 10;

            while (bmp.GetPixel(b, 470).GetBrightness() == 0)
            {
                b++;
            }

            int x = b;

            while (bmp.GetPixel(x, 470).R < 230 || bmp.GetPixel(x, 470).G > 50 || bmp.GetPixel(x, 470).B > 50)
            {
                x++;
            }

            d = x - b;
            doItButton.Text = d.ToString();
        }

        private void doItButton_Click(object sender, EventArgs e)
        {
            t.Interval = 3 * d; //(int)(2.7 * (float)d);
            t.Tick += new EventHandler(timer_done);
            mouseDown(area.X + 100, area.Y + 100);
            t.Start();
        }

        private static void timer_done(Object myObject, EventArgs myEventArgs)
        {
            mouseUp();
            t.Stop();
        }

        // copy-pasted window search
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rectangle rectangle);

        // copy-pasted mouse click
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, uint dwExtraInf);
        public static void mouseDown(int x, int y)
        {
            Cursor.Position = new Point(x, y);
            mouse_event(0x0002, 0, 0, 0, 0); //make left button down
        }

        public static void mouseUp()
        {
            mouse_event(0x0004, 0, 0, 0, 0); //make left button up
        }

        private void allInOneButton_Click(object sender, EventArgs e)
        {
            rt.Interval = 3000;
            rt.Tick += new EventHandler(rt_done);

            captureButton_Click(sender, e);
            analyzeButton_Click(sender, e);
            doItButton_Click(sender, e);

            //rt.Tick += new EventHandler(captureButton_Click);
            //rt.Tick += new EventHandler(analyzeButton_Click);
            //rt.Tick += new EventHandler(doItButton_Click);

            //sndr = sender;
            //ue = e;

            rt.Start();
        }

        private static void rt_done(Object myObject, EventArgs myEventArgs)
        {
            mouseUp();

            //captureButton_Click(EventArgs.Empty);
            //analyzeButton_Click(EventArgs.Empty);
            //doItButton_Click(EventArgs.Empty);

            
        }

    }
}
