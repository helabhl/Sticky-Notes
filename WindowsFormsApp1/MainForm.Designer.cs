namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            // Dispose timers safely
            if (indicatorTimer != null)
            {
                indicatorTimer.Stop();
                indicatorTimer.Dispose();
                indicatorTimer = null; // Prevent double disposal
            }
            if (hoverTimer != null) // Although hoverTimer isn't used anymore, keep disposal for safety if it was added elsewhere
            {
                hoverTimer.Stop();
                hoverTimer.Dispose();
                hoverTimer = null;
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.separatorLogo = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLogoArea = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnDashboard = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCategories = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnNotes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnTasks = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.separatorMenu = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnLogout = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlActiveIndicator = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.indicatorTimer = new System.Windows.Forms.Timer(this.components);
            this.hoverTimer = new System.Windows.Forms.Timer(this.components);
            this.bunifuSeparator5 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanelToday = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCurrentSection = new System.Windows.Forms.Label();
            this.flowLayoutPanelCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelNotes = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.pnlLogoArea.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.separatorLogo);
            this.pnlTopBar.Controls.Add(this.btnMinimize);
            this.pnlTopBar.Controls.Add(this.btnClose);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(194, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(926, 45);
            this.pnlTopBar.TabIndex = 1;
            // 
            // separatorLogo
            // 
            this.separatorLogo.BackColor = System.Drawing.Color.Transparent;
            this.separatorLogo.ForeColor = System.Drawing.Color.LightGray;
            this.separatorLogo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.separatorLogo.LineThickness = 1;
            this.separatorLogo.Location = new System.Drawing.Point(0, 42);
            this.separatorLogo.Margin = new System.Windows.Forms.Padding(15, 0, 15, 10);
            this.separatorLogo.Name = "separatorLogo";
            this.separatorLogo.Size = new System.Drawing.Size(944, 10);
            this.separatorLogo.TabIndex = 8;
            this.separatorLogo.Transparency = 255;
            this.separatorLogo.Vertical = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(863, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 20);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 15;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(894, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 15;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelMenu.Controls.Add(this.pnlLogoArea);
            this.flowLayoutPanelMenu.Controls.Add(this.btnDashboard);
            this.flowLayoutPanelMenu.Controls.Add(this.btnCategories);
            this.flowLayoutPanelMenu.Controls.Add(this.btnNotes);
            this.flowLayoutPanelMenu.Controls.Add(this.btnTasks);
            this.flowLayoutPanelMenu.Controls.Add(this.separatorMenu);
            this.flowLayoutPanelMenu.Controls.Add(this.btnLogout);
            this.flowLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(194, 550);
            this.flowLayoutPanelMenu.TabIndex = 0;
            this.flowLayoutPanelMenu.WrapContents = false;
            // 
            // pnlLogoArea
            // 
            this.pnlLogoArea.Controls.Add(this.lblAppName);
            this.pnlLogoArea.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoArea.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogoArea.Name = "pnlLogoArea";
            this.pnlLogoArea.Size = new System.Drawing.Size(194, 82);
            this.pnlLogoArea.TabIndex = 0;
            // 
            // lblAppName
            // 
            this.lblAppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAppName.Font = new System.Drawing.Font("Freestyle Script", 38F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAppName.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblAppName.Location = new System.Drawing.Point(0, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(194, 82);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Noota";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDashboard
            // 
            this.btnDashboard.AllowAnimations = true;
            this.btnDashboard.AllowMouseEffects = true;
            this.btnDashboard.AllowToggling = false;
            this.btnDashboard.AnimationSpeed = 200;
            this.btnDashboard.AutoGenerateColors = false;
            this.btnDashboard.AutoRoundBorders = false;
            this.btnDashboard.AutoSizeLeftIcon = true;
            this.btnDashboard.AutoSizeRightIcon = true;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackColor1 = System.Drawing.Color.Thistle;
            this.btnDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.BackgroundImage")));
            this.btnDashboard.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.ButtonText = "  Dashboard";
            this.btnDashboard.ButtonTextMarginLeft = 18;
            this.btnDashboard.ColorContrastOnClick = 45;
            this.btnDashboard.ColorContrastOnHover = 45;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDashboard.CustomizableEdges = borderEdges1;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDashboard.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDashboard.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDashboard.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnDashboard.ForeColor = System.Drawing.Color.Purple;
            this.btnDashboard.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDashboard.IconMarginLeft = 11;
            this.btnDashboard.IconPadding = 10;
            this.btnDashboard.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDashboard.IconSize = 25;
            this.btnDashboard.IdleBorderColor = System.Drawing.Color.Thistle;
            this.btnDashboard.IdleBorderRadius = 1;
            this.btnDashboard.IdleBorderThickness = 1;
            this.btnDashboard.IdleFillColor = System.Drawing.Color.Thistle;
            this.btnDashboard.IdleIconLeftImage = null;
            this.btnDashboard.IdleIconRightImage = null;
            this.btnDashboard.IndicateFocus = false;
            this.btnDashboard.Location = new System.Drawing.Point(0, 82);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDashboard.OnDisabledState.BorderRadius = 1;
            this.btnDashboard.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnDisabledState.BorderThickness = 1;
            this.btnDashboard.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDashboard.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDashboard.OnDisabledState.IconLeftImage = null;
            this.btnDashboard.OnDisabledState.IconRightImage = null;
            this.btnDashboard.onHoverState.BorderColor = System.Drawing.Color.Thistle;
            this.btnDashboard.onHoverState.BorderRadius = 1;
            this.btnDashboard.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.onHoverState.BorderThickness = 1;
            this.btnDashboard.onHoverState.FillColor = System.Drawing.Color.Thistle;
            this.btnDashboard.onHoverState.ForeColor = System.Drawing.Color.Purple;
            this.btnDashboard.onHoverState.IconLeftImage = null;
            this.btnDashboard.onHoverState.IconRightImage = null;
            this.btnDashboard.OnIdleState.BorderColor = System.Drawing.Color.Thistle;
            this.btnDashboard.OnIdleState.BorderRadius = 1;
            this.btnDashboard.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnIdleState.BorderThickness = 1;
            this.btnDashboard.OnIdleState.FillColor = System.Drawing.Color.Thistle;
            this.btnDashboard.OnIdleState.ForeColor = System.Drawing.Color.Purple;
            this.btnDashboard.OnIdleState.IconLeftImage = null;
            this.btnDashboard.OnIdleState.IconRightImage = null;
            this.btnDashboard.OnPressedState.BorderColor = System.Drawing.Color.Thistle;
            this.btnDashboard.OnPressedState.BorderRadius = 1;
            this.btnDashboard.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnPressedState.BorderThickness = 1;
            this.btnDashboard.OnPressedState.FillColor = System.Drawing.Color.Thistle;
            this.btnDashboard.OnPressedState.ForeColor = System.Drawing.Color.Purple;
            this.btnDashboard.OnPressedState.IconLeftImage = null;
            this.btnDashboard.OnPressedState.IconRightImage = null;
            this.btnDashboard.Size = new System.Drawing.Size(194, 50);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.TextMarginLeft = 18;
            this.btnDashboard.TextPadding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnDashboard.UseDefaultRadiusAndThickness = true;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.AllowAnimations = true;
            this.btnCategories.AllowMouseEffects = true;
            this.btnCategories.AllowToggling = false;
            this.btnCategories.AnimationSpeed = 200;
            this.btnCategories.AutoGenerateColors = false;
            this.btnCategories.AutoRoundBorders = false;
            this.btnCategories.AutoSizeLeftIcon = true;
            this.btnCategories.AutoSizeRightIcon = true;
            this.btnCategories.BackColor = System.Drawing.Color.Transparent;
            this.btnCategories.BackColor1 = System.Drawing.Color.White;
            this.btnCategories.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCategories.BackgroundImage")));
            this.btnCategories.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCategories.ButtonText = "  Categories";
            this.btnCategories.ButtonTextMarginLeft = 18;
            this.btnCategories.ColorContrastOnClick = 45;
            this.btnCategories.ColorContrastOnHover = 45;
            this.btnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnCategories.CustomizableEdges = borderEdges2;
            this.btnCategories.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCategories.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCategories.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCategories.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCategories.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnCategories.ForeColor = System.Drawing.Color.DimGray;
            this.btnCategories.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategories.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCategories.IconMarginLeft = 11;
            this.btnCategories.IconPadding = 10;
            this.btnCategories.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategories.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategories.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCategories.IconSize = 25;
            this.btnCategories.IdleBorderColor = System.Drawing.Color.White;
            this.btnCategories.IdleBorderRadius = 1;
            this.btnCategories.IdleBorderThickness = 1;
            this.btnCategories.IdleFillColor = System.Drawing.Color.White;
            this.btnCategories.IdleIconLeftImage = null;
            this.btnCategories.IdleIconRightImage = null;
            this.btnCategories.IndicateFocus = false;
            this.btnCategories.Location = new System.Drawing.Point(0, 135);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCategories.OnDisabledState.BorderRadius = 1;
            this.btnCategories.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCategories.OnDisabledState.BorderThickness = 1;
            this.btnCategories.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCategories.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCategories.OnDisabledState.IconLeftImage = null;
            this.btnCategories.OnDisabledState.IconRightImage = null;
            this.btnCategories.onHoverState.BorderColor = System.Drawing.Color.Thistle;
            this.btnCategories.onHoverState.BorderRadius = 1;
            this.btnCategories.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCategories.onHoverState.BorderThickness = 1;
            this.btnCategories.onHoverState.FillColor = System.Drawing.Color.Thistle;
            this.btnCategories.onHoverState.ForeColor = System.Drawing.Color.Purple;
            this.btnCategories.onHoverState.IconLeftImage = null;
            this.btnCategories.onHoverState.IconRightImage = null;
            this.btnCategories.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnCategories.OnIdleState.BorderRadius = 1;
            this.btnCategories.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCategories.OnIdleState.BorderThickness = 1;
            this.btnCategories.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnCategories.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.btnCategories.OnIdleState.IconLeftImage = null;
            this.btnCategories.OnIdleState.IconRightImage = null;
            this.btnCategories.OnPressedState.BorderColor = System.Drawing.Color.Thistle;
            this.btnCategories.OnPressedState.BorderRadius = 1;
            this.btnCategories.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCategories.OnPressedState.BorderThickness = 1;
            this.btnCategories.OnPressedState.FillColor = System.Drawing.Color.Thistle;
            this.btnCategories.OnPressedState.ForeColor = System.Drawing.Color.Purple;
            this.btnCategories.OnPressedState.IconLeftImage = null;
            this.btnCategories.OnPressedState.IconRightImage = null;
            this.btnCategories.Size = new System.Drawing.Size(194, 50);
            this.btnCategories.TabIndex = 10;
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCategories.TextMarginLeft = 18;
            this.btnCategories.TextPadding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnCategories.UseDefaultRadiusAndThickness = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnNotes
            // 
            this.btnNotes.AllowAnimations = true;
            this.btnNotes.AllowMouseEffects = true;
            this.btnNotes.AllowToggling = false;
            this.btnNotes.AnimationSpeed = 200;
            this.btnNotes.AutoGenerateColors = false;
            this.btnNotes.AutoRoundBorders = false;
            this.btnNotes.AutoSizeLeftIcon = true;
            this.btnNotes.AutoSizeRightIcon = true;
            this.btnNotes.BackColor = System.Drawing.Color.Transparent;
            this.btnNotes.BackColor1 = System.Drawing.Color.White;
            this.btnNotes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNotes.BackgroundImage")));
            this.btnNotes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotes.ButtonText = "  Notes";
            this.btnNotes.ButtonTextMarginLeft = 18;
            this.btnNotes.ColorContrastOnClick = 45;
            this.btnNotes.ColorContrastOnHover = 45;
            this.btnNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnNotes.CustomizableEdges = borderEdges3;
            this.btnNotes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNotes.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNotes.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNotes.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNotes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNotes.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnNotes.ForeColor = System.Drawing.Color.DimGray;
            this.btnNotes.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotes.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotes.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNotes.IconMarginLeft = 11;
            this.btnNotes.IconPadding = 10;
            this.btnNotes.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotes.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotes.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNotes.IconSize = 25;
            this.btnNotes.IdleBorderColor = System.Drawing.Color.White;
            this.btnNotes.IdleBorderRadius = 1;
            this.btnNotes.IdleBorderThickness = 1;
            this.btnNotes.IdleFillColor = System.Drawing.Color.White;
            this.btnNotes.IdleIconLeftImage = null;
            this.btnNotes.IdleIconRightImage = null;
            this.btnNotes.IndicateFocus = false;
            this.btnNotes.Location = new System.Drawing.Point(0, 188);
            this.btnNotes.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNotes.OnDisabledState.BorderRadius = 1;
            this.btnNotes.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotes.OnDisabledState.BorderThickness = 1;
            this.btnNotes.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNotes.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNotes.OnDisabledState.IconLeftImage = null;
            this.btnNotes.OnDisabledState.IconRightImage = null;
            this.btnNotes.onHoverState.BorderColor = System.Drawing.Color.Thistle;
            this.btnNotes.onHoverState.BorderRadius = 1;
            this.btnNotes.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotes.onHoverState.BorderThickness = 1;
            this.btnNotes.onHoverState.FillColor = System.Drawing.Color.Thistle;
            this.btnNotes.onHoverState.ForeColor = System.Drawing.Color.Purple;
            this.btnNotes.onHoverState.IconLeftImage = null;
            this.btnNotes.onHoverState.IconRightImage = null;
            this.btnNotes.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnNotes.OnIdleState.BorderRadius = 1;
            this.btnNotes.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotes.OnIdleState.BorderThickness = 1;
            this.btnNotes.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnNotes.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.btnNotes.OnIdleState.IconLeftImage = null;
            this.btnNotes.OnIdleState.IconRightImage = null;
            this.btnNotes.OnPressedState.BorderColor = System.Drawing.Color.Thistle;
            this.btnNotes.OnPressedState.BorderRadius = 1;
            this.btnNotes.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNotes.OnPressedState.BorderThickness = 1;
            this.btnNotes.OnPressedState.FillColor = System.Drawing.Color.Thistle;
            this.btnNotes.OnPressedState.ForeColor = System.Drawing.Color.Purple;
            this.btnNotes.OnPressedState.IconLeftImage = null;
            this.btnNotes.OnPressedState.IconRightImage = null;
            this.btnNotes.Size = new System.Drawing.Size(194, 50);
            this.btnNotes.TabIndex = 2;
            this.btnNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotes.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNotes.TextMarginLeft = 18;
            this.btnNotes.TextPadding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnNotes.UseDefaultRadiusAndThickness = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.AllowAnimations = true;
            this.btnTasks.AllowMouseEffects = true;
            this.btnTasks.AllowToggling = false;
            this.btnTasks.AnimationSpeed = 200;
            this.btnTasks.AutoGenerateColors = false;
            this.btnTasks.AutoRoundBorders = false;
            this.btnTasks.AutoSizeLeftIcon = true;
            this.btnTasks.AutoSizeRightIcon = true;
            this.btnTasks.BackColor = System.Drawing.Color.Transparent;
            this.btnTasks.BackColor1 = System.Drawing.Color.White;
            this.btnTasks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTasks.BackgroundImage")));
            this.btnTasks.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTasks.ButtonText = "  Tasks";
            this.btnTasks.ButtonTextMarginLeft = 18;
            this.btnTasks.ColorContrastOnClick = 45;
            this.btnTasks.ColorContrastOnHover = 45;
            this.btnTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnTasks.CustomizableEdges = borderEdges4;
            this.btnTasks.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTasks.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTasks.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTasks.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTasks.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTasks.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnTasks.ForeColor = System.Drawing.Color.DimGray;
            this.btnTasks.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnTasks.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTasks.IconMarginLeft = 11;
            this.btnTasks.IconPadding = 10;
            this.btnTasks.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTasks.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnTasks.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTasks.IconSize = 25;
            this.btnTasks.IdleBorderColor = System.Drawing.Color.White;
            this.btnTasks.IdleBorderRadius = 1;
            this.btnTasks.IdleBorderThickness = 1;
            this.btnTasks.IdleFillColor = System.Drawing.Color.White;
            this.btnTasks.IdleIconLeftImage = null;
            this.btnTasks.IdleIconRightImage = null;
            this.btnTasks.IndicateFocus = false;
            this.btnTasks.Location = new System.Drawing.Point(0, 241);
            this.btnTasks.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTasks.OnDisabledState.BorderRadius = 1;
            this.btnTasks.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTasks.OnDisabledState.BorderThickness = 1;
            this.btnTasks.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTasks.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTasks.OnDisabledState.IconLeftImage = null;
            this.btnTasks.OnDisabledState.IconRightImage = null;
            this.btnTasks.onHoverState.BorderColor = System.Drawing.Color.Thistle;
            this.btnTasks.onHoverState.BorderRadius = 1;
            this.btnTasks.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTasks.onHoverState.BorderThickness = 1;
            this.btnTasks.onHoverState.FillColor = System.Drawing.Color.Thistle;
            this.btnTasks.onHoverState.ForeColor = System.Drawing.Color.Purple;
            this.btnTasks.onHoverState.IconLeftImage = null;
            this.btnTasks.onHoverState.IconRightImage = null;
            this.btnTasks.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnTasks.OnIdleState.BorderRadius = 1;
            this.btnTasks.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTasks.OnIdleState.BorderThickness = 1;
            this.btnTasks.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnTasks.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.btnTasks.OnIdleState.IconLeftImage = null;
            this.btnTasks.OnIdleState.IconRightImage = null;
            this.btnTasks.OnPressedState.BorderColor = System.Drawing.Color.Thistle;
            this.btnTasks.OnPressedState.BorderRadius = 1;
            this.btnTasks.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTasks.OnPressedState.BorderThickness = 1;
            this.btnTasks.OnPressedState.FillColor = System.Drawing.Color.Thistle;
            this.btnTasks.OnPressedState.ForeColor = System.Drawing.Color.Purple;
            this.btnTasks.OnPressedState.IconLeftImage = null;
            this.btnTasks.OnPressedState.IconRightImage = null;
            this.btnTasks.Size = new System.Drawing.Size(194, 50);
            this.btnTasks.TabIndex = 9;
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTasks.TextMarginLeft = 18;
            this.btnTasks.TextPadding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnTasks.UseDefaultRadiusAndThickness = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // separatorMenu
            // 
            this.separatorMenu.BackColor = System.Drawing.Color.Transparent;
            this.separatorMenu.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.separatorMenu.LineThickness = 1;
            this.separatorMenu.Location = new System.Drawing.Point(15, 294);
            this.separatorMenu.Margin = new System.Windows.Forms.Padding(15, 0, 15, 10);
            this.separatorMenu.Name = "separatorMenu";
            this.separatorMenu.Size = new System.Drawing.Size(220, 5);
            this.separatorMenu.TabIndex = 5;
            this.separatorMenu.Transparency = 255;
            this.separatorMenu.Vertical = false;
            // 
            // btnLogout
            // 
            this.btnLogout.AllowAnimations = true;
            this.btnLogout.AllowMouseEffects = true;
            this.btnLogout.AllowToggling = false;
            this.btnLogout.AnimationSpeed = 200;
            this.btnLogout.AutoGenerateColors = false;
            this.btnLogout.AutoRoundBorders = false;
            this.btnLogout.AutoSizeLeftIcon = true;
            this.btnLogout.AutoSizeRightIcon = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackColor1 = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.ButtonText = "  Déconnexion";
            this.btnLogout.ButtonTextMarginLeft = 18;
            this.btnLogout.ColorContrastOnClick = 45;
            this.btnLogout.ColorContrastOnHover = 45;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnLogout.CustomizableEdges = borderEdges5;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogout.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogout.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogout.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnLogout.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogout.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogout.IconMarginLeft = 11;
            this.btnLogout.IconPadding = 10;
            this.btnLogout.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogout.IconSize = 25;
            this.btnLogout.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.IdleBorderRadius = 1;
            this.btnLogout.IdleBorderThickness = 1;
            this.btnLogout.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnLogout.IdleIconLeftImage = null;
            this.btnLogout.IdleIconRightImage = null;
            this.btnLogout.IndicateFocus = false;
            this.btnLogout.Location = new System.Drawing.Point(0, 309);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogout.OnDisabledState.BorderRadius = 1;
            this.btnLogout.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnDisabledState.BorderThickness = 1;
            this.btnLogout.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogout.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogout.OnDisabledState.IconLeftImage = null;
            this.btnLogout.OnDisabledState.IconRightImage = null;
            this.btnLogout.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.onHoverState.BorderRadius = 1;
            this.btnLogout.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.onHoverState.BorderThickness = 1;
            this.btnLogout.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.onHoverState.IconLeftImage = null;
            this.btnLogout.onHoverState.IconRightImage = null;
            this.btnLogout.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnIdleState.BorderRadius = 1;
            this.btnLogout.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnIdleState.BorderThickness = 1;
            this.btnLogout.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogout.OnIdleState.IconLeftImage = null;
            this.btnLogout.OnIdleState.IconRightImage = null;
            this.btnLogout.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.OnPressedState.BorderRadius = 1;
            this.btnLogout.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogout.OnPressedState.BorderThickness = 1;
            this.btnLogout.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.OnPressedState.IconLeftImage = null;
            this.btnLogout.OnPressedState.IconRightImage = null;
            this.btnLogout.Size = new System.Drawing.Size(194, 50);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.TextMarginLeft = 18;
            this.btnLogout.TextPadding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnLogout.UseDefaultRadiusAndThickness = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // pnlActiveIndicator
            // 
            this.pnlActiveIndicator.BackColor = System.Drawing.Color.Purple;
            this.pnlActiveIndicator.Location = new System.Drawing.Point(0, 95);
            this.pnlActiveIndicator.Name = "pnlActiveIndicator";
            this.pnlActiveIndicator.Size = new System.Drawing.Size(5, 50);
            this.pnlActiveIndicator.TabIndex = 3;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlTopBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // indicatorTimer
            // 
            this.indicatorTimer.Interval = 10;
            this.indicatorTimer.Tick += new System.EventHandler(this.IndicatorTimer_Tick);
            // 
            // hoverTimer
            // 
            this.hoverTimer.Interval = 10;
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator5.BackgroundImage")));
            this.bunifuSeparator5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator5.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator5.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new System.Drawing.Point(691, 66);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator5.Size = new System.Drawing.Size(184, 10);
            this.bunifuSeparator5.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(687, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tasks For Today";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanelToday
            // 
            this.flowLayoutPanelToday.AutoScroll = true;
            this.flowLayoutPanelToday.Location = new System.Drawing.Point(691, 82);
            this.flowLayoutPanelToday.Name = "flowLayoutPanelToday";
            this.flowLayoutPanelToday.Size = new System.Drawing.Size(197, 364);
            this.flowLayoutPanelToday.TabIndex = 0;
            // 
            // lblCurrentSection
            // 
            this.lblCurrentSection.AutoSize = true;
            this.lblCurrentSection.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblCurrentSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblCurrentSection.Location = new System.Drawing.Point(3, 3);
            this.lblCurrentSection.Name = "lblCurrentSection";
            this.lblCurrentSection.Size = new System.Drawing.Size(148, 25);
            this.lblCurrentSection.TabIndex = 7;
            this.lblCurrentSection.Text = "Tableau de Bord";
            // 
            // flowLayoutPanelCategories
            // 
            this.flowLayoutPanelCategories.Location = new System.Drawing.Point(22, 82);
            this.flowLayoutPanelCategories.Name = "flowLayoutPanelCategories";
            this.flowLayoutPanelCategories.Size = new System.Drawing.Size(629, 129);
            this.flowLayoutPanelCategories.TabIndex = 8;
            // 
            // flowLayoutPanelNotes
            // 
            this.flowLayoutPanelNotes.Location = new System.Drawing.Point(22, 261);
            this.flowLayoutPanelNotes.Name = "flowLayoutPanelNotes";
            this.flowLayoutPanelNotes.Size = new System.Drawing.Size(627, 185);
            this.flowLayoutPanelNotes.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "My Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "My Recent Notes";
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.White;
            this.pnlMainContent.Controls.Add(this.flowLayoutPanelToday);
            this.pnlMainContent.Controls.Add(this.bunifuSeparator5);
            this.pnlMainContent.Controls.Add(this.label2);
            this.pnlMainContent.Controls.Add(this.label5);
            this.pnlMainContent.Controls.Add(this.label1);
            this.pnlMainContent.Controls.Add(this.flowLayoutPanelNotes);
            this.pnlMainContent.Controls.Add(this.flowLayoutPanelCategories);
            this.pnlMainContent.Controls.Add(this.lblCurrentSection);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(194, 45);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMainContent.Size = new System.Drawing.Size(926, 505);
            this.pnlMainContent.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 550);
            this.Controls.Add(this.pnlActiveIndicator);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire Notes/Tâches";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.pnlLogoArea.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlTopBar;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Panel pnlLogoArea;
        private System.Windows.Forms.Label lblAppName;
        private Bunifu.Framework.UI.BunifuSeparator separatorLogo;
        private System.Windows.Forms.Panel pnlActiveIndicator;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Timer indicatorTimer;
        private System.Windows.Forms.Timer hoverTimer; // Keep if needed, unused by buttons
        private Bunifu.Framework.UI.BunifuSeparator separatorMenu;
        // --- Use the FULL class name for button fields ---
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDashboard;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNotes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogout;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTasks;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCategories;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNotes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCategories;
        private System.Windows.Forms.Label lblCurrentSection;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelToday;
    }
}