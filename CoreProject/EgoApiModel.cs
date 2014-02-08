using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreProject
{
    public class EgoApiModel
    {
        public string Err { get; set; }
        public string Msg { get; set; }
        public int Row { get; set; }
        //public List<Dictionary<string, string>> Tbl { get; set; }
        public List<EgoApiModelSingleItem> Tbl { get; set; }
    }

    public class EgoApiModelSingleItem
    {
        public string kodu { get; set; }
        public string adi { get; set; }
        public string mesafesi { get; set; }
        public string suresi { get; set; }
        public string otobus { get; set; }
        public string detay { get; set; }
        public string px { get; set; }
        public string py { get; set; }
        public string opx { get; set; }
        public string opy { get; set; }
        public string yon { get; set; }
    }
}