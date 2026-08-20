
using System.Windows.Forms;

namespace ShopManagementSystem.UI
{
   internal static class clsUIFormatter
   {

        internal static System.Drawing.Color DeactivateColor => System.Drawing.Color.FromArgb(0, 0, 192);

        internal static System.Drawing.Color ActivateColor => System.Drawing.Color.White;

        internal static System.Drawing.Color DeactivateFontColor => System.Drawing.Color.White;

        internal static System.Drawing.Color ActivateFontColor => System.Drawing.Color.Blue;

        
        internal static void DeactivateButton(Button button)
        {
            button.BackColor = DeactivateColor;
            button.ForeColor = DeactivateFontColor;
        }

        internal static void ActiveButton(Button button)
        {
            button.BackColor = ActivateColor;
            button.ForeColor = ActivateFontColor;
        }

        internal static void ChangeActivateStateTo(Button From,Button To)
        {
            DeactivateButton(From);
            ActiveButton(To);
        }
    }
}
