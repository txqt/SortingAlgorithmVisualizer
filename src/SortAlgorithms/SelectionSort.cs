using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortVisualizer.SortAlgorithms
{
    public class SelectionSort : SortAlgorithm
    {
        public override async Task Sort(int[] array, Panel panel, int delay)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    Swap(array, i, minIndex);
                    await CheckPause();

                    //redraw
                    panel.Invalidate();
                    await Task.Delay(delay);
                }
            }
        }
    }
}
