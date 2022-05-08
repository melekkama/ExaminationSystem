namespace ExaminationSystem.Entities.Concrete;

public class Topic:EntityBase
{
    public string Name { get; set; }

    public List<Question> Questions { get; set; }
}
