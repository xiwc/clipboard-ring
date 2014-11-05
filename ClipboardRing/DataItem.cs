using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClipboardRing
{
    public class DataItem
    {
        //剪贴板中的值
        private string value;

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        //别名
        private string alias;

        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }
        //种类
        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        //添加时间
        private string createTime;

        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        //修改时间
        private string modifyTime;


        public string ModifyTime
        {
            get { return modifyTime; }
            set { modifyTime = value; }
        }
        //最后访问时间
        private string lastAccessTime;

        public string LastAccessTime
        {
            get { return lastAccessTime; }
            set { lastAccessTime = value; }
        }
        //访问次数
        private int useTimes;

        public int UseTimes
        {
            get { return useTimes; }
            set { useTimes = value; }
        }
        //备注说明
        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
    }
}
