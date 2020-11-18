using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeduShop.Model.Abstract
{
    public abstract class AudiTable : IAudiTable
    {
        public DateTime? CreatedDate { get; set; }
        [MaxLength(256)]
        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        [MaxLength(256)]
        public string UpdateBy { get; set; }
        [MaxLength(256)]
        public string MetaKeyWord { get; set; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }
        [MaxLength(256)]
        public string Status { get; set; }
    }
}
