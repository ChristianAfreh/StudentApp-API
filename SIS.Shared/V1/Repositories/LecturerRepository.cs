using System;
using SIS.Shared.Entities.AssessmentContext;

namespace SIS.Shared.V1.Repositories
{
    public interface ILecturerRepository : IBaseRepository<Lecturer>
    {
    }

    public class LecturerRepository : BaseRepository<Lecturer>, ILecturerRepository
    {
        public LecturerRepository(AssessmentContext DbContext) : base(DbContext)
        {
        }
    }
}
