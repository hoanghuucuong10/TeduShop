using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("SupportOnlines")]
    class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(256)]
        public string Skype { get; set; }
        [MaxLength(256)]
        public string FaceBook { get; set; }
        [MaxLength(256)]
        public string Mobile { get; set; }
        [MaxLength(256)]
        public string Department { get; set; }
        [MaxLength(256)]
        public string Status { get; set; }
        [MaxLength(256)]
        public string Email { get; set; }
    }
}
