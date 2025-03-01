using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Dev_JS_Enquiry.Model
{
    [Table("ENQUIRY_TYPE")]
    public class EnquiryTypes
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TYPE_ID")]
        public int TypeId { get; set; }
        [Column("TYPE_NAME")]
        public string TypeName { get; set; } = string.Empty;
    }
}