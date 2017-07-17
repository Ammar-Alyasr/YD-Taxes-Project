namespace TaxesProjecte.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TaxesProjecte.Data_Access.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TaxesProjecte.Data_Access.Context context)
        {

            context.citizens_tbl.AddOrUpdate(
              p => p.citizen_name,
              new citizen {  citizen_name = "toor" , id=123, tc_no="99559453436", email="ammarik@com", password="root"}
            );

        }
    }
}
