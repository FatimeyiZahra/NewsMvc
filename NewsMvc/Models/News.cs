using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsMvc.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Photo { get; set; }
        public bool IsTop { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
