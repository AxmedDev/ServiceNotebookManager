using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceNotebook.DAL.Repositories.Log;

namespace ServiceNotebook.API.Controllers.AuditLog
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditLogController : ControllerBase
    {
        private readonly AuditLogRepository auditLogRepository;
        public AuditLogController(AuditLogRepository auditLogRepository)
        {
            this.auditLogRepository = auditLogRepository;
        }

        [HttpGet]
        public async Task<IActionResult>  GetActionAsync()
        {
           return Ok (await auditLogRepository.GetAuditLogsAsync());

        }
    }
}
