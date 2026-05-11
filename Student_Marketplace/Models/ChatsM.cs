namespace Student_Marketplace.Models
{
    public class ChatsM
    {
        public int Id { get; set; }
        public string Sender { get; set; } = string.Empty;
        public string Receiver { get; set; } = string.Empty;
        public string MessageContent { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; } = DateTime.Now;


    }
}
