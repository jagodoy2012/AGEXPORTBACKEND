using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AGEXPORTBACKEND.Models;

namespace AGEXPORTBACKEND.Data
{
    public class AGEXPORTBACKENDContext : DbContext
    {
        public AGEXPORTBACKENDContext (DbContextOptions<AGEXPORTBACKENDContext> options)
            : base(options)
        {
        }

        public DbSet<AGEXPORTBACKEND.Models.Empleado> Empleado { get; set; } = default!;
    }
}
