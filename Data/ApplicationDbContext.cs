using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

using appversion2.Models;

 

namespace appversion2.Data;

 

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)

{

    public DbSet<Product> Products { get; set; }

}
