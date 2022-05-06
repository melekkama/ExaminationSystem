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

namespace ExaminationSystem.FormUI.Forms.Areas.Admin
{
    public partial class AdminMain : MaterialForm
    {
        private readonly User LoginUser;
        public AdminMain(IDefaultMaterialFormTheme defaultMaterialFormTheme)
        {
            InitializeComponent();
            defaultMaterialFormTheme.UseTheme(this);
            LoginUser = LoginUserState.User;
            this.Text = $"{LoginUser.FirstName} {LoginUser.LastName}";
        }
    }
}
