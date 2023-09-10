using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteCommandExecution.Views
{
    public partial class CRUDCommandsView : Form
    {
        public int _commandId { get; set; } = 0;
        private string _command;

        public CRUDCommandsView()
        {
            InitializeComponent();
        }

        private void textBoxCommand_TextChanged(object sender, EventArgs e)
        {
            _command = textBox1.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Validar la información aquí
            bool success = false;
            try
            {
                if (_commandId > 0)
                {
                    // Modificar los datos del comando aquí

                    if (success)
                    {
                        MessageBox.Show("Se ha modificado la información del comando", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        // Agregar la descripción del error
                        MessageBox.Show("Ha ocurrido un error modificando el comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Agregar el comando

                    if (success)
                    {
                        MessageBox.Show("Se ha agregado un nuevo comando", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Agregar la descripción del error
                        MessageBox.Show("Ha ocurrido un error agregando el comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                Debug.WriteLine(ex.Message);
                Debugger.Break();
#endif
            }
        }
    }
}
