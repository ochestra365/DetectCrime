using System;
using System.Windows.Forms;
using DetectCrime.Controller;
namespace DetectCrime.View
{
   public partial class LoginForm : Form
   {
      internal bool Isright = false;
      public LoginForm()
      {
         InitializeComponent();
      }

      private void LoginForm_Load(object sender, EventArgs e)
      {
         UIController.SmallForm(this);
         UIController.LabelSetting(LblTitle);
         UIController.TextBoxSetting(textBox1);
         UIController.TextBoxSetting(textBox2);
         UIController.ButtonSetting(BtnLogin);
         UIController.ButtonSetting(BtnClose);
         textBox2.PasswordChar = '●';
         CenterToScreen();
      }

      private void BtnLogin_Click(object sender, EventArgs e)
      {
         if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
         {
            if (INIController.GET("TEMP_LOGIN", "ID").Equals(textBox1.Text) && INIController.GET("TEMP_LOGIN", "PW").Equals(textBox2.Text))
            {
               this.Close();
               Isright = true;
            }
            else
            {
               MessageBox.Show("사용자 정보가 없습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               Isright = false;
            }
         }
         else MessageBox.Show("아이디 혹은 비밀번호를 적으세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

      private void BtnClose_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }
   }
}
