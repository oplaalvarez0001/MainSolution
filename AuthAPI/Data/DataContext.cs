using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthAPI.Data
{
    public class DataContext :IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
            
        }
    }
}