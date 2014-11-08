using System.Windows.Forms;
using ClipboardRing;
using System.Drawing;
using System;
using DesktopHelper;
using QQPrintScreen;

namespace FormBase
{
    public partial class FormM : Form
    {
        public FormM()
        {
            InitializeComponent();

            init();
        }

        private void init()
        {
            this.Region = CommonUtils.Round(Width, Height);
            this.panelMain.Region = CommonUtils.Round(panelMain.Width, panelMain.Height);
        }
        Point mouseDownLoc;
        private void panelMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLoc = e.Location;
                Console.WriteLine("mouse down...");
            }
        }

        private void panelMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Top += (e.Y - mouseDownLoc.Y);
                this.Left += (e.X - mouseDownLoc.X);
            }
        }

        private void CloseApplication()
        {
            this.ucClipboardRing1.SaveDataItems();
            this.ucClipboardRing1.UnregisterHotKey();
            this.Close();
        }
        
        private void FormM_Load(object sender, EventArgs e)
        {
            this.ucClipboardRing1.LoadDataItems();
            this.ucSearch1.TextChanged += new UcSearch.SearchDelegate(ucSearch1_TextChanged);
            this.ucSearch1.EnterKeyDown += new UcSearch.SearchDelegate(ucSearch1_EnterKeyDown);
        }

        void ucSearch1_EnterKeyDown(object sender, string value)
        {
            this.ucClipboardRing1.GetSearchResult(value);
        }

        void ucSearch1_TextChanged(object sender, string value)
        {
            showSearchResult(value);
        }

        private void showSearchResult(string value)
        {
            this.ucClipboardRing1.ShowSearchResult(value);
        }

        private void btnPut_Click(object sender, EventArgs e)
        {
            this.ucClipboardRing1.PutItem();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            this.ucClipboardRing1.GetItem();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Visible = !Visible;
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void 热键开启ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (热键开启ToolStripMenuItem.Checked)
            {
                ucClipboardRing1.RegisterHotKey();
            }
            else
            {
                ucClipboardRing1.UnregisterHotKey();
            }
        }

        private void FormM_SizeChanged(object sender, EventArgs e)
        {
            this.Region = CommonUtils.Round(Width, Height);
            this.panelMain.Region = CommonUtils.Round(panelMain.Width, panelMain.Height);
        }

        private void 关闭提示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ucClipboardRing1.formCanvas.ShowWarning = !关闭提示ToolStripMenuItem.Checked;
        }

    }
}
