using System;

namespace API.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public string SenderUsername { get; set; }
        public AppUser Sender { get; set; }
        public int RecipientId { get; set; }
        public string RecipientUsername { get; set; }
        public AppUser Recipient { get; set; }
        
        public DateTime DateSent { get; set; } = DateTime.Now;
        public DateTime? DateRead { get; set; }
        
        public string Content { get; set; }
        public bool SenderDeleted { get; set; }
        public bool RecipientDeleted { get; set; }
    }
}