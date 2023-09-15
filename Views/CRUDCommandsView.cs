using RemoteCommandExecution.Models;
using Renci.SshNet;
using System.Diagnostics;
using System.Xml.Serialization;

namespace RemoteCommandExecution.Views
{
    public partial class CRUDCommandsView : Form
    {
        public int _commandId { get; set; } = 0;
        public string _commandName { get; set; }
        string xmlFilePathServers = "Servers.xml"; // Ruta al archivo XML
        string xmlFilePathCommands = "Comandos.xml"; // Ruta al archivo XML
        public event EventHandler CommandAdded;

        public CRUDCommandsView(string command = "")
        {
            InitializeComponent();
            _commandName = command;

            if (!String.IsNullOrEmpty(command))
            {
                textboxComando.Text = "Cargando...";
                LoadCommandData(command);
            }


        }
        private void LoadCommandData(string commandName)
        {
            Commands commandData = GetCommandDataByName(commandName);

            if (commandData != null)
            {
                _commandId = commandData.Id;
                textboxComando.Text = commandData.Command;
            }

        }

        private Commands GetCommandDataByName(string commandName)
        {
            List<Commands> commandList = LoadCommandsFromXml();
            return commandList.Find(c => c.Command == commandName);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Commands> LoadCommandsFromXml()
        {

            if (File.Exists(xmlFilePathCommands))
            {
                using (FileStream fs = new FileStream(xmlFilePathCommands, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Commands>));
                    return (List<Commands>)serializer.Deserialize(fs);
                }
            }
            return new List<Commands>();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            try
            {
                string ip = "";
                string user = "";
                string password = "";

                List<Servers> serverList = LoadServersFromXml(xmlFilePathServers);

                if (serverList.Any())
                {
                    ip = serverList.First().Ip;
                    user = serverList.First().User;
                    password = serverList.First().Password;

                    using (var client = new SshClient(ip, user, password))
                    {
                        try
                        {
                            client.Connect();

                            string commandText = textboxComando.Text.Trim();

                            if (string.IsNullOrEmpty(commandText))
                            {
                                MessageBox.Show("Por favor, ingrese un comando válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;

                            }
                            else
                            {
                                var cmd = client.RunCommand(commandText);
                                string result = cmd.Result;

                                if (cmd.ExitStatus == 0)
                                {
                                    Commands commandData = new Commands
                                    {
                                        Command = commandText
                                    };

                                    if (_commandId > 0)
                                    {
                                        bool success = ModifyCommandData(_commandId, commandData);
                                        if (success)
                                        {
                                            MessageBox.Show("Se ha modificado la información del comando", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            CommandAdded?.Invoke(this, EventArgs.Empty);
                                            DialogResult = DialogResult.OK;
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ha ocurrido un error modificando el comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        bool success = AddCommandData(commandData);
                                        if (success)
                                        {
                                            MessageBox.Show("Se ha agregado un nuevo comando", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            CommandAdded?.Invoke(this, EventArgs.Empty);
                                            DialogResult = DialogResult.OK;
                                            this.Close();
                                        }
                                        else
                                        {

                                            MessageBox.Show("Ha ocurrido un error agregando el comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                else
                                {
                                    //necesitamos un mensaje de error
                                    if (_commandId > 0)
                                    {
                                        MessageBox.Show("Ha ocurrido un error modificando el comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ha ocurrido un error agregando el comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ha ocurrido un error agregando el comando. Error: {ex.Message}");
                        }
                        finally
                        {
                            client.Disconnect();
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Ha ocurrido un error agregando el comando. Error: debe de haber ingresado un servidor valido antes.");
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


        private bool ModifyCommandData(int commandId, Commands updatedCommandData)
        {
            List<Commands> commandList = LoadCommandsFromXml();

            Commands existingCommand = commandList.Find(c => c.Id == commandId);

            if (existingCommand != null)
            {
                existingCommand.Command = updatedCommandData.Command;

                SaveCommandsToXml(commandList);

                return true;
            }

            return false;
        }


        private void SaveCommandsToXml(List<Commands> commandList)
        {
            using (FileStream fs = new FileStream(xmlFilePathCommands, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Commands>));
                serializer.Serialize(fs, commandList);
            }
        }

        private int GenerateUniqueId(List<Commands> commandList)
        {
            int maxId = 0;

            foreach (var command in commandList)
            {
                if (command.Id > maxId)
                {
                    maxId = command.Id;
                }
            }

            return maxId + 1;
        }

        private bool AddCommandData(Commands newCommandData)
        {
            List<Commands> commandList = LoadCommandsFromXml();

            int newId = GenerateUniqueId(commandList);

            newCommandData.Id = newId;

            commandList.Add(newCommandData);

            SaveCommandsToXml(commandList);

            return true;
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
