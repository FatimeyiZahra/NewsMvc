using NewsMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsMvc.ViewModels
{
    public class HomeViewModel
    {
        public  List<News> TopNews { get; set; }
        public List<News> LastNews { get; set; }
        public List<News> AllNews { get; set; }
        public List<Category> Categories { get; set; }

        public List<News> MostSharedNews { get; set; }


    }
}
