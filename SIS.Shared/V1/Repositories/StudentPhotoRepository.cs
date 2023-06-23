using System;
using SIS.Shared.Entities.SISContext;

namespace SIS.Shared.V1.Repositories
{
    public interface IStudentPhotoRepository : IBaseRepository<Studentphoto>
    {

    }

    public class StudentPhotoRepository : BaseRepository<Studentphoto>, IStudentPhotoRepository
    {
        public StudentPhotoRepository(SISContext DbContext) : base(DbContext)
        {
        }
    }
}
