using ExaminationSystem.BLL.Interfaces;
using ExaminationSystem.Entities.Concrete;
using ExaminationSystem.FormUI.Services;
using ExaminationSystem.FormUI.States;
using MaterialSkin.Controls;

namespace ExaminationSystem.FormUI.Forms
{
    public partial class MainForm : MaterialForm
    {
        private readonly User LoginUser;
        public MainForm(IDefaultMaterialFormTheme defaultMaterialFormTheme)
        {
            InitializeComponent();
            defaultMaterialFormTheme.UseTheme(this);
            LoginUser = LoginUserState.User;
            lb_userStatus.Text = $"{LoginUser.FirstName} {LoginUser.LastName}";
        }

     
    }
}
