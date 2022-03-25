using ExaminationSystem.BLL.Interfaces;
using ExaminationSystem.DAL.StringInfos;
using ExaminationSystem.Entities.Concrete;

namespace ExaminationSystem.FormUI.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly IGenericService<User> userService;

        public RegisterForm(IGenericService<User> userService)
        {
            InitializeComponent();
            this.userService = userService;
        }

        private async void btn_register_Click(object sender, EventArgs e)
        {
            var roles = new Dictionary<string, bool>
            {
                { RoleInfo.Student, rb_student.Checked },
                { RoleInfo.Examiner, rb_examiner.Checked },
                { RoleInfo.Admin, rb_admin.Checked }
            };
            var selectedRole=roles.FirstOrDefault(x=>x.Value);
            MessageBox.Show(selectedRole.Key);

            //var user = new User()
            //{
            //    FirstName = tb_firstName.Text,
            //    LastName = tb_lastName.Text,
            //    Email = tb_email.Text,
            //    Passowrd = tb_password.Text
            //};

            //await userService.AddAsync(user);
            //await userService.SaveChangesAsync();
            //MessageBox.Show("Kayıt başarılı");
        }
    }
}
