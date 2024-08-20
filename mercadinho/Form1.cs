using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mercadinho
{
    public partial class Form1 : Form
    {
        double tottal;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            double valor = double.Parse(valortxt.Text);
            double quantidade = double.Parse(qnttxt.Text);
           
            
            tottal += quantidade * valor;
            listBox1.Items.Add(produtotxt.Text+"   " +qnttxt.Text+"   " +valortxt.Text);
            lbltotal.Text = tottal.ToString("C");

            produtotxt.Clear();
            qnttxt.Clear();
            valortxt.Clear();
            produtotxt.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
