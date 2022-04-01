using ExaminationSystem.FormUI.Services;
using MaterialSkin.Controls;

namespace ExaminationSystem.FormUI.Forms;

public partial class LoginForm : MaterialForm
{
    public LoginForm(IDefaultMaterialFormTheme defaultMaterialFormTheme)
    {
        InitializeComponent();
        defaultMaterialFormTheme.UseTheme(this);
    }
}
