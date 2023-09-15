namespace RemoteCommandExecution.Views
{
    partial class CRUDCommandsView
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
            btnCancel = new Button();
            btnAccept = new Button();
            label1 = new Label();
            textboxComando = new TextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(12, 111);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.Green;
            btnAccept.FlatStyle = FlatStyle.Popup;
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(172, 111);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(140, 23);
            btnAccept.TabIndex = 1;
            btnAccept.Text = "Aceptar";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Comando";
            // 
            // textboxComando
            // 
            textboxComando.Location = new Point(12, 27);
            textboxComando.Multiline = true;
            textboxComando.Name = "textboxComando";
            textboxComando.Size = new Size(300, 78);
            textboxComando.TabIndex = 3;
            // 
            // CRUDCommandsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 141);
            Controls.Add(textboxComando);
            Controls.Add(label1);
            Controls.Add(btnAccept);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(340, 180);
            Name = "CRUDCommandsView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comando";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAccept;
        private Label label1;
        private TextBox textboxComando;
    }
}