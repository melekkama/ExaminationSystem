using ExaminationSystem.BLL.Interfaces;
using ExaminationSystem.Entities.Concrete;
using ExaminationSystem.Entities.Enums;
using ExaminationSystem.FormUI.Dto;
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
    private readonly IGenericService<UserQuestion> userQuestionService;
    private readonly IGenericService<SigmaDate> sigmaDateService;

    public ExamForm(IDefaultMaterialFormTheme defaultMaterialFormTheme, IGenericService<Question> questionService, IServiceProvider serviceProvider, IGenericService<UserQuestion> userQuestionService, IGenericService<SigmaDate> sigmaDateService)
    {
        InitializeComponent();
        defaultMaterialFormTheme.UseTheme(this);
        LoginUser = LoginUserState.User;
        this.questionService = questionService;
        this.serviceProvider = serviceProvider;
        this.userQuestionService = userQuestionService;
        this.sigmaDateService = sigmaDateService;
        Load += ExamForm_Load;
    }

    private List<Question> _allQuestions;
    private List<Question> _questions;
    private List<Choose> _chooses;
    private int _index = 0;
    private TimeSpan _time;


    private List<UserQuestion> _userQuestions;

    public Guid? TopicId { get; set; }

    private void LoadWithTopic()
    {
        _questions = _allQuestions.Where(x => x.TopicId == TopicId).OrderBy(question => Random.Shared.Next()).Take(10).ToList();
    }
    private void LoadWithoutTopic()
    {
        _questions = _allQuestions.Where(question =>
        question.UserQuestions.FirstOrDefault(x => x.UserId == LoginUser.Id)?.QuestionLevel == QuestionLevel.LevelZero ||
        !question.UserQuestions.Any(x => x.UserId == LoginUser.Id))
            .OrderBy(question => Random.Shared.Next()).Take(10).ToList();
        var sigmaQuestions = _allQuestions
           .Where(question => question.UserQuestions.Any(x => x.UserId == LoginUser.Id));
        foreach (var question in sigmaQuestions)
        {
            var userQuestion = question.UserQuestions.FirstOrDefault(x => x.UserId == LoginUser.Id);
            if (userQuestion.QuestionLevel is QuestionLevel.LevelZero or QuestionLevel.Completed) continue;
            var date = userQuestion.GetCurrentStepDateTime();
            if (DateTime.Now.Date == date.Value.Date)
                _questions.Add(question);
        }

    }
    private async void ExamForm_Load(object sender, EventArgs e)
    {
        _chooses = new List<Choose>();
        _userQuestions = (await userQuestionService.GetAllAsync()).Where(x => x.UserId == LoginUser.Id).ToList();
        _allQuestions = (await questionService.GetAllAsync("UserQuestions")).Where(question => question.IsActive).ToList();

        if (TopicId is null)
            LoadWithoutTopic();
        else
            LoadWithTopic();

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

    private  void ExamFinish()
    {
        if (TopicId is null)
             ExamFinishWithoutTopic();
        else
            ExamFinishWithTopic();
    }

    private  void ExamFinishWithTopic()
    {
        ExamResultDto dto = new();
        dto.Total = _questions.Count;
        for (int i = 0; i < _questions.Count; i++)
        {
            var question = _questions.ElementAt(i);
            var questionAnswer = question.GetAnswer();
            var choose = _chooses.ElementAt(i);
            if (choose == questionAnswer)
                dto.CorrectCount++;
        }
        ExamReport form = serviceProvider.GetRequiredService<ExamReport>();
        form.PrintResult(dto);
        this.SwitchForm(form);
    }
    private async void ExamFinishWithoutTopic()
    {
        ExamResultDto dto = new();
        dto.Total = _questions.Count;
        //Cevapları kaydet
        for (int i = 0; i < _questions.Count; i++)
        {
            var question = _questions.ElementAt(i);
            var questionAnswer = question.GetAnswer();
            var choose = _chooses.ElementAt(i);
            var userQuestion = _userQuestions.FirstOrDefault(x => x.QuestionId == question.Id);
            var sigmaDate = (await sigmaDateService.GetAllAsync()).FirstOrDefault();
            if (userQuestion == null)
            {
                userQuestion = new UserQuestion()
                {
                    QuestionId = question.Id,
                    UserId = LoginUser.Id
                };
                userQuestion.SigmaDateSet(sigmaDate);
                await userQuestionService.AddAsync(userQuestion);
                await userQuestionService.SaveChangesAsync();
            }

            if (choose == questionAnswer)
            {
                userQuestion.QuestionLevel++;
                dto.CorrectCount++;
            }
            else
            {
                userQuestion.QuestionLevel = QuestionLevel.LevelZero;
                userQuestion.SigmaDateSet(sigmaDate);
            }
            await userQuestionService.UpdateAsync(userQuestion);
            await userQuestionService.SaveChangesAsync();
        }
        ExamReport form = serviceProvider.GetRequiredService<ExamReport>();
        form.PrintResult(dto);
        this.SwitchForm(form);
    }

    private Choose getSelectedChoose()
    {
        if (rb_a.Checked) return Choose.A;
        if (rb_b.Checked) return Choose.B;
        if (rb_c.Checked) return Choose.C;
        if (rb_d.Checked) return Choose.D;
        return Choose.D;
    }

    private void btn_next_Click(object sender, EventArgs e)
    {
        Choose choose = getSelectedChoose();
        _chooses.Add(choose);
        _index++;
        if (_index == _questions.Count)
        {
            ExamFinish();
            return;
        }
        if (_index == _questions.Count - 1)
            btn_next.Text = "Sınavı Bitir";
        drawQuestion();
    }

    private void exam_timer_Tick(object sender, EventArgs e)
    {
        _time -= TimeSpan.FromSeconds(1);
        lb_timer.Text = _time.ToString();
        if (_time == TimeSpan.Zero)
        {
            exam_timer.Stop();
            ExamFinish();
        }
    }
}
