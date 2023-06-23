using System;
using System.Collections.Generic;

#nullable disable

namespace SIS.Shared.Entities.SISContext
{
    public partial class Room
    {
        public int RoomId { get; set; }
        public int BuildingFloorId { get; set; }
        public int? FloorTypeId { get; set; }
        public int? CollegeId { get; set; }
        public int? FacultyId { get; set; }
        public int? DepartmentId { get; set; }
        public string RoomName { get; set; }
        public string RoomNumber { get; set; }
        public string RoomLabel { get; set; }
        public string RoomLocation { get; set; }
        public int? TeachingCapacity { get; set; }
        public int? ExamCapacity { get; set; }
        public double? EffectiveArea { get; set; }
        public string Notes { get; set; }
        public bool? IsActive { get; set; }

        public virtual BuildingLevel BuildingFloor { get; set; }
        public virtual College1 College { get; set; }
        public virtual Faculty1 Faculty { get; set; }
        public virtual FloorType FloorType { get; set; }
    }
}
