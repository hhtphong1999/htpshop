using System;

namespace HtpShop.Model.Abstract
{
    internal interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }
        bool Status { set; get; }
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
    }
}