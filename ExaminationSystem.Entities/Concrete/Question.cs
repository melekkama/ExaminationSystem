using ExaminationSystem.Entities.Enums;

namespace ExaminationSystem.Entities.Concrete;

public class Question : EntityBase
{
    public string? ImageName { get; set; }
    public string Content { get; set; }
    public string ChooseA { get; set; }
    public string ChooseB { get; set; }
    public string ChooseC { get; set; }
    public string ChooseD { get; set; }
    public string Answer { get; set; }

    public bool IsActive { get; set; }

    public Guid TopicId { get; set; }
    public Topic Topic { get; set; }

    public List<UserQuestion> UserQuestions { get; set; }

    public Choose GetAnswer() => (Choose)Enum.Parse(typeof(Choose), Answer);
}
