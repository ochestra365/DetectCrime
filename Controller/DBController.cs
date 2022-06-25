using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DetectCrime.Controller;
using System.Threading;

namespace DetectCrime.Controller
{
   class DBController
   {
      MySqlConnection Conn = new MySqlConnection(String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}",
         INIController.GET("SERVER_PATH", "SERVER"), INIController.GET("SERVER_PATH", "PORT"),
         INIController.GET("SERVER_PATH", "DATABASE"), INIController.GET("SERVER_PATH", "ID"), INIController.GET("SERVER_PATH", "PW")
         ));

      internal bool Open()
      {
         try
         {
            if (Conn == null)
            {
               Conn.Open();
               return true;
            }
            else
            {
               return false;
            }
         }
         catch (ThreadAbortException){ }
         catch (Exception ex)
         {
            LogController.Write("DBController.Open()", ex.Message);
         }
         return false;
      }
      internal void Close()
      {
         try
         {
            if (Conn != null)
            {
               Conn.Close();
            }
         }
         catch (ThreadAbortException) { }
         catch (Exception ex)
         {
            LogController.Write("DBController.Close()", ex.Message);
         }
         finally
         {
            Conn = null;
            Conn.Dispose();
         }
      }
   }
}
