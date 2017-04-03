using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CMPE1600_ICA11
{
    public partial class Form1 : Form
    {
        public int[] valueArray = new int[5000];
        private Thread threadOne = null;
        private Thread threadTwo = null;
        private delegate void delVoidVoid();
        private delegate void delVoidInt(int i);
        object placeholder = new object();

        public Form1()
        {
            InitializeComponent();
            FillArray();

        }

        private void UI_GenerateButton_Click(object sender, EventArgs e)
        {

            threadOne = new Thread(new ThreadStart(counter));
            threadOne.Start();

        }
        public void FillArray()
        {
            Random rand = new Random();
            for (int i = 0; i < 5000; i++)
            {
                valueArray[i] = rand.Next(50001);
            }
        }


        private void UI_ClearButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void cbBoxFill(int i)
        {
            lock (placeholder)
            {
                listBox1.Items.Add(valueArray[i]);
            }
        }
        private void counter()
        {
            for (int i = 0; i < 5000; i++)
            {
                if (InvokeRequired)
                {
                    try
                    {
                        Invoke(new delVoidInt(cbBoxFill), i);
                    }
                    catch (ObjectDisposedException)
                    {
                        MessageBox.Show("The form is gone!");
                    }
                }
            }
        }
        private void BubbleSort()
        {
            bool unsorted = false;
            do
            {
                unsorted = false;
                for (int j = 0; j < valueArray.Length - 1; j++)
                {
                    if (valueArray[j] > valueArray[j + 1])
                    {
                        unsorted = true;
                        int temp = valueArray[j];
                        valueArray[j] = valueArray[j + 1];
                        valueArray[j + 1] = temp;
                    }
                }
            } while (unsorted);
            threadOne = new Thread(new ThreadStart(counter));
            threadOne.Start();
        }

        private void UI_SortButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            BubbleSort();
            
        }
    }
}
