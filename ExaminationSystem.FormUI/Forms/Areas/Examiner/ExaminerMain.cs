using ExaminationSystem.Entities.Concrete;
using ExaminationSystem.FormUI.Services;
using ExaminationSystem.FormUI.States;
using MaterialSkin.Controls;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.FormUI.Forms.Areas.Examiner
{
    public partial class ExaminerMain : MaterialForm
    {
        private readonly User LoginUser;
        public ExaminerMain(IDefaultMaterialFormTheme defaultMaterialFormTheme)
        {
            InitializeComponent();
            defaultMaterialFormTheme.UseTheme(this);
            LoginUser = LoginUserState.User;
            this.Text = $"{LoginUser.FirstName} {LoginUser.LastName}";
        }

        private void ExaminerMain_Load(object sender, EventArgs e)
        {

        }

        private void pb_soru_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.PNG)|*.jpg; *.jpeg; *.gif; *.bmp; *.PNG";
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                pb_soru.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }
    }
}
