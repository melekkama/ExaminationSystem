using ExaminationSystem.BLL.Interfaces;
using ExaminationSystem.Entities.Concrete;
using ExaminationSystem.FormUI.ExtensionMethods;
using ExaminationSystem.FormUI.Services;
using ExaminationSystem.FormUI.States;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;
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
        private readonly IServiceProvider serviceProvider;
        private readonly IGenericService<SigmaDate> sigmaDateService;

        public StudentMain(IDefaultMaterialFormTheme defaultMaterialFormTheme, IServiceProvider serviceProvider, IGenericService<SigmaDate> sigmaDateService)
        {
            InitializeComponent();
            defaultMaterialFormTheme.UseTheme(this);
            LoginUser = LoginUserState.User;
            this.serviceProvider = serviceProvider;
            this.sigmaDateService = sigmaDateService;
        }

        private void StudentMain_Load(object sender, EventArgs e)
        {
            lb_tarih.Text = (DateTime.Now.ToShortDateString());
            lb_ad.Text = LoginUser.FirstName;
            lb_soyad.Text = LoginUser.LastName;
            lb_email.Text = LoginUser.Email;
            lb_kayıt_tarih.Text = LoginUser.CreatedTime.ToShortDateString();
        }

        private void btn_start_exam_Click(object sender, EventArgs e)
        {
            ExamForm form = serviceProvider.GetRequiredService<ExamForm>();
            this.SwitchForm(form);
        }

        int stringToDay(string text)
        {
            var arr = text.Trim().Split(" ");
            int value = int.Parse(arr[0]);
            int multiple = 1;
            if (text.Contains("GÜN"))
                multiple = 1;
            if (text.Contains("HAFTA"))
                multiple = 7;
            if (text.Contains("AY"))
                multiple = 30;
            return value * multiple;
        }

        private async void btn_zamanKaydet_Click(object sender, EventArgs e)
        {
            var rangeOne = stringToDay(cb_aralık1.Text);
            var rangeTwo = stringToDay(cb_aralık2.Text);
            var rangeThree = stringToDay(cb_aralık3.Text);
            var rangeFour = stringToDay(cb_aralık4.Text);
            var rangeFive = stringToDay(cb_aralık5.Text);
            var rangeSix = stringToDay(cb_aralık6.Text);
            var sigmaDate= (await sigmaDateService.GetAllAsync()).FirstOrDefault();
            sigmaDate.StepOneDate = rangeOne;
            sigmaDate.StepTwoDate = rangeTwo;
            sigmaDate.StepThreeDate = rangeThree;
            sigmaDate.StepFourDate = rangeFour;
            sigmaDate.StepFiveDate = rangeFive;
            sigmaDate.StepSixDate = rangeSix;
            await sigmaDateService.UpdateAsync(sigmaDate);
            await sigmaDateService.SaveChangesAsync();
            MessageBox.Show("Sınav aralıkları güncellendi");
        }
    }
}
