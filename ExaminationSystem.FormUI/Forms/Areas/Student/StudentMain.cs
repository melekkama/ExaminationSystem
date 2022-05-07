using ExaminationSystem.Entities.Concrete;
using ExaminationSystem.FormUI.Services;
using ExaminationSystem.FormUI.States;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.FormUI.Forms.Areas.Student
{
    public partial class StudentMain : MaterialForm
    {
        private readonly User LoginUser;
        public StudentMain(IDefaultMaterialFormTheme defaultMaterialFormTheme)
        {
            InitializeComponent();
            defaultMaterialFormTheme.UseTheme(this);
            LoginUser = LoginUserState.User;
            //this.Text = $"{LoginUser.FirstName} {LoginUser.LastName}";
        }

        private void StudentMain_Load(object sender, EventArgs e)
        {
            lb_tarih.Text=(DateTime.Now.ToShortDateString());
            lb_ad.Text = LoginUser.FirstName;
            lb_soyad.Text = LoginUser.LastName;
            lb_email.Text = LoginUser.Email;
            lb_kayıt_tarih.Text = LoginUser.CreatedTime.ToShortDateString();
        }
    }
}
