using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OutsideBoxApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OutsideBoxApi.Repositories
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options) { }

        public DbSet<ShareableCode> shareableCodes { get; set; }

    }
}
