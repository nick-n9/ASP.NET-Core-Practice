using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCoreDataBaseLayer
{
    public class DbContext : IdentityDbContext<MyUser>
    {
        public DbContext(DbContextOptions<DbContext> options)
           : base(options)
        {
        }

    }
}
