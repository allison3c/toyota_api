using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TOYOTA.API.Models.ReportDto
{
    public class SaveReportAttachdto
    {
        public int UserId { get; set; }
        public List<ReportAttachmentDto> AttachList { get; set; }

    }
}
