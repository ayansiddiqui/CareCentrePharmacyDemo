using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using caredemo.Models;

namespace caredemo.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<caredemo.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<caredemo.Models.Bill> Bill { get; set; }

        public DbSet<caredemo.Models.BillType> BillType { get; set; }

        public DbSet<caredemo.Models.Branch> Branch { get; set; }

        public DbSet<caredemo.Models.CashBank> CashBank { get; set; }

        public DbSet<caredemo.Models.Currency> Currency { get; set; }

        public DbSet<caredemo.Models.Customer> Customer { get; set; }

        public DbSet<caredemo.Models.CustomerType> CustomerType { get; set; }

        public DbSet<caredemo.Models.GoodsReceivedNote> GoodsReceivedNote { get; set; }

        public DbSet<caredemo.Models.Invoice> Invoice { get; set; }

        public DbSet<caredemo.Models.InvoiceType> InvoiceType { get; set; }

        public DbSet<caredemo.Models.NumberSequence> NumberSequence { get; set; }

        public DbSet<caredemo.Models.PaymentReceive> PaymentReceive { get; set; }

        public DbSet<caredemo.Models.PaymentType> PaymentType { get; set; }

        public DbSet<caredemo.Models.PaymentVoucher> PaymentVoucher { get; set; }

        public DbSet<caredemo.Models.Product> Product { get; set; }

        public DbSet<caredemo.Models.ProductType> ProductType { get; set; }

        public DbSet<caredemo.Models.PurchaseOrder> PurchaseOrder { get; set; }

        public DbSet<caredemo.Models.PurchaseOrderLine> PurchaseOrderLine { get; set; }

        public DbSet<caredemo.Models.PurchaseType> PurchaseType { get; set; }

        public DbSet<caredemo.Models.SalesOrder> SalesOrder { get; set; }

        public DbSet<caredemo.Models.SalesOrderLine> SalesOrderLine { get; set; }

        public DbSet<caredemo.Models.SalesType> SalesType { get; set; }

        public DbSet<caredemo.Models.Shipment> Shipment { get; set; }

        public DbSet<caredemo.Models.ShipmentType> ShipmentType { get; set; }

        public DbSet<caredemo.Models.UnitOfMeasure> UnitOfMeasure { get; set; }

        public DbSet<caredemo.Models.Vendor> Vendor { get; set; }

        public DbSet<caredemo.Models.VendorType> VendorType { get; set; }

        public DbSet<caredemo.Models.Warehouse> Warehouse { get; set; }

        public DbSet<caredemo.Models.UserProfile> UserProfile { get; set; }
    }
}
