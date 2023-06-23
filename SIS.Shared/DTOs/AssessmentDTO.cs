using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.DTOs
{
    public class AssessmentQuestionGetDTO
    {
        public string Quiz { get; set; }
        public int Number { get; set; }
        public int SetId { get; set; }
        public int QuestionId { get; set; }
        public bool IsCompulsory { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool IsCommentQuestion { get; set; }
        public List<AssessmentQuestionChoiceGetDTO> Choices { get; set; }
    }

    public class AssessmentQuestionChoiceGetDTO
    {
        public int Value { get; set; }
        public string Label { get; set; }
        public int SetId { get; set; }
        public int ResponseValueId { get; set; }
    }

    public class AssessmentAnswerDTO
    {
        public int Number { get; set; }
        public int SetId { get; set; }
        public int QuestionId { get; set; }
        public bool IsCommentQuestion { get; set; }
        public bool IsCompulsory { get; set; }
        public object Answer { get; set; }
    }

    public class AssessmentGetDTO
    {
        public int SetId { get; set; }
        public List<AssessmentQuestionGetDTO> Questions { get; set; }
    }

    public class AssessmentAddDTO
    {
        public string StudentId { get; set; }
        public int SetId { get; set; }
        public int AcadYear { get; set; }
        public int Sem { get; set; }
        public int LecturerId { get; set; }
        public string CourseCode { get; set; }
        public List<AssessmentAnswerDTO> Answers { get; set; }
    }
}
  