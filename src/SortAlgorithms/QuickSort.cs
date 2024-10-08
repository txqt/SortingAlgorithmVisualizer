using Microsoft.VisualBasic.Logging;
using SortVisualizer.SortAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithmVisualizer.SortAlgorithms
{
    public class QuickSort : SortAlgorithm
    {
        public override async Task Sort(int[] array, Panel panel, int delay)
        {
            await Sort(array, 0, array.Length - 1, panel, delay);
        }
        public async Task Sort(int[] arr, int low, int high, Panel panel, int delay)
        {
            if (low < high)
            {
                int pivotIndex = await Partition(arr, low, high, panel, delay);

                // Sắp xếp các phần tử trước và sau pivot
                await Sort(arr, low, pivotIndex - 1, panel, delay);
                await Sort(arr, pivotIndex + 1, high, panel, delay);
            }
        }

        public async Task<int> Partition(int[] arr, int low, int high, Panel panel, int delay)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                    if (isAnimation)
                    {
                        panel.Invalidate();
                        await Task.Delay(delay);
                    }
                }
            }

            Swap(arr, i + 1, high);
            if (isAnimation)
            {
                panel.Invalidate();
                await Task.Delay(delay);
            }
            return i + 1;
        }
    }
}
