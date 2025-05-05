using System;
using System.Collections.Generic;

namespace TodoApi
{
    public class Item
    {
        public int Id { get; set; }
        public string NameT { get; set; }
        public bool IsComplete { get; set; }
        public int UserId { get; set; }
    }
}
