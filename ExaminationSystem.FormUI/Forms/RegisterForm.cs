using ExaminationSystem.BLL.Interfaces;
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
            var user = new User()
            {
                FirstName = tb_firstName.Text,
                LastName = tb_lastName.Text,
                Email = tb_email.Text,
                Passowrd = tb_password.Text
            };

            await userService.AddAsync(user);
            await userService.SaveChangesAsync();
            MessageBox.Show("Kayıt başarılı");
        }
    }
}
