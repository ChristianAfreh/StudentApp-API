using System;
namespace SIS.Shared.Entities.SISContext
{
    public class procGetLecturersforStudentRegisteredCourses_Result
    {
        public string FULLNAME { get; set; }
        public string COURSECODE { get; set; }
        public string COURSENAME { get; set; }
        public int? LECTURERID { get; set; }
        public int? ACADYEAR { get; set; }
        public int? SEM { get; set; }
        public byte[] PHOTO { get; set; }
    }
}
