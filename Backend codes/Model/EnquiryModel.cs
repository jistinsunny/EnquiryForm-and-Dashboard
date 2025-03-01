using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Dev_JS_Enquiry.Model
{
    [Table("ENQUIRY")]
    public class EnquiryModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ENQUIRY_ID")]
        public int EnquiryId { get; set; }
        [Column("ENQUIRY_TYPE_ID")]
        public int EnquiryTypeId { get; set; }
        [Column("ENQUIRY_STATUS_ID")]
        public int EnquiryStatusId { get; set; }
        [Column("CUSTOMER_NAME")]
        public string CustomerName { get; set; } = string.Empty;
        [Column("MOBILE_NO")]
        public string MobileNo { get; set; } = string.Empty;
        [Column("EMAIL")]
        public string Email { get; set; } = string.Empty;
        [Column("MESSAGE")]
        public string Message { get; set; } = string.Empty;
        [Column("CREATED_DATE")]
        public DateTime CreatedDateTime { get; set; }
        [Column("RESOLUTION")]
        public string Resolution { get; set; } = string.Empty;
    }
}
