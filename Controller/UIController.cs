using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DetectCrime.Controller
{
   class UIController
   {
      /// <summary>
      /// 기본 폼을 세팅하는 것.
      /// </summary>
      /// <param name="_form">설정이 필요한 폼</param>
      internal static void FormBasic(Form _form)
      {
         _form.StartPosition = FormStartPosition.CenterScreen;
         _form.ControlBox = false;
         _form.BackColor = Color.FromArgb(64, 64, 64);
         _form.Size = new Size(850, 600);
      }
      internal static void ButtonSetting(Button _button)
      {
         _button.Size = new Size(100, 50);
         _button.FlatStyle = FlatStyle.Flat;
         _button.FlatAppearance.BorderSize = 0;
         _button.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
         _button.ForeColor = Color.White;
         _button.Font = new Font("나눔고딕코딩", 20, FontStyle.Bold);
      }
   }
}
