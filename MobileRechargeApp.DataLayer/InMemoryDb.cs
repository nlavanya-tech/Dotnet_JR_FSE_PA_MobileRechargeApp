using Microsoft.EntityFrameworkCore;
using MobileRechargeApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileRechargeApp.DataLayer
{
    public class InMemoryDb : DbContext
    {
        //Create InmemoryDb Context
        public InMemoryDb(DbContextOptions<InMemoryDb> options) : base(options)
        {

        }

        //Create Notes Property
        public DbSet<Postpaid> postpaid { get; set; }
        public DbSet<Prepaid> prepaid { get; set; }

    }
}
