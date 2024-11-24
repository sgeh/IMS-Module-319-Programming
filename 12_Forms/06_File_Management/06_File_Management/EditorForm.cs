using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bwz.Rappi
{
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();
        }

        private void CmdReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;
            openFile.InitialDirectory = "C:\\";
            openFile.Filter = "Textdateien (*.txt)|*.txt|Node Packakge|package.json|All files (*.*)|*.*";
            openFile.Title = "IMS BWZ-Rappi, bitte File öffnen";
            
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                TbxSelectedFile.Text = openFile.FileName;
                TbxFileContent.Text = File.ReadAllText(openFile.FileName);
            }
            else
            {
                TbxSelectedFile.Text = "Invalid File Path";
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = "C:\\";
            saveFile.Filter = "Textdateien (*.txt)|*.txt";
            saveFile.Title = "IMS BWZ-Rappi, bitte File speichern";
            saveFile.OverwritePrompt = true;

            DialogResult result = saveFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                TbxSelectedFile.Text = saveFile.FileName;
                 File.WriteAllText(saveFile.FileName, TbxFileContent.Text);
            }
            else
            {
                TbxSelectedFile.Text = "Invalid File Path";
            }
        }

        private void CmdReadFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog readFolder = new FolderBrowserDialog();
            readFolder.RootFolder = Environment.SpecialFolder.UserProfile;
            readFolder.Description = "IMS BWZ-Rappi, bitte Folder öffnen";

            DialogResult result = readFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                TbxSelectedFile.Text = readFolder.SelectedPath;
                TbxFileContent.Text = "";

                OutputFolderRecursive(TbxSelectedFile.Text);
            }
            else
            {
                TbxSelectedFile.Text = "Invalid File Path";
            }
        }

        private void OutputFolderRecursive(string toOutput)
        {
            TbxFileContent.Text += $"{toOutput}\r\n";

            string[] files = Directory.GetFiles(toOutput);
            for (int i = 0; i < files.Length; ++i)
            {
                TbxFileContent.Text +=  $"{files[i]}\r\n"; 
            }

            string[] dirs = Directory.GetDirectories(toOutput);
            for (int i = 0; i < dirs.Length; ++i)
            {
                OutputFolderRecursive(dirs[i]);
            }
        }
    }
}
