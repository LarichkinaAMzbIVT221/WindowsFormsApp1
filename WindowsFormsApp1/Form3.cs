using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Прямоугольник class1 = new Прямоугольник(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            MessageBox.Show("Площадь равна" + class1.Площадь());
        }
    }
}
