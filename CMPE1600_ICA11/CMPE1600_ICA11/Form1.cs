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
        public int[] valueArray = new int[50000];
        //public Thread threadOne = null;


        public Form1()
        {
            InitializeComponent();

        }

        private void UI_GenerateButton_Click(object sender, EventArgs e)
        {
            UI_StatusLabel.Text = "Filling List Box";
            Thread threadOne = new Thread(FillArray);
            threadOne.Start();
            Thread threadTwo = new Thread(PopListBox);
            threadTwo.Start();
            UI_StatusLabel.Text = "Done";

        }
        public void FillArray()
        {
            Random rand = new Random();
            for(int i = 0; i < valueArray.Length; i++)
            {
                valueArray[i] = rand.Next(50001);
            }
        }
        public void PopListBox()
        {
            
            foreach (int i in valueArray)
            {
                listBox1.Items.Add(i);
                progressBar1.Value++;
            }
            
            progressBar1.Value = 0;
        }

        private void UI_ClearButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
