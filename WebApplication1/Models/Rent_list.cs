using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Rent_list
    {
        public string Id { get; set; }
        public string Id_user { get; set; }
        public string Id_kendaraan { get; set; }
        public bool status { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public int nomor_pesanan { get; set; }
    }
}