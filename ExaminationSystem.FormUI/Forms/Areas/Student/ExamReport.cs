using ExaminationSystem.Entities.Concrete;
using ExaminationSystem.FormUI.Dto;
using ExaminationSystem.FormUI.Services;
using ExaminationSystem.FormUI.States;
using MaterialSkin.Controls;

namespace ExaminationSystem.FormUI.Forms.Areas.Student;

public partial class ExamReport : MaterialForm
{
    private readonly User LoginUser;
    public ExamReport(IDefaultMaterialFormTheme defaultMaterialFormTheme)
    {
        InitializeComponent();
        defaultMaterialFormTheme.UseTheme(this);
        LoginUser = LoginUserState.User;
    }

    public void PrintResult(ExamResultDto dto)
    {
        lb_result.Text = $"{dto.CorrectCount} / {dto.Total}";
    }
}
