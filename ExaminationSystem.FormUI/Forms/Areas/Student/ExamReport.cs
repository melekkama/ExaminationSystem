using ExaminationSystem.Entities.Concrete;
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
}
