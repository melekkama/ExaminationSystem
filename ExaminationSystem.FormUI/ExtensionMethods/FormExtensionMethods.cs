namespace ExaminationSystem.FormUI.ExtensionMethods;

public static class FormExtensionMethods
{
    public static void SwitchForm(this Form current,Form form)
    {
        current.Hide();
        form.ShowDialog();
        current.Close();
    }
}
