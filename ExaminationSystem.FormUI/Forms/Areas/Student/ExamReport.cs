using ExaminationSystem.Entities.Concrete;
using ExaminationSystem.FormUI.Dto;
using ExaminationSystem.FormUI.ExtensionMethods;
using ExaminationSystem.FormUI.Services;
using ExaminationSystem.FormUI.States;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;

namespace ExaminationSystem.FormUI.Forms.Areas.Student;

public partial class ExamReport : MaterialForm
{
    private readonly IServiceProvider sp;

    public ExamReport(IDefaultMaterialFormTheme defaultMaterialFormTheme,IServiceProvider sp)
    {
        InitializeComponent();
        defaultMaterialFormTheme.UseTheme(this);
        this.sp = sp;
    }

    public void PrintResult(ExamResultDto dto)
    {
        lb_result.Text = $"{dto.CorrectCount} / {dto.Total}";
    }

    private void btn_redirect_Click(object sender, EventArgs e)
    {
        StudentMain form=sp.GetRequiredService<StudentMain>();  
        this.SwitchForm(form);
    }
}
