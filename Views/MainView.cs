using RemoteCommandExecution.Models;
using RemoteCommandExecution.Views;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RemoteCommandExecution
{
    public partial class MainView : Form
    {

        string xmlFilePathServers = "Servers.xml"; // Ruta al archivo XML
        string xmlFilePathCommands = "Commands.xml"; // Ruta al archivo XML

        public MainView()
        {
            InitializeComponent();
            LoadServersFromXml();
        }

        private void pictureBoxAddServer_Click(object sender, EventArgs e)
        {
            try
            {
                CRUDServerView crudServerView = new();
                DialogResult result = crudServerView.ShowDialog();

                if (result == DialogResult.OK)
                {
                    listBoxServers.Items.Clear();
                    LoadServersFromXml();
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

        private void pictureBoxRemoveServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxServers.SelectedIndex != -1)
                {
                    DialogResult resultado = MessageBox.Show("�Desea eliminar el servidor?", "S�", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        // Eliminar la informaci�n del servidor aqu�
                        List<Servers> serverList = LoadServersFromXml(xmlFilePathServers);
                        string selectedServerName = listBoxServers.SelectedItem as string;

                        if (!string.IsNullOrEmpty(selectedServerName))
                        {
                            // Buscar el servidor con el nombre especificado y eliminarlo.
                            Servers serverToRemove = serverList.FirstOrDefault(s => s.Name == selectedServerName);
                            if (serverToRemove != null)
                            {
                                serverList.Remove(serverToRemove);
                            }

                            // Guardar la lista actualizada de servidores en el archivo XML.
                            using (FileStream fs = new FileStream(xmlFilePathServers, FileMode.Create))
                            {
                                XmlSerializer serializer = new XmlSerializer(typeof(List<Servers>));
                                serializer.Serialize(fs, serverList);
                            }

                            // Opcional: Limpia la selecci�n.
                            //listBoxServers.ClearSelected();
                            listBoxServers.Items.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadServersFromXml();
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
                if (listBoxServers.SelectedIndex != -1)
                {

                    List<Servers> serverList = LoadServersFromXml(xmlFilePathServers);
                    string selectedServerName = listBoxServers.SelectedItem as string;

                    if (!string.IsNullOrEmpty(selectedServerName))
                    {
                        CRUDServerView serverCRUD = new(selectedServerName);

                        DialogResult result = serverCRUD.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            listBoxServers.Items.Clear();
                            LoadServersFromXml();
                        }
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

        private void pictureBoxAddCommand_Click(object sender, EventArgs e)
        {
            try
            {
                CRUDCommandsView crudCommandsView = new();
                DialogResult result = crudCommandsView.ShowDialog();

                if (result == DialogResult.OK)
                {
                    listBoxCommands.Items.Clear();

                    // LoadCommandsFromXml();
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

        private void pictureBoxRemoveCommand_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxCommands.SelectedIndex != -1)
                {
                    DialogResult resultado = MessageBox.Show("�Desea eliminar el comando?", "S�", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        // Eliminar el comando aqu�




                        //List<Commands> commandList = LoadCommandsFromXml(xmlFilePathCommands);
                        //string selectedCommandName = listBoxCommands.SelectedItem as string;

                        //if (!string.IsNullOrEmpty(selectedCommandName))
                        //{




                        // Buscar el servidor con el nombre especificado y eliminarlo.



                        //Servers commandToRemove = commandList.FirstOrDefault(s => s.Command == selectedCommandName);
                        //if (commandToRemove != null)
                        //{
                        //    commandList.Remove(commandToRemove);
                        //}

                        // Guardar la lista actualizada de comandos en el archivo XML.

                        //using (FileStream fs = new FileStream(xmlFilePathServers, FileMode.Create))
                        //{
                        //    XmlSerializer serializer = new XmlSerializer(typeof(List<Servers>));
                        //    serializer.Serialize(fs, commandList);
                        //}

                        // Opcional: Limpia la selecci�n.
                        //listBoxCommands.ClearSelected();
                        //listBoxCommands.Items.Clear();
                        //}
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
                if (listBoxCommands.SelectedIndex != -1)
                {

                    //List<Commands> commandsList = LoadCommandsFromXml(xmlFilePathCommands);
                    //string selectedCommand = listBoxCommands.SelectedItem as string;

                    //if (!string.IsNullOrEmpty(selectedCommand))
                    //{
                    //    CRUDCommandsView commandCRUD = new(selectedCommand);

                    //    DialogResult result = commandCRUD.ShowDialog();

                    //    if (result == DialogResult.OK)
                    //    {
                    //        listBoxCommands.Items.Clear();
                    //        LoadCommandsFromXml();
                    //    }
                    //}

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
                // Aqu� va la respuesta al ejecutar el c�digo en el servidor 
            }
            catch (Exception ex)
            {
#if DEBUG
                Debug.WriteLine(ex.Message);
                Debugger.Break();
#endif
            }
        }

        private void LoadServersFromXml()
        {


            if (File.Exists(xmlFilePathServers))
            {
                // Leer los servidores desde el archivo XML y agregarlos al ListBox.
                using (FileStream fs = new FileStream(xmlFilePathServers, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Servers>));
                    List<Servers> serverList = (List<Servers>)serializer.Deserialize(fs);

                    foreach (Servers server in serverList)
                    {
                        listBoxServers.Items.Add(server.Name); // Agregar el nombre del servidor al ListBox de la pantalla.
                    }
                }
            }
            else
            {
                // Si el archivo XML no existe, crea uno nuevo archivo xml para guardar la informacion.
                List<Servers> newServerList = new List<Servers>();
                using (FileStream fs = new FileStream(xmlFilePathServers, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Servers>));
                    serializer.Serialize(fs, newServerList);
                }
                // MessageBox.Show("Se ha creado un nuevo archivo XML de servidores.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private List<Servers> LoadServersFromXml(string xmlFilePath)
        {
            List<Servers> serverList = new List<Servers>();

            if (File.Exists(xmlFilePath))
            {
                using (FileStream fs = new FileStream(xmlFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Servers>));
                    serverList = (List<Servers>)serializer.Deserialize(fs);
                }
            }
            return serverList;
        }
    }
}