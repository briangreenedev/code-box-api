using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OutsideBoxApi.Data
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public IPAddress CreatedLocation { get; set; }
        public IPAddress UpdatedLocation { get; set; }
    }
}
