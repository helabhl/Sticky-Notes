namespace WindowsFormsApp1
{
    partial class CategoryNote
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryNote));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnAddNote = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.flpNotesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnAddNote
            // 
            this.btnAddNote.AllowAnimations = true;
            this.btnAddNote.AllowMouseEffects = true;
            this.btnAddNote.AllowToggling = false;
            this.btnAddNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddNote.AnimationSpeed = 200;
            this.btnAddNote.AutoGenerateColors = false;
            this.btnAddNote.AutoRoundBorders = false;
            this.btnAddNote.AutoSizeLeftIcon = true;
            this.btnAddNote.AutoSizeRightIcon = true;
            this.btnAddNote.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNote.BackColor1 = System.Drawing.Color.RosyBrown;
            this.btnAddNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNote.BackgroundImage")));
            this.btnAddNote.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNote.ButtonText = "Add Note";
            this.btnAddNote.ButtonTextMarginLeft = 0;
            this.btnAddNote.ColorContrastOnClick = 45;
            this.btnAddNote.ColorContrastOnHover = 45;
            this.btnAddNote.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddNote.CustomizableEdges = borderEdges1;
            this.btnAddNote.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNote.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNote.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNote.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNote.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNote.ForeColor = System.Drawing.Color.White;
            this.btnAddNote.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNote.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNote.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddNote.IconMarginLeft = 11;
            this.btnAddNote.IconPadding = 10;
            this.btnAddNote.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNote.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNote.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddNote.IconSize = 25;
            this.btnAddNote.IdleBorderColor = System.Drawing.Color.RosyBrown;
            this.btnAddNote.IdleBorderRadius = 40;
            this.btnAddNote.IdleBorderThickness = 1;
            this.btnAddNote.IdleFillColor = System.Drawing.Color.RosyBrown;
            this.btnAddNote.IdleIconLeftImage = null;
            this.btnAddNote.IdleIconRightImage = null;
            this.btnAddNote.IndicateFocus = false;
            this.btnAddNote.Location = new System.Drawing.Point(720, 3);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNote.OnDisabledState.BorderRadius = 40;
            this.btnAddNote.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNote.OnDisabledState.BorderThickness = 1;
            this.btnAddNote.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNote.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNote.OnDisabledState.IconLeftImage = null;
            this.btnAddNote.OnDisabledState.IconRightImage = null;
            this.btnAddNote.onHoverState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnAddNote.onHoverState.BorderRadius = 40;
            this.btnAddNote.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNote.onHoverState.BorderThickness = 1;
            this.btnAddNote.onHoverState.FillColor = System.Drawing.Color.RosyBrown;
            this.btnAddNote.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddNote.onHoverState.IconLeftImage = null;
            this.btnAddNote.onHoverState.IconRightImage = null;
            this.btnAddNote.OnIdleState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnAddNote.OnIdleState.BorderRadius = 40;
            this.btnAddNote.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNote.OnIdleState.BorderThickness = 1;
            this.btnAddNote.OnIdleState.FillColor = System.Drawing.Color.RosyBrown;
            this.btnAddNote.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddNote.OnIdleState.IconLeftImage = null;
            this.btnAddNote.OnIdleState.IconRightImage = null;
            this.btnAddNote.OnPressedState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnAddNote.OnPressedState.BorderRadius = 40;
            this.btnAddNote.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNote.OnPressedState.BorderThickness = 1;
            this.btnAddNote.OnPressedState.FillColor = System.Drawing.Color.RosyBrown;
            this.btnAddNote.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddNote.OnPressedState.IconLeftImage = null;
            this.btnAddNote.OnPressedState.IconRightImage = null;
            this.btnAddNote.Size = new System.Drawing.Size(84, 34);
            this.btnAddNote.TabIndex = 3;
            this.btnAddNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNote.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNote.TextMarginLeft = 0;
            this.btnAddNote.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddNote.UseDefaultRadiusAndThickness = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.bunifuLabel1);
            this.pnlTopBar.Controls.Add(this.btnAddNote);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(920, 50);
            this.pnlTopBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AllowParentOverrides = false;
            this.lblTitle.AutoEllipsis = false;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(3, 5);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(85, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "My Notes";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // flpNotesContainer
            // 
            this.flpNotesContainer.AutoScroll = true;
            this.flpNotesContainer.BackColor = System.Drawing.Color.White;
            this.flpNotesContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpNotesContainer.Location = new System.Drawing.Point(0, 39);
            this.flpNotesContainer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flpNotesContainer.Name = "flpNotesContainer";
            this.flpNotesContainer.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.flpNotesContainer.Size = new System.Drawing.Size(920, 473);
            this.flpNotesContainer.TabIndex = 1;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(0, 3);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(85, 25);
            this.bunifuLabel1.TabIndex = 4;
            this.bunifuLabel1.Text = "My Notes";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CategoryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 512);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.flpNotesContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(450, 325);
            this.Name = "CategoryNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Notes";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlTopBar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddNote;
        private System.Windows.Forms.FlowLayoutPanel flpNotesContainer;
        private Bunifu.UI.WinForms.BunifuLabel lblTitle;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}