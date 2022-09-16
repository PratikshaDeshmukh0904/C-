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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void clearradio()
        {
            groupBox1.Visible = false;
        }
        public void cleartext()
        {
            textBox1.Clear();

        }
        public void filltextbox(string text)
        {
            textBox1.Text = text;
        }
        public void setnumber(int age)
        {
            label1.Text = "Your age is" + age.ToString() + "years old";
        }
        string getname()
        {
            string name = "Pratiksha";
            return name;
        }
        //Method have parameters and return type
        int sum(int x,int y)
        {
            int result = x + y;
            return result;
        }
        //method overloading
        string valuecontrol()
        {
            string text = "";
            return text;
        }
        string valuecontrol(string Name)
        {
            string text = "";
            return text;
        }
        string valuecontrol(string Name, bool control)
        {
            string text = "";
            return text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clearradio();
           // cleartext();
            filltextbox(textBox2.Text);
            setnumber(65);
            string name = getname();
            MessageBox.Show(name);

            int result = sum(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
            MessageBox.Show(result.ToString());


            //method overloading
            string Name = valuecontrol("John");
            MessageBox.Show(Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Class1 = new Form();

        }
    }
}
