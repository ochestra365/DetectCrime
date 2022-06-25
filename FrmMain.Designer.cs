
namespace DetectCrime
{
   partial class FrmMain
   {
      /// <summary>
      /// 필수 디자이너 변수입니다.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 사용 중인 모든 리소스를 정리합니다.
      /// </summary>
      /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form 디자이너에서 생성한 코드

      /// <summary>
      /// 디자이너 지원에 필요한 메서드입니다. 
      /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
      /// </summary>
      private void InitializeComponent()
      {
         this.button1 = new System.Windows.Forms.Button();
         this.BtnClose = new System.Windows.Forms.Button();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.SubMenuCCTV = new System.Windows.Forms.ToolStripMenuItem();
         this.SubMenuCall = new System.Windows.Forms.ToolStripMenuItem();
         this.SubMenuRobot = new System.Windows.Forms.ToolStripMenuItem();
         this.SubMenuCallPolice = new System.Windows.Forms.ToolStripMenuItem();
         this.SubMenu911 = new System.Windows.Forms.ToolStripMenuItem();
         this.SubMenuList = new System.Windows.Forms.ToolStripMenuItem();
         this.cCTV리스트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.SubMenuListRobot = new System.Windows.Forms.ToolStripMenuItem();
         this.TplMain = new System.Windows.Forms.TableLayoutPanel();
         this.TplButton = new System.Windows.Forms.TableLayoutPanel();
         this.PanelMain = new System.Windows.Forms.Panel();
         this.menuStrip1.SuspendLayout();
         this.TplMain.SuspendLayout();
         this.TplButton.SuspendLayout();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.button1.Location = new System.Drawing.Point(400, 3);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(391, 73);
         this.button1.TabIndex = 0;
         this.button1.Text = "TEST";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // BtnClose
         // 
         this.BtnClose.Dock = System.Windows.Forms.DockStyle.Fill;
         this.BtnClose.FlatAppearance.BorderSize = 0;
         this.BtnClose.Location = new System.Drawing.Point(3, 3);
         this.BtnClose.Name = "BtnClose";
         this.BtnClose.Size = new System.Drawing.Size(391, 73);
         this.BtnClose.TabIndex = 1;
         this.BtnClose.Text = "종료";
         this.BtnClose.UseVisualStyleBackColor = true;
         this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuCCTV,
            this.SubMenuCall,
            this.SubMenuRobot,
            this.SubMenuList});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(800, 24);
         this.menuStrip1.TabIndex = 2;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // SubMenuCCTV
         // 
         this.SubMenuCCTV.Name = "SubMenuCCTV";
         this.SubMenuCCTV.Size = new System.Drawing.Size(49, 20);
         this.SubMenuCCTV.Text = "CCTV";
         // 
         // SubMenuCall
         // 
         this.SubMenuCall.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuCallPolice,
            this.SubMenu911});
         this.SubMenuCall.Name = "SubMenuCall";
         this.SubMenuCall.Size = new System.Drawing.Size(39, 20);
         this.SubMenuCall.Text = "Call";
         // 
         // SubMenuRobot
         // 
         this.SubMenuRobot.Name = "SubMenuRobot";
         this.SubMenuRobot.Size = new System.Drawing.Size(51, 20);
         this.SubMenuRobot.Text = "Robot";
         // 
         // SubMenuCallPolice
         // 
         this.SubMenuCallPolice.Name = "SubMenuCallPolice";
         this.SubMenuCallPolice.Size = new System.Drawing.Size(180, 22);
         this.SubMenuCallPolice.Text = "경찰";
         // 
         // SubMenu911
         // 
         this.SubMenu911.Name = "SubMenu911";
         this.SubMenu911.Size = new System.Drawing.Size(180, 22);
         this.SubMenu911.Text = "소방서";
         // 
         // SubMenuList
         // 
         this.SubMenuList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cCTV리스트ToolStripMenuItem,
            this.SubMenuListRobot});
         this.SubMenuList.Name = "SubMenuList";
         this.SubMenuList.Size = new System.Drawing.Size(37, 20);
         this.SubMenuList.Text = "List";
         // 
         // cCTV리스트ToolStripMenuItem
         // 
         this.cCTV리스트ToolStripMenuItem.Name = "cCTV리스트ToolStripMenuItem";
         this.cCTV리스트ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.cCTV리스트ToolStripMenuItem.Text = "CCTV리스트";
         this.cCTV리스트ToolStripMenuItem.Click += new System.EventHandler(this.cCTV리스트ToolStripMenuItem_Click);
         // 
         // SubMenuListRobot
         // 
         this.SubMenuListRobot.Name = "SubMenuListRobot";
         this.SubMenuListRobot.Size = new System.Drawing.Size(180, 22);
         this.SubMenuListRobot.Text = "Robot리스트";
         this.SubMenuListRobot.Click += new System.EventHandler(this.SubMenuListRobot_Click);
         // 
         // TplMain
         // 
         this.TplMain.ColumnCount = 1;
         this.TplMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.TplMain.Controls.Add(this.TplButton, 0, 0);
         this.TplMain.Controls.Add(this.PanelMain, 0, 1);
         this.TplMain.Dock = System.Windows.Forms.DockStyle.Fill;
         this.TplMain.Location = new System.Drawing.Point(0, 24);
         this.TplMain.Name = "TplMain";
         this.TplMain.RowCount = 2;
         this.TplMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
         this.TplMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
         this.TplMain.Size = new System.Drawing.Size(800, 426);
         this.TplMain.TabIndex = 3;
         // 
         // TplButton
         // 
         this.TplButton.ColumnCount = 2;
         this.TplButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.TplButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.TplButton.Controls.Add(this.BtnClose, 0, 0);
         this.TplButton.Controls.Add(this.button1, 1, 0);
         this.TplButton.Dock = System.Windows.Forms.DockStyle.Fill;
         this.TplButton.Location = new System.Drawing.Point(3, 3);
         this.TplButton.Name = "TplButton";
         this.TplButton.RowCount = 1;
         this.TplButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.TplButton.Size = new System.Drawing.Size(794, 79);
         this.TplButton.TabIndex = 0;
         // 
         // PanelMain
         // 
         this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
         this.PanelMain.Location = new System.Drawing.Point(3, 88);
         this.PanelMain.Name = "PanelMain";
         this.PanelMain.Size = new System.Drawing.Size(794, 335);
         this.PanelMain.TabIndex = 1;
         // 
         // FrmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.TplMain);
         this.Controls.Add(this.menuStrip1);
         this.Name = "FrmMain";
         this.Text = "DetectCrime";
         this.Load += new System.EventHandler(this.FrmMain_Load);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.TplMain.ResumeLayout(false);
         this.TplButton.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button BtnClose;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem SubMenuCCTV;
      private System.Windows.Forms.ToolStripMenuItem SubMenuCall;
      private System.Windows.Forms.ToolStripMenuItem SubMenuRobot;
      private System.Windows.Forms.ToolStripMenuItem SubMenuCallPolice;
      private System.Windows.Forms.ToolStripMenuItem SubMenu911;
      private System.Windows.Forms.ToolStripMenuItem SubMenuList;
      private System.Windows.Forms.ToolStripMenuItem cCTV리스트ToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem SubMenuListRobot;
      private System.Windows.Forms.TableLayoutPanel TplMain;
      private System.Windows.Forms.TableLayoutPanel TplButton;
      private System.Windows.Forms.Panel PanelMain;
   }
}

