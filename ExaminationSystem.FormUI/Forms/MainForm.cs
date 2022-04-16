using ExaminationSystem.BLL.Interfaces;
using ExaminationSystem.Entities.Concrete;
using ExaminationSystem.FormUI.Services;
using MaterialSkin.Controls;

namespace ExaminationSystem.FormUI.Forms
{
    public partial class MainForm : MaterialForm
    {
        public MainForm(IDefaultMaterialFormTheme defaultMaterialFormTheme)
        {
            InitializeComponent();
            defaultMaterialFormTheme.UseTheme(this);
        }

     
    }
}
