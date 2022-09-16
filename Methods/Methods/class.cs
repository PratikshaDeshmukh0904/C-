using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class @class : Form
    {
        public @class()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 personaldetail = new Class1();
            personaldetail.employee = Convert.ToInt32(textBox1.Text);
            personaldetail.name = textBox2.Text;
            personaldetail.Age = Convert.ToInt32(textBox3.Text);
            MessageBox.Show("All data save");

        }
    }
}
