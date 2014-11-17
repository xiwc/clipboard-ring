﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DeskTool;
using DesktopHelper;
using QQPrintScreen;

namespace ClipboardRing
{
    public partial class UcClipboardRing : UserControl
    {
        public UcClipboardRing()
        {
            InitializeComponent();

            init();
        }

        private void init()
        {
            RegisterHotKey();
        }

        //热键注册
        private int idF3;//存值
        private int idF4;//取值
        private int idCtrlQ;//激活窗口
        private int idEsc;//激活窗口

        /// <summary>
        /// 热键注册
        /// </summary>
        public void RegisterHotKey()
        {
            //热键注册
            idF3 = "F3".GetHashCode();
            idF4 = "F4".GetHashCode();
            idCtrlQ = "CtrlQ".GetHashCode();
            idEsc = "Esc".GetHashCode();

            Win32Api.RegisterHotKey(this.Handle, idF3, (int)KeyModifiers.None, (int)Keys.F3);
            Win32Api.RegisterHotKey(this.Handle, idF4, (int)KeyModifiers.None, (int)Keys.F4);
            Win32Api.RegisterHotKey(this.Handle, idCtrlQ, (int)KeyModifiers.Control, (int)Keys.Q);
            //Win32Api.RegisterHotKey(this.Handle, idEsc, (int)KeyModifiers.None, (int)Keys.Escape);
        }
        /// <summary>
        /// 卸载热键
        /// </summary>
        public void UnregisterHotKey()
        {
            Win32Api.UnregisterHotKey(this.Handle, this.idF3);
            Win32Api.UnregisterHotKey(this.Handle, this.idF4);
            Win32Api.UnregisterHotKey(this.Handle, this.idCtrlQ);
            //Win32Api.UnregisterHotKey(this.Handle, this.idEsc);
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            const int VK_CONTROL = 0x11;
            const int VK_C = 67;
            const int WM_KEYDOWN = 0x100;
            const int WM_KEYUP = 0x101;
            const int KEYEVENTF_KEYUP = 0x2;

            switch (m.Msg)
            {
                case WM_HOTKEY:
                    if (idF3 == (int)m.WParam)
                    {
                        this.PutItem();
                    }
                    else if (idF4 == (int)m.WParam)
                    {
                        this.GetItem();
                    }
                    else if (idCtrlQ == (int)m.WParam)
                    {
                        Form form = this.ParentForm;
                        if (form != null)
                        {
                            form.Visible = !form.Visible;

                            if (form.Visible)
                            {
                                form.Activate();
                                form.Focus();
                            }
                        }
                    }
                    else if (idEsc == (int)m.WParam)
                    {
                        //MessageBox.Show(Convert.ToString(Win32Api.MapVirtualKey(VK_CONTROL, 0), 16));

                        POINT p = new POINT();
                        Win32Api.GetCursorPos(ref p);
                        IntPtr h = Win32Api.WindowFromPoint(p);

                         //keybd_event VK_SHIFT, &H2A, 0, 0  ' 模拟按下SHIFT键，&H2A是VK_SHIFT的扫描码
                         //PostMessage hWndMsg, WM_KEYDOWN, VK_A, &H001E0001 ' 模拟按下 A 键，SHIFT+A产生一个大写A字符
                         //PostMessage hWndMsg, WM_KEYUP, VK_A, &HC01E0001   ' 模拟抬起 A 键
                         //keybd_event VK_SHIFT, &H2A, KEYEVENTF_KEYUP, 0    ' 模拟抬起 SHIFT 键

                        Win32Api.keybd_event(VK_CONTROL, 0x1D, 0, 0);// ctrl 按下
                        Win32Api.PostMessage(h, WM_KEYDOWN, VK_C, 0x002E0001); // c 按下
                        Win32Api.PostMessage(h, WM_KEYUP, VK_C, 0xC02E0001);// c 抬起
                        Win32Api.keybd_event(VK_CONTROL, 0x1D, KEYEVENTF_KEYUP, 0);// ctrl 抬起

                        //Thread.Sleep(1000);
                        formCanvas.DrawString(Clipboard.GetText(TextDataFormat.Text));
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            FormDataItemEdit form = new FormDataItemEdit();
            form.Text = ConstVal.AddItemTitle;
            form.LoadCategory(this.categoryItems);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                DataItem item = form.DataItem;
                AddDataItem(item);
            }

            form.Dispose();
            form = null;
        }

        private void AddDataItem(DataItem item)
        {
            string[] items = { item.Alias, item.Value, item.Category, item.CreateTime, item.ModifyTime, item.LastAccessTime };

            ListViewItem lvItem = new ListViewItem(items);
            lvItem.Tag = item.Value;

            lvDataItem.Items.Insert(0,lvItem);
        }

        private void AddDataItemToBottom(DataItem item)
        {
            string[] items = { item.Alias, item.Value, item.Category, item.CreateTime, item.ModifyTime, item.LastAccessTime };

            ListViewItem lvItem = new ListViewItem(items);
            lvItem.Tag = item.Value;

            lvDataItem.Items.Add(lvItem);
        }

        private void lvDataItem_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                rtbItemValue.Text = e.Item.SubItems[1].Text;
            }
        }

