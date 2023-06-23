using System;
namespace SIS.Shared.Settings
{
    public class ReportServerSettings
    {
        public string ReportServerUrl { get; set; }
        public string ReportServerUsername { get; set; }
        public string ReportServerPassword { get; set; }
        public string ReportFolder { get; set; }
    } 
    
    public class VirtualGraduationSettings
    {
        public string CheckFeesForVirtualGraduation { get; set; }
        public string VirtualGraduationDisplayName { get; set; }
        public string VirtualGraduationShortName { get; set; }
    }
}
