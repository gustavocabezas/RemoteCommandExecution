namespace RemoteCommandExecution.Models
{
    public class Commands
    {
        public int Id { get; set; }
        public int ServerId { get; set; }
        public string? Command { get; set; }
    }
}
