using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    [Table("DataRent")]
    public class DataRent
    {
        [Key]
        public string Id { get; set; }
        
        public string id_User { get; set; }
        
        public string id_Kendaraan { get; set; }

        public bool Status { get; set; }

        [Required, StringLength(255)]
        public string Nomor_Pesanan { get; set; }

        public DateTime Start_Date { get; set; }

        public DateTime End_Date { get; set; }

        public virtual data_user DataUser { get; set; }

        public virtual Transport_List Transport_List { get; set; }



    }
}
