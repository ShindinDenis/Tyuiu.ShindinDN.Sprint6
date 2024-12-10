namespace Tyuiu.ShindinDN.Sprint6.Task4.V2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelCondition = new Panel();
            buttonHelp = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            groupBox2 = new GroupBox();
            textBoxEnd = new TextBox();
            labelEnd = new Label();
            textBoxStart = new TextBox();
            labelStart = new Label();
            groupBox1 = new GroupBox();
            groupBoxTextCondition = new GroupBox();
            label1 = new Label();
            panelLeft = new Panel();
            groupBox3 = new GroupBox();
            textBoxResult = new TextBox();
            panelGraphic = new Panel();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelCondition.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxTextCondition.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBox3.SuspendLayout();
            panelGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            SuspendLayout();
            // 
            // panelCondition
            // 
            panelCondition.BackColor = SystemColors.ControlLight;
            panelCondition.Controls.Add(buttonHelp);
            panelCondition.Controls.Add(buttonSave);
            panelCondition.Controls.Add(buttonDone);
            panelCondition.Controls.Add(groupBox2);
            panelCondition.Controls.Add(groupBox1);
            panelCondition.Dock = DockStyle.Top;
            panelCondition.Location = new Point(0, 0);
            panelCondition.Margin = new Padding(4, 3, 4, 3);
            panelCondition.Name = "panelCondition";
            panelCondition.Size = new Size(1040, 93);
            panelCondition.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.DodgerBlue;
            buttonHelp.Location = new Point(947, 14);
            buttonHelp.Margin = new Padding(4, 3, 4, 3);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(84, 67);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.Highlight;
            buttonSave.Location = new Point(856, 14);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(84, 67);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LimeGreen;
            buttonDone.Location = new Point(765, 14);
            buttonDone.Margin = new Padding(4, 3, 4, 3);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(84, 67);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxEnd);
            groupBox2.Controls.Add(labelEnd);
            groupBox2.Controls.Add(textBoxStart);
            groupBox2.Controls.Add(labelStart);
            groupBox2.Location = new Point(464, 5);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(294, 85);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных:";
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(146, 43);
            textBoxEnd.Margin = new Padding(4, 3, 4, 3);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(116, 23);
            textBoxEnd.TabIndex = 3;
            textBoxEnd.Text = "5";
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Location = new Point(142, 21);
            labelEnd.Margin = new Padding(4, 0, 4, 0);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(75, 15);
            labelEnd.TabIndex = 2;
            labelEnd.Text = "Конец шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(12, 43);
            textBoxStart.Margin = new Padding(4, 3, 4, 3);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(116, 23);
            textBoxStart.TabIndex = 1;
            textBoxStart.Text = "-5";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(8, 23);
            labelStart.Margin = new Padding(4, 0, 4, 0);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(72, 15);
            labelStart.TabIndex = 0;
            labelStart.Text = "Старт шага:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(groupBoxTextCondition);
            groupBox1.Location = new Point(4, 3);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(464, 84);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // groupBoxTextCondition
            // 
            groupBoxTextCondition.Controls.Add(label1);
            groupBoxTextCondition.Location = new Point(12, 22);
            groupBoxTextCondition.Margin = new Padding(4, 3, 4, 3);
            groupBoxTextCondition.Name = "groupBoxTextCondition";
            groupBoxTextCondition.Padding = new Padding(4, 3, 4, 3);
            groupBoxTextCondition.Size = new Size(442, 61);
            groupBoxTextCondition.TabIndex = 0;
            groupBoxTextCondition.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(8, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(412, 47);
            label1.TabIndex = 0;
            label1.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.Результат вывести в textBox, построить график функции и сохранить\r\nв файл OutPutFileTask.txt по нажатию.";
            // 
            // panelLeft
            // 
            panelLeft.BackColor = SystemColors.ControlLight;
            panelLeft.Controls.Add(groupBox3);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 93);
            panelLeft.Margin = new Padding(4, 3, 4, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(6);
            panelLeft.Size = new Size(282, 486);
            panelLeft.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLight;
            groupBox3.Controls.Add(textBoxResult);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(6, 6);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(270, 474);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод";
            // 
            // textBoxResult
            // 
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(4, 19);
            textBoxResult.Margin = new Padding(4, 3, 4, 3);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(262, 452);
            textBoxResult.TabIndex = 0;
            // 
            // panelGraphic
            // 
            panelGraphic.BackColor = SystemColors.ControlLight;
            panelGraphic.Controls.Add(chartResult);
            panelGraphic.Dock = DockStyle.Fill;
            panelGraphic.Location = new Point(282, 93);
            panelGraphic.Margin = new Padding(4, 3, 4, 3);
            panelGraphic.Name = "panelGraphic";
            panelGraphic.Size = new Size(758, 486);
            panelGraphic.TabIndex = 2;
            // 
            // chartResult
            // 
            chartArea2.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea2);
            chartResult.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartResult.Legends.Add(legend2);
            chartResult.Location = new Point(0, 0);
            chartResult.Margin = new Padding(4, 3, 4, 3);
            chartResult.Name = "chartResult";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartResult.Series.Add(series2);
            chartResult.Size = new Size(758, 486);
            chartResult.TabIndex = 0;
            chartResult.Text = "chartFunction";
            title2.Name = "Title1";
            title2.Text = "График функции";
            chartResult.Titles.Add(title2);
            // 
            // splitter1
            // 
            splitter1.Location = new Point(282, 93);
            splitter1.Margin = new Padding(4, 3, 4, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 486);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 579);
            Controls.Add(splitter1);
            Controls.Add(panelGraphic);
            Controls.Add(panelLeft);
            Controls.Add(panelCondition);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(931, 513);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 2 | Шиндин Д. Н.";
            panelCondition.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBoxTextCondition.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panelGraphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelCondition;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelGraphic;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxTextCondition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
    }
}
