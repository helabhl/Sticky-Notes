using static Bunifu.UI.WinForms.BunifuButton.BunifuButton;

namespace WindowsFormsApp1.Forms
{
    partial class SigninForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SigninForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.login_showPass = new System.Windows.Forms.CheckBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelRegisterPrompt = new System.Windows.Forms.Label();
            this.login_registerHere = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.login_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.pictureBoxClose);
            this.panelContainer.Controls.Add(this.panelForm);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(300, 455);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(84, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 76);
            this.label1.TabIndex = 4;
            this.label1.Text = "Noota";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(273, 10);
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
            this.panelForm.Controls.Add(this.labelRegisterPrompt);
            this.panelForm.Controls.Add(this.login_registerHere);
            this.panelForm.Controls.Add(this.txtPassword);
            this.panelForm.Controls.Add(this.login_btn);
            this.panelForm.Controls.Add(this.txtEmail);
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
            this.login_showPass.Location = new System.Drawing.Point(33, 187);
            this.login_showPass.Margin = new System.Windows.Forms.Padding(2);
            this.login_showPass.Name = "login_showPass";
            this.login_showPass.Size = new System.Drawing.Size(102, 17);
            this.login_showPass.TabIndex = 15;
            this.login_showPass.Text = "Show Password";
            this.login_showPass.UseVisualStyleBackColor = true;
            this.login_showPass.CheckedChanged += new System.EventHandler(this.login_showPass_CheckedChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitle.Location = new System.Drawing.Point(33, 20);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(180, 32);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Welcome Back!";
            // 
            // labelRegisterPrompt
            // 
            this.labelRegisterPrompt.AutoSize = true;
            this.labelRegisterPrompt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterPrompt.ForeColor = System.Drawing.Color.Gray;
            this.labelRegisterPrompt.Location = new System.Drawing.Point(47, 312);
            this.labelRegisterPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegisterPrompt.Name = "labelRegisterPrompt";
            this.labelRegisterPrompt.Size = new System.Drawing.Size(131, 15);
            this.labelRegisterPrompt.TabIndex = 13;
            this.labelRegisterPrompt.Text = "Don\'t have an account?";
            // 
            // login_registerHere
            // 
            this.login_registerHere.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.login_registerHere.AutoSize = true;
            this.login_registerHere.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_registerHere.LinkColor = System.Drawing.Color.RosyBrown;
            this.login_registerHere.Location = new System.Drawing.Point(182, 312);
            this.login_registerHere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login_registerHere.Name = "login_registerHere";
            this.login_registerHere.Size = new System.Drawing.Size(83, 15);
            this.login_registerHere.TabIndex = 12;
            this.login_registerHere.TabStop = true;
            this.login_registerHere.Text = "Register here";
            this.login_registerHere.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.login_registerHere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_registerHere_LinkClicked_1);
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
            this.txtPassword.Location = new System.Drawing.Point(33, 143);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(233, 32);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // login_btn
            // 
            this.login_btn.AllowAnimations = true;
            this.login_btn.AllowMouseEffects = true;
            this.login_btn.AllowToggling = false;
            this.login_btn.AnimationSpeed = 200;
            this.login_btn.AutoGenerateColors = false;
            this.login_btn.AutoRoundBorders = true;
            this.login_btn.AutoSizeLeftIcon = true;
            this.login_btn.AutoSizeRightIcon = true;
            this.login_btn.BackColor = System.Drawing.Color.Transparent;
            this.login_btn.BackColor1 = System.Drawing.Color.RosyBrown;
            this.login_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_btn.BackgroundImage")));
            this.login_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.login_btn.ButtonText = "LOGIN";
            this.login_btn.ButtonTextMarginLeft = 0;
            this.login_btn.ColorContrastOnClick = 45;
            this.login_btn.ColorContrastOnHover = 45;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.login_btn.CustomizableEdges = borderEdges1;
            this.login_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.login_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.login_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.login_btn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.login_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.login_btn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.login_btn.IconMarginLeft = 11;
            this.login_btn.IconPadding = 10;
            this.login_btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.login_btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.login_btn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.login_btn.IconSize = 25;
            this.login_btn.IdleBorderColor = System.Drawing.Color.RosyBrown;
            this.login_btn.IdleBorderRadius = 30;
            this.login_btn.IdleBorderThickness = 1;
            this.login_btn.IdleFillColor = System.Drawing.Color.RosyBrown;
            this.login_btn.IdleIconLeftImage = null;
            this.login_btn.IdleIconRightImage = null;
            this.login_btn.IndicateFocus = false;
            this.login_btn.Location = new System.Drawing.Point(33, 214);
            this.login_btn.Name = "login_btn";
            this.login_btn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.login_btn.OnDisabledState.BorderRadius = 30;
            this.login_btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.login_btn.OnDisabledState.BorderThickness = 1;
            this.login_btn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.login_btn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.login_btn.OnDisabledState.IconLeftImage = null;
            this.login_btn.OnDisabledState.IconRightImage = null;
            this.login_btn.onHoverState.BorderColor = System.Drawing.Color.RosyBrown;
            this.login_btn.onHoverState.BorderRadius = 30;
            this.login_btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.login_btn.onHoverState.BorderThickness = 1;
            this.login_btn.onHoverState.FillColor = System.Drawing.Color.RosyBrown;
            this.login_btn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.login_btn.onHoverState.IconLeftImage = null;
            this.login_btn.onHoverState.IconRightImage = null;
            this.login_btn.OnIdleState.BorderColor = System.Drawing.Color.RosyBrown;
            this.login_btn.OnIdleState.BorderRadius = 30;
            this.login_btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.login_btn.OnIdleState.BorderThickness = 1;
            this.login_btn.OnIdleState.FillColor = System.Drawing.Color.RosyBrown;
            this.login_btn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.login_btn.OnIdleState.IconLeftImage = null;
            this.login_btn.OnIdleState.IconRightImage = null;
            this.login_btn.OnPressedState.BorderColor = System.Drawing.Color.RosyBrown;
            this.login_btn.OnPressedState.BorderRadius = 30;
            this.login_btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.login_btn.OnPressedState.BorderThickness = 1;
            this.login_btn.OnPressedState.FillColor = System.Drawing.Color.RosyBrown;
            this.login_btn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.login_btn.OnPressedState.IconLeftImage = null;
            this.login_btn.OnPressedState.IconRightImage = null;
            this.login_btn.Size = new System.Drawing.Size(233, 32);
            this.login_btn.TabIndex = 7;
            this.login_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_btn.TextMarginLeft = 0;
            this.login_btn.TextPadding = new System.Windows.Forms.Padding(0);
            this.login_btn.UseDefaultRadiusAndThickness = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
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
            this.txtEmail.HintText = "Enter your username or email";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.RosyBrown;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.RosyBrown;
            this.txtEmail.LineThickness = 2;
            this.txtEmail.Location = new System.Drawing.Point(33, 91);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 32);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.OnValueChanged += new System.EventHandler(this.login_username_OnValueChanged);
            // 
            // SigninForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 455);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SigninForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton login_btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private System.Windows.Forms.LinkLabel login_registerHere;
        private System.Windows.Forms.Label labelRegisterPrompt;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.CheckBox login_showPass;
        private System.Windows.Forms.Label label1;
    }
}