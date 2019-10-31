﻿using ExpenseAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExpenseAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=ExpenseDb")
        {

        }

        public DbSet<Entry> Entries { get; set; }
    }
}