using ExaminationSystem.Entities.Enums;

namespace ExaminationSystem.Entities.Concrete;

public class UserQuestion:EntityBase
{
    public Guid QuestionId { get; set; }
    public Question Question { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }

    public QuestionLevel QuestionLevel { get; set; }

    public DateTime? StepOneDate { get; set; }
    public DateTime? StepTwoDate { get; set; }
    public DateTime? StepThreeDate { get; set; }
    public DateTime? StepFourDate { get; set; }
    public DateTime? StepFiveDate { get; set; }
    public DateTime? StepSixDate { get; set; }

}
