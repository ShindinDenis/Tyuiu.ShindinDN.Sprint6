namespace Tyuiu.ShindinDN.Sprint6.Task6.V6
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelTools_NVI = new Panel();
            buttonFindFile = new Button();
            buttonDone = new Button();
            buttonForm2 = new Button();
            groupBoxInfo2 = new GroupBox();
            textBoxOut = new TextBox();
            groupBox2 = new GroupBox();
            textBoxIn = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTipHelp = new ToolTip(components);
            panelQuestion_NVI = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            splitContainerTask_NVI = new SplitContainer();
            panelTools_NVI.SuspendLayout();
            groupBoxInfo2.SuspendLayout();
            groupBox2.SuspendLayout();
            panelQuestion_NVI.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerTask_NVI).BeginInit();
            splitContainerTask_NVI.Panel1.SuspendLayout();
            splitContainerTask_NVI.Panel2.SuspendLayout();
            splitContainerTask_NVI.SuspendLayout();
            SuspendLayout();
            // 
            // panelTools_NVI
            // 
            panelTools_NVI.BackColor = SystemColors.ControlLight;
            panelTools_NVI.Controls.Add(buttonFindFile);
            panelTools_NVI.Controls.Add(buttonDone);
            panelTools_NVI.Controls.Add(buttonForm2);
            panelTools_NVI.Dock = DockStyle.Top;
            panelTools_NVI.Location = new Point(0, 0);
            panelTools_NVI.Margin = new Padding(3, 2, 3, 2);
            panelTools_NVI.Name = "panelTools_NVI";
            panelTools_NVI.Padding = new Padding(3, 2, 3, 2);
            panelTools_NVI.Size = new Size(831, 72);
            panelTools_NVI.TabIndex = 0;
            // 
            // buttonFindFile
            // 
            buttonFindFile.BackColor = SystemColors.Control;
            buttonFindFile.BackgroundImageLayout = ImageLayout.Zoom;
            buttonFindFile.Cursor = Cursors.Hand;
            buttonFindFile.FlatStyle = FlatStyle.Flat;
            buttonFindFile.Image = Properties.Resources.folder_page;
            buttonFindFile.Location = new Point(5, 4);
            buttonFindFile.Margin = new Padding(3, 2, 3, 2);
            buttonFindFile.Name = "buttonFindFile";
            buttonFindFile.Size = new Size(107, 63);
            buttonFindFile.TabIndex = 0;
            toolTipHelp.SetToolTip(buttonFindFile, "Выбрать файл для вводных данных");
            buttonFindFile.UseVisualStyleBackColor = false;
            buttonFindFile.Click += buttonFindFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.Control;
            buttonDone.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone.Cursor = Cursors.Hand;
            buttonDone.Enabled = false;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Image = Properties.Resources.page_white_go;
            buttonDone.Location = new Point(117, 4);
            buttonDone.Margin = new Padding(3, 2, 3, 2);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(107, 63);
            buttonDone.TabIndex = 0;
            toolTipHelp.SetToolTip(buttonDone, "Провести действие и вывести результат");
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonForm2
            // 
            buttonForm2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonForm2.BackgroundImageLayout = ImageLayout.Zoom;
            buttonForm2.FlatStyle = FlatStyle.Flat;
            buttonForm2.Image = Properties.Resources.information;
            buttonForm2.Location = new Point(743, 4);
            buttonForm2.Margin = new Padding(3, 2, 3, 2);
            buttonForm2.Name = "buttonForm2";
            buttonForm2.Size = new Size(82, 63);
            buttonForm2.TabIndex = 0;
            toolTipHelp.SetToolTip(buttonForm2, "Нажмите, чтобы узнать о разработчике программы");
            buttonForm2.UseVisualStyleBackColor = true;
            buttonForm2.Click += buttonFormAbout_Click;
            // 
            // groupBoxInfo2
            // 
            groupBoxInfo2.Controls.Add(textBoxOut);
            groupBoxInfo2.Dock = DockStyle.Fill;
            groupBoxInfo2.Location = new Point(3, 3);
            groupBoxInfo2.Margin = new Padding(3, 2, 3, 2);
            groupBoxInfo2.Name = "groupBoxInfo2";
            groupBoxInfo2.Padding = new Padding(3, 2, 3, 2);
            groupBoxInfo2.Size = new Size(406, 249);
            groupBoxInfo2.TabIndex = 2;
            groupBoxInfo2.TabStop = false;
            groupBoxInfo2.Text = "Вывод";
            // 
            // textBoxOut
            // 
            textBoxOut.Dock = DockStyle.Fill;
            textBoxOut.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxOut.Location = new Point(3, 18);
            textBoxOut.Margin = new Padding(3, 2, 3, 2);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ReadOnly = true;
            textBoxOut.ScrollBars = ScrollBars.Both;
            textBoxOut.Size = new Size(400, 229);
            textBoxOut.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxIn);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(409, 249);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод";
            // 
            // textBoxIn
            // 
            textBoxIn.Dock = DockStyle.Fill;
            textBoxIn.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxIn.Location = new Point(3, 18);
            textBoxIn.Margin = new Padding(3, 2, 3, 2);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.ReadOnly = true;
            textBoxIn.ScrollBars = ScrollBars.Both;
            textBoxIn.Size = new Size(403, 229);
            textBoxIn.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTipHelp
            // 
            toolTipHelp.ToolTipTitle = "Подсказка";
            // 
            // panelQuestion_NVI
            // 
            panelQuestion_NVI.Controls.Add(groupBox1);
            panelQuestion_NVI.Dock = DockStyle.Top;
            panelQuestion_NVI.Location = new Point(0, 72);
            panelQuestion_NVI.Name = "panelQuestion_NVI";
            panelQuestion_NVI.Size = new Size(831, 67);
            panelQuestion_NVI.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(831, 67);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 18);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(825, 47);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // splitContainerTask_NVI
            // 
            splitContainerTask_NVI.BackColor = SystemColors.ActiveCaption;
            splitContainerTask_NVI.Dock = DockStyle.Fill;
            splitContainerTask_NVI.Location = new Point(0, 139);
            splitContainerTask_NVI.Name = "splitContainerTask_NVI";
            // 
            // splitContainerTask_NVI.Panel1
            // 
            splitContainerTask_NVI.Panel1.Controls.Add(groupBox2);
            splitContainerTask_NVI.Panel1.Padding = new Padding(3);
            // 
            // splitContainerTask_NVI.Panel2
            // 
            splitContainerTask_NVI.Panel2.Controls.Add(groupBoxInfo2);
            splitContainerTask_NVI.Panel2.Padding = new Padding(3);
            splitContainerTask_NVI.Size = new Size(831, 255);
            splitContainerTask_NVI.SplitterDistance = 415;
            splitContainerTask_NVI.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 394);
            Controls.Add(splitContainerTask_NVI);
            Controls.Add(panelQuestion_NVI);
            Controls.Add(panelTools_NVI);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(847, 433);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 6 | Шиндин Д.Н";
            panelTools_NVI.ResumeLayout(false);
            groupBoxInfo2.ResumeLayout(false);
            groupBoxInfo2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panelQuestion_NVI.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            splitContainerTask_NVI.Panel1.ResumeLayout(false);
            splitContainerTask_NVI.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerTask_NVI).EndInit();
            splitContainerTask_NVI.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTools_NVI;
        private GroupBox groupBoxInfo2;
        private GroupBox groupBox2;
        private TextBox textBoxOut;
        private TextBox textBoxIn;
        private Button buttonFindFile;
        private Button buttonDone;
        private Button buttonForm2;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipHelp;
        private Panel panelQuestion_NVI;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private SplitContainer splitContainerTask_NVI;
    }
}
