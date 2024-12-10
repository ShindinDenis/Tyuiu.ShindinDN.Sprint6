using Tyuiu.ShindinDN.Sprint6.Task3.V15.Lib;

namespace Tyuiu.ShindinDN.Sprint6.Task3.V15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] matrix = {
                {  33, 28, 31, 19, 4 },
                {  1, 32, -3, -17, -12 },
                {  24, -19, 26, 31, -3 },
                { 30, -16, 29, 28, 8 },
                { 30, 5, 11, 7, 32 }
            };
        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                dataGridViewMatrix.Rows[i].Height = 25;
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] array = ds.Calculate(matrix);
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = array[i, j].ToString();
                }
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСТНб-24-1 Шиндин Денис Николаевич", "Сообщение");
        }
    }
}
