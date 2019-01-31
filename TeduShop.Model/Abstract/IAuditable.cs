using System;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { get; set; }
        string UpdateBy { set; get; }

        string MetaKeyWord { set; get; }
        string MetaDescription { set; get; }

        bool Status { get; set; }
    }
}