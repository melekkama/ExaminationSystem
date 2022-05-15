using ExaminationSystem.BLL.Interfaces;
using ExaminationSystem.Entities.Concrete;
using ExaminationSystem.Entities.Enums;
using ExaminationSystem.FormUI.Dto;
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
        private readonly IGenericService<Topic> topicService;

        public StudentMain(IDefaultMaterialFormTheme defaultMaterialFormTheme, IServiceProvider serviceProvider, IGenericService<SigmaDate> sigmaDateService,IGenericService<Topic> topicService)
        {
            InitializeComponent();
            defaultMaterialFormTheme.UseTheme(this);
            LoginUser = LoginUserState.User;
            this.serviceProvider = serviceProvider;
            this.sigmaDateService = sigmaDateService;
            this.topicService = topicService;
        }

        private void StudentMain_Load(object sender, EventArgs e)
        {
            lb_tarih.Text = (DateTime.Now.ToShortDateString());
            lb_ad.Text = LoginUser.FirstName;
            lb_soyad.Text = LoginUser.LastName;
            lb_email.Text = LoginUser.Email;
            lb_kayıt_tarih.Text = LoginUser.CreatedTime.ToShortDateString();
            reportView();
        }

        private async void reportView()
        {
            List<ReportModel> reportModels = new();
            var topics = await topicService.GetAllAsync("Questions", "Questions.UserQuestions");
            foreach (var topic in topics)
            {
                ReportModel rm = new();
                rm.Topic= topic;
                var userQuestions = topic.Questions.Where(question=>question.UserQuestions.Any(x=>x.UserId==LoginUser.Id)).Select(x=>x.UserQuestions.FirstOrDefault(uq=>uq.UserId==LoginUser.Id));
                var correctCount = userQuestions.Where(x => x.QuestionLevel > QuestionLevel.LevelZero).Count();
                rm.Total = topic.Questions.Count;
                rm.Saw = userQuestions.Count();
                rm.Correct=correctCount;
                reportModels.Add(rm);
            }
            foreach (var report in reportModels)
            {
                MaterialButton name = new();
                MaterialLabel  total = new(), saw = new(), correct = new(),percent=new();
                name.Tag = report.Topic.Id;
                name.Click += topicExamStart;
                name.Type = MaterialButton.MaterialButtonType.Text;
                name.Text = report.Topic.Name;
                name.Size = new Size(250,30);
                total.Text = $"Total: {report.Total}";
                saw.Text = $"Saw: {report.Saw}";
                correct.Text = $"Correct: {report.Correct}";
                var percentValue = report.Saw==0? 0: (int)((double)report.Correct/ report.Saw * 100);
                percent.Text = $"Percent: %{percentValue}";
                flp_report.Controls.Add(name);
                flp_report.Controls.Add(total);
                flp_report.Controls.Add(saw);
                flp_report.Controls.Add(correct);
                flp_report.Controls.Add(percent);
            }
        }

        private void topicExamStart(object sender, EventArgs e)
        {
            var topicId=(Guid)((MaterialButton)sender).Tag;
            ExamForm form = serviceProvider.GetRequiredService<ExamForm>();
            form.TopicId = topicId;
            this.SwitchForm(form);
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
