using Tyuiu.ShindinDN.Sprint6.Task2.V29.Lib;

namespace Tyuiu.ShindinDN.Sprint6.Task2.V29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void ButtonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartResult.Titles.Add("График функции");
                this.chartResult.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartResult.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ButtonDone_MouseEnter(object sender, EventArgs e)
        {
            ButtonDone.BackColor = Color.Blue;
        }
        private void ButtonDone_MouseLeave(object sender, EventArgs e)
        {
            ButtonDone.BackColor = Color.Green;
        }
        private void ButtonDone_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonDone.BackColor = Color.Blue;
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИСТНб-24-1 Шиндин Денис Николаевич", "Сообщение");
        }
    }
}
