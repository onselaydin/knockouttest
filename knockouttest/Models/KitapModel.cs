using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace knockouttest.Models
{
    public class KitapModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
    public class KutuphaneModel
    {
        public List<KitapModel> Kitaplar { get; set; }
    }
}