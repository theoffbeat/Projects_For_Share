using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Batch_Program
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        string googleFolder = @"C:\Users\" + Environment.UserName + @"\Google Drive";
        string skyDriveFolder = @"C:\Users\" + Environment.UserName + @"\SkyDrive";
        string syncFolder = @"D:\Sync Folder";
        //string syncFolder;

        public void ChooseSyncLocation()
        {
            if (Directory.Exists(syncFolder) == true)
            {
                Process.Start(syncFolder);
            }
            else
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowDialog();

                if (Directory.Exists(fbd.SelectedPath))
                {
                    Process.Start(fbd.SelectedPath);
                    syncFolder = fbd.SelectedPath;
                }
            }
        }
                
        public void BatchExecute(string batchName)
        {
            Process batchProcess = new Process();

            try
            {                
                batchProcess.StartInfo.UseShellExecute = false;
                batchProcess.StartInfo.FileName = batchName;
                batchProcess.StartInfo.CreateNoWindow = false;

                batchProcess.StartInfo.Arguments = string.Format("{0}", syncFolder);

                batchProcess.Start();
                batchProcess.WaitForExit();
                //batchProcess.Kill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }
        }



        public void OpenFolder(string folderLocation)
        {
            if (Directory.Exists(folderLocation) == true)
            {
                Process.Start(folderLocation);
            }
            else
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowDialog();
                if (Directory.Exists(fbd.SelectedPath))
                {
                    Process.Start(fbd.SelectedPath);
                }
            }
        }
        
        private void CopyFromGoogle(object sender, EventArgs e)
        {
            BatchExecute("Sync From Google.bat");            
        }

        private void CopyToGoogle(object sender, EventArgs e)
        {
            BatchExecute("Sync To Google.bat");
        }

        private void OpenGoogleFolder(object sender, EventArgs e)
        {
            /*// opens the folder in explorer
            Process.Start(@"c:\temp");
            // opens the folder in explorer
            Process.Start("explorer.exe", @"c:\temp");
            // throws exception
            Process.Start(@"c:\does_not_exist");
            // opens explorer, showing some other folder)
            Process.Start("explorer.exe", @"c:\does_not_exist");*/

            //Process.Start(@"C:\Users\marko\Google Drive");

            OpenFolder(googleFolder);

        }

        private void CopyFromOneDrive(object sender, EventArgs e)
        {
            BatchExecute("Sync From SkyDrive.bat");
        }

        private void CopyToOneDrive(object sender, EventArgs e)
        {
            BatchExecute("Sync To SkyDrive.bat");
        }

        private void OpenOneDrive(object sender, EventArgs e)
        {
            OpenFolder(skyDriveFolder);
        }

        private void OpenSyncFolder(object sender, EventArgs e)
        {
            //OpenFolder(syncFolder);
            ChooseSyncLocation();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
