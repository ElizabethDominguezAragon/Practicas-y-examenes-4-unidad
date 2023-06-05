namespace Examen_unidad4_05_06_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 4;
            int[,] matriz = new int[5,4];
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int num = rand.Next(50, 300);
                    if (num%2 == 0)
                    { matriz[i,j] = num; }
                    else { matriz[i,j] = 1; }
                    dataGridView1[j, i].Value = matriz[i,j];
                }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            
        }
    }
}