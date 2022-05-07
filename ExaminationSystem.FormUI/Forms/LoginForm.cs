using ExaminationSystem.BLL.Interfaces;
using ExaminationSystem.DAL.StringInfos;
using ExaminationSystem.Entities.Concrete;
using ExaminationSystem.FormUI.ExtensionMethods;
using ExaminationSystem.FormUI.Forms.Areas.Admin;
using ExaminationSystem.FormUI.Forms.Areas.Examiner;
using ExaminationSystem.FormUI.Forms.Areas.Student;
using ExaminationSystem.FormUI.Services;
using ExaminationSystem.FormUI.States;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;

namespace ExaminationSystem.FormUI.Forms;

public partial class LoginForm : MaterialForm
{
    private readonly IGenericService<User> userService;
    private readonly IServiceProvider sp;

    public LoginForm(IDefaultMaterialFormTheme defaultMaterialFormTheme,
        IGenericService<User> userService,
        IServiceProvider sp)
    {
        InitializeComponent();
        defaultMaterialFormTheme.UseTheme(this);
        this.userService = userService;
        this.sp = sp;
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
    }

    private async void btn_login_Click(object sender, EventArgs e)
    {
        if (tb_email.Text == null || tb_email.Text == "" || pb_password.Text == null || pb_password.Text == "")
        {
            MessageBox.Show("Lütfen gerekli alanları boş geçmeyiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var users = await userService.GetAllAsync("Role");
        var found = users.FirstOrDefault(user => user.Email == tb_email.Text && user.Passowrd == pb_password.Text);
        if (found == null)
        {
            MessageBox.Show("Girdiğiniz bilgilerle eşleşen kayıt bulunamadı.\nBilgilerinizi kontrol edip tekrar deneyiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        LoginUserState.User = found;
        Form form = found.Role.Name switch
        {
            RoleInfo.Examiner => sp.GetRequiredService<ExaminerMain>(),
            RoleInfo.Admin => sp.GetRequiredService<AdminMain>(),
            RoleInfo.Student => sp.GetRequiredService<StudentMain>(),
            _ => throw new NotImplementedException()
        };
        this.SwitchForm(form);
    }

    private void btn_forgot_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Lütfen emailinize gelen bağlantıya tıklayarak parolanızı sıfırlayınız.", "Parola Sıfırlama",MessageBoxButtons.OK,MessageBoxIcon.Information);
    }

    private void btn_go_register_Click(object sender, EventArgs e)
    {
        RegisterForm registerForm=sp.GetRequiredService<RegisterForm>();
        this.SwitchForm(registerForm);
    }
}
