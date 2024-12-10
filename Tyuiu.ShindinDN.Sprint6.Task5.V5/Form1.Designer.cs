namespace Tyuiu.ShindinDN.Sprint6.Task5.V5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_IAA = new Panel();
            buttonHelp = new Button();
            buttonOpen = new Button();
            buttonDone = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            panelRight_IAA = new Panel();
            groupBox2 = new GroupBox();
            dataGridViewRes = new DataGridView();
            panelFill_IAA = new Panel();
            chartRes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitterPanel_IAA = new Splitter();
            panelTop_IAA.SuspendLayout();
            groupBox1.SuspendLayout();
            panelRight_IAA.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).BeginInit();
            panelFill_IAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes).BeginInit();
            SuspendLayout();
            // 
            // panelTop_IAA
            // 
            panelTop_IAA.Controls.Add(buttonHelp);
            panelTop_IAA.Controls.Add(buttonOpen);
            panelTop_IAA.Controls.Add(buttonDone);
            panelTop_IAA.Controls.Add(groupBox1);
            panelTop_IAA.Dock = DockStyle.Top;
            panelTop_IAA.Location = new Point(0, 0);
            panelTop_IAA.Name = "panelTop_IAA";
            panelTop_IAA.Size = new Size(712, 94);
            panelTop_IAA.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.DeepSkyBlue;
            buttonHelp.Location = new Point(604, 17);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(90, 61);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = SystemColors.Highlight;
            buttonOpen.Location = new Point(508, 17);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(90, 61);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Открыть файл";
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.DarkGreen;
            buttonDone.Location = new Point(413, 17);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(90, 61);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 94);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(402, 72);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла InPutFileTask5V5.txt. Вывести в dataGridView. Вывести все числа, кратные 2. Построить диаграмму по этим значениям.";
            // 
            // panelRight_IAA
            // 
            panelRight_IAA.Controls.Add(groupBox2);
            panelRight_IAA.Dock = DockStyle.Left;
            panelRight_IAA.Location = new Point(0, 94);
            panelRight_IAA.Name = "panelRight_IAA";
            panelRight_IAA.Size = new Size(175, 328);
            panelRight_IAA.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewRes);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(175, 328);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // dataGridViewRes
            // 
            dataGridViewRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes.Dock = DockStyle.Fill;
            dataGridViewRes.Location = new Point(3, 19);
            dataGridViewRes.Name = "dataGridViewRes";
            dataGridViewRes.RowHeadersWidth = 51;
            dataGridViewRes.RowTemplate.Height = 24;
            dataGridViewRes.Size = new Size(169, 306);
            dataGridViewRes.TabIndex = 0;
            // 
            // panelFill_IAA
            // 
            panelFill_IAA.Controls.Add(chartRes);
            panelFill_IAA.Controls.Add(splitterPanel_IAA);
            panelFill_IAA.Dock = DockStyle.Fill;
            panelFill_IAA.Location = new Point(175, 94);
            panelFill_IAA.Name = "panelFill_IAA";
            panelFill_IAA.Size = new Size(537, 328);
            panelFill_IAA.TabIndex = 0;
            // 
            // chartRes
            // 
            chartArea3.Name = "ChartArea1";
            chartRes.ChartAreas.Add(chartArea3);
            chartRes.Dock = DockStyle.Fill;
            legend3.Name = "Legend1";
            chartRes.Legends.Add(legend3);
            chartRes.Location = new Point(3, 0);
            chartRes.Name = "chartRes";
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartRes.Series.Add(series3);
            chartRes.Size = new Size(534, 328);
            chartRes.TabIndex = 1;
            chartRes.Text = "chart1";
            // 
            // splitterPanel_IAA
            // 
            splitterPanel_IAA.Location = new Point(0, 0);
            splitterPanel_IAA.Name = "splitterPanel_IAA";
            splitterPanel_IAA.Size = new Size(3, 328);
            splitterPanel_IAA.TabIndex = 0;
            splitterPanel_IAA.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 422);
            Controls.Add(panelFill_IAA);
            Controls.Add(panelRight_IAA);
            Controls.Add(panelTop_IAA);
            Name = "Form1";
            Text = "Спринт 6 | Таск 5 | Вариант 5 | Шиндин Д. Н.";
            panelTop_IAA.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelRight_IAA.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).EndInit();
            panelFill_IAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartRes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop_IAA;
        private System.Windows.Forms.Panel panelRight_IAA;
        private System.Windows.Forms.Panel panelFill_IAA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Splitter splitterPanel_IAA;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewRes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes;
    }
}
