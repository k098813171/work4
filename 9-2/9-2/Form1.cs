using System;
using System.Windows.Forms;

namespace BoxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double width = double.Parse(txtWidth.Text);
                double height = double.Parse(txtHeight.Text);
                double length = double.Parse(txtLength.Text);

                Box box = new Box(width, height, length);

                lblVolume.Text = box.Volume().ToString("F2");
                lblArea.Text = box.Area().ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class Box
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }

        public Box(double width, double height, double length)
        {
            Width = width;
            Height = height;
            Length = length;
        }

        public double Volume()
        {
            return Width * Height * Length;
        }

        public double Area()
        {
            return 2 * (Width * Height + Width * Length + Height * Length);
        }
    }
}