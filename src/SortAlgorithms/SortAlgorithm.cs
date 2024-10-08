using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortVisualizer.SortAlgorithms
{
    public abstract class SortAlgorithm
    {
        protected bool isPaused = false;
        protected bool isAnimation = true;

        public abstract Task Sort(int[] array, Panel panel, int delay);

        protected void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        // Kiểm tra nếu tạm dừng
        protected async Task CheckPause()
        {
            while (isPaused)
            {
                await Task.Delay(100);
            }
        }

        public void Pause() => isPaused = true;

        public void Resume() => isPaused = false;
        public void SetAnimation(bool on)
        {
            this.isAnimation = on;
        }
    }
}
