using System;
using System.Windows.Forms;
using System.IO;
namespace DetectCrime.Controller
{
   class LogController
   {
      /// <summary>
      /// 로그 기록
      /// </summary>
      /// <param name="_location">클래스.함수 위치</param>
      /// <param name="_message">에러 메시지</param>
      internal static void Write(String _location, String _message)
      {
         try
         {
            if (INIController.GET("USE_LOG", "USE").Equals("Y"))
            {
               String nowYear = DateTime.Now.Year.ToString();
               String nowMonth = DateTime.Now.Month.ToString();
               String nowDay = DateTime.Now.Day.ToString();
               String nowHour = DateTime.Now.Hour.ToString();

               String folderPath = $"{Application.StartupPath}\\LOG\\{nowYear}\\{nowMonth}\\{nowDay}";
               String filePath = $@"{folderPath}\{nowHour}.txt";
               DirectoryInfo directory = new DirectoryInfo(folderPath);
               if (!directory.Exists) directory.Create();
               using(StreamWriter stream = new StreamWriter(filePath))
               {
                  String result = $"LOCATION : {_location} / MESSAGE : {_message} / TIME : {DateTime.Now.ToString("yyyy년 MM월 dd일 HH:mm:ss")}";
                  stream.WriteLine(result);
                  stream.Dispose();
               }
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
