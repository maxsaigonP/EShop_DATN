﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DA_TotNghiep.Models;
using E_Shop_DATN.Models;

namespace E_Shop.Data
{
    public class E_ShopContext : DbContext
    {
        public E_ShopContext (DbContextOptions<E_ShopContext> options)
            : base(options)
        {
        }

        public DbSet<DA_TotNghiep.Models.Admin>? Admin { get; set; }

        public DbSet<DA_TotNghiep.Models.Product>? Product { get; set; }

        public DbSet<E_Shop_DATN.Models.Log>? Log { get; set; }

        public DbSet<E_Shop_DATN.Models.ImportedInvoice>? ImportedInvoice { get; set; }

        public DbSet<E_Shop_DATN.Models.ImportecInvoiceDetail>? ImportecInvoiceDetail { get; set; }
    }
}
