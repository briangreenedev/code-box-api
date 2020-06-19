using System;

namespace OutsideBoxApi.Models
{
    public class ShareableCode : BaseEntity
    {
        public int Code { get; set; }
        public DateTime Expiration { get; set; }
    }
}
