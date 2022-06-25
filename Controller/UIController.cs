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
      #region 폼
      /// <summary>
      /// 기본 폼 세팅
      /// </summary>
      /// <param name="_form">설정이 필요한 폼</param>
      internal static void FormBasic(Form _form)
      {
         _form.StartPosition = FormStartPosition.CenterScreen;
         _form.ControlBox = false;
         _form.BackColor = Color.FromArgb(64, 64, 64);
         _form.WindowState = FormWindowState.Maximized;
      }
      internal static void SmallForm(Form _form)
      {
         _form.StartPosition = FormStartPosition.CenterScreen;
         _form.ControlBox = false;
         _form.BackColor = Color.FromArgb(64, 64, 64);
         _form.Size = new Size(350, 200);
      }
      #endregion

      #region 버튼
      /// <summary>
      /// 버튼 기본 세팅
      /// </summary>
      /// <param name="_button">설정이 필요한 폼</param>
      internal static void ButtonSetting(Button _button)
      {
         _button.Size = new Size(100, 50);
         _button.FlatStyle = FlatStyle.Flat;
         _button.FlatAppearance.BorderSize = 0;
         _button.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
         _button.ForeColor = Color.White;
         _button.Font = new Font("나눔고딕코딩", 20, FontStyle.Bold);
      }
      #endregion

      #region 라벨
      internal static void LabelSetting(Label _label)
      {
         _label.ForeColor = Color.White;
         _label.Font = new Font("나눔고딕코딩", 15, FontStyle.Bold);
      }
      #endregion

      #region 텍스트 박스
      internal static void TextBoxSetting(TextBox _textbox)
      {
         _textbox.TextAlign = HorizontalAlignment.Center;
         _textbox.Font = new Font("나눔고딕코딩", 10, FontStyle.Bold);
      }
      #endregion
   }
}
