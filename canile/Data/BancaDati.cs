using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace canile.Data
{
	public class BancaDati : DbContext
	{
		public DbSet<Cane> cani { get; set; }


		public BancaDati(DbContextOptions options) : base(options) { }
	}
}
