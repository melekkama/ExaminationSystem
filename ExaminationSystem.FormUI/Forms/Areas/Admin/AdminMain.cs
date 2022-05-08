using ExaminationSystem.BLL.Interfaces;
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
        private readonly IGenericService<Question> questionService;

        public AdminMain(IDefaultMaterialFormTheme defaultMaterialFormTheme,IGenericService<Question> questionService)
        {
            InitializeComponent();
            defaultMaterialFormTheme.UseTheme(this);
            LoginUser = LoginUserState.User;
            this.Text = $"{LoginUser.FirstName} {LoginUser.LastName}";
            this.questionService = questionService;
        }

        private async void AdminMain_Load(object sender, EventArgs e)
        {
            var questions= await questionService.GetAllAsync("Topic");
            var nonActiveQuestions= questions.Where(x => !x.IsActive).ToList();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = nonActiveQuestions;
        }

        private async void btn_savechanges_Click(object sender, EventArgs e)
        {
            var datasources = dataGridView1.DataSource as IEnumerable<Question>;
            var activateds= datasources.Where(x => x.IsActive).ToList();
            foreach (var item in activateds)
                await questionService.UpdateAsync(item);
            await questionService.SaveChangesAsync();
            MessageBox.Show("Veriler güncellendi");
            var questions = await questionService.GetAllAsync("Topic");
            var nonActiveQuestions = questions.Where(x => !x.IsActive).ToList();
            dataGridView1.DataSource = nonActiveQuestions;
        }
    }
}
