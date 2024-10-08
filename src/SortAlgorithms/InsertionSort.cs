using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortVisualizer.SortAlgorithms
{
    public class InsertionSort : SortAlgorithm
    {
        public override async Task Sort(int[] array, Panel panel, int delay)
        {
            for(int i = 1; i < array.Length; i++)
            {
                var curr = array[i];
                var j = i - 1;

                while (j >= 0 && array[j] > curr)
                {
                    array[j + 1] = array[j];
                    j--;
                    await CheckPause();

                    //redraw
                    if (isAnimation)
                    {
                        panel.Invalidate();
                        await Task.Delay(delay);
                    }
                }

                array[j + 1] = curr;
            }
            
        }
    }
}
