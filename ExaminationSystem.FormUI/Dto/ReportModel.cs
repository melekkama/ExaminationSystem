using ExaminationSystem.Entities.Concrete;

namespace ExaminationSystem.FormUI.Dto;

public class ReportModel
{
    public Topic Topic { get; set; }
    public int Total { get; set; }
    public int Saw { get; set; }
    public int Correct { get; set; }
}
