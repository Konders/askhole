using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace AskholeLib
{
    public class Lib
    {
        public static void Resize(Control control, int startWidth, int startHeight)
        {
            System.Drawing.Size resolution = Screen.PrimaryScreen.Bounds.Size; // системні значення
            // якщо вікно повністю розгорнуте повертаємо початкові розміри
            if ((control.Width == resolution.Width) && (control.Height == resolution.Height))
            {
                control.Location = new Point((resolution.Width - startWidth) / 2,  // знаходимо центр
                                             (resolution.Height - startHeight) / 2);
                control.Size = new Size(startWidth, startHeight);
            }
            else // якщо вікно повністю маленького розміру
            {
                control.Location = new Point(0, 0);
                control.Size = new Size(resolution.Width, resolution.Height);
            }
        }

        public static void LeaveField(Bunifu.Framework.UI.BunifuMaterialTextbox temp)
        {
            if (temp.Text == "")
            {
                temp.Text = temp.Name;
                if (temp.Name == "Password")
                    temp.isPassword = false;
            }
            else
            {
                if (temp.Name == "Password")
                    temp.isPassword = true;
            }
        }

        public static void EnterText(Bunifu.Framework.UI.BunifuMaterialTextbox temp)
        {
            if (temp.Text == temp.Name)
            {
                temp.Text = "";
                if (temp.Name == "Password")
                    temp.isPassword = true;
            }
        }
    }
}
