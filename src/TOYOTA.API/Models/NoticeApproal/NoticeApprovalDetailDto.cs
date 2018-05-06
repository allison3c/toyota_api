﻿using TOYOTA.API.Models.ImprovementDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TOYOTA.API.Models.NoticeApproal
{
    public class NoticeApprovalDetailDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ReplyContent { get; set; }
        public string Status { get; set; }
        public string FeedbackContent { get; set; }
        public string NoticeNo { get; set; }
        public string ReaderName { get; set; }
        public List<AttachDto> AttachList { get; set; }

        public int NoticeId { get; set; }
    }
}
