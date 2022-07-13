namespace NexerApplication.Model.Configurations
{
    public class ConnectionStringsOptions
    {
        public const string ConnectionStrings = "ConnectionStrings";

        public string BlobEndpoint { get; set; } = String.Empty;
        public string QueueEndpoint { get; set; } = String.Empty;
        public string FileEndpoint { get; set; } = String.Empty;
        public string TableEndpoint { get; set; } = String.Empty;
        public string SharedAccessSignature { get; set; } = String.Empty;
    }
}
