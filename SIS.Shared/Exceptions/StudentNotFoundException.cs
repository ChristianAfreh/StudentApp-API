using System;
namespace SIS.Shared.Exceptions
{
    public class StudentNotFoundException : CustomException
    {
        public StudentNotFoundException() : base("Student not found")
        {
        }
    }
}
