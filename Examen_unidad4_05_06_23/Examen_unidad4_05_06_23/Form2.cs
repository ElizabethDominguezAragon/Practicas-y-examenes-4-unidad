using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_unidad4_05_06_23
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cambio.Text != "")
            {
                int[] a1 = new int[10];
                float[] a2 = new float[10];
                Random rm = new Random(Environment.TickCount);

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                for (int i = 0; i < 10; i++)
                {
                    a1[i] = rm.Next(500, 1290);
                    listBox1.Items.Add(a1[i]);
                    a2[i] = (a1[i] / float.Parse(Cambio.Text));
                    listBox2.Items.Add(a2[i]);
                }

            }
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
