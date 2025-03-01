using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dev_JS_Enquiry.Model
{
    [Table("ENQUIRY_STATUS")]
    public class EnquiryStatus
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("STATUS_ID")]
        public int StatusId { get; set; }
        [Required]
        [Column("STATUS")]
        public string Status { get; set; } = string.Empty;
    }
}
