using System.Drawing;

namespace WindowsFormsApp1
{
    partial class TaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.txtTitle = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.dueDate = new System.Windows.Forms.DateTimePicker();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCreateTask = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblNewTask = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDescription = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmbPriority = new WindowsFormsApp1.CustomComboBox();
            this.cmbStatus = new WindowsFormsApp1.CustomComboBox();
            this.bunifuCards1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.txtTitle.BorderColorActive = System.Drawing.Color.LavenderBlush;
            this.txtTitle.BorderColorDisabled = System.Drawing.Color.LavenderBlush;
            this.txtTitle.BorderColorHover = System.Drawing.Color.LavenderBlush;
            this.txtTitle.BorderColorIdle = System.Drawing.Color.LavenderBlush;
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
            stateProperties5.BorderColor = System.Drawing.Color.LavenderBlush;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTitle.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.LavenderBlush;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTitle.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.LavenderBlush;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTitle.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.LavenderBlush;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTitle.OnIdleState = stateProperties8;
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
            this.txtTitle.Size = new System.Drawing.Size(281, 26);
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
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Purple;
            this.bunifuCards1.Controls.Add(this.bunifuPanel2);
            this.bunifuCards1.Controls.Add(this.dueDate);
            this.bunifuCards1.Controls.Add(this.cmbPriority);
            this.bunifuCards1.Controls.Add(this.cmbStatus);
            this.bunifuCards1.Controls.Add(this.bunifuLabel3);
            this.bunifuCards1.Controls.Add(this.bunifuLabel2);
            this.bunifuCards1.Controls.Add(this.bunifuLabel1);
            this.bunifuCards1.Controls.Add(this.btnCancel);
            this.bunifuCards1.Controls.Add(this.btnCreateTask);
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
            this.bunifuCards1.Size = new System.Drawing.Size(305, 316);
            this.bunifuCards1.TabIndex = 0;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.LavenderBlush;
            this.bunifuPanel2.BorderRadius = 5;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.txtDescription);
            this.bunifuPanel2.Location = new System.Drawing.Point(12, 122);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(281, 59);
            this.bunifuPanel2.TabIndex = 26;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtDescription.Location = new System.Drawing.Point(14, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(249, 53);
            this.txtDescription.TabIndex = 13;
            this.txtDescription.Text = "";
            // 
            // dueDate
            // 
            this.dueDate.Location = new System.Drawing.Point(102, 241);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(188, 20);
            this.dueDate.TabIndex = 25;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuLabel3.Location = new System.Drawing.Point(13, 246);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(50, 15);
            this.bunifuLabel3.TabIndex = 15;
            this.bunifuLabel3.Text = "Due Date";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuLabel2.Location = new System.Drawing.Point(13, 220);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(38, 15);
            this.bunifuLabel2.TabIndex = 14;
            this.bunifuLabel2.Text = "Priority";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuLabel1.Location = new System.Drawing.Point(13, 193);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(33, 15);
            this.bunifuLabel1.TabIndex = 13;
            this.bunifuLabel1.Text = "Status";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnCancel.CustomizableEdges = borderEdges3;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Purple;
            this.btnCancel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancel.IconMarginLeft = 11;
            this.btnCancel.IconPadding = 10;
            this.btnCancel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancel.IconSize = 25;
            this.btnCancel.IdleBorderColor = System.Drawing.Color.Purple;
            this.btnCancel.IdleBorderRadius = 40;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleIconLeftImage = null;
            this.btnCancel.IdleIconRightImage = null;
            this.btnCancel.IndicateFocus = false;
            this.btnCancel.Location = new System.Drawing.Point(128, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.OnDisabledState.BorderRadius = 40;
            this.btnCancel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnDisabledState.BorderThickness = 1;
            this.btnCancel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.OnDisabledState.IconLeftImage = null;
            this.btnCancel.OnDisabledState.IconRightImage = null;
            this.btnCancel.onHoverState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnCancel.onHoverState.BorderRadius = 40;
            this.btnCancel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.onHoverState.BorderThickness = 1;
            this.btnCancel.onHoverState.FillColor = System.Drawing.Color.RosyBrown;
            this.btnCancel.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.onHoverState.IconLeftImage = null;
            this.btnCancel.onHoverState.IconRightImage = null;
            this.btnCancel.OnIdleState.BorderColor = System.Drawing.Color.Purple;
            this.btnCancel.OnIdleState.BorderRadius = 40;
            this.btnCancel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnIdleState.BorderThickness = 1;
            this.btnCancel.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnCancel.OnIdleState.ForeColor = System.Drawing.Color.Purple;
            this.btnCancel.OnIdleState.IconLeftImage = null;
            this.btnCancel.OnIdleState.IconRightImage = null;
            this.btnCancel.OnPressedState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnCancel.OnPressedState.BorderRadius = 40;
            this.btnCancel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnPressedState.BorderThickness = 1;
            this.btnCancel.OnPressedState.FillColor = System.Drawing.Color.RosyBrown;
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
            // btnCreateTask
            // 
            this.btnCreateTask.AllowAnimations = true;
            this.btnCreateTask.AllowMouseEffects = true;
            this.btnCreateTask.AllowToggling = false;
            this.btnCreateTask.AnimationSpeed = 200;
            this.btnCreateTask.AutoGenerateColors = false;
            this.btnCreateTask.AutoRoundBorders = false;
            this.btnCreateTask.AutoSizeLeftIcon = true;
            this.btnCreateTask.AutoSizeRightIcon = true;
            this.btnCreateTask.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateTask.BackColor1 = System.Drawing.Color.Purple;
            this.btnCreateTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateTask.BackgroundImage")));
            this.btnCreateTask.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateTask.ButtonText = "Save";
            this.btnCreateTask.ButtonTextMarginLeft = 0;
            this.btnCreateTask.ColorContrastOnClick = 45;
            this.btnCreateTask.ColorContrastOnHover = 45;
            this.btnCreateTask.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnCreateTask.CustomizableEdges = borderEdges4;
            this.btnCreateTask.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCreateTask.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCreateTask.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCreateTask.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCreateTask.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCreateTask.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTask.ForeColor = System.Drawing.Color.White;
            this.btnCreateTask.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateTask.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCreateTask.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCreateTask.IconMarginLeft = 11;
            this.btnCreateTask.IconPadding = 10;
            this.btnCreateTask.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateTask.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCreateTask.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCreateTask.IconSize = 25;
            this.btnCreateTask.IdleBorderColor = System.Drawing.Color.Purple;
            this.btnCreateTask.IdleBorderRadius = 40;
            this.btnCreateTask.IdleBorderThickness = 1;
            this.btnCreateTask.IdleFillColor = System.Drawing.Color.Purple;
            this.btnCreateTask.IdleIconLeftImage = null;
            this.btnCreateTask.IdleIconRightImage = null;
            this.btnCreateTask.IndicateFocus = false;
            this.btnCreateTask.Location = new System.Drawing.Point(206, 267);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCreateTask.OnDisabledState.BorderRadius = 40;
            this.btnCreateTask.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateTask.OnDisabledState.BorderThickness = 1;
            this.btnCreateTask.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCreateTask.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCreateTask.OnDisabledState.IconLeftImage = null;
            this.btnCreateTask.OnDisabledState.IconRightImage = null;
            this.btnCreateTask.onHoverState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnCreateTask.onHoverState.BorderRadius = 40;
            this.btnCreateTask.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateTask.onHoverState.BorderThickness = 1;
            this.btnCreateTask.onHoverState.FillColor = System.Drawing.Color.RosyBrown;
            this.btnCreateTask.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCreateTask.onHoverState.IconLeftImage = null;
            this.btnCreateTask.onHoverState.IconRightImage = null;
            this.btnCreateTask.OnIdleState.BorderColor = System.Drawing.Color.Purple;
            this.btnCreateTask.OnIdleState.BorderRadius = 40;
            this.btnCreateTask.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateTask.OnIdleState.BorderThickness = 1;
            this.btnCreateTask.OnIdleState.FillColor = System.Drawing.Color.Purple;
            this.btnCreateTask.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCreateTask.OnIdleState.IconLeftImage = null;
            this.btnCreateTask.OnIdleState.IconRightImage = null;
            this.btnCreateTask.OnPressedState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnCreateTask.OnPressedState.BorderRadius = 40;
            this.btnCreateTask.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCreateTask.OnPressedState.BorderThickness = 1;
            this.btnCreateTask.OnPressedState.FillColor = System.Drawing.Color.RosyBrown;
            this.btnCreateTask.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCreateTask.OnPressedState.IconLeftImage = null;
            this.btnCreateTask.OnPressedState.IconRightImage = null;
            this.btnCreateTask.Size = new System.Drawing.Size(84, 39);
            this.btnCreateTask.TabIndex = 9;
            this.btnCreateTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreateTask.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCreateTask.TextMarginLeft = 0;
            this.btnCreateTask.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCreateTask.UseDefaultRadiusAndThickness = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblNewTask);
            this.bunifuPanel1.Controls.Add(this.btnClose);
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 5);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(305, 37);
            this.bunifuPanel1.TabIndex = 8;
            // 
            // lblNewTask
            // 
            this.lblNewTask.AllowParentOverrides = false;
            this.lblNewTask.AutoEllipsis = false;
            this.lblNewTask.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNewTask.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNewTask.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewTask.ForeColor = System.Drawing.Color.Purple;
            this.lblNewTask.Location = new System.Drawing.Point(22, 7);
            this.lblNewTask.Name = "lblNewTask";
            this.lblNewTask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNewTask.Size = new System.Drawing.Size(76, 15);
            this.lblNewTask.TabIndex = 0;
            this.lblNewTask.Text = "Add New Task";
            this.lblNewTask.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNewTask.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(270, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 27);
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
            this.lblDescription.Location = new System.Drawing.Point(13, 101);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescription.Size = new System.Drawing.Size(61, 15);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDescription.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cmbPriority
            // 
            this.cmbPriority.AutoCompleteCustomSource.AddRange(new string[] {
            "High Priority",
            "Low Priority",
            "Medium",
            "Urgent"});
            this.cmbPriority.BorderColor = System.Drawing.Color.LavenderBlush;
            this.cmbPriority.BorderRadius = 5;
            this.cmbPriority.BorderThickness = 1;
            this.cmbPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "High Priority",
            "Urgent",
            "Medium",
            "Low Priority"});
            this.cmbPriority.Location = new System.Drawing.Point(102, 214);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(188, 21);
            this.cmbPriority.TabIndex = 24;
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "To Do",
            "In Progress",
            "Delayed",
            "Done"});
            this.cmbStatus.BorderColor = System.Drawing.Color.LavenderBlush;
            this.cmbStatus.BorderRadius = 5;
            this.cmbStatus.BorderThickness = 1;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "To Do",
            "In Progress",
            "Done",
            "Delayed"});
            this.cmbStatus.Location = new System.Drawing.Point(102, 187);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(188, 21);
            this.cmbStatus.TabIndex = 23;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 316);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskForm";
            this.Text = "Form2";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuLabel lblDescription;
        private Bunifu.UI.WinForms.BunifuTextBox txtTitle;
        private Bunifu.UI.WinForms.BunifuLabel lblTitle;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel lblNewTask;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCreateTask;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private CustomComboBox cmbStatus;
        private CustomComboBox cmbPriority;
        private System.Windows.Forms.DateTimePicker dueDate;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.RichTextBox txtDescription;
    }
}