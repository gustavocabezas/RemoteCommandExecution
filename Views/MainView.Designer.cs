namespace RemoteCommandExecution
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictBoxAddServer = new PictureBox();
            pictBoxRemoveServer = new PictureBox();
            pictBoxModifyServer = new PictureBox();
            pictBoxAddCommand = new PictureBox();
            pictBoxRemoveCommand = new PictureBox();
            pictBoxPlayCommand = new PictureBox();
            txbResponseCommand = new TextBox();
            listBoxServers = new ListBox();
            listBoxCommands = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictBoxAddServer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxRemoveServer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxModifyServer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxAddCommand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxRemoveCommand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxPlayCommand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 0;
            label1.Text = "Servidores disponibles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "lbServers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 9);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 2;
            label3.Text = "Comandos del servidor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(395, 101);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "lbCommands";
            // 
            // pictBoxAddServer
            // 
            pictBoxAddServer.Cursor = Cursors.Hand;
            pictBoxAddServer.Image = (Image)resources.GetObject("pictBoxAddServer.Image");
            pictBoxAddServer.Location = new Point(12, 37);
            pictBoxAddServer.Name = "pictBoxAddServer";
            pictBoxAddServer.Size = new Size(50, 50);
            pictBoxAddServer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictBoxAddServer.TabIndex = 6;
            pictBoxAddServer.TabStop = false;
            pictBoxAddServer.Click += pictureBoxAddServer_Click;
            // 
            // pictBoxRemoveServer
            // 
            pictBoxRemoveServer.Cursor = Cursors.Hand;
            pictBoxRemoveServer.Image = (Image)resources.GetObject("pictBoxRemoveServer.Image");
            pictBoxRemoveServer.Location = new Point(86, 37);
            pictBoxRemoveServer.Name = "pictBoxRemoveServer";
            pictBoxRemoveServer.Size = new Size(50, 50);
            pictBoxRemoveServer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictBoxRemoveServer.TabIndex = 7;
            pictBoxRemoveServer.TabStop = false;
            pictBoxRemoveServer.Click += pictureBoxRemoveServer_Click;
            // 
            // pictBoxModifyServer
            // 
            pictBoxModifyServer.Cursor = Cursors.Hand;
            pictBoxModifyServer.Image = (Image)resources.GetObject("pictBoxModifyServer.Image");
            pictBoxModifyServer.Location = new Point(158, 37);
            pictBoxModifyServer.Name = "pictBoxModifyServer";
            pictBoxModifyServer.Size = new Size(50, 50);
            pictBoxModifyServer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictBoxModifyServer.TabIndex = 8;
            pictBoxModifyServer.TabStop = false;
            pictBoxModifyServer.Click += pictureBoxModifyServer_Click;
            // 
            // pictBoxAddCommand
            // 
            pictBoxAddCommand.Cursor = Cursors.Hand;
            pictBoxAddCommand.Image = (Image)resources.GetObject("pictBoxAddCommand.Image");
            pictBoxAddCommand.Location = new Point(395, 37);
            pictBoxAddCommand.Name = "pictBoxAddCommand";
            pictBoxAddCommand.Size = new Size(50, 50);
            pictBoxAddCommand.SizeMode = PictureBoxSizeMode.StretchImage;
            pictBoxAddCommand.TabIndex = 9;
            pictBoxAddCommand.TabStop = false;
            pictBoxAddCommand.Click += pictureBoxAddCommand_Click;
            // 
            // pictBoxRemoveCommand
            // 
            pictBoxRemoveCommand.Cursor = Cursors.Hand;
            pictBoxRemoveCommand.Image = (Image)resources.GetObject("pictBoxRemoveCommand.Image");
            pictBoxRemoveCommand.Location = new Point(474, 37);
            pictBoxRemoveCommand.Name = "pictBoxRemoveCommand";
            pictBoxRemoveCommand.Size = new Size(50, 50);
            pictBoxRemoveCommand.SizeMode = PictureBoxSizeMode.StretchImage;
            pictBoxRemoveCommand.TabIndex = 10;
            pictBoxRemoveCommand.TabStop = false;
            pictBoxRemoveCommand.Click += pictureBoxRemoveCommand_Click;
            // 
            // pictBoxPlayCommand
            // 
            pictBoxPlayCommand.Cursor = Cursors.Hand;
            pictBoxPlayCommand.Image = (Image)resources.GetObject("pictBoxPlayCommand.Image");
            pictBoxPlayCommand.Location = new Point(627, 37);
            pictBoxPlayCommand.Name = "pictBoxPlayCommand";
            pictBoxPlayCommand.Size = new Size(50, 50);
            pictBoxPlayCommand.SizeMode = PictureBoxSizeMode.StretchImage;
            pictBoxPlayCommand.TabIndex = 11;
            pictBoxPlayCommand.TabStop = false;
            pictBoxPlayCommand.Click += pictBoxPlayCommand_Click;
            // 
            // txbResponseCommand
            // 
            txbResponseCommand.BackColor = Color.Black;
            txbResponseCommand.ForeColor = SystemColors.Window;
            txbResponseCommand.Location = new Point(12, 249);
            txbResponseCommand.Multiline = true;
            txbResponseCommand.Name = "txbResponseCommand";
            txbResponseCommand.Size = new Size(760, 300);
            txbResponseCommand.TabIndex = 13;
            // 
            // listBoxServers
            // 
            listBoxServers.FormattingEnabled = true;
            listBoxServers.ItemHeight = 15;
            listBoxServers.Location = new Point(12, 119);
            listBoxServers.Name = "listBoxServers";
            listBoxServers.Size = new Size(377, 124);
            listBoxServers.TabIndex = 14;
            // 
            // listBoxCommands
            // 
            listBoxCommands.FormattingEnabled = true;
            listBoxCommands.ItemHeight = 15;
            listBoxCommands.Location = new Point(395, 119);
            listBoxCommands.Name = "listBoxCommands";
            listBoxCommands.Size = new Size(377, 124);
            listBoxCommands.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(553, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBoxModifyCommand_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(pictureBox1);
            Controls.Add(listBoxCommands);
            Controls.Add(listBoxServers);
            Controls.Add(txbResponseCommand);
            Controls.Add(pictBoxPlayCommand);
            Controls.Add(pictBoxRemoveCommand);
            Controls.Add(pictBoxAddCommand);
            Controls.Add(pictBoxModifyServer);
            Controls.Add(pictBoxRemoveServer);
            Controls.Add(pictBoxAddServer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(800, 600);
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administración de comandos remotos"; 
            ((System.ComponentModel.ISupportInitialize)pictBoxAddServer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxRemoveServer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxModifyServer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxAddCommand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxRemoveCommand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictBoxPlayCommand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictBoxAddServer;
        private PictureBox pictBoxRemoveServer;
        private PictureBox pictBoxModifyServer;
        private PictureBox pictBoxAddCommand;
        private PictureBox pictBoxRemoveCommand;
        private PictureBox pictBoxPlayCommand;
        private TextBox txbResponseCommand;
        private ListBox listBoxServers;
        private ListBox listBoxCommands;
        private PictureBox pictureBox1;
    }
}