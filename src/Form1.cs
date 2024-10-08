using SortingAlgorithmVisualizer.SortAlgorithms;
using SortVisualizer.SortAlgorithms;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortVisualizer
{
    public partial class Form1 : Form
    {
        private int[] array;
        private SortAlgorithm currentAlgorithm;
        private int delay = 0;
        private int numEntities = 100;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            AlgorithmListInit();
            cbb_algorithm.SelectedIndex = 0;
            RandomValue();
            trackBarSpeed.ValueChanged += trackBarSpeed_ValueChanged;
            txt_numEntities.Text = numEntities.ToString();
            panelVisualizer.Paint += PanelVisualizer_Paint;
            trackBarSpeed.Minimum = 1;
            trackBarSpeed.Maximum = 1000;
            cb_animation.Checked = true;
            trackBarSpeed.Value = 100;
            txt_trackBarValue.Text = trackBarSpeed.Value.ToString();
        }

        private void AlgorithmListInit()
        {
            cbb_algorithm.Items.Add(new ComboboxItem() { Text = "Bubble sort", Value = 0 });
            cbb_algorithm.Items.Add(new ComboboxItem() { Text = "Selection sort", Value = 1 });
            cbb_algorithm.Items.Add(new ComboboxItem() { Text = "Insertion sort", Value = 2 });
            cbb_algorithm.Items.Add(new ComboboxItem() { Text = "Merge sort", Value = 3 });
            cbb_algorithm.Items.Add(new ComboboxItem() { Text = "Quick sort", Value = 4 });
        }

        private void PanelVisualizer_Paint(object sender, PaintEventArgs e)
        {
            GenerateBars(array, e.Graphics);
        }

        private void RandomValue()
        {
            int maxVal = 1000;
            array = new int[numEntities];
            Random rand = new Random();
            for (int i = 0; i < numEntities; i++)
            {
                array[i] = rand.Next(0, maxVal);
            }
            panelVisualizer.Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            RandomValue();
        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            switch (cbb_algorithm.SelectedIndex)
            {
                case 0:
                    currentAlgorithm = new BubbleSort();
                    break;
                case 1:
                    currentAlgorithm = new SelectionSort();
                    break;
                case 2:
                    currentAlgorithm = new InsertionSort();
                    break;
                case 3:
                    currentAlgorithm = new MergeSort();
                    break;
                case 4:
                    currentAlgorithm = new QuickSort();
                    break;
                default:
                    currentAlgorithm = new BubbleSort();
                    break;
            }

            if (currentAlgorithm != null)
            {
                currentAlgorithm.SetAnimation(cb_animation.Checked);
                await currentAlgorithm.Sort(array, panelVisualizer, delay);
                if(cb_animation.Checked == false)
                {
                    panelVisualizer.Invalidate();
                }
            }
        }

        private void GenerateBars(int[] array, Graphics g)
        {
            if (array == null) return;

            g.Clear(panelVisualizer.BackColor);

            float width = (float)panelVisualizer.Width / array.Length   ;

            using (Pen blackPen = new Pen(Color.Black, 1))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int height = (int)(panelVisualizer.Height * array[i] / (float)array.Max());

                    float x = (i * width) + (width / 2);

                    g.DrawLine(blackPen, x, panelVisualizer.Height, x, panelVisualizer.Height - height);
                }
            }
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            currentAlgorithm?.Pause();
        }

        private void btn_resume_Click(object sender, EventArgs e)
        {
            currentAlgorithm?.Resume();
        }

        private void trackBarSpeed_ValueChanged(object sender, EventArgs e)
        {
            delay = trackBarSpeed.Value;
            txt_trackBarValue.Text = delay.ToString();
        }

        private void txt_numEntities_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_numEntities.Text, out int value) && value >= 0)
            {
                numEntities = value;
            }
        }

        private void txt_numEntities_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_trackBarValue_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_trackBarValue.Text, out int value) && value >= 0)
            {
                delay = value;
            }
        }

        private void txt_trackBarValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
