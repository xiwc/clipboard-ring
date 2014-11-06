namespace ClipboardRing
{
    partial class UcClipboardRing
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvDataItem = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGetValue = new System.Windows.Forms.ToolStripButton();
            this.tsbPutValue = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtbItemValue = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 351);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(311, 351);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvDataItem);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip);
            this.splitContainer2.Panel2Collapsed = true;
            this.splitContainer2.Size = new System.Drawing.Size(311, 351);
            this.splitContainer2.SplitterDistance = 281;
            this.splitContainer2.TabIndex = 0;
            // 
            // lvDataItem
            // 
            this.lvDataItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDataItem.CheckBoxes = true;
            this.lvDataItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvDataItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDataItem.FullRowSelect = true;
            this.lvDataItem.Location = new System.Drawing.Point(0, 25);
            this.lvDataItem.Name = "lvDataItem";
            this.lvDataItem.ShowItemToolTips = true;
            this.lvDataItem.Size = new System.Drawing.Size(311, 326);
            this.lvDataItem.TabIndex = 1;
            this.lvDataItem.UseCompatibleStateImageBehavior = false;
            this.lvDataItem.View = System.Windows.Forms.View.Details;
            this.lvDataItem.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvDataItem_ColumnClick);
            this.lvDataItem.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvDataItem_ItemChecked);
            this.lvDataItem.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvDataItem_ItemSelectionChanged);
            this.lvDataItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvDataItem_KeyDown);
            this.lvDataItem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvDataItem_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 270;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "值";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "类别";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "创建时间";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "修改时间";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "最后访问时间";
            this.columnHeader6.Width = 130;
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbUpdate,
            this.tsbSave,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.tsbGetValue,
            this.tsbPutValue});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip.Size = new System.Drawing.Size(311, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.toolStrip_MouseDoubleClick);
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::ClipboardRing.Properties.Resources.add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "添加";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUpdate.Image = global::ClipboardRing.Properties.Resources.modify;
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(23, 22);
            this.tsbUpdate.Text = "更新";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::ClipboardRing.Properties.Resources.save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::ClipboardRing.Properties.Resources.delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbGetValue
            // 
            this.tsbGetValue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGetValue.Image = global::ClipboardRing.Properties.Resources.get;
            this.tsbGetValue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGetValue.Name = "tsbGetValue";
            this.tsbGetValue.Size = new System.Drawing.Size(23, 22);
            this.tsbGetValue.Text = "取值";
            this.tsbGetValue.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // tsbPutValue
            // 
            this.tsbPutValue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPutValue.Image = global::ClipboardRing.Properties.Resources.put;
            this.tsbPutValue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPutValue.Name = "tsbPutValue";
            this.tsbPutValue.Size = new System.Drawing.Size(23, 22);
            this.tsbPutValue.Text = "存值";
            this.tsbPutValue.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 419);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.panel3);
            this.splitContainer3.Size = new System.Drawing.Size(311, 419);
            this.splitContainer3.SplitterDistance = 351;
            this.splitContainer3.SplitterWidth = 2;
            this.splitContainer3.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rtbItemValue);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 66);
            this.panel3.TabIndex = 0;
            // 
            // rtbItemValue
            // 
            this.rtbItemValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbItemValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbItemValue.Location = new System.Drawing.Point(0, 0);
            this.rtbItemValue.Name = "rtbItemValue";
            this.rtbItemValue.ReadOnly = true;
            this.rtbItemValue.Size = new System.Drawing.Size(311, 66);
            this.rtbItemValue.TabIndex = 0;
            this.rtbItemValue.Text = "";
            this.rtbItemValue.WordWrap = false;
            // 
            // UcClipboardRing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "UcClipboardRing";
            this.Size = new System.Drawing.Size(311, 419);
            this.Load += new System.EventHandler(this.UcClipboardRing_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ListView lvDataItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox rtbItemValue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripButton tsbGetValue;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbPutValue;
    }
}
