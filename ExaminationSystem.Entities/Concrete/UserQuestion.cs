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

    public void SigmaDateSet(SigmaDate sigmaDate)
    {
        var now=DateTime.Now;
        StepOneDate=now.AddDays(sigmaDate.StepOneDate);
        StepTwoDate=now.AddDays(sigmaDate.StepTwoDate);
        StepThreeDate=now.AddDays(sigmaDate.StepThreeDate);
        StepFourDate=now.AddDays(sigmaDate.StepFourDate);
        StepFiveDate=now.AddDays(sigmaDate.StepFiveDate);
        StepSixDate = now.AddDays(sigmaDate.StepSixDate);
    }

    public DateTime? GetCurrentStepDateTime() => QuestionLevel switch
    {
        QuestionLevel.LevelOne => StepOneDate,
        QuestionLevel.LevelTwo => StepTwoDate,
        QuestionLevel.LevelThree => StepThreeDate,
        QuestionLevel.LevelFour => StepFourDate,
        QuestionLevel.LevelFive => StepFiveDate,
        QuestionLevel.LevelSix => StepSixDate,
        _ => throw new NotImplementedException()
    };

}
