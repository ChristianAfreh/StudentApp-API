using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class ViewAlumniDetail
    {
        public string Studentid { get; set; }
        public string Email { get; set; }
        public string Surname { get; set; }
        public string OtherNames { get; set; }
        public string Gender { get; set; }
        public string WhatsappNumber { get; set; }
        public string TelegramNumber { get; set; }
        public string TwitterHandle { get; set; }
        public string FacebookUrl { get; set; }
        public string HallOfAffiliation { get; set; }
        public string NationalServiceInstitution { get; set; }
        public string ServicePostingLocation { get; set; }
    }
}
