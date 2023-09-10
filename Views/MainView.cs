using RemoteCommandExecution.Views;
using System.Diagnostics;

namespace RemoteCommandExecution
{
    public partial class MainView : Form
    {
        private int _serverSelecctedId = 0;
        private int _commandSelecctedId = 0;

        public MainView()
        {
            InitializeComponent();
        }

        private void pictureBoxAddServer_Click(object sender, EventArgs e)
        {
            try
            {
                CRUDServerView crudServerView = new();
                crudServerView.ShowDialog();
            }
            catch (Exception ex)
            {
#if DEBUG
                Debug.WriteLine(ex.Message);
                Debugger.Break();
#endif
            }
        }

        private void pictureBoxRemoveServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (_serverSelecctedId > 0)
                {
                    DialogResult resultado = MessageBox.Show("¿Desea eliminar el servidor?", "Sí", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        // Eliminar la información del servidor aquí
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pictureBoxModifyServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (_serverSelecctedId > 0)
                {
                    CRUDServerView serverCRUD = new()
                    {
                        _serverId = _serverSelecctedId
                    };
                    serverCRUD.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pictureBoxAddCommand_Click(object sender, EventArgs e)
        {
            CRUDCommandsView crudCommandsView = new();
            crudCommandsView.ShowDialog();
        }

        private void pictureBoxRemoveCommand_Click(object sender, EventArgs e)
        {
            try
            {
                if (_commandSelecctedId > 0)
                {
                    DialogResult resultado = MessageBox.Show("¿Desea eliminar el comando?", "Sí", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        // Eliminar el comando aquí
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pictureBoxModifyCommand_Click(object sender, EventArgs e)
        {
            try
            {
                if (_commandSelecctedId > 0)
                {
                    CRUDCommandsView crudCommandsView = new()
                    {
                        _commandId = _commandSelecctedId
                    };
                    crudCommandsView.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pictBoxPlayCommand_Click(object sender, EventArgs e)
        {
            try
            {
                // Aquí va la respuesta al ejecutar el código en el servidor

            }
            catch (Exception ex)
            {
#if DEBUG
                Debug.WriteLine(ex.Message);
                Debugger.Break();
#endif
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }
    }
}