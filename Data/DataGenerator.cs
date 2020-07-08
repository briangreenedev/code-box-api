using OutsideBoxApi.Models;
using OutsideBoxApi.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OutsideBoxApi.Data
{
    public class DataGenerator
    {
        protected readonly DatabaseContext context;
        public DataGenerator(DatabaseContext context)
        {
            this.context = context;
        }
    }
}
