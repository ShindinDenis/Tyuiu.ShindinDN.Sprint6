namespace Tyuiu.ShindinDN.Sprint6.Task7.V2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxAvatar = new PictureBox();
            labelInfo_NVI = new Label();
            buttonOk = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxAvatar.Image = Properties.Resources.th_3696939689;
            pictureBoxAvatar.Location = new Point(10, 32);
            pictureBoxAvatar.Margin = new Padding(3, 2, 3, 2);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(119, 125);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar.TabIndex = 0;
            pictureBoxAvatar.TabStop = false;
            // 
            // labelInfo_NVI
            // 
            labelInfo_NVI.AutoSize = true;
            labelInfo_NVI.Location = new Point(150, 32);
            labelInfo_NVI.Name = "labelInfo_NVI";
            labelInfo_NVI.Size = new Size(0, 15);
            labelInfo_NVI.TabIndex = 1;
            // 
            // buttonOk
            // 
            buttonOk.FlatStyle = FlatStyle.Flat;
            buttonOk.Location = new Point(434, 178);
            buttonOk.Margin = new Padding(3, 2, 3, 2);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(82, 22);
            buttonOk.TabIndex = 2;
            buttonOk.Text = "ОК";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 32);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 3;
            label1.Text = "Разработчик: Шиндин Д.Н";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 56);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 4;
            label2.Text = "группа ИСТНБ-24-1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 82);
            label3.Name = "label3";
            label3.Size = new Size(302, 15);
            label3.TabIndex = 5;
            label3.Text = "Программа разработана в рамках изучения языка C#";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 208);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonOk);
            Controls.Add(labelInfo_NVI);
            Controls.Add(pictureBoxAvatar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar;
        private Label labelInfo_NVI;
        private Button buttonOk;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}