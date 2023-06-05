using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Arreglos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            Areglo1.Items.Clear(); Areglo2.Items.Clear(); Areglo3.Items.Clear();
            int[] A1 = new int[10];
            int[] A2 = new int[10];
            int[] A3 = new int[10];
            Random rdm= new Random(Environment.TickCount);
            int n1, n2, n3, s1 = 0, s2 = 0, s3 = 0;
            for (int i = 0; i < 10; i++)
            {
                n1 = rdm.Next(20, 200); n2 = rdm.Next(20, 200); n3 = rdm.Next(20, 200);
                A1[i] = n1; A2[i] = n2; A3[i] = n3;
                Areglo1.Items.Add((i + 1) + ": " + n1);
                Areglo2.Items.Add((i + 1) + ": " + n2);
                Areglo3.Items.Add((i + 1) + ": " + n3);
                s1 += n1; s2 += n2; s3 += n3;
               
            }
            string Mnsg =  "   La suma del arreglo 1 es: " + s1 + "."
                        +"\n   La suma del arreglo 2 es: " + s2 + "."
                        +"\n   La suma del arreglo 3 es: " + s3 + ".\n ";
            if ((s1 > s2)&& (s1 > s3)){
                Mnsg += "\n✧El mayor arreglo es el primero✧";
            }else if ((s2 > s1) && (s2 > s3)){
                Mnsg += "\n✧El mayor arreglo es el segundo✧";
            }else{
                Mnsg += "\n✧El mayor arreglo es el tercero✧";
            }
            MessageBox.Show(Mnsg);
           
        }
    }
}
