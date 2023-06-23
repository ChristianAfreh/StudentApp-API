using SIS.Shared.Entities.AssessmentContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
    public interface IAssessmentQuestionRepository : IBaseRepository<Question>
    {
    }

    public class AssessmentQuestionRepository : BaseRepository<Question>, IAssessmentQuestionRepository
    {
        public AssessmentQuestionRepository(AssessmentContext DbContext) : base(DbContext)
        {
        }
    }
}
