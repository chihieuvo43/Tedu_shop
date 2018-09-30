using System;

namespace tedushop.model.model
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }

        string MetaKeyword { get; set; }
        string MetaDiscription { get; set; }

        bool Status { get; set; }
    }
}
