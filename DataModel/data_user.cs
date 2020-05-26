using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    [Table("DataUser")]
    public class data_user
    {
        [Key]
        public string Id { get; set; }

        [Required, StringLength(255)]
        public string Email { get; set; }

        [Required, StringLength(255)]
        public string Nama { get; set; }

        [Required, StringLength(255)]
        public string Alamat { get; set; }

        [Required]
        public long nomor_id { get; set; }
        
        public virtual ICollection<DataRent> DataRents { get; set; }

        public virtual ICollection<Transport_List> Transport_Lists { get; set; }

    }
}
