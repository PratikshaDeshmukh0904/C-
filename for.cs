using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forloop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = "";
            for(int i = 0;i< 10;i++)
                { 
                value += " " + i + " ";

            }
            textBox1.Text = value.ToString();
            //MessageBox.Show(value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = "";
            for(int i=0;i<10;i++)
            {
                for(int j =0;j<8;j++)
                {
                    value += "i:" + i + " " + "j:" + j + Environment.NewLine;

                }
                textBox1.Text = value;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string value= "" ;

            int[] array =  {1,2,3,4,5,6,7,8,9};

            foreach(int item in array )
            {
                value +=   item + " ";
            }
            textBox1.Text = value;
        }
    }
}
