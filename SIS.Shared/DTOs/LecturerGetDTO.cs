using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.DTOs
{
    public class LecturerGetDTO
    {
        [JsonProperty("lecturerId")]
        public int LecturerId { get; set; }

        [JsonProperty("lecturerTitle")]
        public string LecturerTitle { get; set; }

        [JsonProperty("lecturerName")]
        public string LecturerName { get; set; }
    }
}
