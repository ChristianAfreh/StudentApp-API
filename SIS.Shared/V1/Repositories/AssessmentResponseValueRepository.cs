using SIS.Shared.Entities.AssessmentContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
    public interface IAssessmentResponseValueRepository : IBaseRepository<Responsevalue>
    {
    }

    public class AssessmentResponseValueRepository : BaseRepository<Responsevalue>, IAssessmentResponseValueRepository
    {
        public AssessmentResponseValueRepository(AssessmentContext DbContext) : base(DbContext)
        {
        }
    }
}
