using System;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms.BunifuButton;
using Bunifu.UI.WinForms;

namespace WindowsFormsApp1
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.login_showPass = new System.Windows.Forms.CheckBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLoginPrompt = new System.Windows.Forms.Label();
            this.signup_loginHere = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.signup_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.pictureBoxClose);
            this.panelContainer.Controls.Add(this.panelForm);
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(300, 459);
            this.panelContainer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Freestyle Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(83, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 76);
            this.label2.TabIndex = 5;
            this.label2.Text = "Noota";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(272, 11);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(17, 16);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 3;
            this.pictureBoxClose.TabStop = false;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.login_showPass);
            this.panelForm.Controls.Add(this.labelTitle);
            this.panelForm.Controls.Add(this.labelLoginPrompt);
            this.panelForm.Controls.Add(this.signup_loginHere);
            this.panelForm.Controls.Add(this.txtPassword);
            this.panelForm.Controls.Add(this.txtEmail);
            this.panelForm.Controls.Add(this.signup_btn);
            this.panelForm.Controls.Add(this.txtUsername);
            this.panelForm.Location = new System.Drawing.Point(0, 98);
            this.panelForm.Margin = new System.Windows.Forms.Padding(2);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(300, 358);
            this.panelForm.TabIndex = 2;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForm_Paint);
            // 
            // login_showPass
            // 
            this.login_showPass.AutoSize = true;
            this.login_showPass.Location = new System.Drawing.Point(33, 207);
            this.login_showPass.Margin = new System.Windows.Forms.Padding(2);
            this.login_showPass.Name = "login_showPass";
            this.login_showPass.Size = new System.Drawing.Size(102, 17);
            this.login_showPass.TabIndex = 16;
            this.login_showPass.Text = "Show Password";
            this.login_showPass.UseVisualStyleBackColor = true;
            this.login_showPass.CheckedChanged += new System.EventHandler(this.login_showPass_CheckedChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitle.Location = new System.Drawing.Point(28, 14);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(238, 32);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Create Your Account";
            // 
            // labelLoginPrompt
            // 
            this.labelLoginPrompt.AutoSize = true;
            this.labelLoginPrompt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPrompt.ForeColor = System.Drawing.Color.Gray;
            this.labelLoginPrompt.Location = new System.Drawing.Point(53, 320);
            this.labelLoginPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoginPrompt.Name = "labelLoginPrompt";
            this.labelLoginPrompt.Size = new System.Drawing.Size(107, 15);
            this.labelLoginPrompt.TabIndex = 13;
            this.labelLoginPrompt.Text = "Already registered?";
            // 
            // signup_loginHere
            // 
            this.signup_loginHere.ActiveLinkColor = System.Drawing.Color.RosyBrown;
            this.signup_loginHere.AutoSize = true;
            this.signup_loginHere.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_loginHere.LinkColor = System.Drawing.Color.RosyBrown;
            this.signup_loginHere.Location = new System.Drawing.Point(174, 320);
            this.signup_loginHere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signup_loginHere.Name = "signup_loginHere";
            this.signup_loginHere.Size = new System.Drawing.Size(66, 15);
            this.signup_loginHere.TabIndex = 12;
            this.signup_loginHere.TabStop = true;
            this.signup_loginHere.Text = "Login here";
            this.signup_loginHere.VisitedLinkColor = System.Drawing.Color.RosyBrown;
            this.signup_loginHere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_loginHere_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Gray;
            this.txtPassword.HintText = "Enter your password";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.RosyBrown;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.RosyBrown;
            this.txtPassword.LineThickness = 2;
            this.txtPassword.Location = new System.Drawing.Point(33, 170);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(233, 32);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Gray;
            this.txtEmail.HintText = "Enter your email";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.RosyBrown;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.RosyBrown;
            this.txtEmail.LineThickness = 2;
            this.txtEmail.Location = new System.Drawing.Point(33, 64);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 32);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // signup_btn
            // 
            this.signup_btn.AllowAnimations = true;
            this.signup_btn.AllowMouseEffects = true;
            this.signup_btn.AllowToggling = false;
            this.signup_btn.AnimationSpeed = 200;
            this.signup_btn.AutoGenerateColors = false;
            this.signup_btn.AutoRoundBorders = true;
            this.signup_btn.AutoSizeLeftIcon = true;
            this.signup_btn.AutoSizeRightIcon = true;
            this.signup_btn.BackColor = System.Drawing.Color.Transparent;
            this.signup_btn.BackColor1 = System.Drawing.Color.RosyBrown;
            this.signup_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signup_btn.BackgroundImage")));
            this.signup_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.signup_btn.ButtonText = "SIGN UP";
            this.signup_btn.ButtonTextMarginLeft = 0;
            this.signup_btn.ColorContrastOnClick = 45;
            this.signup_btn.ColorContrastOnHover = 45;
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.signup_btn.CustomizableEdges = borderEdges3;
            this.signup_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.signup_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.signup_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.signup_btn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.signup_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.signup_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.ForeColor = System.Drawing.Color.White;
            this.signup_btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signup_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.signup_btn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.signup_btn.IconMarginLeft = 11;
            this.signup_btn.IconPadding = 10;
            this.signup_btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signup_btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.signup_btn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.signup_btn.IconSize = 25;
            this.signup_btn.IdleBorderColor = System.Drawing.Color.RosyBrown;
            this.signup_btn.IdleBorderRadius = 30;
            this.signup_btn.IdleBorderThickness = 1;
            this.signup_btn.IdleFillColor = System.Drawing.Color.RosyBrown;
            this.signup_btn.IdleIconLeftImage = null;
            this.signup_btn.IdleIconRightImage = null;
            this.signup_btn.IndicateFocus = false;
            this.signup_btn.Location = new System.Drawing.Point(33, 239);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.signup_btn.OnDisabledState.BorderRadius = 30;
            this.signup_btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.signup_btn.OnDisabledState.BorderThickness = 1;
            this.signup_btn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.signup_btn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.signup_btn.OnDisabledState.IconLeftImage = null;
            this.signup_btn.OnDisabledState.IconRightImage = null;
            this.signup_btn.onHoverState.BorderColor = System.Drawing.Color.RosyBrown;
            this.signup_btn.onHoverState.BorderRadius = 30;
            this.signup_btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.signup_btn.onHoverState.BorderThickness = 1;
            this.signup_btn.onHoverState.FillColor = System.Drawing.Color.RosyBrown;
            this.signup_btn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.signup_btn.onHoverState.IconLeftImage = null;
            this.signup_btn.onHoverState.IconRightImage = null;
            this.signup_btn.OnIdleState.BorderColor = System.Drawing.Color.RosyBrown;
            this.signup_btn.OnIdleState.BorderRadius = 30;
            this.signup_btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.signup_btn.OnIdleState.BorderThickness = 1;
            this.signup_btn.OnIdleState.FillColor = System.Drawing.Color.RosyBrown;
            this.signup_btn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.signup_btn.OnIdleState.IconLeftImage = null;
            this.signup_btn.OnIdleState.IconRightImage = null;
            this.signup_btn.OnPressedState.BorderColor = System.Drawing.Color.RosyBrown;
            this.signup_btn.OnPressedState.BorderRadius = 30;
            this.signup_btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.signup_btn.OnPressedState.BorderThickness = 1;
            this.signup_btn.OnPressedState.FillColor = System.Drawing.Color.RosyBrown;
            this.signup_btn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.signup_btn.OnPressedState.IconLeftImage = null;
            this.signup_btn.OnPressedState.IconRightImage = null;
            this.signup_btn.Size = new System.Drawing.Size(233, 32);
            this.signup_btn.TabIndex = 7;
            this.signup_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signup_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.signup_btn.TextMarginLeft = 0;
            this.signup_btn.TextPadding = new System.Windows.Forms.Padding(0);
            this.signup_btn.UseDefaultRadiusAndThickness = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.HintForeColor = System.Drawing.Color.Gray;
            this.txtUsername.HintText = "Enter your password";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.RosyBrown;
            this.txtUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.RosyBrown;
            this.txtUsername.LineThickness = 2;
            this.txtUsername.Location = new System.Drawing.Point(33, 117);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(233, 32);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Text = "Enter your username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 455);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelForm;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton signup_btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private System.Windows.Forms.LinkLabel signup_loginHere;
        private System.Windows.Forms.Label labelLoginPrompt;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private Label label2;
        private CheckBox login_showPass;
    }
}