using System;

namespace TamagotchiAPI.Models
{
    public class Play
    {
        public int Id { get; set; }
        public DateTime When { get; set; } = DateTime.Now;
        public int PetId { get; set; }
    }
}