using ExaminationSystem.BLL.Interfaces;
using ExaminationSystem.DAL.StringInfos;
using ExaminationSystem.Entities.Concrete;

namespace ExaminationSystem.FormUI.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly IGenericService<User> userService;
        private readonly IGenericService<Role> roleService;

        public RegisterForm(IGenericService<User> userService, IGenericService<Role> roleService)
        {
            InitializeComponent();
            this.userService = userService;
            this.roleService = roleService;
        }

        private async void btn_register_Click(object sender, EventArgs e)
        {
            string roleName = string.Empty;
            if (rb_student.Checked)
                roleName = RoleInfo.Student;
            else if (rb_admin.Checked)
                roleName = RoleInfo.Admin;
            else if (rb_examiner.Checked)
                roleName = RoleInfo.Examiner;
            else
            {
                MessageBox.Show("Lütfen bir rol seçiniz");
                return;
            }
            var roles = await roleService.GetAllAsync();
            Role selectedRole = roles.FirstOrDefault(x => x.Name == roleName);
            if (selectedRole is null)
            {
                selectedRole = new Role()
                {
                    Name = roleName,
                };
                await roleService.AddAsync(selectedRole);
                await roleService.SaveChangesAsync();
            }
            var user = new User()
            {
                FirstName = tb_firstName.Text,
                LastName = tb_lastName.Text,
                Email = tb_email.Text,
                Passowrd = tb_password.Text,
                RoleId = selectedRole.Id,
            };

            await userService.AddAsync(user);
            await userService.SaveChangesAsync();
            MessageBox.Show("Kayıt başarılı");
        }
    }
}
