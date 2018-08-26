using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void StartButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.flag, 4, 2, 16, 16);
        }

        private void StartMenu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Blue, 2, 2, 18, StartMenu.Height - 4);
        }
    }
}
