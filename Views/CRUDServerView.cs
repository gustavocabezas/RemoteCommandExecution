using Microsoft.VisualBasic;
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
    public partial class CRUDServerView : Form
    {

        public int _serverId { get; set; } = 0;

        public CRUDServerView()
        {
            InitializeComponent();
            if (_serverId > 0)
            {
                textBoxName.Enabled = false;
                textBoxName.Text = "Cargando...";
                textBoxIp.Enabled = false;
                textBoxIp.Text = "Cargando...";
                textBoxUser.Enabled = false;
                textBoxUser.Text = "Cargando...";
                textBoxPassword.Enabled = false;
                textBoxPassword.Text = "Cargando...";

                // Cargar los datos del servidor aquí, una vez cargados habilitar los texbox. 
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            // Verifique la conexión con el servidor Linux aquí

            bool success = false;
            try
            {
                if (_serverId > 0)
                {
                    // Modificar los datos del servidor aquí

                    if (success)
                    {
                        MessageBox.Show("Se ha modificado la información del servidor", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        // Agregar la descripción del error

                        MessageBox.Show("Ha ocurrido un error modificando el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Agregar el servidor

                    if (success)
                    {
                        MessageBox.Show("Se ha agregado un nuevo servidor", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Agregar la descripción del error
                        MessageBox.Show("Ha ocurrido un error agregando el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
