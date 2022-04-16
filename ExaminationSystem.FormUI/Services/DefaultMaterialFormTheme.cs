using MaterialSkin;
using MaterialSkin.Controls;

namespace ExaminationSystem.FormUI.Services;

public class DefaultMaterialFormTheme : IDefaultMaterialFormTheme
{
    public MaterialSkinManager UseTheme(MaterialForm form)
    {
        MaterialSkinManager materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.AddFormToManage(form);
        materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.DeepPurple700, MaterialSkin.TextShade.WHITE);
        return materialSkinManager;
    }
}
