using RemoteCommandExecution.Models;
using RemoteCommandExecution.Views;
using Renci.SshNet;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RemoteCommandExecution
{
    public partial class MainView : Form
    {

        string xmlFilePathServers = "Servers.xml"; // Ruta al archivo XML
        string xmlFilePathCommands = "Comandos.xml"; // Ruta al archivo XML

        public MainView()
        {
            InitializeComponent();
            LoadServersFromXml();
            LoadCommandsFromXml();


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
                    DialogResult resultado = MessageBox.Show("¿Desea eliminar el servidor?", "Sí", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        // Eliminar la información del servidor aquí
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

                            // Opcional: Limpia la selección.
                            //listBoxServers.ClearSelected();
                            listBoxServers.Items.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                listBoxServers.Items.Clear();
                LoadServersFromXml();
            }
            catch (Exception ex)
            {
#if DEBUG
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Ha ocurrido un error agregando el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                CRUDCommandsView crudCommandsView = new CRUDCommandsView();
                DialogResult result = crudCommandsView.ShowDialog();

                if (result == DialogResult.OK)
                {
                    listBoxCommands.Items.Clear();
                    LoadCommandsFromXml();

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
                    DialogResult resultado = MessageBox.Show("¿Desea eliminar el comando?", "Sí", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        // Eliminar el comando aquí
                        List<Commands> commandList = LoadCommandsFromXml(xmlFilePathCommands);
                        string selectedCommandText = listBoxCommands.SelectedItem as string;

                        if (!string.IsNullOrEmpty(selectedCommandText))
                        {
                            // Buscar el comando con el texto especificado y eliminarlo.
                            Commands commandToRemove = commandList.FirstOrDefault(c => c.Command == selectedCommandText);
                            if (commandToRemove != null)
                            {
                                commandList.Remove(commandToRemove);
                            }
                            // Guardar la lista actualizada de servidores en el archivo XML.
                            using (FileStream fc = new FileStream(xmlFilePathCommands, FileMode.Create))
                            {
                                XmlSerializer serializer = new XmlSerializer(typeof(List<Commands>));
                                serializer.Serialize(fc, commandList);
                            }

                            // Limpiar la selección y actualizar la lista de comandos.
                            listBoxCommands.Items.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                listBoxCommands.Items.Clear();
                LoadCommandsFromXml();
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
                    List<Commands> commandList = LoadCommandsFromXml(xmlFilePathCommands);
                    string selectedCommandText = listBoxCommands.SelectedItem as string;

                    if (!string.IsNullOrEmpty(selectedCommandText))
                    {
                        CRUDCommandsView commandCRUD = new(selectedCommandText);

                        DialogResult result = commandCRUD.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            listBoxCommands.Items.Clear();
                            LoadCommandsFromXml();
                        }
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

        private void pictBoxPlayCommand_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedServerName = listBoxServers.SelectedItem as string;
                string selectedCommandText = listBoxCommands.SelectedItem as string;

                if (string.IsNullOrEmpty(selectedServerName) || string.IsNullOrEmpty(selectedCommandText))
                {
                    MessageBox.Show("Por favor seleccione el servidor y comando que desea ejecutar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string ip = "";
                string user = "";
                string password = "";

                List<Servers> serverList = LoadServersFromXml(xmlFilePathServers);
                Servers serverInfo = serverList.FirstOrDefault(s => s.Name == selectedServerName);

                if (serverInfo != null)
                {
                    ip = serverInfo.Ip;
                    user = serverInfo.User;
                    password = serverInfo.Password;
                }

                using (var client = new SshClient(ip, user, password))
                {
                    try
                    {
                        client.Connect();

                        List<Commands> commandList = LoadCommandsFromXml(xmlFilePathCommands);
                        string selectedCommand = commandList.FirstOrDefault(c => c.Command == selectedCommandText)?.Command;

                        if (selectedCommand != null)
                        {
                            var cmd = client.RunCommand(selectedCommand);
                            string result = cmd.Result;

                            if (string.IsNullOrEmpty(result))
                            {
                                txbResponseCommand.AppendText("Se ha conectado al servidor correctamen" + Environment.NewLine);
                                txbResponseCommand.AppendText(selectedCommand + Environment.NewLine + result);
                            }
                            else
                            {
                                txbResponseCommand.AppendText("Se ha conectado al servidor correctamen" + Environment.NewLine);
                                txbResponseCommand.AppendText(selectedCommand + Environment.NewLine + result + Environment.NewLine);
                            }
                        }
                        else
                        {
                            txbResponseCommand.AppendText("No se pudo ejecutar el comando" + Environment.NewLine);
                        }
                    }
                    catch (Exception ex)
                    {
                        txbResponseCommand.AppendText("No se pudo conectar al servidor" + Environment.NewLine);
                    }
                    finally
                    {
                        client.Disconnect();
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
        private void LoadCommandsFromXml()
        {
            if (File.Exists(xmlFilePathCommands))
            {
                // Leer los comandos desde el archivo XML y agregarlos al ListBox.
                using (FileStream fs = new FileStream(xmlFilePathCommands, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Commands>));
                    List<Commands> commandList = (List<Commands>)serializer.Deserialize(fs);

                    foreach (Commands command in commandList)
                    {
                        listBoxCommands.Items.Add(command.Command); // Agregar el comando al ListBox de la pantalla.
                    }
                }
            }
            else
            {
                // Si el archivo XML no existe, crea uno nuevo archivo XML para guardar la información.
                List<Commands> newCommandList = new List<Commands>();
                using (FileStream fs = new FileStream(xmlFilePathCommands, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Commands>));
                    serializer.Serialize(fs, newCommandList);
                }
                // MessageBox.Show("Se ha creado un nuevo archivo XML de comandos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private List<Commands> LoadCommandsFromXml(string xmlFilePath)
        {
            List<Commands> commandList = new List<Commands>();

            if (File.Exists(xmlFilePath))
            {
                using (FileStream fs = new FileStream(xmlFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Commands>));
                    commandList = (List<Commands>)serializer.Deserialize(fs);
                }
            }
            return commandList;
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
                // MessageBox.Show("Se ha creado un nuevo archivo XML de servidores.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void MainView_Load(object sender, EventArgs e)
        {

        }
    }
}