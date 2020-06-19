using OutsideBoxApi.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OutsideBoxApi.Models
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        [AllowNull]
        public DateTime UpdatedAt { get; set; }

        public IPAddress CreatedLocation { get; set; }

        [AllowNull]
        public IPAddress UpdatedLocation { get; set; }

    }
}
