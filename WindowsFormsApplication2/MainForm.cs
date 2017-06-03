using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            InputFileTxt.Text = fileDialog.FileName;
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            var path = InputFileTxt.Text;
            XMLReader.LoadFile(path);
            MessageBox.Show("Archivo importado correctamente.");
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            var fileDialog = new FolderBrowserDialog();
            fileDialog.ShowDialog();
            XMLReader.WriteFile(fileDialog.SelectedPath + "/accountingEntries.xml");
            MessageBox.Show("Archivo generado correctamente.");
        }
    }
}
