using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace zaj05.Models
{
    public class ConferenceUserContext : DbContext
    {
        public DbSet<ConferenceUser> ConferenceUsers { get; set; }

        public ConferenceUserContext() : base("Kopytko")
        {
            Database.SetInitializer(new CompanyInitializer());
        }

    }

    public class CompanyInitializer : DropCreateDatabaseIfModelChanges<ConferenceUserContext>
    {
        protected override void Seed(ConferenceUserContext context)
        {
            //context.Database.ExecuteSqlCommand(@"ALTER TABLE ConferenceUsers ADD AvatarID [uniqueidentifier] DEFAULT NEWID() unique ROWGUIDCOL  NOT NULL; ");
            base.Seed(context);
            InitDatabase(context);
        }

        public void InitDatabase(ConferenceUserContext context)
        {

        }

    }
}