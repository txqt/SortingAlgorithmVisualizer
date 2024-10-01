using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortVisualizer
{
    public class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel()
        {
            // Bật double buffering để giảm nhấp nháy
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }
    }
}
