using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OutsideBoxApi.Models
{
    public class CodeBox : BaseEntity
    {
        public int Code { get; set; }
        public DateTime Expiration { get; set; }
    }
}
