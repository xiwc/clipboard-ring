using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ClipboardRing
{
    public partial class FormCanvas : Form
    {
        public FormCanvas()
        {
            InitializeComponent();
        }
        private string drawTxt;
        private Font penFont;
        private Brush penBrush;

        public bool ShowWarning = false;

        private void FormCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(this.BackColor);
            SizeF size = g.MeasureString(drawTxt, penFont);
            float locX = (Width - size.Width) / 2;
            float locY = (Height - size.Height) / 2;
            g.DrawString(drawTxt, penFont, penBrush, locX, locY);
            
        }

        public void DrawString(string txt)
        {
            if (ShowWarning)
            {
                this.TopMost = true;
                this.drawTxt = txt;
                this.timer1.Start();
                this.Visible = true;
                this.Refresh();
            }
        }

        private void FormCanvas_Load(object sender, EventArgs e)
        {
            penFont = new Font(Font.FontFamily, 50F);
            penBrush = new SolidBrush(Color.Red);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.drawTxt = string.Empty;
            this.Refresh();
            this.Visible = false;
            this.timer1.Stop();
        }
    }
}
