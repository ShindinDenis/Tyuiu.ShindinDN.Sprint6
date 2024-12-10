namespace Tyuiu.ShindinDN.Sprint6.Task1.V7
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
            GroupBox = new GroupBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBoxStopStep = new TextBox();
            label4 = new Label();
            textBoxStartStep = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            textBoxResult = new TextBox();
            label3 = new Label();
            buttonHelp = new Button();
            ButtonDone = new Button();
            GroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(label1);
            GroupBox.Location = new Point(13, 30);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(374, 226);
            GroupBox.TabIndex = 0;
            GroupBox.TabStop = false;
            GroupBox.Text = "Условие";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(320, 62);
            label1.TabIndex = 2;
            label1.Text = "Потабулировать функцию ((2x-3)/cos(x)+x)+5 на заданном диапазоне. Результат вывести в виде таблице.";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxStopStep);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxStartStep);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(19, 262);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 77);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(153, 48);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(103, 23);
            textBoxStopStep.TabIndex = 3;
            textBoxStopStep.Text = "5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(153, 21);
            label4.Name = "label4";
            label4.Size = new Size(85, 19);
            label4.TabIndex = 2;
            label4.Text = "Конец шага:";
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(11, 52);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(103, 23);
            textBoxStartStep.TabIndex = 1;
            textBoxStartStep.Text = "-5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(11, 21);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 0;
            label2.Text = "Старт шага:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(393, 42);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(207, 214);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 10F);
            textBoxResult.Location = new Point(6, 46);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(195, 162);
            textBoxResult.TabIndex = 1;
            textBoxResult.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(9, 24);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 0;
            label3.Text = "Результат:";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.Highlight;
            buttonHelp.Font = new Font("Segoe UI", 10F);
            buttonHelp.Location = new Point(310, 274);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(94, 65);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            // 
            // ButtonDone
            // 
            ButtonDone.BackColor = Color.FromArgb(0, 64, 0);
            ButtonDone.Font = new Font("Segoe UI", 10F);
            ButtonDone.Location = new Point(410, 274);
            ButtonDone.Name = "ButtonDone";
            ButtonDone.Size = new Size(116, 63);
            ButtonDone.TabIndex = 4;
            ButtonDone.Text = "Выполнить";
            ButtonDone.UseVisualStyleBackColor = false;
            ButtonDone.Click += buttonDone_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 386);
            Controls.Add(ButtonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(GroupBox);
            Name = "Form1";
            Text = "Спринт 6 | Таск 1 | Вариант 7 | Шиндин Д.Н";
            GroupBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBox;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBoxStartStep;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox textBoxResult;
        private Label label3;
        private Button buttonHelp;
        private Button ButtonDone;
        private TextBox textBoxStopStep;
        private Label label4;

    }
}
