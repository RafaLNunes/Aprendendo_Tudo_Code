# Aprendendo_Tudo_Code

1. aprendendo_class
* exemplo de como usar o basico de class
3. TryCatch
* exemplo basico do trycatchfinally
5. database com c#
6. SideBar
7. Control of Color Themes
8. Archor funtion
  * ```
    using System.Windows.Forms;

    public static class Mark
    {
      public static void SetAnchor(this Form form)
      {
          foreach (Control control in form.Controls)
          {
              control.Anchor = AnchorStyles.None;
          }
      }
    }
    ```
