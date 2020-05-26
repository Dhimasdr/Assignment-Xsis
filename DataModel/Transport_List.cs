using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    [Table("TransportList")]
    public class Transport_List
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required, StringLength(255)]
        public string nama { get; set; }

        [Required, StringLength(255)]
        public string plat_nomor { get; set; }

        public bool isActive { get; set; }
        
        public int ready_count { get; set; }

        public int harga { get; set; }

        public int total { get; set; }

        public virtual ICollection<DataRent> DataRents { get; set; }
        


    }
}
