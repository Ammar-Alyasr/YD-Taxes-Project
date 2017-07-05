using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaxesProjecte.Models;
using System.Data.Entity;

namespace TaxesProjecte.Data_Access
{
    public class Context : DbContext
    {
        public Context()
            : base("name=codi")
        {

        }

        public DbSet<citizen> citizens_tbl { get; set; }

    }
}