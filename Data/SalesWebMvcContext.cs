using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

public class SalesWebMvcContext : DbContext
{
    public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options)
        : base(options)
    {
    }

    public DbSet<SalesWebMvc.Models.Department> Department { get; set; } = default!;
    public DbSet<Seller> Seller { get; set; } = default!;
    public DbSet<SalesRecord> SalesRecord { get; set; } = default!;
}
