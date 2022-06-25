
namespace DetectCrime.View
{
   partial class LoginForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.LblTitle = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.BtnLogin = new System.Windows.Forms.Button();
         this.BtnClose = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // LblTitle
         // 
         this.LblTitle.AutoSize = true;
         this.LblTitle.Location = new System.Drawing.Point(45, 36);
         this.LblTitle.Name = "LblTitle";
         this.LblTitle.Size = new System.Drawing.Size(57, 12);
         this.LblTitle.TabIndex = 0;
         this.LblTitle.Text = "로그인 창";
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(62, 69);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(100, 21);
         this.textBox1.TabIndex = 1;
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(62, 116);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(100, 21);
         this.textBox2.TabIndex = 2;
         // 
         // BtnLogin
         // 
         this.BtnLogin.Location = new System.Drawing.Point(168, 36);
         this.BtnLogin.Name = "BtnLogin";
         this.BtnLogin.Size = new System.Drawing.Size(114, 57);
         this.BtnLogin.TabIndex = 3;
         this.BtnLogin.Text = "로그인";
         this.BtnLogin.UseVisualStyleBackColor = true;
         this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
         // 
         // BtnClose
         // 
         this.BtnClose.Location = new System.Drawing.Point(168, 97);
         this.BtnClose.Name = "BtnClose";
         this.BtnClose.Size = new System.Drawing.Size(114, 57);
         this.BtnClose.TabIndex = 4;
         this.BtnClose.Text = "종료";
         this.BtnClose.UseVisualStyleBackColor = true;
         this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
         // 
         // LoginForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(309, 168);
         this.Controls.Add(this.BtnClose);
         this.Controls.Add(this.BtnLogin);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.LblTitle);
         this.Name = "LoginForm";
         this.Text = "LoginForm";
         this.Load += new System.EventHandler(this.LoginForm_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label LblTitle;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Button BtnLogin;
      private System.Windows.Forms.Button BtnClose;
   }
}