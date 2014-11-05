using System.Windows.Forms;
using ClipboardRing;
using System.Drawing;
using System;

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
        private int maxHeight = 368;
        private int minHeight = 51;
        private void btnExpand_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Height == maxHeight)
                {
                    this.Height = minHeight;
                    this.btnExpand.BackgroundImage = Properties.Resources.down2;
                    this.toolTip.SetToolTip(btnExpand, "展开");
                }
                else
                {
                    this.Height = maxHeight;
                    this.btnExpand.BackgroundImage = Properties.Resources.up;
                    this.toolTip.SetToolTip(btnExpand, "折叠");
                }
            }
            catch (Exception)
            {

            }
            
        }
        
        private void FormM_Load(object sender, EventArgs e)
        {
            this.ucClipboardRing1.LoadDataItems();
            this.ucSearch1.TextChanged += new UcSearch.SearchDelegate(ucSearch1_TextChanged);
        }

        void ucSearch1_TextChanged(object sender, string value)
        {
            showSearchResult(value);
        }

        private void showSearchResult(string value)
        {
            if (this.Height == minHeight)
            {
                this.btnExpand.PerformClick();
            }
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

        private void FormM_Deactivate(object sender, EventArgs e)
        {
            if (this.Height == maxHeight && !ucClipboardRing1.FormLockFlag)
            {
                this.btnExpand.PerformClick();
            }
            this.Opacity = 0.6;
        }

        private void FormM_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1.0;
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
        private int miniWidth = 100;
        private int miniHeight = 26;
        private int normalWidth = 264;
        private void btnLeftRight_Click(object sender, EventArgs e)
        {
            if ("mini".Equals(btnLeftRight.Tag))
            {
                btnLeftRight.Tag = "normal";
                btnLeftRight.BackgroundImage = Properties.Resources.left;
                this.Width = miniWidth;
                this.Height = miniHeight;
                this.pbLogo.Visible = false;
                this.lblTitle.Visible = false;
                this.ucSearch1.Visible = false;
                toolTip.SetToolTip(btnLeftRight, "正常模式");
            }
            else
            {
                btnLeftRight.Tag = "mini";
                btnLeftRight.BackgroundImage = Properties.Resources.right;
                this.Width = normalWidth;
                this.Height = minHeight;
                this.pbLogo.Visible = true;
                this.lblTitle.Visible = true;
                this.ucSearch1.Visible = true;
                toolTip.SetToolTip(btnLeftRight, "迷你模式");
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
