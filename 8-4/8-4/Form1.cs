using System;
using System.Windows.Forms;

namespace ArrayMinMaxFinder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = new int[6];
                numbers[0] = int.Parse(txtNumber1.Text);
                numbers[1] = int.Parse(txtNumber2.Text);
                numbers[2] = int.Parse(txtNumber3.Text);
                numbers[3] = int.Parse(txtNumber4.Text);
                numbers[4] = int.Parse(txtNumber5.Text);
                numbers[5] = int.Parse(txtNumber6.Text);

                int min = arrMin(numbers);
                int max = arrMax(numbers);

                lblResult.Text = $"最小值: {min}, 最大值: {max}";
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數字!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int arrMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        private int arrMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}