using Abp.Application.Services.Dto;

namespace UNMR.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

