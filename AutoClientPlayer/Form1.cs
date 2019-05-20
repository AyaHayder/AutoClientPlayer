using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
namespace AutoClientPlayer
{
    public partial class ClientPlayer : Form
    {
        int cSharpName = 0;
        int javaName = 0;
        Process[] autoClients;
        Process[] normalClients;
        Process[] serverProcesses;
        string hostIP;
        string autoClientFilename;
        string serverFilename;
        string jServerFilename;
        string jnClientFilename;
        string nClientFilename;
        string jAutoClientFilename;
        public ClientPlayer()
        {
            InitializeComponent();
            Thread activeC = new Thread(ProcessManager);
            activeC.Start();
        }

        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);

        private void start_Click(object sender, EventArgs e)
        {
            cSharpName++;
            hostIP = IPTextBox.Text;
            autoClientFilename = pathTextBox.Text;
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.Arguments = cSharpName.ToString()+ " " + hostIP;
            processStartInfo.FileName = autoClientFilename;
            //processStartInfo.FileName = "C:\\Program Files (x86)\\Aya\\AutoClient\\AutoClient.exe";
            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
            Thread.Sleep(10);
        }


        public void ProcessManager() {
            while (true) {
                autoClients = Process.GetProcessesByName("AutoClient");
                normalClients = Process.GetProcessesByName("Client");
                serverProcesses = Process.GetProcessesByName("Server");

    }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int cSharpClientsNo = autoClients.Length + normalClients.Length;
            clientsNoTextBox.Text = cSharpClientsNo.ToString();

            if (serverProcesses.Length == 0) {
                cSharpServer.Enabled = true;
                JServer.Enabled = true;
            }
            if(JSererPath.Text == "")
            {
                JServer.Enabled = false;
            }
            if (JNormalClientPath.Text == "")
            {
                JNormalClient.Enabled = false;
            }

            if(IPTextBox.Text == "")
            {
                start.Enabled = false;
            }
        }

        private void ClientPlayer_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            start.Enabled = false;
            if(JSererPath.Text == "")
            {
                JServer.Enabled = false;
            }

        }

        private void IPTextBox_TextChanged(object sender, EventArgs e)
        {
            start.Enabled = true;
        }


        private void startJava_Click(object sender, EventArgs e)
        {
            javaName++;
            jAutoClientFilename = textBox2.Text;
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.Arguments = "/K  cd " + jAutoClientFilename + "&java -jar AutoClient.jar";
            processStartInfo.FileName = "cmd";
            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();

        }

       
        private void cSharpServer_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            serverFilename = serverPath.Text;
            processStartInfo.FileName = serverFilename;
            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
            cSharpServer.Enabled = false;
            JServer.Enabled = false;
        }

        private void normalClient_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            nClientFilename = normalClientPath.Text;
            processStartInfo.FileName = nClientFilename;
            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
        }

        private void JSererPath_TextChanged(object sender, EventArgs e)
        {
            JServer.Enabled = true;
        }

        private void JNormalClientPath_TextChanged(object sender, EventArgs e)
        {
            JNormalClient.Enabled = true;
        }

        private void JServer_Click(object sender, EventArgs e)
        {
            jServerFilename = JSererPath.Text;
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.Arguments = "/K  cd " + jServerFilename + "&java -jar TcpSerevr1.jar";
            processStartInfo.FileName = "cmd";
            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
            Thread.Sleep(100);
            SetWindowText(process.MainWindowHandle, "Java Server");
            JServer.Enabled = false;
            cSharpServer.Enabled = false;
        }

        private void JNormalClient_Click(object sender, EventArgs e)
        {
            jnClientFilename = JNormalClientPath.Text;
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.Arguments = "/K  cd " + jnClientFilename + "&java -jar  ConsoleCLient.jar";
            processStartInfo.FileName = "cmd";
            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
        }

        private void JServerIP_TextChanged(object sender, EventArgs e)
        {
            startJava.Enabled = true;
        }

        private void normalClientBox_Enter(object sender, EventArgs e)
        {

        }

        private void AutoClientBox_Enter(object sender, EventArgs e)
        {

        }

        private void clientsNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void clientsNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
