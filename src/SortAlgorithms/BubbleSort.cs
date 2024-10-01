using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortVisualizer.SortAlgorithms
{
    public class BubbleSort : SortAlgorithm
    {
        public override async Task Sort(int[] array, Panel panel, int delay)
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        sorted = false;
                        await CheckPause();

                        //redraw
                        panel.Invalidate();
                        await Task.Delay(delay);
                    }
                }
            }
        }
    }
}
