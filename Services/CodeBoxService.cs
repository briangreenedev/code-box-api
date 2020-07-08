using Microsoft.EntityFrameworkCore.Storage;
using OutsideBoxApi.Models;
using OutsideBoxApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OutsideBoxApi.Services
{
    public class CodeBoxService
    {
        protected DatabaseContext context;

        public CodeBoxService(DatabaseContext context)
        {
            this.context = context;
        }

        public void CreateNewCodeBox(string value)
        {

        }
    }
}
