using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titanik.Repository.Entity;
using System.Data.SqlClient;
using System.Data.Entity;

namespace Titanik.Repository
{
    public class TitanikContext : DbContext
    {
        public TitanikContext(): base(@"Data Source = 172.18.195.19\OYAKDEVDB; Initial Catalog = VBTIK_DEV; User ID = VbtIK; Password=1234")
        {
            var ensureDLLIsCopied =
                System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<User> Users { get; set; }
    }
}
