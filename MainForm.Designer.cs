namespace Keywords
{
    partial class MainForm
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
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.dataGridViewWords = new System.Windows.Forms.DataGridView();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxSourceFile = new System.Windows.Forms.GroupBox();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelRes = new System.Windows.Forms.Label();
            this.labelResText = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelWordsUniqueCount = new System.Windows.Forms.Label();
            this.labelWordsTotalCount = new System.Windows.Forms.Label();
            this.labelWordsUnique = new System.Windows.Forms.Label();
            this.labelWordsTotal = new System.Windows.Forms.Label();
            this.panelCover = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.groupBoxOtherSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxDeleteNumbers = new System.Windows.Forms.CheckBox();
            this.radioButtonOff = new System.Windows.Forms.RadioButton();
            this.radioButtonOn = new System.Windows.Forms.RadioButton();
            this.buttonBlacklistDefault = new System.Windows.Forms.Button();
            this.checkBoxBlacklist = new System.Windows.Forms.CheckBox();
            this.richTextBoxBlacklist = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).BeginInit();
            this.groupBoxSourceFile.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.panelCover.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxOtherSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(6, 19);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(104, 39);
            this.buttonOpenFile.TabIndex = 5;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Enabled = false;
            this.textBoxFilePath.Location = new System.Drawing.Point(120, 32);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(136, 20);
            this.textBoxFilePath.TabIndex = 6;
            // 
            // openFile
            // 
            this.openFile.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // textArea
            // 
            this.textArea.Enabled = false;
            this.textArea.Location = new System.Drawing.Point(9, 90);
            this.textArea.Name = "textArea";
            this.textArea.ReadOnly = true;
            this.textArea.Size = new System.Drawing.Size(357, 274);
            this.textArea.TabIndex = 7;
            this.textArea.Text = "";
            // 
            // dataGridViewWords
            // 
            this.dataGridViewWords.AllowUserToAddRows = false;
            this.dataGridViewWords.AllowUserToDeleteRows = false;
            this.dataGridViewWords.AllowUserToResizeColumns = false;
            this.dataGridViewWords.AllowUserToResizeRows = false;
            this.dataGridViewWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewWords.Location = new System.Drawing.Point(6, 90);
            this.dataGridViewWords.Name = "dataGridViewWords";
            this.dataGridViewWords.ReadOnly = true;
            this.dataGridViewWords.RowHeadersVisible = false;
            this.dataGridViewWords.Size = new System.Drawing.Size(321, 214);
            this.dataGridViewWords.TabIndex = 8;
            // 
            // buttonProcess
            // 
            this.buttonProcess.Enabled = false;
            this.buttonProcess.Location = new System.Drawing.Point(262, 19);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(104, 39);
            this.buttonProcess.TabIndex = 12;
            this.buttonProcess.Text = "Обработать файл";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(153, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Адрес файла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Исходный текст";
            // 
            // groupBoxSourceFile
            // 
            this.groupBoxSourceFile.Controls.Add(this.textArea);
            this.groupBoxSourceFile.Controls.Add(this.buttonProcess);
            this.groupBoxSourceFile.Controls.Add(this.label1);
            this.groupBoxSourceFile.Controls.Add(this.label2);
            this.groupBoxSourceFile.Controls.Add(this.buttonOpenFile);
            this.groupBoxSourceFile.Controls.Add(this.textBoxFilePath);
            this.groupBoxSourceFile.Location = new System.Drawing.Point(12, 33);
            this.groupBoxSourceFile.Name = "groupBoxSourceFile";
            this.groupBoxSourceFile.Size = new System.Drawing.Size(372, 375);
            this.groupBoxSourceFile.TabIndex = 15;
            this.groupBoxSourceFile.TabStop = false;
            this.groupBoxSourceFile.Text = "Исходный файл";
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.buttonSave);
            this.groupBoxResults.Controls.Add(this.label4);
            this.groupBoxResults.Controls.Add(this.buttonForward);
            this.groupBoxResults.Controls.Add(this.buttonBack);
            this.groupBoxResults.Controls.Add(this.labelRes);
            this.groupBoxResults.Controls.Add(this.labelResText);
            this.groupBoxResults.Controls.Add(this.buttonSearch);
            this.groupBoxResults.Controls.Add(this.textBoxSearch);
            this.groupBoxResults.Controls.Add(this.labelWordsUniqueCount);
            this.groupBoxResults.Controls.Add(this.labelWordsTotalCount);
            this.groupBoxResults.Controls.Add(this.labelWordsUnique);
            this.groupBoxResults.Controls.Add(this.labelWordsTotal);
            this.groupBoxResults.Controls.Add(this.dataGridViewWords);
            this.groupBoxResults.Enabled = false;
            this.groupBoxResults.Location = new System.Drawing.Point(633, 33);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(338, 375);
            this.groupBoxResults.TabIndex = 16;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Результаты";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(240, 19);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 40);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Сохранить результаты";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Поиск по результатам";
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(187, 61);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(27, 23);
            this.buttonForward.TabIndex = 18;
            this.buttonForward.Text = ">";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Visible = false;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(139, 61);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(27, 23);
            this.buttonBack.TabIndex = 17;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(90, 66);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(13, 13);
            this.labelRes.TabIndex = 16;
            this.labelRes.Text = "0";
            this.labelRes.Visible = false;
            // 
            // labelResText
            // 
            this.labelResText.AutoSize = true;
            this.labelResText.Location = new System.Drawing.Point(30, 66);
            this.labelResText.Name = "labelResText";
            this.labelResText.Size = new System.Drawing.Size(54, 13);
            this.labelResText.TabIndex = 15;
            this.labelResText.Text = "Найдено:";
            this.labelResText.Visible = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(139, 35);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 24);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(9, 38);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(124, 20);
            this.textBoxSearch.TabIndex = 13;
            // 
            // labelWordsUniqueCount
            // 
            this.labelWordsUniqueCount.AutoSize = true;
            this.labelWordsUniqueCount.Location = new System.Drawing.Point(151, 339);
            this.labelWordsUniqueCount.Name = "labelWordsUniqueCount";
            this.labelWordsUniqueCount.Size = new System.Drawing.Size(13, 13);
            this.labelWordsUniqueCount.TabIndex = 12;
            this.labelWordsUniqueCount.Text = "0";
            this.labelWordsUniqueCount.Visible = false;
            // 
            // labelWordsTotalCount
            // 
            this.labelWordsTotalCount.AutoSize = true;
            this.labelWordsTotalCount.Location = new System.Drawing.Point(151, 316);
            this.labelWordsTotalCount.Name = "labelWordsTotalCount";
            this.labelWordsTotalCount.Size = new System.Drawing.Size(13, 13);
            this.labelWordsTotalCount.TabIndex = 11;
            this.labelWordsTotalCount.Text = "0";
            this.labelWordsTotalCount.Visible = false;
            // 
            // labelWordsUnique
            // 
            this.labelWordsUnique.AutoSize = true;
            this.labelWordsUnique.Location = new System.Drawing.Point(6, 339);
            this.labelWordsUnique.Name = "labelWordsUnique";
            this.labelWordsUnique.Size = new System.Drawing.Size(130, 13);
            this.labelWordsUnique.TabIndex = 10;
            this.labelWordsUnique.Text = "Всего уникальных слов:";
            this.labelWordsUnique.Visible = false;
            // 
            // labelWordsTotal
            // 
            this.labelWordsTotal.AutoSize = true;
            this.labelWordsTotal.Location = new System.Drawing.Point(6, 316);
            this.labelWordsTotal.Name = "labelWordsTotal";
            this.labelWordsTotal.Size = new System.Drawing.Size(67, 13);
            this.labelWordsTotal.TabIndex = 9;
            this.labelWordsTotal.Text = "Всего слов:";
            this.labelWordsTotal.Visible = false;
            // 
            // panelCover
            // 
            this.panelCover.Controls.Add(this.label3);
            this.panelCover.Controls.Add(this.progressBar1);
            this.panelCover.Location = new System.Drawing.Point(0, 22);
            this.panelCover.Name = "panelCover";
            this.panelCover.Size = new System.Drawing.Size(983, 386);
            this.panelCover.TabIndex = 15;
            this.panelCover.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Пожалуйста, подождите...";
            this.label3.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(436, 196);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorkspaceToolStripMenuItem,
            this.openWorkspaceToolStripMenuItem,
            this.saveWorkspaceToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // newWorkspaceToolStripMenuItem
            // 
            this.newWorkspaceToolStripMenuItem.Name = "newWorkspaceToolStripMenuItem";
            this.newWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.newWorkspaceToolStripMenuItem.Text = "Новое рабочее пространство";
            this.newWorkspaceToolStripMenuItem.Click += new System.EventHandler(this.newWorkspaceToolStripMenuItem_Click);
            // 
            // openWorkspaceToolStripMenuItem
            // 
            this.openWorkspaceToolStripMenuItem.Name = "openWorkspaceToolStripMenuItem";
            this.openWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.openWorkspaceToolStripMenuItem.Text = "Открыть рабочее пространство";
            this.openWorkspaceToolStripMenuItem.Click += new System.EventHandler(this.openWorkspaceToolStripMenuItem_Click);
            // 
            // saveWorkspaceToolStripMenuItem
            // 
            this.saveWorkspaceToolStripMenuItem.Name = "saveWorkspaceToolStripMenuItem";
            this.saveWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.saveWorkspaceToolStripMenuItem.Text = "Сохранить рабочее пространство";
            this.saveWorkspaceToolStripMenuItem.Click += new System.EventHandler(this.saveWorkspaceToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.closeToolStripMenuItem.Text = "Закрыть";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "results.csv";
            this.saveFileDialog1.Filter = "CSV-файл|*.csv";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.groupBoxOtherSettings);
            this.groupBoxSettings.Controls.Add(this.buttonBlacklistDefault);
            this.groupBoxSettings.Controls.Add(this.checkBoxBlacklist);
            this.groupBoxSettings.Controls.Add(this.richTextBoxBlacklist);
            this.groupBoxSettings.Enabled = false;
            this.groupBoxSettings.Location = new System.Drawing.Point(390, 33);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(240, 375);
            this.groupBoxSettings.TabIndex = 18;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Настройки";
            // 
            // groupBoxOtherSettings
            // 
            this.groupBoxOtherSettings.Controls.Add(this.checkBoxDeleteNumbers);
            this.groupBoxOtherSettings.Controls.Add(this.radioButtonOff);
            this.groupBoxOtherSettings.Controls.Add(this.radioButtonOn);
            this.groupBoxOtherSettings.Location = new System.Drawing.Point(6, 245);
            this.groupBoxOtherSettings.Name = "groupBoxOtherSettings";
            this.groupBoxOtherSettings.Size = new System.Drawing.Size(226, 119);
            this.groupBoxOtherSettings.TabIndex = 10;
            this.groupBoxOtherSettings.TabStop = false;
            this.groupBoxOtherSettings.Text = "Другие настройки";
            // 
            // checkBoxDeleteNumbers
            // 
            this.checkBoxDeleteNumbers.AutoSize = true;
            this.checkBoxDeleteNumbers.Location = new System.Drawing.Point(6, 90);
            this.checkBoxDeleteNumbers.Name = "checkBoxDeleteNumbers";
            this.checkBoxDeleteNumbers.Size = new System.Drawing.Size(101, 17);
            this.checkBoxDeleteNumbers.TabIndex = 2;
            this.checkBoxDeleteNumbers.Text = "Удалить числа";
            this.checkBoxDeleteNumbers.UseVisualStyleBackColor = true;
            this.checkBoxDeleteNumbers.CheckedChanged += new System.EventHandler(this.checkBoxDeleteNumbers_CheckedChanged);
            // 
            // radioButtonOff
            // 
            this.radioButtonOff.AutoSize = true;
            this.radioButtonOff.Location = new System.Drawing.Point(6, 42);
            this.radioButtonOff.Name = "radioButtonOff";
            this.radioButtonOff.Size = new System.Drawing.Size(134, 17);
            this.radioButtonOff.TabIndex = 1;
            this.radioButtonOff.TabStop = true;
            this.radioButtonOff.Text = "Не лемматизировать";
            this.radioButtonOff.UseVisualStyleBackColor = true;
            this.radioButtonOff.CheckedChanged += new System.EventHandler(this.radioButtonOff_CheckedChanged);
            // 
            // radioButtonOn
            // 
            this.radioButtonOn.AutoSize = true;
            this.radioButtonOn.Location = new System.Drawing.Point(6, 19);
            this.radioButtonOn.Name = "radioButtonOn";
            this.radioButtonOn.Size = new System.Drawing.Size(119, 17);
            this.radioButtonOn.TabIndex = 0;
            this.radioButtonOn.TabStop = true;
            this.radioButtonOn.Text = "Лемматизировать";
            this.radioButtonOn.UseVisualStyleBackColor = true;
            this.radioButtonOn.CheckedChanged += new System.EventHandler(this.radioButtonOn_CheckedChanged);
            // 
            // buttonBlacklistDefault
            // 
            this.buttonBlacklistDefault.Location = new System.Drawing.Point(6, 214);
            this.buttonBlacklistDefault.Name = "buttonBlacklistDefault";
            this.buttonBlacklistDefault.Size = new System.Drawing.Size(226, 23);
            this.buttonBlacklistDefault.TabIndex = 6;
            this.buttonBlacklistDefault.Text = "По умолчанию";
            this.buttonBlacklistDefault.UseVisualStyleBackColor = true;
            this.buttonBlacklistDefault.Click += new System.EventHandler(this.buttonBlacklistStandardDefault_Click);
            // 
            // checkBoxBlacklist
            // 
            this.checkBoxBlacklist.AutoSize = true;
            this.checkBoxBlacklist.Checked = true;
            this.checkBoxBlacklist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBlacklist.Location = new System.Drawing.Point(6, 18);
            this.checkBoxBlacklist.Name = "checkBoxBlacklist";
            this.checkBoxBlacklist.Size = new System.Drawing.Size(105, 17);
            this.checkBoxBlacklist.TabIndex = 3;
            this.checkBoxBlacklist.Text = "Черный список";
            this.checkBoxBlacklist.UseVisualStyleBackColor = true;
            this.checkBoxBlacklist.CheckedChanged += new System.EventHandler(this.checkBoxBlacklistStandard_CheckedChanged);
            // 
            // richTextBoxBlacklist
            // 
            this.richTextBoxBlacklist.Location = new System.Drawing.Point(6, 42);
            this.richTextBoxBlacklist.Name = "richTextBoxBlacklist";
            this.richTextBoxBlacklist.Size = new System.Drawing.Size(226, 166);
            this.richTextBoxBlacklist.TabIndex = 2;
            this.richTextBoxBlacklist.Text = "";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileName = "workspace";
            this.saveFileDialog2.Filter = "Рабочее пространство Keywords|*.kws";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Рабочее пространство Keywords|*.kws";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 414);
            this.Controls.Add(this.panelCover);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.groupBoxSourceFile);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Keywords";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).EndInit();
            this.groupBoxSourceFile.ResumeLayout(false);
            this.groupBoxSourceFile.PerformLayout();
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.panelCover.ResumeLayout(false);
            this.panelCover.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxOtherSettings.ResumeLayout(false);
            this.groupBoxOtherSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.RichTextBox textArea;
        private System.Windows.Forms.DataGridView dataGridViewWords;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxSourceFile;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelCover;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWordsTotal;
        private System.Windows.Forms.Label labelWordsTotalCount;
        private System.Windows.Forms.Label labelWordsUnique;
        private System.Windows.Forms.Label labelWordsUniqueCount;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelResText;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.RichTextBox richTextBoxBlacklist;
        private System.Windows.Forms.CheckBox checkBoxBlacklist;
        private System.Windows.Forms.Button buttonBlacklistDefault;
        private System.Windows.Forms.GroupBox groupBoxOtherSettings;
        private System.Windows.Forms.RadioButton radioButtonOff;
        private System.Windows.Forms.RadioButton radioButtonOn;
        private System.Windows.Forms.CheckBox checkBoxDeleteNumbers;
        private System.Windows.Forms.ToolStripMenuItem openWorkspaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWorkspaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWorkspaceToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

