using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class List_User
    {
        public string Id { get; set; }

        [Required, StringLength(255)]
        public string Email { get; set; }

        [Required, StringLength(255)]
        public string Nama { get; set; }

        [Required, StringLength(255)]
        public string Alamat { get; set; }
        
        public long nomor_id { get; set; }
    }
}
