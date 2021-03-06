﻿namespace FormBase
{
    partial class FormM
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormM));
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnLeftRight = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnPut = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.热键开启ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭提示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucClipboardRing1 = new ClipboardRing.UcClipboardRing();
            this.ucSearch1 = new FormBase.UcSearch();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelMain.Controls.Add(this.btnLeftRight);
            this.panelMain.Controls.Add(this.btnExpand);
            this.panelMain.Controls.Add(this.ucClipboardRing1);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.btnGet);
            this.panelMain.Controls.Add(this.btnPut);
            this.panelMain.Controls.Add(this.btnClose);
            this.panelMain.Controls.Add(this.ucSearch1);
            this.panelMain.Controls.Add(this.pbLogo);
            this.panelMain.Location = new System.Drawing.Point(1, 1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(262, 366);
            this.panelMain.TabIndex = 0;
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseMove);
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseDown);
            // 
            // btnLeftRight
            // 
            this.btnLeftRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeftRight.BackgroundImage = global::FormBase.Properties.Resources.right;
            this.btnLeftRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeftRight.FlatAppearance.BorderSize = 0;
            this.btnLeftRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftRight.Location = new System.Drawing.Point(216, 1);
            this.btnLeftRight.Margin = new System.Windows.Forms.Padding(0);
            this.btnLeftRight.Name = "btnLeftRight";
            this.btnLeftRight.Size = new System.Drawing.Size(18, 18);
            this.btnLeftRight.TabIndex = 11;
            this.btnLeftRight.Tag = "mini";
            this.toolTip.SetToolTip(this.btnLeftRight, "迷你模式");
            this.btnLeftRight.UseVisualStyleBackColor = true;
            this.btnLeftRight.Click += new System.EventHandler(this.btnLeftRight_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.BackgroundImage = global::FormBase.Properties.Resources.up;
            this.btnExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExpand.FlatAppearance.BorderSize = 0;
            this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpand.Location = new System.Drawing.Point(196, 1);
            this.btnExpand.Margin = new System.Windows.Forms.Padding(0);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(1, 1);
            this.btnExpand.TabIndex = 10;
            this.btnExpand.TabStop = false;
            this.toolTip.SetToolTip(this.btnExpand, "折叠");
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(23, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 16);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "剪贴环";
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseMove);
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseDown);
            // 
            // btnGet
            // 
            this.btnGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGet.BackgroundImage = global::FormBase.Properties.Resources.get;
            this.btnGet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGet.FlatAppearance.BorderSize = 0;
            this.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGet.Location = new System.Drawing.Point(167, 1);
            this.btnGet.Margin = new System.Windows.Forms.Padding(0);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(18, 18);
            this.btnGet.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnGet, "取值(热键F4)");
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnPut
            // 
            this.btnPut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPut.BackgroundImage = global::FormBase.Properties.Resources.put;
            this.btnPut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPut.FlatAppearance.BorderSize = 0;
            this.btnPut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPut.Location = new System.Drawing.Point(190, 1);
            this.btnPut.Margin = new System.Windows.Forms.Padding(0);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(18, 18);
            this.btnPut.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnPut, "存值(热键F3)");
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::FormBase.Properties.Resources.close1;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(239, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnClose, "关闭");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::FormBase.Properties.Resources.clipboard;
            this.pbLogo.Location = new System.Drawing.Point(1, 1);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(20, 20);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "剪贴环\r\n作者:卍 (◕⊥◕) 卐\r\nE-mail:547538651@qq.com";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.热键开启ToolStripMenuItem,
            this.关闭提示ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // 热键开启ToolStripMenuItem
            // 
            this.热键开启ToolStripMenuItem.Checked = true;
            this.热键开启ToolStripMenuItem.CheckOnClick = true;
            this.热键开启ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.热键开启ToolStripMenuItem.Name = "热键开启ToolStripMenuItem";
            this.热键开启ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.热键开启ToolStripMenuItem.Text = "热键开启";
            this.热键开启ToolStripMenuItem.Click += new System.EventHandler(this.热键开启ToolStripMenuItem_Click);
            // 
            // 关闭提示ToolStripMenuItem
            // 
            this.关闭提示ToolStripMenuItem.Checked = true;
            this.关闭提示ToolStripMenuItem.CheckOnClick = true;
            this.关闭提示ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.关闭提示ToolStripMenuItem.Name = "关闭提示ToolStripMenuItem";
            this.关闭提示ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关闭提示ToolStripMenuItem.Text = "关闭提示";
            this.关闭提示ToolStripMenuItem.Click += new System.EventHandler(this.关闭提示ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // ucClipboardRing1
            // 
            this.ucClipboardRing1.Location = new System.Drawing.Point(1, 50);
            this.ucClipboardRing1.Name = "ucClipboardRing1";
            this.ucClipboardRing1.Size = new System.Drawing.Size(260, 315);
            this.ucClipboardRing1.TabIndex = 9;
            // 
            // ucSearch1
            // 
            this.ucSearch1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSearch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucSearch1.Location = new System.Drawing.Point(2, 22);
            this.ucSearch1.Margin = new System.Windows.Forms.Padding(0);
            this.ucSearch1.Name = "ucSearch1";
            this.ucSearch1.Size = new System.Drawing.Size(258, 25);
            this.ucSearch1.TabIndex = 1;
            // 
            // FormM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(264, 368);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "剪贴环";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.FormM_Deactivate);
            this.Load += new System.EventHandler(this.FormM_Load);
            this.SizeChanged += new System.EventHandler(this.FormM_SizeChanged);
            this.Activated += new System.EventHandler(this.FormM_Activated);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pbLogo;
        private UcSearch ucSearch1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblTitle;
        private ClipboardRing.UcClipboardRing ucClipboardRing1;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 热键开启ToolStripMenuItem;
        private System.Windows.Forms.Button btnLeftRight;
        private System.Windows.Forms.ToolStripMenuItem 关闭提示ToolStripMenuItem;
    }
}

