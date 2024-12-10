namespace Tyuiu.ShindinDN.Sprint6.Task0.V4
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            GroupBox = new GroupBox();
            label1 = new Label();
            pictureBoxNamedOne_SDN = new PictureBox();
            groupBox1 = new GroupBox();
            textBoxVarX = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            textBoxResult = new TextBox();
            label3 = new Label();
            buttonHelp = new Button();
            ButtonDone = new Button();
            GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNamedOne_SDN).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(label1);
            GroupBox.Controls.Add(pictureBoxNamedOne_SDN);
            GroupBox.Location = new Point(13, 30);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(593, 199);
            GroupBox.TabIndex = 0;
            GroupBox.TabStop = false;
            GroupBox.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(234, 19);
            label1.TabIndex = 2;
            label1.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxNamedOne_SDN
            // 
            pictureBoxNamedOne_SDN.Image = (Image)resources.GetObject("pictureBoxNamedOne_SDN.Image");
            pictureBoxNamedOne_SDN.Location = new Point(253, 22);
            pictureBoxNamedOne_SDN.Name = "pictureBoxNamedOne_SDN";
            pictureBoxNamedOne_SDN.Size = new Size(334, 28);
            pictureBoxNamedOne_SDN.TabIndex = 0;
            pictureBoxNamedOne_SDN.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxVarX);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(19, 262);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 81);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(11, 52);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(103, 23);
            textBoxVarX.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(11, 21);
            label2.Name = "label2";
            label2.Size = new Size(103, 19);
            label2.TabIndex = 0;
            label2.Text = "Переменная X:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(302, 262);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(304, 81);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 52);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(292, 23);
            textBoxResult.TabIndex = 1;
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
            buttonHelp.Font = new Font("Segoe UI", 10F);
            buttonHelp.Location = new Point(449, 349);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(37, 34);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // ButtonDone
            // 
            ButtonDone.Font = new Font("Segoe UI", 10F);
            ButtonDone.Location = new Point(493, 349);
            ButtonDone.Name = "ButtonDone";
            ButtonDone.Size = new Size(107, 34);
            ButtonDone.TabIndex = 4;
            ButtonDone.Text = "Выполнить";
            ButtonDone.UseVisualStyleBackColor = true;
            ButtonDone.Click += ButtonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 386);
            Controls.Add(ButtonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(GroupBox);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 4 | Шиндин Д.Н";
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNamedOne_SDN).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBox;
        private PictureBox pictureBoxNamedOne_SDN;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBoxVarX;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox textBoxResult;
        private Label label3;
        private Button buttonHelp;
        private Button ButtonDone;
    }
}
