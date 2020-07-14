using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Colores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startComponent();
        }

        private void startComponent()
        {
            comboBox1.Items.Add("Rojo");
            comboBox1.Items.Add("Azul");
            comboBox1.Items.Add("Verde");

            comboBox1.SelectedIndexChanged += (s, e) =>
            {
                int index = comboBox1.SelectedIndex;
                BackColor = index == 0 ? Color.Red : index == 1 ? Color.Blue : Color.Green;
            };
        }
    }
}
