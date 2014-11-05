using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ClipboardRing
{
    public class CommonUtils
    {
        // 圆角代码
        public static Region Round(int width, int height)
        {
            System.Drawing.Drawing2D.GraphicsPath oPath = new System.Drawing.Drawing2D.GraphicsPath();

            int x = 0;
            int y = 0;
            int thisWidth = width;
            int thisHeight = height;
            int dd = 2;

            oPath.AddLine(x, dd, dd, y);
            oPath.AddLine(thisWidth - dd, y, thisWidth, dd);
            oPath.AddLine(thisWidth, thisHeight - dd, thisWidth - dd, thisHeight);
            oPath.AddLine(dd, thisHeight, x, thisHeight - dd);
            oPath.CloseAllFigures();
            return new System.Drawing.Region(oPath);
        }
    }
}
