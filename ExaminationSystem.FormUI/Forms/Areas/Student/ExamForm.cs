using ExaminationSystem.BLL.Interfaces;
using ExaminationSystem.Entities.Concrete;
using ExaminationSystem.FormUI.ExtensionMethods;
using ExaminationSystem.FormUI.Services;
using ExaminationSystem.FormUI.States;
using MaterialSkin.Controls;
using Microsoft.Extensions.DependencyInjection;

namespace ExaminationSystem.FormUI.Forms.Areas.Student;

public partial class ExamForm : MaterialForm
{
    private readonly User LoginUser;
    private readonly IGenericService<Question> questionService;
    private readonly IServiceProvider serviceProvider;

    public ExamForm(IDefaultMaterialFormTheme defaultMaterialFormTheme, IGenericService<Question> questionService,IServiceProvider serviceProvider)
    {
        InitializeComponent();
        defaultMaterialFormTheme.UseTheme(this);
        LoginUser = LoginUserState.User;
        this.questionService = questionService;
        this.serviceProvider = serviceProvider;
        Load += ExamForm_Load;
    }

    private List<Question> _questions;
    private int _index = 0;
    private TimeSpan _time;

    private async void ExamForm_Load(object sender, EventArgs e)
    {
        var allQuestions= await questionService.GetAllAsync();
        var activatedQuestions = allQuestions.Where(question=>question.IsActive).ToList();
        _questions = activatedQuestions.OrderBy(question=>Random.Shared.Next()).Take(10).ToList();
        _time = TimeSpan.FromMinutes(_questions.Count);
        lb_timer.Text = _time.ToString();
        drawQuestion();
    }

    private void drawQuestion()
    {
        var question = _questions[_index];
        lb_soru.Text = question.Content;
        rb_a.Text = question.ChooseA;
        rb_b.Text = question.ChooseB;
        rb_c.Text = question.ChooseC;
        rb_d.Text = question.ChooseD;
        pb_soru.Image = null;
        if (question.ImageName != null)
        {
            var path = Path.Combine("Images", question.ImageName);
            pb_soru.Image = new Bitmap(path);
        }
        lb_count.Text = $"{_index + 1}/{_questions.Count}";
    }

    private void examFinish()
    {
        //Cevapları kaydet
        ExamReport form = serviceProvider.GetRequiredService<ExamReport>();
        this.SwitchForm(form);
    }

    private void btn_next_Click(object sender, EventArgs e)
    {
        _index++;
        if (_index == _questions.Count)
        {
            examFinish();
            return;
        }
        if (_index == _questions.Count - 1)
            btn_next.Text = "Sınavı Bitir";
        drawQuestion();
    }

    private void exam_timer_Tick(object sender, EventArgs e)
    {
        _time -= TimeSpan.FromSeconds(1);
        lb_timer.Text=_time.ToString();
        if (_time==TimeSpan.Zero)
        {
            exam_timer.Stop();
            examFinish();
        }
    }
}
