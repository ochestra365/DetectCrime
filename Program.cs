using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DetectCrime.View;
namespace DetectCrime
{
   static class Program
   {
      /// <summary>
      /// 해당 애플리케이션의 주 진입점입니다.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         LoginForm login = new LoginForm();
         login.ShowDialog();
         if(login.Isright) Application.Run(new FrmMain());
      }
   }
}
