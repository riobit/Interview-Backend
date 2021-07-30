using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Models
{
    public class QuestionModel : Item
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public DateTime CreatedAt { get; set; }
    }

    public class QuestionThreeModel
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public List<Item> Items { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
    }

    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Footer { get; set; }

    }
}
