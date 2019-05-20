namespace AutoClientPlayer
{
    partial class ClientPlayer
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
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.clientsNoLabel = new System.Windows.Forms.Label();
            this.clientsNoTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.ServerIPLabel = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.startJava = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serverBox = new System.Windows.Forms.GroupBox();
            this.serverPath = new System.Windows.Forms.TextBox();
            this.serverPathLabel = new System.Windows.Forms.Label();
            this.cSharpServer = new System.Windows.Forms.Button();
            this.AutoClientBox = new System.Windows.Forms.GroupBox();
            this.normalClientBox = new System.Windows.Forms.GroupBox();
            this.normalClientPath = new System.Windows.Forms.TextBox();
            this.nClientPathLabel = new System.Windows.Forms.Label();
            this.normalClient = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.JServerBox = new System.Windows.Forms.GroupBox();
            this.JSererPath = new System.Windows.Forms.TextBox();
            this.JServer = new System.Windows.Forms.Button();
            this.JServerPathLabel = new System.Windows.Forms.Label();
            this.JAutoClientBox = new System.Windows.Forms.GroupBox();
            this.jAutoClientPathLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.normalJClientBox = new System.Windows.Forms.GroupBox();
            this.JNormalClientPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.JNormalClient = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.serverBox.SuspendLayout();
            this.AutoClientBox.SuspendLayout();
            this.normalClientBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.JServerBox.SuspendLayout();
            this.JAutoClientBox.SuspendLayout();
            this.normalJClientBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(44, 19);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(146, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Start Auto Client";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // clientsNoLabel
            // 
            this.clientsNoLabel.AutoSize = true;
            this.clientsNoLabel.Location = new System.Drawing.Point(21, 582);
            this.clientsNoLabel.Name = "clientsNoLabel";
            this.clientsNoLabel.Size = new System.Drawing.Size(132, 13);
            this.clientsNoLabel.TabIndex = 1;
            this.clientsNoLabel.Text = "Number of Active Clients: ";
            this.clientsNoLabel.Click += new System.EventHandler(this.clientsNoLabel_Click);
            // 
            // clientsNoTextBox
            // 
            this.clientsNoTextBox.Enabled = false;
            this.clientsNoTextBox.Location = new System.Drawing.Point(159, 582);
            this.clientsNoTextBox.Name = "clientsNoTextBox";
            this.clientsNoTextBox.Size = new System.Drawing.Size(46, 20);
            this.clientsNoTextBox.TabIndex = 2;
            this.clientsNoTextBox.TextChanged += new System.EventHandler(this.clientsNoTextBox_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(106, 55);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(119, 20);
            this.IPTextBox.TabIndex = 3;
            this.IPTextBox.TextChanged += new System.EventHandler(this.IPTextBox_TextChanged);
            // 
            // ServerIPLabel
            // 
            this.ServerIPLabel.AutoSize = true;
            this.ServerIPLabel.Location = new System.Drawing.Point(49, 55);
            this.ServerIPLabel.Name = "ServerIPLabel";
            this.ServerIPLabel.Size = new System.Drawing.Size(59, 13);
            this.ServerIPLabel.TabIndex = 4;
            this.ServerIPLabel.Text = "Server IP: ";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(12, 113);
            this.pathTextBox.Multiline = true;
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(213, 66);
            this.pathTextBox.TabIndex = 5;
            this.pathTextBox.Text = "C:\\\\Program Files (x86)\\\\Aya\\\\AutoClient\\\\AutoClient.exe";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(9, 86);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(86, 13);
            this.pathLabel.TabIndex = 6;
            this.pathLabel.Text = "AutoClient path:";
            // 
            // startJava
            // 
            this.startJava.Location = new System.Drawing.Point(44, 45);
            this.startJava.Name = "startJava";
            this.startJava.Size = new System.Drawing.Size(146, 23);
            this.startJava.TabIndex = 7;
            this.startJava.Text = "Start Auto Client";
            this.startJava.UseVisualStyleBackColor = true;
            this.startJava.Click += new System.EventHandler(this.startJava_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 640);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serverBox);
            this.groupBox1.Controls.Add(this.AutoClientBox);
            this.groupBox1.Controls.Add(this.normalClientBox);
            this.groupBox1.Controls.Add(this.clientsNoTextBox);
            this.groupBox1.Controls.Add(this.clientsNoLabel);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 616);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "C# Applications";
            // 
            // serverBox
            // 
            this.serverBox.Controls.Add(this.serverPath);
            this.serverBox.Controls.Add(this.serverPathLabel);
            this.serverBox.Controls.Add(this.cSharpServer);
            this.serverBox.Location = new System.Drawing.Point(15, 27);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(237, 163);
            this.serverBox.TabIndex = 12;
            this.serverBox.TabStop = false;
            this.serverBox.Text = "Server";
            // 
            // serverPath
            // 
            this.serverPath.Location = new System.Drawing.Point(12, 81);
            this.serverPath.Multiline = true;
            this.serverPath.Name = "serverPath";
            this.serverPath.Size = new System.Drawing.Size(213, 66);
            this.serverPath.TabIndex = 10;
            this.serverPath.Text = "C:\\\\Aya\\\\Server.exe";
            // 
            // serverPathLabel
            // 
            this.serverPathLabel.AutoSize = true;
            this.serverPathLabel.Location = new System.Drawing.Point(6, 54);
            this.serverPathLabel.Name = "serverPathLabel";
            this.serverPathLabel.Size = new System.Drawing.Size(68, 13);
            this.serverPathLabel.TabIndex = 9;
            this.serverPathLabel.Text = "Server path:";
            // 
            // cSharpServer
            // 
            this.cSharpServer.Location = new System.Drawing.Point(44, 16);
            this.cSharpServer.Name = "cSharpServer";
            this.cSharpServer.Size = new System.Drawing.Size(146, 23);
            this.cSharpServer.TabIndex = 8;
            this.cSharpServer.Text = "Start Server";
            this.cSharpServer.UseVisualStyleBackColor = true;
            this.cSharpServer.Click += new System.EventHandler(this.cSharpServer_Click);
            // 
            // AutoClientBox
            // 
            this.AutoClientBox.Controls.Add(this.IPTextBox);
            this.AutoClientBox.Controls.Add(this.ServerIPLabel);
            this.AutoClientBox.Controls.Add(this.start);
            this.AutoClientBox.Controls.Add(this.pathLabel);
            this.AutoClientBox.Controls.Add(this.pathTextBox);
            this.AutoClientBox.Location = new System.Drawing.Point(15, 371);
            this.AutoClientBox.Name = "AutoClientBox";
            this.AutoClientBox.Size = new System.Drawing.Size(237, 192);
            this.AutoClientBox.TabIndex = 11;
            this.AutoClientBox.TabStop = false;
            this.AutoClientBox.Text = "Auto Client";
            this.AutoClientBox.Enter += new System.EventHandler(this.AutoClientBox_Enter);
            // 
            // normalClientBox
            // 
            this.normalClientBox.Controls.Add(this.normalClientPath);
            this.normalClientBox.Controls.Add(this.nClientPathLabel);
            this.normalClientBox.Controls.Add(this.normalClient);
            this.normalClientBox.Location = new System.Drawing.Point(15, 202);
            this.normalClientBox.Name = "normalClientBox";
            this.normalClientBox.Size = new System.Drawing.Size(237, 163);
            this.normalClientBox.TabIndex = 9;
            this.normalClientBox.TabStop = false;
            this.normalClientBox.Text = "Normal Client";
            this.normalClientBox.Enter += new System.EventHandler(this.normalClientBox_Enter);
            // 
            // normalClientPath
            // 
            this.normalClientPath.Location = new System.Drawing.Point(12, 81);
            this.normalClientPath.Multiline = true;
            this.normalClientPath.Name = "normalClientPath";
            this.normalClientPath.Size = new System.Drawing.Size(213, 66);
            this.normalClientPath.TabIndex = 9;
            this.normalClientPath.Text = "C:\\\\Aya\\\\Client.exe";
            // 
            // nClientPathLabel
            // 
            this.nClientPathLabel.AutoSize = true;
            this.nClientPathLabel.Location = new System.Drawing.Point(6, 54);
            this.nClientPathLabel.Name = "nClientPathLabel";
            this.nClientPathLabel.Size = new System.Drawing.Size(102, 13);
            this.nClientPathLabel.TabIndex = 8;
            this.nClientPathLabel.Text = "Normal Client path: ";
            // 
            // normalClient
            // 
            this.normalClient.Location = new System.Drawing.Point(44, 19);
            this.normalClient.Name = "normalClient";
            this.normalClient.Size = new System.Drawing.Size(146, 23);
            this.normalClient.TabIndex = 7;
            this.normalClient.Text = "Start Normal Client";
            this.normalClient.UseVisualStyleBackColor = true;
            this.normalClient.Click += new System.EventHandler(this.normalClient_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.JServerBox);
            this.groupBox2.Controls.Add(this.JAutoClientBox);
            this.groupBox2.Controls.Add(this.normalJClientBox);
            this.groupBox2.Location = new System.Drawing.Point(330, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 616);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Java Applications";
            // 
            // JServerBox
            // 
            this.JServerBox.Controls.Add(this.JSererPath);
            this.JServerBox.Controls.Add(this.JServer);
            this.JServerBox.Controls.Add(this.JServerPathLabel);
            this.JServerBox.Location = new System.Drawing.Point(15, 27);
            this.JServerBox.Name = "JServerBox";
            this.JServerBox.Size = new System.Drawing.Size(237, 163);
            this.JServerBox.TabIndex = 17;
            this.JServerBox.TabStop = false;
            this.JServerBox.Text = "Server";
            // 
            // JSererPath
            // 
            this.JSererPath.Location = new System.Drawing.Point(12, 81);
            this.JSererPath.Multiline = true;
            this.JSererPath.Name = "JSererPath";
            this.JSererPath.Size = new System.Drawing.Size(213, 66);
            this.JSererPath.TabIndex = 15;
            this.JSererPath.Text = "C:\\\\Users\\\\user\\\\Desktop\\\\project";
            this.JSererPath.TextChanged += new System.EventHandler(this.JSererPath_TextChanged);
            // 
            // JServer
            // 
            this.JServer.Location = new System.Drawing.Point(44, 16);
            this.JServer.Name = "JServer";
            this.JServer.Size = new System.Drawing.Size(146, 23);
            this.JServer.TabIndex = 8;
            this.JServer.Text = "Start Server";
            this.JServer.UseVisualStyleBackColor = true;
            this.JServer.Click += new System.EventHandler(this.JServer_Click);
            // 
            // JServerPathLabel
            // 
            this.JServerPathLabel.AutoSize = true;
            this.JServerPathLabel.Location = new System.Drawing.Point(6, 54);
            this.JServerPathLabel.Name = "JServerPathLabel";
            this.JServerPathLabel.Size = new System.Drawing.Size(68, 13);
            this.JServerPathLabel.TabIndex = 14;
            this.JServerPathLabel.Text = "Server path:";
            // 
            // JAutoClientBox
            // 
            this.JAutoClientBox.Controls.Add(this.jAutoClientPathLabel);
            this.JAutoClientBox.Controls.Add(this.textBox2);
            this.JAutoClientBox.Controls.Add(this.startJava);
            this.JAutoClientBox.Location = new System.Drawing.Point(15, 371);
            this.JAutoClientBox.Name = "JAutoClientBox";
            this.JAutoClientBox.Size = new System.Drawing.Size(237, 192);
            this.JAutoClientBox.TabIndex = 12;
            this.JAutoClientBox.TabStop = false;
            this.JAutoClientBox.Text = "Auto Client";
            // 
            // jAutoClientPathLabel
            // 
            this.jAutoClientPathLabel.AutoSize = true;
            this.jAutoClientPathLabel.Location = new System.Drawing.Point(9, 86);
            this.jAutoClientPathLabel.Name = "jAutoClientPathLabel";
            this.jAutoClientPathLabel.Size = new System.Drawing.Size(86, 13);
            this.jAutoClientPathLabel.TabIndex = 11;
            this.jAutoClientPathLabel.Text = "AutoClient path:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 113);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 66);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "C:\\\\Users\\\\user\\\\Desktop\\\\project";
            // 
            // normalJClientBox
            // 
            this.normalJClientBox.Controls.Add(this.JNormalClientPath);
            this.normalJClientBox.Controls.Add(this.label1);
            this.normalJClientBox.Controls.Add(this.JNormalClient);
            this.normalJClientBox.Location = new System.Drawing.Point(15, 202);
            this.normalJClientBox.Name = "normalJClientBox";
            this.normalJClientBox.Size = new System.Drawing.Size(237, 163);
            this.normalJClientBox.TabIndex = 11;
            this.normalJClientBox.TabStop = false;
            this.normalJClientBox.Text = "NormalClient";
            // 
            // JNormalClientPath
            // 
            this.JNormalClientPath.Location = new System.Drawing.Point(12, 81);
            this.JNormalClientPath.Multiline = true;
            this.JNormalClientPath.Name = "JNormalClientPath";
            this.JNormalClientPath.Size = new System.Drawing.Size(213, 66);
            this.JNormalClientPath.TabIndex = 2;
            this.JNormalClientPath.Text = "C:\\\\Users\\\\user\\\\Desktop\\\\project";
            this.JNormalClientPath.TextChanged += new System.EventHandler(this.JNormalClientPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Normal Client path:";
            // 
            // JNormalClient
            // 
            this.JNormalClient.Location = new System.Drawing.Point(44, 19);
            this.JNormalClient.Name = "JNormalClient";
            this.JNormalClient.Size = new System.Drawing.Size(146, 23);
            this.JNormalClient.TabIndex = 0;
            this.JNormalClient.Text = "Start Normal Client";
            this.JNormalClient.UseVisualStyleBackColor = true;
            this.JNormalClient.Click += new System.EventHandler(this.JNormalClient_Click);
            // 
            // ClientPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 640);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter1);
            this.Name = "ClientPlayer";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.ClientPlayer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.serverBox.ResumeLayout(false);
            this.serverBox.PerformLayout();
            this.AutoClientBox.ResumeLayout(false);
            this.AutoClientBox.PerformLayout();
            this.normalClientBox.ResumeLayout(false);
            this.normalClientBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.JServerBox.ResumeLayout(false);
            this.JServerBox.PerformLayout();
            this.JAutoClientBox.ResumeLayout(false);
            this.JAutoClientBox.PerformLayout();
            this.normalJClientBox.ResumeLayout(false);
            this.normalJClientBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label clientsNoLabel;
        private System.Windows.Forms.TextBox clientsNoTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Label ServerIPLabel;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button startJava;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox AutoClientBox;
        private System.Windows.Forms.GroupBox normalClientBox;
        private System.Windows.Forms.TextBox normalClientPath;
        private System.Windows.Forms.Label nClientPathLabel;
        private System.Windows.Forms.Button normalClient;
        private System.Windows.Forms.Button cSharpServer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button JServer;
        private System.Windows.Forms.GroupBox JAutoClientBox;
        private System.Windows.Forms.GroupBox normalJClientBox;
        private System.Windows.Forms.Label JServerPathLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox JNormalClientPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button JNormalClient;
        private System.Windows.Forms.GroupBox serverBox;
        private System.Windows.Forms.TextBox serverPath;
        private System.Windows.Forms.Label serverPathLabel;
        private System.Windows.Forms.GroupBox JServerBox;
        private System.Windows.Forms.Label jAutoClientPathLabel;
        private System.Windows.Forms.TextBox JSererPath;
    }
}

