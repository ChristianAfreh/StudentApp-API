using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace SIS.Shared.DTOs
{
    public class MailRequestDTO
    {
        public string[] RecipientEmails { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsBodyHtml { get; set; }
        public List<MailRequestAttachmentDTO> Attachments { get; set; }
    }

    public class MailRequestAttachmentDTO
    {
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public string ContentType { get; set; }
    }
}
