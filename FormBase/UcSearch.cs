using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormBase
{
    public partial class UcSearch : UserControl
    {
        public delegate void SearchDelegate(Object sender, string value);

        new public event SearchDelegate TextChanged;

        public event SearchDelegate EnterKeyDown;

        public UcSearch()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbSearch.Text = "";
            TextChanged(sender, cbSearch.Text);
        }

        private void cbSearch_TextChanged(object sender, EventArgs e)
        {
            if (TextChanged != null)
            {
                TextChanged(sender, cbSearch.Text);
            }
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextChanged != null)
            {
                TextChanged(sender, cbSearch.Text);
            }
        }

        private void cbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string txt = cbSearch.Text;
                if (!string.IsNullOrEmpty(txt.Trim()))
                {
                    if (!cbSearch.Items.Contains(txt))
                    {
                        cbSearch.Items.Insert(0, txt);
                    }
                }

                if (EnterKeyDown != null)
                {
                    EnterKeyDown(sender, txt);
                }
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (cbSearch.SelectedItem != null)
                {
                    cbSearch.Items.Remove(cbSearch.SelectedItem);
                    cbSearch.Text = string.Empty;
                }
            }
        }

        private void cbSearch_Click(object sender, EventArgs e)
        {
            if (TextChanged != null)
            {
                TextChanged(sender, cbSearch.Text);
            }
        }

        private void cbSearch_Leave(object sender, EventArgs e)
        {
            string txt = cbSearch.Text;
            if (!string.IsNullOrEmpty(txt))
            {
                if (!cbSearch.Items.Contains(txt))
                {
                    cbSearch.Items.Add(txt);
                }
            }
        }
    }
}