        public void SaveDataItems()
        {
            List<ListViewItem> items = new List<ListViewItem>();
            foreach (ListViewItem item in lvDataItem.Items)
            {
                items.Add(item);
            }
            ConfigMgr.GetInstance().Save(ConfigItems.DataItems, items);
        }

        // 剪贴板值分类列表
        private List<String> categoryItems = new List<string>();

        public void LoadDataItems()
        {
            // 读取剪贴板保存值项目
            Object val = ConfigMgr.GetInstance().Read(ConfigItems.DataItems);
            List<ListViewItem> items = val as List<ListViewItem>;

            if (items != null)
            {
                foreach (ListViewItem item in items)
                {
                    lvDataItem.Items.Add(item);
                    // 提取分类
                    string category = item.SubItems[2].Text;

                    if (!categoryItems.Contains(category))
                    {
                        categoryItems.Add(category);
                    }
                }
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PutItem();
        }
        /// <summary>
        /// 从系统剪贴板中取值保存到程序中
        /// </summary>
        public void PutItem()
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                string txt = Clipboard.GetText(TextDataFormat.Text);

                if (!string.IsNullOrEmpty(txt.Trim()))
                {
                    DataItem item = new DataItem();
                    item.Value = txt;
                    item.Alias = StringUtils.GetShortMsg(txt.Trim(), ConstVal.MaxLength);
                    item.Category = ConstVal.DefaultCategory;
                    item.CreateTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    item.ModifyTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    item.LastAccessTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    AddDataItem(item);
                    formCanvas.DrawString("保存成功!");
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            GetItem();
        }

        /// <summary>
        /// 将选择的值放在剪贴板中
        /// </summary>
        public void GetItem()
        {
            StringBuilder sb = new StringBuilder();
            foreach (ListViewItem item in lvDataItem.Items)
            {
                if (item.Checked)
                {
                    sb.AppendLine(item.SubItems[1].Text);
                    item.SubItems[5].Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    break;
                }
            }

            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - Environment.NewLine.Length, Environment.NewLine.Length);
                Clipboard.SetText(sb.ToString(), TextDataFormat.Text);
                formCanvas.DrawString("取值成功!");
            }
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            UpdateItem();
        }

        /// <summary>
        /// 更新项目
        /// </summary>
        private void UpdateItem()
        {
            DataItem newItem = null;
            ListViewItem updateItem = null;
            foreach (ListViewItem item in lvDataItem.SelectedItems)
            {
                FormDataItemEdit form = new FormDataItemEdit();
                form.Text = ConstVal.UpdateItemTitle;
                form.LoadCategory(categoryItems);

                DataItem dataItem = new DataItem();
                dataItem.Alias = item.SubItems[0].Text;
                dataItem.Value = item.SubItems[1].Text;
                dataItem.Category = item.SubItems[2].Text;

                form.Init(dataItem);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    newItem = form.DataItem;
                }

                form.Dispose();
                form = null;

                updateItem = item;
                break;
            }

            if (updateItem != null && newItem != null)
            {
                updateItem.SubItems[0].Text = newItem.Alias;
                updateItem.SubItems[1].Text = newItem.Value;
                updateItem.SubItems[2].Text = newItem.Category;
                updateItem.SubItems[4].Text = newItem.ModifyTime;
                updateItem.SubItems[5].Text = newItem.LastAccessTime;
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void DeleteItem()
        {
            if (lvDataItem.SelectedItems != null && lvDataItem.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("确认要删除选中项目吗?", "确认警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    for (int i = lvDataItem.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        lvDataItem.Items.Remove(lvDataItem.SelectedItems[i]);
                    }
                    rtbItemValue.Clear();
                }
            }
        }

        private void lvDataItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem item in lvDataItem.Items)
            {
                if (item.Selected)
                {
                    item.Checked = true;
                }
                else
                {
                    item.Checked = false;
                }
            }
            this.GetItem();
        }

        public void ShowSearchResult(string value)
        {
            foreach (ListViewItem item in lvDataItem.Items)
            {
                if (!string.IsNullOrEmpty(value) && item.SubItems[0].Text.ToUpper().Contains(value.ToUpper()))
                {
                    item.Selected = true;
                    item.BackColor = Color.Blue;
                    item.EnsureVisible();
                }
                else
                {
                    item.Selected = false;
                    item.BackColor = Color.White;
                    if (item.Checked)
                    {
                        item.EnsureVisible();
                    }
                }
            }
        }

        private void lvDataItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (ListViewItem item in lvDataItem.Items)
                {
                    if (item.Selected)
                    {
                        item.Checked = true;
                    }
                    else
                    {
                        item.Checked = false;
                    }
                }
                this.GetItem();
            }
        }

        private void toolStrip_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.splitContainer3.Panel2Collapsed = !splitContainer3.Panel2Collapsed;
        }

        public FormCanvas formCanvas;

        private void UcClipboardRing_Load(object sender, EventArgs e)
        {
            formCanvas = new FormCanvas();
            formCanvas.Visible = false;
            this.lvDataItem.ListViewItemSorter = new ListViewColumnSorter();
        }

        private void lvDataItem_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewColumnSorter sorter = lvDataItem.ListViewItemSorter as ListViewColumnSorter;
            if (e.Column == sorter.SortColumn)
            {
                // 重新设置此列的排序方法.
                if (sorter.Order == SortOrder.Ascending)
                {
                    sorter.Order = SortOrder.Descending;
                }
                else
                {
                    sorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // 设置排序列，默认为正向排序
                sorter.SortColumn = e.Column;
                sorter.Order = SortOrder.Ascending;
            }
            // 用新的排序方法对ListView排序
            this.lvDataItem.Sort();   
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            this.SaveDataItems();
            formCanvas.DrawString("保存成功!");
        }

        private void tsbGet_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ListViewItem item in lvDataItem.SelectedItems)
            {
                if (item.Checked)
                {
                    sb.AppendLine(item.SubItems[1].Text);
                    item.SubItems[5].Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                }
            }

            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - Environment.NewLine.Length, Environment.NewLine.Length);
                Clipboard.SetText(sb.ToString(), TextDataFormat.Text);
                formCanvas.DrawString("取值成功!");
            }
        }

        private void tsbPut_Click(object sender, EventArgs e)
        {
            this.PutItem();
        }

        public void GetSearchResult(string value)
        {
            foreach (ListViewItem item in lvDataItem.Items)
            {
                if (item.Selected)
                {
                    item.Checked = true;
                }
                else
                {
                    item.Checked = false;
                }
            }
            this.GetItem();
        }

        private void lvDataItem_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListViewItem item = e.Item;

            if (item.Checked)
            {
                foreach (ListViewItem item2 in lvDataItem.Items)
                {
                    if (item2.Checked && item2 != item)
                    {
                        item2.Checked = false;
                    }
                }
            }
        }

        private void lvDataItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine();

            ListView lv = sender as ListView;

            if (lv != null)
            {
                foreach (ListViewItem item in lvDataItem.Items)
                {
                    if (item.Selected)
                    {
                        item.Checked = true;
                    }
                }
            }
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ListViewItem item in lvDataItem.SelectedItems)
            {
                if (item.Selected)
                {
                    sb.AppendLine(item.SubItems[1].Text);
                    item.SubItems[5].Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                }
            }

            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - Environment.NewLine.Length, Environment.NewLine.Length);
                Clipboard.SetText(sb.ToString(), TextDataFormat.Text);
                formCanvas.DrawString("复制成功!");
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateItem();
        }

        private void 置顶ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem chkItem = null;

            foreach (ListViewItem item in lvDataItem.SelectedItems)
            {
                if (item.Checked)
                {
                    chkItem = item;
                    break;
                }
            }

            if (chkItem != null)
            {
                string txt = chkItem.SubItems[1].Text;
                lvDataItem.Items.Remove(chkItem);

                DataItem item = new DataItem();
                item.Value = txt;
                item.Alias = chkItem.SubItems[0].Text;
                item.Category = chkItem.SubItems[2].Text;
                item.CreateTime = chkItem.SubItems[3].Text;
                item.ModifyTime = chkItem.SubItems[4].Text;
                item.LastAccessTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                AddDataItem(item);
                formCanvas.DrawString("置顶成功!");
            }
        }

        private void 置底ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem chkItem = null;

            foreach (ListViewItem item in lvDataItem.SelectedItems)
            {
                if (item.Checked)
                {
                    chkItem = item;
                    break;
                }
            }

            if (chkItem != null)
            {
                string txt = chkItem.SubItems[1].Text;
                lvDataItem.Items.Remove(chkItem);

                DataItem item = new DataItem();
                item.Value = txt;
                item.Alias = chkItem.SubItems[0].Text;
                item.Category = chkItem.SubItems[2].Text;
                item.CreateTime = chkItem.SubItems[3].Text;
                item.ModifyTime = chkItem.SubItems[4].Text;
                item.LastAccessTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                AddDataItemToBottom(item);
                formCanvas.DrawString("置底成功!");
            }
        }
    }
}
