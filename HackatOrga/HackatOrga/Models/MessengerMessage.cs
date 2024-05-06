using System;
using System.Collections.Generic;

namespace HackatOrga.Models
{
    public partial class MessengerMessage
    {
        public long Id { get; set; }
        public string Body { get; set; } = null!;
        public string Headers { get; set; } = null!;
        public string QueueName { get; set; } = null!;
        /// <summary>
        /// (DC2Type:datetime_immutable)
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// (DC2Type:datetime_immutable)
        /// </summary>
        public DateTime AvailableAt { get; set; }
        /// <summary>
        /// (DC2Type:datetime_immutable)
        /// </summary>
        public DateTime? DeliveredAt { get; set; }
    }
}
