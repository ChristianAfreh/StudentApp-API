using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.DTOs
{
    public class MobileAppSettingDTO
    {
        public string AboutApp { get; set; }
        public string PasswordResetUrl { get; set; }
        public string TimeTableApiBaseUrl { get; set; }
        public List<UpdateSettingDTO> UpdateSettings { get; set; }
    }

    public class UpdateSettingDTO
    {
        public string AppPlatform { get; set; }
        public int MinVersion { get; set; }
        public bool IsCritical { get; set; }
        public string CustomMessage { get; set; }
        public string StoreDownloadUrl { get; set; }
        public string AltDownloadUrl { get; set; }
    }
}
