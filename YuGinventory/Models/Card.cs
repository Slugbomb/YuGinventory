using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YuGinventory.Models
{
    public class Card
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public int ReferenceCardId { get; set; }
        public int DeckId { get; set; }
    }
}