namespace RemoteCommandExecution.Views
{
    partial class CRUDServerView
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            textBoxIp = new TextBox();
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Dirección IP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 3;
            label4.Text = "Constraseña";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 27);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(300, 23);
            textBoxName.TabIndex = 5;
            // 
            // textBoxIp
            // 
            textBoxIp.Location = new Point(12, 83);
            textBoxIp.Name = "textBoxIp";
            textBoxIp.Size = new Size(300, 23);
            textBoxIp.TabIndex = 6;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(12, 143);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(300, 23);
            textBoxUser.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 203);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(300, 23);
            textBoxPassword.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 241);
            button1.Name = "button1";
            button1.Size = new Size(140, 23);
            button1.TabIndex = 10;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonCancel_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(171, 241);
            button2.Name = "button2";
            button2.Size = new Size(140, 23);
            button2.TabIndex = 11;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonAccept_Click;
            // 
            // CRUDServerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 281);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUser);
            Controls.Add(textBoxIp);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(340, 318);
            Name = "CRUDServerView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servidor";
            Load += CRUDServerView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private TextBox textBoxName;
        private TextBox textBoxIp;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
    }
}