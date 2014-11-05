using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClipboardRing
{
    public partial class FormDataItemEdit : Form
    {
        // 设置当前选中分类
        public static String selectedCategory = "未分类";

        private DataItem dataItem;

        public DataItem DataItem
        {
            get { return dataItem; }
            set { dataItem = value; }
        }

        public FormDataItemEdit()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StringBuilder sbMsg = new StringBuilder();

            string val = rtbItemValue.Text;
            string category = cbItemCategory.Text;
            string alias = tbItemName.Text;

            if (String.IsNullOrEmpty(val.Trim()))
            {
                sbMsg.AppendLine("项目值不能为空!");
            }
            if (String.IsNullOrEmpty(category))
            {
                category = "未分类";
            }
            if (String.IsNullOrEmpty(alias))
            {
                alias = StringUtils.GetShortMsg(val.Trim(), ConstVal.MaxLength);
            }

            if (sbMsg.Length > 0)
            {
                MessageBox.Show(sbMsg.ToString());
                return;
            }

            DataItem item = new DataItem();
            item.Value = val;
            item.Category = category;
            item.Alias = alias;
            item.CreateTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            item.ModifyTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            item.LastAccessTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            this.dataItem = item;
            // 保存设置的分类
            selectedCategory = category;
            if (!categoryItems.Contains(category))
            {
                categoryItems.Insert(0, category);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void Init(DataItem dataItem)
        {
            this.rtbItemValue.Text = dataItem.Value;
            this.cbItemCategory.Text = dataItem.Category;
            this.tbItemName.Text = dataItem.Alias;
        }
        /// <summary>
        /// 分类列表
        /// </summary>
        private List<String> categoryItems;
        /// <summary>
        /// 加载分类信息
        /// </summary>
        /// <param name="list"></param>
        internal void LoadCategory(List<string> list)
        {
            this.categoryItems = list;
            this.cbItemCategory.Items.Clear();
            cbItemCategory.Items.AddRange(list.ToArray());
            if (list.Contains("未分类"))
            {
                cbItemCategory.Items.Remove("未分类");
            }
            cbItemCategory.Items.Insert(0, "未分类");
            if (cbItemCategory.Items.Contains(selectedCategory))
            {
                cbItemCategory.SelectedItem = selectedCategory;
            }
        }
    }
}
