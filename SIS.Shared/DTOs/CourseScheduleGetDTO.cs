using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.DTOs
{
    public class CourseScheduleGetDTO
    {
        [JsonProperty("courseScheduleId")]
        public int CourseScheduleId { get; set; }

        [JsonProperty("weekDayId")]
        public int WeekDayId { get; set; }

        [JsonProperty("weekDayName")]
        public string WeekDayName { get; set; }

        [JsonProperty("startDateTime")]
        public DateTime StartDateTime { get; set; }

        [JsonProperty("endDateTime")]
        public DateTime EndDateTime { get; set; }

        [JsonProperty("startTimeString")]
        public string StartTimeString { get; set; }

        [JsonProperty("endTimeString")]
        public string EndTimeString { get; set; }

        [JsonProperty("roomName")]
        public string RoomName { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("acadYear")]
        public int AcadYear { get; set; }

        [JsonProperty("semesterName")]
        public string SemesterName { get; set; }

        [JsonProperty("programmeName")]
        public string ProgrammeName { get; set; }

        [JsonProperty("courseId")]
        public int CourseId { get; set; }

        [JsonProperty("courseCode")]
        public string CourseCode { get; set; }

        [JsonProperty("courseColourCode")]
        public string CourseColourCode { get; set; }

        [JsonProperty("courseName")]
        public string CourseName { get; set; }

        [JsonProperty("lecturers")]

        public List<LecturerGetDTO> Lecturers { get; set; } = new();
    }

    public partial class CourseScheduleGetDetailDTO
    {
        [JsonProperty("courseScheduleId")]
        public long CourseScheduleId { get; set; }

        [JsonProperty("weekDay")]
        public WeekDay WeekDay { get; set; }

        [JsonProperty("startTimeString")]
        public string StartTimeString { get; set; }

        [JsonProperty("endTimeString")]
        public string EndTimeString { get; set; }

        [JsonProperty("room")]
        public Room Room { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("lecturerNames")]
        public string LecturerNames { get; set; }

        [JsonProperty("academicSemester")]
        public AcademicSemester AcademicSemester { get; set; }

        [JsonProperty("course")]
        public Course Course { get; set; }

        [JsonProperty("lecturers")]
        public List<LecturerGetDTO> Lecturers { get; set; }
    }

    public partial class AcademicSemester
    {
        [JsonProperty("academicSemesterId")]
        public int AcademicSemesterId { get; set; }

        [JsonProperty("acadYear")]
        public int AcadYear { get; set; }

        [JsonProperty("semesterId")]
        public int SemesterId { get; set; }

        [JsonProperty("academicSemesterName")]
        public string AcademicSemesterName { get; set; }
    }

    public partial class Course
    {
        [JsonProperty("courseId")]
        public int CourseId { get; set; }

        [JsonProperty("courseCode")]
        public string CourseCode { get; set; }

        [JsonProperty("courseName")]
        public string CourseName { get; set; }

        [JsonProperty("credit")]
        public int Credit { get; set; }

        [JsonProperty("fullCourseName")]
        public string FullCourseName { get; set; }
    }

    

    public partial class Room
    {
        [JsonProperty("roomId")]
        public long RoomId { get; set; }

        [JsonProperty("roomName")]
        public string RoomName { get; set; }

        [JsonProperty("roomNumber")]
        public string RoomNumber { get; set; }

        [JsonProperty("roomLabel")]
        public string RoomLabel { get; set; }

        [JsonProperty("roomLocation")]
        public string RoomLocation { get; set; }

        [JsonProperty("collegeId")]
        public int CollegeId { get; set; }

        [JsonProperty("floorTypeId")]
        public int FloorTypeId { get; set; }

        [JsonProperty("teachingCapacity")]
        public int TeachingCapacity { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("floor")]
        public Floor Floor { get; set; }

        [JsonProperty("building")]
        public Building Building { get; set; }

        [JsonProperty("fullRoomName")]
        public string FullRoomName { get; set; }
    }

    public partial class Building
    {
        [JsonProperty("buildingId")]
        public long BuildingId { get; set; }

        [JsonProperty("buildingName")]
        public string BuildingName { get; set; }

        [JsonProperty("buildingCode")]
        public string BuildingCode { get; set; }

        [JsonProperty("buildingLocation")]
        public string BuildingLocation { get; set; }

        [JsonProperty("buildingLatitude")]
        public double BuildingLatitude { get; set; }

        [JsonProperty("buildingLongitude")]
        public double BuildingLongitude { get; set; }
    }

    public partial class Floor
    {
        [JsonProperty("buildingFloorId")]
        public int BuildingFloorId { get; set; }

        [JsonProperty("levelId")]
        public int LevelId { get; set; }

        [JsonProperty("levelName")]
        public string LevelName { get; set; }

        [JsonProperty("floorName")]
        public string FloorName { get; set; }
    }

    public partial class WeekDay
    {
        [JsonProperty("weekDayId")]
        public int WeekDayId { get; set; }

        [JsonProperty("weekDayName")]
        public string WeekDayName { get; set; }
    }
}