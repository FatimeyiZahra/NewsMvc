using NewsMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsMvc.ViewModels
{
    public class NewsSingleViewModel
    {
        public News NewsDetails { get; set; }
        public List<Category> Categories { get; set; }
    }
}
