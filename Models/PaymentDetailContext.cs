using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_WebAPI.Models
{
    public class PaymentDetailContext:DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options):base(options)
        {
        }

        //property for this class
        public DbSet<PaymentDetail> paymentDetails { get; set; }
    }
}
