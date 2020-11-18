using System;
using System.Collections.Generic;
using System.Text;

namespace TeduShop.Model.Abstract
{
    public interface IAudiTable
    {
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }
        string MetaKeyWord { get; set; }
        string MetaDescription { get; set; }
        string Status { get; set; }
    }
}
