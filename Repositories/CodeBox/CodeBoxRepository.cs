using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models = OutsideBoxApi.Models;

namespace OutsideBoxApi.Repositories.CodeBox
{
    public class CodeBoxRepository : Repository<Models.CodeBox>, ICodeBoxRepository
    {
        public CodeBoxRepository(DatabaseContext context) : base(context)
        { }
    }
}
