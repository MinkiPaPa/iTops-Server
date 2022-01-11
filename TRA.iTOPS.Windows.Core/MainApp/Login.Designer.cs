﻿namespace TRA.TBOS.Windows.Core.MainApp
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            this.Login_Fill_Panel = new Infragistics.Win.Misc.UltraPanel();
            this.BtnLogin = new Infragistics.Win.Misc.UltraButton();
            this.txtPassword = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtUserName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraFormManager1 = new Infragistics.Win.UltraWinForm.UltraFormManager(this.components);
            this._Login_UltraFormManager_Dock_Area_Top = new Infragistics.Win.UltraWinForm.UltraFormDockArea();
            this._Login_UltraFormManager_Dock_Area_Bottom = new Infragistics.Win.UltraWinForm.UltraFormDockArea();
            this._Login_UltraFormManager_Dock_Area_Left = new Infragistics.Win.UltraWinForm.UltraFormDockArea();
            this._Login_UltraFormManager_Dock_Area_Right = new Infragistics.Win.UltraWinForm.UltraFormDockArea();
            this.Login_Fill_Panel.ClientArea.SuspendLayout();
            this.Login_Fill_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraFormManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Fill_Panel
            // 
            appearance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Login_Fill_Panel.Appearance = appearance1;
            // 
            // Login_Fill_Panel.ClientArea
            // 
            this.Login_Fill_Panel.ClientArea.Controls.Add(this.BtnLogin);
            this.Login_Fill_Panel.ClientArea.Controls.Add(this.txtPassword);
            this.Login_Fill_Panel.ClientArea.Controls.Add(this.txtUserName);
            this.Login_Fill_Panel.ClientArea.Controls.Add(this.ultraLabel2);
            this.Login_Fill_Panel.ClientArea.Controls.Add(this.ultraLabel1);
            this.Login_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Login_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_Fill_Panel.Location = new System.Drawing.Point(8, 32);
            this.Login_Fill_Panel.Name = "Login_Fill_Panel";
            this.Login_Fill_Panel.Size = new System.Drawing.Size(401, 138);
            this.Login_Fill_Panel.TabIndex = 5;
            this.Login_Fill_Panel.UseAppStyling = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(291, 99);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(80, 24);
            this.BtnLogin.StyleSetName = "ultraButtonType4";
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Log In";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(115, 62);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(256, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "TestUser";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(115, 33);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(256, 21);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Tag = "";
            this.txtUserName.Text = "TestUser";
            // 
            // ultraLabel2
            // 
            appearance2.ForeColor = System.Drawing.Color.White;
            this.ultraLabel2.Appearance = appearance2;
            this.ultraLabel2.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.ultraLabel2.Location = new System.Drawing.Point(51, 61);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(77, 23);
            this.ultraLabel2.TabIndex = 0;
            this.ultraLabel2.Text = "PassWord";
            this.ultraLabel2.UseAppStyling = false;
            // 
            // ultraLabel1
            // 
            appearance3.ForeColor = System.Drawing.Color.White;
            this.ultraLabel1.Appearance = appearance3;
            this.ultraLabel1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ultraLabel1.Location = new System.Drawing.Point(64, 33);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(54, 23);
            this.ultraLabel1.TabIndex = 0;
            this.ultraLabel1.Text = "ID";
            this.ultraLabel1.UseAppStyling = false;
            // 
            // ultraFormManager1
            // 
            this.ultraFormManager1.Form = this;
            // 
            // _Login_UltraFormManager_Dock_Area_Top
            // 
            this._Login_UltraFormManager_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Login_UltraFormManager_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._Login_UltraFormManager_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinForm.DockedPosition.Top;
            this._Login_UltraFormManager_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Login_UltraFormManager_Dock_Area_Top.FormManager = this.ultraFormManager1;
            this._Login_UltraFormManager_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._Login_UltraFormManager_Dock_Area_Top.Name = "_Login_UltraFormManager_Dock_Area_Top";
            this._Login_UltraFormManager_Dock_Area_Top.Size = new System.Drawing.Size(417, 32);
            // 
            // _Login_UltraFormManager_Dock_Area_Bottom
            // 
            this._Login_UltraFormManager_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Login_UltraFormManager_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._Login_UltraFormManager_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinForm.DockedPosition.Bottom;
            this._Login_UltraFormManager_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Login_UltraFormManager_Dock_Area_Bottom.FormManager = this.ultraFormManager1;
            this._Login_UltraFormManager_Dock_Area_Bottom.InitialResizeAreaExtent = 8;
            this._Login_UltraFormManager_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 170);
            this._Login_UltraFormManager_Dock_Area_Bottom.Name = "_Login_UltraFormManager_Dock_Area_Bottom";
            this._Login_UltraFormManager_Dock_Area_Bottom.Size = new System.Drawing.Size(417, 8);
            // 
            // _Login_UltraFormManager_Dock_Area_Left
            // 
            this._Login_UltraFormManager_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Login_UltraFormManager_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._Login_UltraFormManager_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinForm.DockedPosition.Left;
            this._Login_UltraFormManager_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Login_UltraFormManager_Dock_Area_Left.FormManager = this.ultraFormManager1;
            this._Login_UltraFormManager_Dock_Area_Left.InitialResizeAreaExtent = 8;
            this._Login_UltraFormManager_Dock_Area_Left.Location = new System.Drawing.Point(0, 32);
            this._Login_UltraFormManager_Dock_Area_Left.Name = "_Login_UltraFormManager_Dock_Area_Left";
            this._Login_UltraFormManager_Dock_Area_Left.Size = new System.Drawing.Size(8, 138);
            // 
            // _Login_UltraFormManager_Dock_Area_Right
            // 
            this._Login_UltraFormManager_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Login_UltraFormManager_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._Login_UltraFormManager_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinForm.DockedPosition.Right;
            this._Login_UltraFormManager_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Login_UltraFormManager_Dock_Area_Right.FormManager = this.ultraFormManager1;
            this._Login_UltraFormManager_Dock_Area_Right.InitialResizeAreaExtent = 8;
            this._Login_UltraFormManager_Dock_Area_Right.Location = new System.Drawing.Point(409, 32);
            this._Login_UltraFormManager_Dock_Area_Right.Name = "_Login_UltraFormManager_Dock_Area_Right";
            this._Login_UltraFormManager_Dock_Area_Right.Size = new System.Drawing.Size(8, 138);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 178);
            this.Controls.Add(this.Login_Fill_Panel);
            this.Controls.Add(this._Login_UltraFormManager_Dock_Area_Left);
            this.Controls.Add(this._Login_UltraFormManager_Dock_Area_Right);
            this.Controls.Add(this._Login_UltraFormManager_Dock_Area_Top);
            this.Controls.Add(this._Login_UltraFormManager_Dock_Area_Bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "TBOS - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Login_Fill_Panel.ClientArea.ResumeLayout(false);
            this.Login_Fill_Panel.ClientArea.PerformLayout();
            this.Login_Fill_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraFormManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel Login_Fill_Panel;
        private Infragistics.Win.Misc.UltraButton BtnLogin;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtPassword;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtUserName;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinForm.UltraFormManager ultraFormManager1;
        private Infragistics.Win.UltraWinForm.UltraFormDockArea _Login_UltraFormManager_Dock_Area_Left;
        private Infragistics.Win.UltraWinForm.UltraFormDockArea _Login_UltraFormManager_Dock_Area_Right;
        private Infragistics.Win.UltraWinForm.UltraFormDockArea _Login_UltraFormManager_Dock_Area_Top;
        private Infragistics.Win.UltraWinForm.UltraFormDockArea _Login_UltraFormManager_Dock_Area_Bottom;
    }
}