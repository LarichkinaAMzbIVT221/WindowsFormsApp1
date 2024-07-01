using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Прямоугольник class1 = new Прямоугольник(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            MessageBox.Show("Периметр равен" + class1.Периметр());
        }
    }
}
