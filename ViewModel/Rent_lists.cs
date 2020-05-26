using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class Rent_lists
    {
        public string Id { get; set; }

        public string id_User { get; set; }

        public string email { get; set; }

        public string id_Kendaraan { get; set; }

        public bool Status { get; set; }

        [Required, StringLength(255)]
        public string Nomor_Pesanan { get; set; }

        public DateTime Start_Date { get; set; }

        public DateTime End_Date { get; set; }


    }
}
