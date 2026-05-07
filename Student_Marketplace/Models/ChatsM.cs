namespace Student_Marketplace.Models
{
    public class ChatsM
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string MessageContent { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;


    }
}
