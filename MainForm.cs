using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using SolarixLemmatizatorEngineNET;
using System.IO;
using System.Xml;

namespace Keywords
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            proc.OnProgressUpdate += proc_OnProgressUpdate;
        }

        private void proc_OnProgressUpdate(int value)
        {
            // Its another thread so invoke back to UI thread
            base.Invoke((Action)delegate
            {
                progressBar1.Value = value;
            });
        }


        List<int> searchRes;
        int srselected;

        Processor proc = new Processor();


        private void MainForm_Load(object sender, EventArgs e)
        {
            //load default blacklist

            var fileStream = new FileStream("default_blacklist.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, System.Text.Encoding.Default))
            {
                proc.blacklistText = streamReader.ReadToEnd();
            }
            fileStream.Close();

            richTextBoxBlacklist.Text = proc.blacklistText;

            //load settings

            if (proc.lemmatize)
            {
                radioButtonOn.Checked = true;
                radioButtonOff.Checked = false;
            }
            else
            {
                radioButtonOn.Checked = false;
                radioButtonOff.Checked = true;
            }
            if (proc.deletenumbers)
            {
                checkBoxDeleteNumbers.Checked = true;
            }
            else
            {
                checkBoxDeleteNumbers.Checked = false;
            }
            if (proc.blacklistEnabled)
            {
                checkBoxBlacklist.Checked = true;
                richTextBoxBlacklist.Enabled = true;
                buttonBlacklistDefault.Enabled = true;
            }
            else
            {
                checkBoxBlacklist.Checked = false;
                richTextBoxBlacklist.Enabled = false;
                buttonBlacklistDefault.Enabled = false;
            }

        }


        private void buttonOpenFile_Click(object sender, EventArgs e)
        {

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                textBoxFilePath.Text = openFile.FileName;

                var fileStream = new FileStream(@openFile.FileName, FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, System.Text.Encoding.Default))
                {
                    proc.text = streamReader.ReadToEnd();
                }

                label1.Enabled = true;
                label2.Enabled = true;
                textArea.Enabled = true;
                textBoxFilePath.Enabled = true;
                buttonProcess.Enabled = true;
                textArea.Text = proc.text;
                groupBoxSettings.Enabled = true;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            proc.wordsList = new List<string>();
            proc.wordsCount = new List<int>();
            proc.blacklist = new List<string>();

            String[] lines = richTextBoxBlacklist.Text.Split('\n');

            foreach (string line1 in lines)
            {
                proc.blacklist.Add(line1);
            }

            label3.Visible = true;
            progressBar1.Visible = true;
            panelCover.Visible = true;

            backgroundWorker1.RunWorkerAsync();

            textBoxSearch.Text = String.Empty;
            labelRes.Visible = false;
            labelResText.Visible = false;
            buttonBack.Visible = false;
            buttonForward.Visible = false;

            newWorkspaceToolStripMenuItem.Enabled = false;
            openWorkspaceToolStripMenuItem.Enabled = false;
            saveWorkspaceToolStripMenuItem.Enabled = false;

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            proc.process();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            dataGridViewWords.Rows.Clear();

            dataGridViewWords.ColumnCount = 3;
            dataGridViewWords.Columns[0].Name = "Слово";
            dataGridViewWords.Columns[1].Name = "Количество";
            dataGridViewWords.Columns[2].Name = "Отн. частота";

            for (int i = 0; i < proc.wordsList.Count; i++)
            {
                float relfreq = (float)proc.wordsCount[i] / proc.wordsTotal;
                dataGridViewWords.Rows.Add(proc.wordsList[i], proc.wordsCount[i], relfreq);
            }

            dataGridViewWords.Sort(dataGridViewWords.Columns[1], ListSortDirection.Descending);
            label3.Visible = false;
            progressBar1.Visible = false;
            panelCover.Visible = false;
            labelWordsTotalCount.Text = proc.wordsTotal.ToString();
            labelWordsUniqueCount.Text = proc.wordsUnique.ToString();
            labelWordsTotal.Visible = true;
            labelWordsTotalCount.Visible = true;
            labelWordsUnique.Visible = true;
            labelWordsUniqueCount.Visible = true;
            groupBoxResults.Enabled = true;
            newWorkspaceToolStripMenuItem.Enabled = true;
            openWorkspaceToolStripMenuItem.Enabled = true;
            saveWorkspaceToolStripMenuItem.Enabled = true;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                string word = textBoxSearch.Text;
                searchRes = new List<int>();
                for (int i = 0; i < dataGridViewWords.RowCount; i++)
                {
                    if (dataGridViewWords.Rows[i].Cells[0].Value.ToString().Contains(word))
                    {
                        searchRes.Add(i);
                        //dataGridViewWords.CurrentCell = dataGridViewWords.Rows[i].Cells[0];
                    }
                }
                labelRes.Text = searchRes.Count.ToString();
                if (searchRes.Count != 0)
                {
                    dataGridViewWords.CurrentCell = dataGridViewWords.Rows[searchRes[0]].Cells[0];
                    buttonForward.Enabled = true;
                    buttonBack.Enabled = true;
                }
                else
                {
                    buttonForward.Enabled = false;
                    buttonBack.Enabled = false;
                }
                srselected = 0;
                labelRes.Visible = true;
                labelResText.Visible = true;
                buttonBack.Visible = true;
                buttonForward.Visible = true;
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (srselected == searchRes.Count - 1)
            {
                srselected = 0;
            }
            else
            {
                srselected++;
            }
            dataGridViewWords.CurrentCell = dataGridViewWords.Rows[searchRes[srselected]].Cells[0];
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (srselected == 0)
            {
                srselected = searchRes.Count - 1;
            }
            else
            {
                srselected--;
            }
            dataGridViewWords.CurrentCell = dataGridViewWords.Rows[searchRes[srselected]].Cells[0];
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                panelCover.Visible = true;
                if (File.Exists(saveFileDialog1.FileName))
                {
                    try
                    {
                        File.Delete(saveFileDialog1.FileName);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Не удалось сохранить файл." + ex.Message);
                    }
                }
                int columnCount = dataGridViewWords.ColumnCount;
                string columnNames = "";
                string[] output = new string[dataGridViewWords.RowCount + 1];
                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += dataGridViewWords.Columns[i].Name.ToString() + System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
                }
                output[0] += columnNames;
                for (int i = 1; (i - 1) < dataGridViewWords.RowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        output[i] += dataGridViewWords.Rows[i - 1].Cells[j].Value.ToString() + System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
                    }
                }
                System.IO.File.WriteAllLines(saveFileDialog1.FileName, output, System.Text.Encoding.Default);
                panelCover.Visible = false;
                MessageBox.Show("Файл сохранен.");
            }
        }

        private void buttonBlacklistStandardDefault_Click(object sender, EventArgs e)
        {
            var fileStream = new FileStream("default_blacklist.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, System.Text.Encoding.Default))
            {
                richTextBoxBlacklist.Text = streamReader.ReadToEnd();
            }
            fileStream.Close();

            System.IO.File.WriteAllText(@"blacklist.txt", string.Empty);
            var fileStream1 = new FileStream("blacklist.txt", FileMode.Open, FileAccess.Write);
            using (var streamWriter = new StreamWriter(fileStream1, System.Text.Encoding.Default))
            {
                for (int i = 0; i < richTextBoxBlacklist.Lines.Length; i++)
                {
                    streamWriter.WriteLine(richTextBoxBlacklist.Lines[i]);
                }
            }
            fileStream1.Close();
        }
         
        private void checkBoxBlacklistStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBlacklist.Checked == true)
            {
                proc.blacklistEnabled = true;
                richTextBoxBlacklist.Enabled = true;
                buttonBlacklistDefault.Enabled = true;
            }
            else
            {
                proc.blacklistEnabled = false;
                richTextBoxBlacklist.Enabled = false;
                buttonBlacklistDefault.Enabled = false;
            }
        }

        private void radioButtonOn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOn.Checked)
            {
                proc.lemmatize = true;
            }
            else
            {
                proc.lemmatize = false;
            }
        }

        private void radioButtonOff_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOff.Checked)
            {
                proc.lemmatize = false;
            }
            else
            {
                proc.lemmatize = true;
            }
        }

        private void checkBoxDeleteNumbers_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDeleteNumbers.Checked)
            {
                proc.deletenumbers = true;
            }
            else
            {
                proc.deletenumbers = false;
            }
        }

        private void openXML(string fileName)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fileName);

            XmlNode xn = xDoc.SelectSingleNode("/workspace/label1");
            label1.Enabled = bool.Parse(xn.Attributes["enabled"].Value.ToString());

            xn = xDoc.SelectSingleNode("/workspace/label2");
            label2.Enabled = bool.Parse(xn.Attributes["enabled"].Value.ToString());

            xn = xDoc.SelectSingleNode("/workspace/textArea");
            textArea.Enabled = bool.Parse(xn.Attributes["enabled"].Value.ToString());
            textArea.Text = xn.Attributes["text"].Value.ToString();
            proc.text = textArea.Text;

            xn = xDoc.SelectSingleNode("/workspace/textBoxFilePath");
            textBoxFilePath.Enabled = bool.Parse(xn.Attributes["enabled"].Value.ToString());
            textBoxFilePath.Text = xn.Attributes["text"].Value.ToString();

            xn = xDoc.SelectSingleNode("/workspace/buttonProcess");
            buttonProcess.Enabled = bool.Parse(xn.Attributes["enabled"].Value.ToString());

            xn = xDoc.SelectSingleNode("/workspace/groupBoxSettings");
            groupBoxSettings.Enabled = bool.Parse(xn.Attributes["enabled"].Value.ToString());

            xn = xDoc.SelectSingleNode("/workspace/checkBoxBlacklist");
            checkBoxBlacklist.Checked = bool.Parse(xn.Attributes["checked"].Value.ToString());

            xn = xDoc.SelectSingleNode("/workspace/richTextBoxBlacklist");
            richTextBoxBlacklist.Text = xn.Attributes["text"].Value.ToString();

            xn = xDoc.SelectSingleNode("/workspace/radioButtonOn");
            radioButtonOn.Checked = bool.Parse(xn.Attributes["checked"].Value.ToString());

            xn = xDoc.SelectSingleNode("/workspace/radioButtonOff");
            radioButtonOff.Checked = bool.Parse(xn.Attributes["checked"].Value.ToString());

            xn = xDoc.SelectSingleNode("/workspace/checkBoxDeleteNumbers");
            checkBoxDeleteNumbers.Checked = bool.Parse(xn.Attributes["checked"].Value.ToString());

            xn = xDoc.SelectSingleNode("/workspace/groupBoxResults");
            groupBoxResults.Enabled = bool.Parse(xn.Attributes["enabled"].Value.ToString());

            xn = xDoc.SelectSingleNode("/workspace/textBoxSearch");
            textBoxSearch.Text = xn.Attributes["text"].Value.ToString();

            xn = xDoc.SelectSingleNode("/workspace/labelResText");
            labelResText.Visible = bool.Parse(xn.Attributes["visible"].Value.ToString());

            xn = xDoc.SelectSingleNode("/workspace/labelRes");
            labelRes.Visible = bool.Parse(xn.Attributes["visible"].Value.ToString());

            xn = xDoc.SelectSingleNode("/workspace/buttonBack");
            buttonBack.Visible = bool.Parse(xn.Attributes["visible"].Value.ToString());

            xn = xDoc.SelectSingleNode("/workspace/buttonForward");
            buttonForward.Visible = bool.Parse(xn.Attributes["visible"].Value.ToString());

            xn = xDoc.SelectSingleNode("/workspace/labelWordsTotal");
            labelWordsTotal.Visible = bool.Parse(xn.Attributes["visible"].Value.ToString());

            xn = xDoc.SelectSingleNode("/workspace/labelWordsTotalCount");
            labelWordsTotalCount.Visible = bool.Parse(xn.Attributes["visible"].Value.ToString());
            labelWordsTotalCount.Text = xn.Attributes["text"].Value.ToString();

            xn = xDoc.SelectSingleNode("/workspace/labelWordsUnique");
            labelWordsUnique.Visible = bool.Parse(xn.Attributes["visible"].Value.ToString());

            xn = xDoc.SelectSingleNode("/workspace/labelWordsUniqueCount");
            labelWordsUniqueCount.Visible = bool.Parse(xn.Attributes["visible"].Value.ToString());
            labelWordsUniqueCount.Text = xn.Attributes["text"].Value.ToString();

            xn = xDoc.SelectSingleNode("/workspace/dataGridView");
            bool attrActive = bool.Parse(xn.Attributes["active"].Value.ToString());
            if (!attrActive)
            {
                dataGridViewWords.Columns.Clear();
            }
            else
            {
                dataGridViewWords.Rows.Clear();

                dataGridViewWords.ColumnCount = 3;
                dataGridViewWords.Columns[0].Name = "Слово";
                dataGridViewWords.Columns[1].Name = "Количество";
                dataGridViewWords.Columns[2].Name = "Отн. частота";

                XmlNodeList xnList1 = xDoc.SelectNodes("/workspace/dataGridView/row");
                foreach (XmlNode xn1 in xnList1)
                {
                    dataGridViewWords.Rows.Add(xn1.Attributes["col0"].Value, xn1.Attributes["col1"].Value, xn1.Attributes["col2"].Value);
                }
            }
        }

        private void openWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                panelCover.Visible = true;

                openXML(openFileDialog1.FileName);
                
                panelCover.Visible = false;
            }
        }

        private void newWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelCover.Visible = true;

            openXML("workspace_new.xml");

            panelCover.Visible = false;

        }

        private void saveXML(string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fileStream))
            using (XmlTextWriter xmlWriter = new XmlTextWriter(sw))
            {
                xmlWriter.Formatting = Formatting.Indented;
                xmlWriter.Indentation = 4;

                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("workspace");

                xmlWriter.WriteStartElement("label1");
                xmlWriter.WriteAttributeString("enabled", label1.Enabled.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("label2");
                xmlWriter.WriteAttributeString("enabled", label2.Enabled.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("textArea");
                xmlWriter.WriteAttributeString("enabled", textArea.Enabled.ToString());
                xmlWriter.WriteAttributeString("text", textArea.Text);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("textBoxFilePath");
                xmlWriter.WriteAttributeString("enabled", textBoxFilePath.Enabled.ToString());
                xmlWriter.WriteAttributeString("text", textBoxFilePath.Text);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("buttonProcess");
                xmlWriter.WriteAttributeString("enabled", buttonProcess.Enabled.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("groupBoxSettings");
                xmlWriter.WriteAttributeString("enabled", groupBoxSettings.Enabled.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("checkBoxBlacklist");
                xmlWriter.WriteAttributeString("checked", checkBoxBlacklist.Checked.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("richTextBoxBlacklist");
                xmlWriter.WriteAttributeString("text", richTextBoxBlacklist.Text);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("radioButtonOn");
                xmlWriter.WriteAttributeString("checked", radioButtonOn.Checked.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("radioButtonOff");
                xmlWriter.WriteAttributeString("checked", radioButtonOff.Checked.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("checkBoxDeleteNumbers");
                xmlWriter.WriteAttributeString("checked", checkBoxDeleteNumbers.Checked.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("groupBoxResults");
                xmlWriter.WriteAttributeString("enabled", groupBoxResults.Enabled.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("textBoxSearch");
                xmlWriter.WriteAttributeString("text", textBoxSearch.Text);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("labelResText");
                xmlWriter.WriteAttributeString("visible", "false");
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("labelRes");
                xmlWriter.WriteAttributeString("visible", "false");
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("buttonBack");
                xmlWriter.WriteAttributeString("visible", "false");
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("buttonForward");
                xmlWriter.WriteAttributeString("visible", "false");
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("labelWordsTotal");
                xmlWriter.WriteAttributeString("visible", labelWordsTotal.Visible.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("labelWordsTotalCount");
                xmlWriter.WriteAttributeString("visible", labelWordsTotalCount.Visible.ToString());
                xmlWriter.WriteAttributeString("text", labelWordsTotalCount.Text);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("labelWordsUnique");
                xmlWriter.WriteAttributeString("visible", labelWordsUnique.Visible.ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("labelWordsUniqueCount");
                xmlWriter.WriteAttributeString("visible", labelWordsUniqueCount.Visible.ToString());
                xmlWriter.WriteAttributeString("text", labelWordsUniqueCount.Text);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("dataGridView");
                if (dataGridViewWords.Columns.Count == 0)
                {
                    xmlWriter.WriteAttributeString("active", "False");
                }
                else
                {
                    xmlWriter.WriteAttributeString("active", "True");
                    for (int i = 0; i < dataGridViewWords.Rows.Count; i++)
                    {
                        xmlWriter.WriteStartElement("row");
                        xmlWriter.WriteAttributeString("col0", dataGridViewWords.Rows[i].Cells[0].Value.ToString());
                        xmlWriter.WriteAttributeString("col1", dataGridViewWords.Rows[i].Cells[1].Value.ToString());
                        xmlWriter.WriteAttributeString("col2", dataGridViewWords.Rows[i].Cells[2].Value.ToString());
                        xmlWriter.WriteEndElement();
                    }
                }
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }
        }

        private void saveWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {

                panelCover.Visible = true;
                if (File.Exists(saveFileDialog2.FileName))
                {
                    try
                    {
                        File.Delete(saveFileDialog2.FileName);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Не удалось сохранить файл." + ex.Message);
                    }
                }

                saveXML(saveFileDialog2.FileName);

                MessageBox.Show("Файл сохранен.");
                panelCover.Visible = false;
            }
        }
    }
}
