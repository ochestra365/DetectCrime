using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DetectCrime.Controller;

namespace DetectCrime
{
   public partial class FrmMain : Form
   {
      public FrmMain()
      {
         InitializeComponent();
      }
      private void button1_Click(object sender, EventArgs e)
      {

      }

      private void FrmMain_Load(object sender, EventArgs e)
      {
         UIController.FormBasic(this);
         UIController.ButtonSetting(BtnClose);
         UIController.ButtonSetting(button1);
         PanelMain.BackColor = Color.FromArgb(64, 64, 64);
      }

      private void BtnClose_Click(object sender, EventArgs e)
      {
         if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
      }

      private void cCTV리스트ToolStripMenuItem_Click(object sender, EventArgs e)
      {

      }

      private void SubMenuListRobot_Click(object sender, EventArgs e)
      {

      }
   }
}
