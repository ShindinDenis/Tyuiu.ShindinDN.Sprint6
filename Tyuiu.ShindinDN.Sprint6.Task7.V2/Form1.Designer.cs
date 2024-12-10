namespace Tyuiu.ShindinDN.Sprint6.Task7.V2
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
            panelButtons_SAS = new Panel();
            buttonHelp = new Button();
            buttonSaveFile = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            panelCondition_SAS = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            panelInPut_SAS = new Panel();
            groupBoxInPut = new GroupBox();
            dataGridViewIn = new DataGridView();
            splitterInPut_SAS = new Splitter();
            panelOutPut_SAS = new Panel();
            splitterOutPut_SAS = new Splitter();
            groupBoxOut = new GroupBox();
            dataGridViewOut = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            toolTipButton = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            panelButtons_SAS.SuspendLayout();
            panelCondition_SAS.SuspendLayout();
            groupBox1.SuspendLayout();
            panelInPut_SAS.SuspendLayout();
            groupBoxInPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            panelOutPut_SAS.SuspendLayout();
            groupBoxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_SAS
            // 
            panelButtons_SAS.Controls.Add(buttonHelp);
            panelButtons_SAS.Controls.Add(buttonSaveFile);
            panelButtons_SAS.Controls.Add(buttonDone);
            panelButtons_SAS.Controls.Add(buttonOpenFile);
            panelButtons_SAS.Dock = DockStyle.Top;
            panelButtons_SAS.Location = new Point(0, 0);
            panelButtons_SAS.Name = "panelButtons_SAS";
            panelButtons_SAS.Size = new Size(1030, 82);
            panelButtons_SAS.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Image = Properties.Resources.information;
            buttonHelp.Location = new Point(949, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(79, 68);
            buttonHelp.TabIndex = 0;
            toolTipButton.SetToolTip(buttonHelp, "Сведение о программе\r\n");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            buttonHelp.MouseEnter += buttonHelp_MouseEnter;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Enabled = false;
            buttonSaveFile.FlatStyle = FlatStyle.Flat;
            buttonSaveFile.Image = Properties.Resources.page_save;
            buttonSaveFile.Location = new Point(179, 12);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(79, 68);
            buttonSaveFile.TabIndex = 0;
            toolTipButton.SetToolTip(buttonSaveFile, "Сохранит результат в файле OutPutFileTask7.csv\r\n\r\n");
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            buttonSaveFile.MouseEnter += buttonSaveFile_MouseEnter;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Image = Properties.Resources.page_white_go;
            buttonDone.Location = new Point(95, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(79, 68);
            buttonDone.TabIndex = 0;
            toolTipButton.SetToolTip(buttonDone, "Меняет во второй строке четные числа на 555\r\n");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Image = Properties.Resources.folder_page;
            buttonOpenFile.Location = new Point(11, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(79, 68);
            buttonOpenFile.TabIndex = 0;
            toolTipButton.SetToolTip(buttonOpenFile, "Выберите нужный файл для обработки\r\n");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            buttonOpenFile.MouseEnter += buttonOpenFile_MouseEnter;
            // 
            // panelCondition_SAS
            // 
            panelCondition_SAS.Controls.Add(groupBox1);
            panelCondition_SAS.Dock = DockStyle.Top;
            panelCondition_SAS.Location = new Point(0, 82);
            panelCondition_SAS.Name = "panelCondition_SAS";
            panelCondition_SAS.Size = new Size(1030, 86);
            panelCondition_SAS.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(11, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1008, 77);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(6, 21);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(997, 56);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelInPut_SAS
            // 
            panelInPut_SAS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelInPut_SAS.Controls.Add(groupBoxInPut);
            panelInPut_SAS.Controls.Add(splitterInPut_SAS);
            panelInPut_SAS.Location = new Point(0, 175);
            panelInPut_SAS.Name = "panelInPut_SAS";
            panelInPut_SAS.Size = new Size(508, 328);
            panelInPut_SAS.TabIndex = 2;
            // 
            // groupBoxInPut
            // 
            groupBoxInPut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInPut.Controls.Add(dataGridViewIn);
            groupBoxInPut.Location = new Point(18, 7);
            groupBoxInPut.Name = "groupBoxInPut";
            groupBoxInPut.Size = new Size(487, 319);
            groupBoxInPut.TabIndex = 1;
            groupBoxInPut.TabStop = false;
            groupBoxInPut.Text = "Ввод:";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.ColumnHeadersVisible = false;
            dataGridViewIn.Location = new Point(6, 21);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.ReadOnly = true;
            dataGridViewIn.RowHeadersVisible = false;
            dataGridViewIn.RowHeadersWidth = 51;
            dataGridViewIn.RowTemplate.Height = 24;
            dataGridViewIn.Size = new Size(481, 298);
            dataGridViewIn.TabIndex = 0;
            // 
            // splitterInPut_SAS
            // 
            splitterInPut_SAS.Location = new Point(0, 0);
            splitterInPut_SAS.Name = "splitterInPut_SAS";
            splitterInPut_SAS.Size = new Size(3, 328);
            splitterInPut_SAS.TabIndex = 0;
            splitterInPut_SAS.TabStop = false;
            // 
            // panelOutPut_SAS
            // 
            panelOutPut_SAS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelOutPut_SAS.Controls.Add(splitterOutPut_SAS);
            panelOutPut_SAS.Controls.Add(groupBoxOut);
            panelOutPut_SAS.Location = new Point(510, 172);
            panelOutPut_SAS.Name = "panelOutPut_SAS";
            panelOutPut_SAS.Size = new Size(518, 341);
            panelOutPut_SAS.TabIndex = 3;
            // 
            // splitterOutPut_SAS
            // 
            splitterOutPut_SAS.Location = new Point(0, 0);
            splitterOutPut_SAS.Name = "splitterOutPut_SAS";
            splitterOutPut_SAS.Size = new Size(3, 341);
            splitterOutPut_SAS.TabIndex = 1;
            splitterOutPut_SAS.TabStop = false;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxOut.Controls.Add(dataGridViewOut);
            groupBoxOut.Location = new Point(4, 7);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(514, 332);
            groupBoxOut.TabIndex = 0;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод:";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.ColumnHeadersVisible = false;
            dataGridViewOut.Location = new Point(6, 21);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.ReadOnly = true;
            dataGridViewOut.RowHeadersVisible = false;
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.RowTemplate.Height = 24;
            dataGridViewOut.Size = new Size(508, 301);
            dataGridViewOut.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask_SAS";
            // 
            // toolTipButton
            // 
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 513);
            Controls.Add(panelOutPut_SAS);
            Controls.Add(panelInPut_SAS);
            Controls.Add(panelCondition_SAS);
            Controls.Add(panelButtons_SAS);
            MinimumSize = new Size(1046, 552);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 2 | Шиндин Д.Н";
            Load += Form1_Load;
            panelButtons_SAS.ResumeLayout(false);
            panelCondition_SAS.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelInPut_SAS.ResumeLayout(false);
            groupBoxInPut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            panelOutPut_SAS.ResumeLayout(false);
            groupBoxOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_SAS;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Panel panelCondition_SAS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelInPut_SAS;
        private System.Windows.Forms.GroupBox groupBoxInPut;
        private System.Windows.Forms.DataGridView dataGridViewIn;
        private System.Windows.Forms.Splitter splitterInPut_SAS;
        private System.Windows.Forms.Panel panelOutPut_SAS;
        private System.Windows.Forms.GroupBox groupBoxOut;
        private System.Windows.Forms.DataGridView dataGridViewOut;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
        private System.Windows.Forms.Splitter splitterOutPut_SAS;
    }
}
