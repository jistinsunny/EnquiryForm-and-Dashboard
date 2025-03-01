using Dev_JS_Enquiry.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dev_JS_Enquiry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAngularApp")]
    public class EnquiryMasterController : ControllerBase
    {
        private readonly EnquiryDbContext _context;

        public EnquiryMasterController(EnquiryDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllStatus")]
        public List<EnquiryStatus> GetEnquiryStatus()
        {
            var list = _context.EnquiryStatuses.ToList();
            return list;
        }

        [HttpGet("GetAllTypes")]
        public List<EnquiryTypes> GetAllTypes()
        {
            var list = _context.EnquiryTypes.ToList();
            return list;
        }

        [HttpGet("GetAllEnquiry")]
        public List<EnquiryModel> GetAllEnquiry()
        {
            var list = _context.EnquiryModels.ToList();
            return list;
        }

        [HttpPost("CreateNewEnquiry")]
        public EnquiryModel AddNewEnquiry(EnquiryModel obj)
        {
            try
            {
                obj.CreatedDateTime = DateTime.Now;
                _context.EnquiryModels.Add(obj);
                _context.SaveChanges();
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("UpdateEnquiry")]
        public EnquiryModel Update(EnquiryModel obj)
        {
            var record = _context.EnquiryModels.SingleOrDefault(m => m.EnquiryId == obj.EnquiryId);
            if (record != null)
            {
                record.EnquiryStatusId = obj.EnquiryStatusId;
                record.Resolution = obj.Resolution;
                _context.SaveChanges();
            }

            return obj;

        }

        [HttpDelete("DeleteEnquiryById")]
        public bool DeleteEnquiryById(int id)
        {
            var record = _context.EnquiryModels.SingleOrDefault(m => m.EnquiryId == id);
            if (record != null)
            {
                _context.EnquiryModels.Remove(record);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
