using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Transport_List
    {
        public string Id { get; set; }
        public string plat_nomor { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public bool is_active { get; set; }
        public int ready_count { get; set; }
        public int total { get; set; }
        public string id_gambar { get; set; }
    }
}