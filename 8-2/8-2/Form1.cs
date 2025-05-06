using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace RandomArraySortApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
 
            int[] array = new int[5];
            Random random = new Random();


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 201); 
            }

            Array.Sort(array);

            label1.Text = "°}¦C: " + string.Join(", ", array);
        }
    }
}