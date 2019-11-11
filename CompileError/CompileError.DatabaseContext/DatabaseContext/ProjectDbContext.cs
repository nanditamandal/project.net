using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompileError.Model.Model;

namespace CompileError.DatabaseContext.DatabaseContext
{
    public class ProjectDbContext:DbContext
    {
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
