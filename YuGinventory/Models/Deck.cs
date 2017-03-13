using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YuGinventory.Models
{
    public class Deck
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string SleeveColour { get; set; }
        public string BoxColour { get; set; }
    }
}
