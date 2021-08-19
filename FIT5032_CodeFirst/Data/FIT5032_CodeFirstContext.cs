using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FIT5032_CodeFirst.Data
{
    public class FIT5032_CodeFirstContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FIT5032_CodeFirstContext() : base("name=FIT5032_CodeFirstContext")
        {
        }

        public System.Data.Entity.DbSet<FIT5032_CodeFirst.Models.Student> Students { get; set; }
    }
}
