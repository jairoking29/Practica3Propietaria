using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication2
{
    class Practice3Db : DbContext
    {
        public Practice3Db() : base("Practica3Db")
        {

        }

        public DbSet<AccountingEntry> AccountingEntries { get; set; }
    }
}
