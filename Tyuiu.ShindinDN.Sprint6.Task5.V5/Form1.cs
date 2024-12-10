using Tyuiu.ShindinDN.Sprint6.Task5.V5.Lib;

namespace Tyuiu.ShindinDN.Sprint6.Task5.V5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V5.txt";


        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewRes.ColumnCount = 2;
            dataGridViewRes.Columns[0].Width = 20;
            dataGridViewRes.Columns[1].Width = 50;

            this.chartRes.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartRes.ChartAreas[0].AxisY.Title = "Ось Y";

            chartRes.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewRes.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartRes.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСТНб-24-1 Шиндин Денис Николаевич", "Сообщение");
        }
    }
}
