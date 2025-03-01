using Microsoft.EntityFrameworkCore;

namespace Dev_JS_Enquiry.Model
{
    public class EnquiryDbContext : DbContext
    {
        public EnquiryDbContext(DbContextOptions<EnquiryDbContext> options) : base(options)
        {
        }

        public DbSet<EnquiryStatus> EnquiryStatuses { get; set; }
        public DbSet<EnquiryTypes> EnquiryTypes { get; set; }
        public DbSet<EnquiryModel> EnquiryModels { get; set; }


    }
}
