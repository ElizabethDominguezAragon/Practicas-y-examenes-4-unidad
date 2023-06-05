namespace examen_UNIDAD4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 7;
            int[] arreglo0 = new int[6] { 5602, 8952, 1025, 7087, 8352, 7441 };
            int[] Arreglo1= new int[6];    int[] Arreglo2 = new int[6];    int[] Arreglo3 = new int[6];    int[] Arreglo4 = new int[6];
            int[,] Matriz = new int[7,5];
            Random rand = new Random();

            //arreglo0[0] = 5602; arreglo0[1] = 8952; arreglo0[2] = 1025; arreglo0[3] = 7087; arreglo0[4] = 8352; arreglo0[5] = 7441;

            for (int i = 0; i < 6; i++)
            {
                Arreglo1[i] = rand.Next(70, 100); Arreglo2[i] = rand.Next(70, 100);
                Arreglo3[i] = rand.Next(70, 100); Arreglo4[i] = rand.Next(70, 100);
            }
            //i=Columnas j=FILAS 
            for (int i = 0; i < 5; i++)
            {
                if (i == 0) {
                    Matriz[0,i ] = i;
                    for (int j = 0; j <6; j++)
                    { Matriz[j+1,i] = arreglo0[j]; }
                }if (i == 1) {
                    Matriz[0, i] = i;
                    for (int j = 0; j < 6; j++)
                    { Matriz[j + 1, i] = Arreglo1[j];}
                }if (i == 2) {
                    Matriz[0, i] = i;
                    for (int j = 0; j < 6; j++)
                    {   Matriz[j + 1, i] = Arreglo2[j];}
                }if (i == 3){
                    Matriz[0, i] = i;
                    for (int j = 0; j < 6; j++)
                    { Matriz[j + 1, i] = Arreglo3[j];}
                }if (i == 4) {
                    Matriz[0, i] = i;
                    for (int j = 0; j < 6; j++)
                    {   Matriz[j + 1, i] = Arreglo4[j];}
                }
            }
            for (int i = 0; i <7; i++) {
                for (int j = 0; j < 5; j++)
                { dataGridView1[j, i].Value = Matriz[i, j]; }
            }
        }
    }
}