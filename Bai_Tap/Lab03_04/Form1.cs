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

namespace Lab03_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //EVENT FOR BUTTON ADD SOURCE
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            //Always default to Folder Selection
            folderBrowser.FileName = "Folder Selection";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                txtSource.Text = folderPath; //put source txt = folderPath selected
            }
        }
        //EVENT FOR BUTTON ADD DESTINATION
        private void btnAdd2_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            //Always default to Folder Selection
            folderBrowser.FileName = "Folder Selection";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                txtDestination.Text = folderPath; //put destination txt = folderPath selected
            }
        }
        //EVENT FOR BUTTON COPY
        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "Copying: {0}";
                if (Directory.Exists(txtSource.Text) && Directory.Exists(txtDestination.Text))
                {
                    string[] files = Directory.GetFiles(txtSource.Text);
                    int step = 100 / files.Count();
                    foreach (string f in files)
                    {
                        string fileName = Path.GetFileName(f);
                        string desFile = Path.Combine(txtDestination.Text, fileName);
                        File.Copy(f, desFile);
                        progressBar.Value += step;
                        msg = string.Format(msg, Path.Combine(txtSource.Text, fileName));
                        LoadStatusStrip(msg);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notifition");
            }
        }
        //LOAT STATUSSTRIP
        private void LoadStatusStrip(string status)
        {
            this.toolStripStatusLabel.Text = status;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(progressBar, status);
        }
    }
}
