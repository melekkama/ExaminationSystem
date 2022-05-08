using ExaminationSystem.BLL.Interfaces;
using ExaminationSystem.Entities.Concrete;
using ExaminationSystem.FormUI.Services;
using ExaminationSystem.FormUI.States;
using MaterialSkin.Controls;

namespace ExaminationSystem.FormUI.Forms.Areas.Examiner;

public partial class ExaminerMain : MaterialForm
{
    private readonly User LoginUser;
    private readonly IGenericService<Topic> topicService;
    private readonly IGenericService<Question> questionService;
    private List<Topic> topicList;

    public ExaminerMain(IDefaultMaterialFormTheme defaultMaterialFormTheme, IGenericService<Topic> topicService, IGenericService<Question> questionService)
    {
        InitializeComponent();
        defaultMaterialFormTheme.UseTheme(this);
        LoginUser = LoginUserState.User;
        this.Text = $"{LoginUser.FirstName} {LoginUser.LastName}";
        this.topicService = topicService;
        this.questionService = questionService;
    }

    private async void ExaminerMain_Load(object sender, EventArgs e)
    {
        var topics = await topicService.GetAllAsync();
        this.topicList = topics.ToList();
        cb_topics.DataSource = topicList;
        cb_topics.DisplayMember = "Name";
    }

    private void pb_soru_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.PNG)|*.jpg; *.jpeg; *.gif; *.bmp; *.PNG";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            pb_soru.Image = new Bitmap(openFileDialog.FileName);
            pb_soru.Tag = openFileDialog.FileName;
        }
    }

    private async void btn_save_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(tb_a.Text) || cb_cevap.SelectedIndex==-1 || cb_topics.SelectedIndex== -1 ||string.IsNullOrEmpty(tb_soru.Text)||string.IsNullOrEmpty(tb_b.Text)||string.IsNullOrEmpty(tb_c.Text)||string.IsNullOrEmpty(tb_d.Text))
        {
            MessageBox.Show("Lütfen gerekli alanları doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        Question question = new();
        var selectedTopic= cb_topics.SelectedItem as Topic;
        question.TopicId=selectedTopic.Id;
        question.Answer = cb_cevap.SelectedItem as string;
        question.Content = tb_soru.Text;
        question.ChooseA = tb_a.Text;
        question.ChooseB = tb_b.Text;
        question.ChooseC = tb_c.Text;
        question.ChooseD = tb_d.Text;

        if (pb_soru.Tag!=null && !string.IsNullOrEmpty(pb_soru.Tag.ToString()))
        {
            Directory.CreateDirectory("Images") ;
            question.ImageName= $"{Guid.NewGuid()}{Path.GetExtension(pb_soru.Tag.ToString())}";
            File.Copy(pb_soru.Tag.ToString(), Path.Combine("Images", question.ImageName), true);
        }

        await questionService.AddAsync(question);
        await questionService.SaveChangesAsync();
        MessageBox.Show("Soru başarıyla oluşturuldu");
        tb_a.Text = string.Empty;
        tb_b.Text = string.Empty;
        tb_c.Text = string.Empty;
        tb_d.Text = string.Empty;
        cb_cevap.SelectedIndex = -1;
        cb_topics.SelectedIndex = -1;
        pb_soru.Tag = null;
        pb_soru.Image = null;
        tb_soru.Text = string.Empty;
        
    }
}
