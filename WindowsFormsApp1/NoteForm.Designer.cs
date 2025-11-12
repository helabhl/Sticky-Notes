namespace WindowsFormsApp1
{
    partial class NoteForm
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtTitle = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnList = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnCrossedOut = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCreateNote = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblNewNote = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDescription = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuCards1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtTitle
            // 
            this.txtTitle.AcceptsReturn = false;
            this.txtTitle.AcceptsTab = false;
            this.txtTitle.AnimationSpeed = 200;
            this.txtTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTitle.BackgroundImage")));
            this.txtTitle.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTitle.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTitle.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTitle.BorderColorIdle = System.Drawing.Color.LightBlue;
            this.txtTitle.BorderRadius = 5;
            this.txtTitle.BorderThickness = 1;
            this.txtTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtTitle.DefaultText = "";
            this.txtTitle.FillColor = System.Drawing.Color.White;
            this.txtTitle.HideSelection = true;
            this.txtTitle.IconLeft = null;
            this.txtTitle.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.IconPadding = 10;
            this.txtTitle.IconRight = null;
            this.txtTitle.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(12, 69);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTitle.Modified = false;
            this.txtTitle.Multiline = false;
            this.txtTitle.Name = "txtTitle";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTitle.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTitle.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTitle.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.LightBlue;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTitle.OnIdleState = stateProperties4;
            this.txtTitle.Padding = new System.Windows.Forms.Padding(3);
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTitle.PlaceholderText = "This is the title";
            this.txtTitle.ReadOnly = false;
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(370, 37);
            this.txtTitle.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTitle.TabIndex = 2;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTitle.TextMarginBottom = 0;
            this.txtTitle.TextMarginLeft = 3;
            this.txtTitle.TextMarginTop = 0;
            this.txtTitle.TextPlaceholder = "This is the title";
            this.txtTitle.UseSystemPasswordChar = false;
            this.txtTitle.WordWrap = true;
            // 
            // btnItalic
            // 
            this.btnItalic.BackColor = System.Drawing.Color.Transparent;
            this.btnItalic.FlatAppearance.BorderSize = 0;
            this.btnItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItalic.Image = ((System.Drawing.Image)(resources.GetObject("btnItalic.Image")));
            this.btnItalic.Location = new System.Drawing.Point(60, 0);
            this.btnItalic.Margin = new System.Windows.Forms.Padding(0);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(30, 30);
            this.btnItalic.TabIndex = 6;
            this.btnItalic.UseVisualStyleBackColor = false;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnBold
            // 
            this.btnBold.BackColor = System.Drawing.Color.Transparent;
            this.btnBold.FlatAppearance.BorderSize = 0;
            this.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.Location = new System.Drawing.Point(30, 0);
            this.btnBold.Margin = new System.Windows.Forms.Padding(0);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(30, 30);
            this.btnBold.TabIndex = 0;
            this.btnBold.UseVisualStyleBackColor = false;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards1.Controls.Add(this.bunifuPanel2);
            this.bunifuCards1.Controls.Add(this.btnCancel);
            this.bunifuCards1.Controls.Add(this.btnCreateNote);
            this.bunifuCards1.Controls.Add(this.bunifuPanel1);
            this.bunifuCards1.Controls.Add(this.lblDescription);
            this.bunifuCards1.Controls.Add(this.txtTitle);
            this.bunifuCards1.Controls.Add(this.lblTitle);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(395, 395);
            this.bunifuCards1.TabIndex = 0;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.LightBlue;
            this.bunifuPanel2.BorderRadius = 5;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.txtDescription);
            this.bunifuPanel2.Controls.Add(this.bunifuSeparator1);
            this.bunifuPanel2.Controls.Add(this.flowLayoutPanel1);
            this.bunifuPanel2.Location = new System.Drawing.Point(13, 133);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(369, 182);
            this.bunifuPanel2.TabIndex = 12;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtDescription.Location = new System.Drawing.Point(13, 12);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(345, 125);
            this.txtDescription.TabIndex = 13;
            this.txtDescription.Text = "";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.LightBlue;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 140);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(369, 10);
            this.bunifuSeparator1.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnList);
            this.flowLayoutPanel1.Controls.Add(this.btnBold);
            this.flowLayoutPanel1.Controls.Add(this.btnItalic);
            this.flowLayoutPanel1.Controls.Add(this.btnUnderline);
            this.flowLayoutPanel1.Controls.Add(this.btnCrossedOut);
            this.flowLayoutPanel1.Controls.Add(this.btnImage);
            this.flowLayoutPanel1.Controls.Add(this.btnColor);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 150);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(355, 30);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Transparent;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.Location = new System.Drawing.Point(0, 0);
            this.btnList.Margin = new System.Windows.Forms.Padding(0);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(30, 30);
            this.btnList.TabIndex = 10;
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.BackColor = System.Drawing.Color.Transparent;
            this.btnUnderline.FlatAppearance.BorderSize = 0;
            this.btnUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderline.Image")));
            this.btnUnderline.Location = new System.Drawing.Point(90, 0);
            this.btnUnderline.Margin = new System.Windows.Forms.Padding(0);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(30, 30);
            this.btnUnderline.TabIndex = 7;
            this.btnUnderline.UseVisualStyleBackColor = false;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnCrossedOut
            // 
            this.btnCrossedOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCrossedOut.FlatAppearance.BorderSize = 0;
            this.btnCrossedOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrossedOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCrossedOut.Image")));
            this.btnCrossedOut.Location = new System.Drawing.Point(120, 0);
            this.btnCrossedOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrossedOut.Name = "btnCrossedOut";
            this.btnCrossedOut.Size = new System.Drawing.Size(30, 30);
            this.btnCrossedOut.TabIndex = 8;
            this.btnCrossedOut.UseVisualStyleBackColor = false;
            this.btnCrossedOut.Click += new System.EventHandler(this.btnCrossedOut_Click);
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.Transparent;
            this.btnImage.FlatAppearance.BorderSize = 0;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Image = ((System.Drawing.Image)(resources.GetObject("btnImage.Image")));
            this.btnImage.Location = new System.Drawing.Point(150, 0);
            this.btnImage.Margin = new System.Windows.Forms.Padding(0);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(30, 30);
            this.btnImage.TabIndex = 9;
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Transparent;
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Image = ((System.Drawing.Image)(resources.GetObject("btnColor.Image")));
            this.btnColor.Location = new System.Drawing.Point(180, 0);
            this.btnColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(30, 30);
            this.btnColor.TabIndex = 11;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AllowAnimations = true;
            this.btnCancel.AllowMouseEffects = true;
            this.btnCancel.AllowToggling = false;
            this.btnCancel.AnimationSpeed = 200;
            this.btnCancel.AutoGenerateColors = false;
            this.btnCancel.AutoRoundBorders = false;
            this.btnCancel.AutoSizeLeftIcon = true;
            this.btnCancel.AutoSizeRightIcon = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackColor1 = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.ButtonTextMarginLeft = 0;
            this.btnCancel.ColorContrastOnClick = 45;
            this.btnCancel.ColorContrastOnHover = 45;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCancel.CustomizableEdges = borderEdges1;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancel.IconMarginLeft = 11;
            this.btnCancel.IconPadding = 10;
            this.btnCancel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancel.IconSize = 25;
            this.btnCancel.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.IdleBorderRadius = 40;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleIconLeftImage = null;
            this.btnCancel.IdleIconRightImage = null;
            this.btnCancel.IndicateFocus = false;
            this.btnCancel.Location = new System.Drawing.Point(196, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.OnDisabledState.BorderRadius = 40;
            this.btnCancel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnDisabledState.BorderThickness = 1;
            this.btnCancel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.OnDisabledState.IconLeftImage = null;
            this.btnCancel.OnDisabledState.IconRightImage = null;
            this.btnCancel.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCancel.onHoverState.BorderRadius = 40;
            this.btnCancel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.onHoverState.BorderThickness = 1;
            this.btnCancel.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCancel.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.onHoverState.IconLeftImage = null;
            this.btnCancel.onHoverState.IconRightImage = null;
            this.btnCancel.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.OnIdleState.BorderRadius = 40;
            this.btnCancel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnIdleState.BorderThickness = 1;
            this.btnCancel.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnCancel.OnIdleState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.OnIdleState.IconLeftImage = null;
            this.btnCancel.OnIdleState.IconRightImage = null;
            this.btnCancel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancel.OnPressedState.BorderRadius = 40;
            this.btnCancel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnPressedState.BorderThickness = 1;
            this.btnCancel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.OnPressedState.IconLeftImage = null;
            this.btnCancel.OnPressedState.IconRightImage = null;
            this.btnCancel.Size = new System.Drawing.Size(72, 39);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.TextMarginLeft = 0;
            this.btnCancel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancel.UseDefaultRadiusAndThickness = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateNote
            // 
            this.btnCreateNote.AllowAnimations = true;
            this.btnCreateNote.AllowMouseEffects = true;
            this.btnCreateNote.AllowToggling = false;
            this.btnCreateNote.AnimationSpeed = 200;
            this.btnCreateNote.AutoGenerateColors = false;
            this.btnCreateNote.AutoRoundBorders = false;
            this.btnCreateNote.AutoSizeLeftIcon = true;
            this.btnCreateNote.AutoSizeRightIcon = true;
            this.btnCreateNote.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateNote.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnCreateNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateNote.BackgroundImage")));
            this.btnCreateNote.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateNote.ButtonText = "Create";
            this.btnCreateNote.ButtonTextMarginLeft = 0;
            this.btnCreateNote.ColorContrastOnClick = 45;
            this.btnCreateNote.ColorContrastOnHover = 45;
            this.btnCreateNote.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnCreateNote.CustomizableEdges = borderEdges2;
            this.btnCreateNote.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCreateNote.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCreateNote.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCreateNote.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCreateNote.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCreateNote.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNote.ForeColor = System.Drawing.Color.White;
            this.btnCreateNote.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNote.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCreateNote.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCreateNote.IconMarginLeft = 11;
            this.btnCreateNote.IconPadding = 10;
            this.btnCreateNote.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateNote.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCreateNote.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCreateNote.IconSize = 25;
            this.btnCreateNote.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateNote.IdleBorderRadius = 40;
            this.btnCreateNote.IdleBorderThickness = 1;
            this.btnCreateNote.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateNote.IdleIconLeftImage = null;
            this.btnCreateNote.IdleIconRightImage = null;
            this.btnCreateNote.IndicateFocus = false;
            this.btnCreateNote.Location = new System.Drawing.Point(280, 332);
            this.btnCreateNote.Name = "btnCreateNote";
            this.btnCreateNote.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCreateNote.OnDisabledState.BorderRadius = 40;
            this.btnCreateNote.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateNote.OnDisabledState.BorderThickness = 1;
            this.btnCreateNote.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCreateNote.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCreateNote.OnDisabledState.IconLeftImage = null;
            this.btnCreateNote.OnDisabledState.IconRightImage = null;
            this.btnCreateNote.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCreateNote.onHoverState.BorderRadius = 40;
            this.btnCreateNote.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateNote.onHoverState.BorderThickness = 1;
            this.btnCreateNote.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCreateNote.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCreateNote.onHoverState.IconLeftImage = null;
            this.btnCreateNote.onHoverState.IconRightImage = null;
            this.btnCreateNote.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateNote.OnIdleState.BorderRadius = 40;
            this.btnCreateNote.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateNote.OnIdleState.BorderThickness = 1;
            this.btnCreateNote.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateNote.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCreateNote.OnIdleState.IconLeftImage = null;
            this.btnCreateNote.OnIdleState.IconRightImage = null;
            this.btnCreateNote.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCreateNote.OnPressedState.BorderRadius = 40;
            this.btnCreateNote.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateNote.OnPressedState.BorderThickness = 1;
            this.btnCreateNote.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCreateNote.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCreateNote.OnPressedState.IconLeftImage = null;
            this.btnCreateNote.OnPressedState.IconRightImage = null;
            this.btnCreateNote.Size = new System.Drawing.Size(84, 39);
            this.btnCreateNote.TabIndex = 9;
            this.btnCreateNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreateNote.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCreateNote.TextMarginLeft = 0;
            this.btnCreateNote.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCreateNote.UseDefaultRadiusAndThickness = true;
            this.btnCreateNote.Click += new System.EventHandler(this.btnCreateNote_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.MintCream;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblNewNote);
            this.bunifuPanel1.Controls.Add(this.btnClose);
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 5);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(405, 37);
            this.bunifuPanel1.TabIndex = 8;
            // 
            // lblNewNote
            // 
            this.lblNewNote.AllowParentOverrides = false;
            this.lblNewNote.AutoEllipsis = false;
            this.lblNewNote.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNewNote.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNewNote.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewNote.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNewNote.Location = new System.Drawing.Point(13, 7);
            this.lblNewNote.Name = "lblNewNote";
            this.lblNewNote.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNewNote.Size = new System.Drawing.Size(74, 15);
            this.lblNewNote.TabIndex = 0;
            this.lblNewNote.Text = "Add new note";
            this.lblNewNote.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNewNote.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(356, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 31);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AllowParentOverrides = false;
            this.lblDescription.AutoEllipsis = false;
            this.lblDescription.CursorType = null;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Location = new System.Drawing.Point(13, 112);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescription.Size = new System.Drawing.Size(61, 15);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDescription.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTitle
            // 
            this.lblTitle.AllowParentOverrides = false;
            this.lblTitle.AutoEllipsis = false;
            this.lblTitle.CursorType = null;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(13, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(23, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 395);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoteForm";
            this.Text = "Form2";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btnCrossedOut;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnList;
        private Bunifu.UI.WinForms.BunifuLabel lblDescription;
        private Bunifu.UI.WinForms.BunifuTextBox txtTitle;
        private Bunifu.UI.WinForms.BunifuLabel lblTitle;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lblNewNote;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCreateNote;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.RichTextBox txtDescription;
    }
}