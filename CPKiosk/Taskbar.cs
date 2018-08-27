using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPKiosk
{
    public partial class TaskBar : Form
    {
        public static Color commonBackColor = Color.FromArgb(192, 192, 192);

        public TaskBar()
        {
            InitializeComponent();
        }

        public Screen primaryScreen = Screen.PrimaryScreen;

        private void TaskBar_Load(object sender, EventArgs e)
        {
            Height = 28;
            
            Top = primaryScreen.Bounds.Height - Height;
            Left = 0;
            Width = primaryScreen.Bounds.Width;

            BackColor = StartButton.BackColor = commonBackColor;
            Border1.BackColor = Color.FromArgb(222, 223, 218);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartMenu.Show();
            StartMenu.BackColor = commonBackColor;
            StartMenu.Top = primaryScreen.Bounds.Height - Height - StartMenu.Height;
            StartMenu.Width = 400;
        }

        private void StartButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.flag, 4, 2, 16, 16);
        }

        private void StartMenu_Paint(object sender, PaintEventArgs e)
        {
            /*
            e.Graphics.FillRectangle(Brushes.DarkBlue, 2, 2, 24, StartMenu.Height - 5);
            e.Graphics.DrawImage(Properties.Resources.grad1, 2, 2, 24, StartMenu.Height - 5);
            e.Graphics.RotateTransform(-90);
            Font font = new Font(SystemFonts.DefaultFont.FontFamily, 12, FontStyle.Bold);
            e.Graphics.DrawString("Cedar Point", font, Brushes.White, new Point(StartMenu.Height * -1 + 8, 5));
            */
        }

        public static void createButton(string Title)
        {




        }

        private async void StartMenu_Opened(object sender, EventArgs e)
        {
            int maxWidth = 0;
            int height = 0;
            int marginLeft = 26;
            foreach(ToolStripItem item in StartMenu.Items)
            {
                if(item is ToolStripMenuItem)
                {
                    Padding margin = item.Margin;
                    margin.Left = marginLeft;
                    item.Margin = margin;
                    if (item.Width > maxWidth)
                    {
                        maxWidth = item.Width;
                    }
                }
                height +=
                item.Height +
                item.Margin.Top +
                item.Margin.Bottom +
                item.Padding.Top +
                item.Padding.Bottom;
            }

            StartMenu.Height = height;
            Size sSize = StartMenu.Size;
            sSize.Width = maxWidth + marginLeft;
            StartMenu.Size = sSize;
            StartMenu.MaximumSize = sSize;
            StartMenu.MinimumSize = sSize;

            await Task.Delay(TimeSpan.FromMilliseconds(10));
            Graphics g = Graphics.FromHwnd(StartMenu.Handle);
            g.FillRectangle(Brushes.DarkBlue, 2, 2, 24, StartMenu.Height - 5);
            g.DrawImage(Properties.Resources.grad1, 2, 2, 24, StartMenu.Height - 5);
            g.RotateTransform(-90);
            Font font = new Font(SystemFonts.DefaultFont.FontFamily, 12, FontStyle.Bold);
            g.DrawString("Cedar Point I.T.", font, Brushes.White, new Point(StartMenu.Height * -1 + 8, 5));
        }

        private void StartMenu_LayoutCompleted(object sender, EventArgs e)
        {
            
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToShortTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
