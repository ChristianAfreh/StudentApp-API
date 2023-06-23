using System;
using SIS.Shared.Entities.AssessmentContext;

namespace SIS.Shared.V1.Repositories
{
    public interface ILecturerPhotoRepository : IBaseRepository<Staffphoto>
    {

    }

    public class LecturerPhotoRepository : BaseRepository<Staffphoto>, ILecturerPhotoRepository
    {
        public LecturerPhotoRepository(AssessmentContext DbContext) : base(DbContext)
        {
        }
    }
}
