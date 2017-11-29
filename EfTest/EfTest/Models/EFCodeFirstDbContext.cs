using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EfTest.Models
{
    public class EFCodeFirstDbContext : DbContext
    {

        public EFCodeFirstDbContext() : base("name=MyStrConn") { }

        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Que> Ques { get; set; }


        public override int SaveChanges()
        {
            //RowVersionHelper.SetRowVersion(this);
            //school.RowVersion = await RowVersionHelper.Get(Request.Form);
            //school.RowVersion = await RowVersionHelper.GetAsync(Request.Form);

            try
            {
                int result = base.SaveChanges();
                return result;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw RowVersionHelper.DbUpdateConcurrencyException;
            }
            catch (OptimisticConcurrencyException)
            {
                throw RowVersionHelper.OptimisticConcurrencyException;
            }
        }

        public override async Task<int> SaveChangesAsync()
        {
            try
            {
                int result = await base.SaveChangesAsync();
                return result;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw RowVersionHelper.DbUpdateConcurrencyException;
            }
            catch (OptimisticConcurrencyException)
            {
                throw RowVersionHelper.OptimisticConcurrencyException;
            }
        }
    }

}