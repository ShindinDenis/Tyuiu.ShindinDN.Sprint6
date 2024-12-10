using Tyuiu.ShindinDN.Sprint6.Task4.V2.Lib;

namespace Tyuiu.ShindinDN.Sprint6.Task4.V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int end = Convert.ToInt32(textBoxEnd.Text);

                int len = ds.GetMassFunction(start, end).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(start, end);


                this.chartResult.ChartAreas[0].AxisX.Title = "��� X";
                this.chartResult.ChartAreas[0].AxisY.Title = "��� Y";

                textBoxResult.Text = "";

                chartResult.Series[0].Points.Clear();
                for (int i = 0; i < len - 1; i++)
                {
                    this.chartResult.Series[0].Points.AddXY(start, valueArray[i]);
                    textBoxResult.AppendText(valueArray[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 �������� ������� ������ �����-24-1 ������ ����� ����������", "���������");
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult.Text);

                DialogResult dialogResult = MessageBox.Show("����" + path + "�������� �������!\n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
