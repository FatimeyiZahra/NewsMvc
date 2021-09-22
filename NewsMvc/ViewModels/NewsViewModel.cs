using NewsMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsMvc.ViewModels
{
    public class NewsViewModel
    {
        public List<Category> Categories { get; set; }
        public List<News> News { get; set; }
    }
}
