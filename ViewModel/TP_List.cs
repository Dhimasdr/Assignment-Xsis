using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class TP_List
    {
        public string Id { get; set; }

        [Required, StringLength(255)]
        public string nama { get; set; }

        [Required, StringLength(255)]
        public string plat_nomor { get; set; }

        public bool isActive { get; set; }

        public string id_gambar { get; set; }

        public int ready_count { get; set; }

        public int total { get; set; }
    }
}
