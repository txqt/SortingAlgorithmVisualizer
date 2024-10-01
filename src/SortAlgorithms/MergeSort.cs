using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortVisualizer.SortAlgorithms
{
    public class MergeSort : SortAlgorithm
    {
        public override async Task Sort(int[] array, Panel panel, int delay)
        {
            await Sort(array, 0, array.Length - 1, panel, delay);
        }
        public async Task Sort(int[] array, int left, int right, Panel panel, int delay)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                await Sort(array, left, middle, panel, delay);
                await Sort(array, middle + 1, right, panel, delay);

                await Merge(array, left, middle, right, panel, delay);
            }
        }
        public async Task Merge(int[] array, int left, int middle, int right, Panel panel, int delay)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = array[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = array[middle + 1 + j];

            int iLeft = 0, iRight = 0;
            int k = left;

            while (iLeft < n1 && iRight < n2)
            {
                await CheckPause();

                if (leftArray[iLeft] <= rightArray[iRight])
                {
                    array[k] = leftArray[iLeft];
                    iLeft++;
                }
                else
                {
                    array[k] = rightArray[iRight];
                    iRight++;
                }
                k++;

                panel.Invalidate();
                await Task.Delay(delay);
            }

            while (iLeft < n1)
            {
                await CheckPause();
                array[k] = leftArray[iLeft];
                iLeft++;
                k++;

                panel.Invalidate();
                await Task.Delay(delay);
            }

            while (iRight < n2)
            {
                await CheckPause();
                array[k] = rightArray[iRight];
                iRight++;
                k++;

                panel.Invalidate();
                await Task.Delay(delay);
            }

        }
    }
}
