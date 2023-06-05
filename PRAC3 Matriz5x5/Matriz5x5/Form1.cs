namespace Matriz5x5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rm = new Random();
            int numero;
            int[,] matriz = new int[5, 5];
            //string ImprimirM = "";
            //llenar matrisz
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 5; j++){
                    if (i == j){
                        matriz[i, j] = 0;
                    }else {

                        numero = rm.Next(90, 325);
                        matriz[i, j] = numero;
                    }
                    //ImprimirM += "[" + matriz[i, j] + "]   ";
                }

               // ImprimirM += "\n";
            }
            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 5;
            for (int i = 0; i < 5; i++){
                for (int j = 0; j < 5; j++) {
                   
                        dataGridView1.Rows[i].Cells[j].Value = matriz[i, j].ToString();
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }

       
            }
            //MessageBox.Show(ImprimirM);
            

        }
    }

}