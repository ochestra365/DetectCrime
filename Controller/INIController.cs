using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace DetectCrime.Controller
{
   class INIController
   {
      [DllImport("kernel32")]
      private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);//고정된 함수
      [DllImport("kernel32")]
      private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);//고정된 함수

      /// <summary>
      /// 폼 로드 시 INI파일로부터 초기 세팅 정보 호출
      /// </summary>
      /// <param name="_section">섹션</param>
      /// <param name="_key">키</param>
      /// <returns></returns>
      internal static String GET(String _section, String _key)
      {
         try
         {

            StringBuilder result = new StringBuilder();
            String returnValue = String.Empty;
            GetPrivateProfileString(_section, _key, String.Empty, result, result.Capacity, $@"{Application.StartupPath}\INI\SystemSetting.ini");
            returnValue = result.ToString();
            return returnValue;
         }
         catch { }
         return String.Empty;
      }
      internal static void SET(String _section, String _key,String _value)
      {
         try
         {
            WritePrivateProfileString(_section, _key, _value, $@"{Application.StartupPath}\INI\SystemSetting.ini");
         }
         catch { }
      }
   }
}
