using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class AllCategoriesForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelContainer;
        private Label lblMyNotesTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllCategoriesForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lblMyNotesTitle = new System.Windows.Forms.Label();
            this.flowLayoutNotes = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCategory = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.lblMyNotesTitle);
            this.panelContainer.Controls.Add(this.flowLayoutNotes);
            this.panelContainer.Controls.Add(this.flowLayoutPanelCategories);
            this.panelContainer.Location = new System.Drawing.Point(0, 51);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(920, 470);
            this.panelContainer.TabIndex = 0;
            // 
            // lblMyNotesTitle
            // 
            this.lblMyNotesTitle.AutoSize = true;
            this.lblMyNotesTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMyNotesTitle.ForeColor = System.Drawing.Color.Black;
            this.lblMyNotesTitle.Location = new System.Drawing.Point(10, 213);
            this.lblMyNotesTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMyNotesTitle.Name = "lblMyNotesTitle";
            this.lblMyNotesTitle.Size = new System.Drawing.Size(97, 25);
            this.lblMyNotesTitle.TabIndex = 2;
            this.lblMyNotesTitle.Text = "My Notes";
            // 
            // flowLayoutNotes
            // 
            this.flowLayoutNotes.AutoScroll = true;
            this.flowLayoutNotes.BackColor = System.Drawing.Color.White;
            this.flowLayoutNotes.Location = new System.Drawing.Point(0, 242);
            this.flowLayoutNotes.Margin = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.flowLayoutNotes.Name = "flowLayoutNotes";
            this.flowLayoutNotes.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutNotes.Size = new System.Drawing.Size(920, 222);
            this.flowLayoutNotes.TabIndex = 1;
            // 
            // flowLayoutPanelCategories
            // 
            this.flowLayoutPanelCategories.AutoScroll = true;
            this.flowLayoutPanelCategories.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelCategories.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelCategories.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.flowLayoutPanelCategories.Name = "flowLayoutPanelCategories";
            this.flowLayoutPanelCategories.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelCategories.Size = new System.Drawing.Size(920, 192);
            this.flowLayoutPanelCategories.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(10, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(139, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "My Categories";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAddCategory);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 53);
            this.panel1.TabIndex = 1;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.AllowAnimations = true;
            this.btnAddCategory.AllowMouseEffects = true;
            this.btnAddCategory.AllowToggling = false;
            this.btnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddCategory.AnimationSpeed = 200;
            this.btnAddCategory.AutoGenerateColors = false;
            this.btnAddCategory.AutoRoundBorders = false;
            this.btnAddCategory.AutoSizeLeftIcon = true;
            this.btnAddCategory.AutoSizeRightIcon = true;
            this.btnAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.BackColor1 = System.Drawing.Color.RosyBrown;
            this.btnAddCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.BackgroundImage")));
            this.btnAddCategory.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCategory.ButtonText = "Add Category";
            this.btnAddCategory.ButtonTextMarginLeft = 0;
            this.btnAddCategory.ColorContrastOnClick = 45;
            this.btnAddCategory.ColorContrastOnHover = 45;
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddCategory.CustomizableEdges = borderEdges1;
            this.btnAddCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddCategory.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddCategory.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddCategory.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddCategory.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddCategory.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddCategory.IconMarginLeft = 11;
            this.btnAddCategory.IconPadding = 10;
            this.btnAddCategory.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCategory.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddCategory.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddCategory.IconSize = 25;
            this.btnAddCategory.IdleBorderColor = System.Drawing.Color.RosyBrown;
            this.btnAddCategory.IdleBorderRadius = 40;
            this.btnAddCategory.IdleBorderThickness = 1;
            this.btnAddCategory.IdleFillColor = System.Drawing.Color.RosyBrown;
            this.btnAddCategory.IdleIconLeftImage = null;
            this.btnAddCategory.IdleIconRightImage = null;
            this.btnAddCategory.IndicateFocus = false;
            this.btnAddCategory.Location = new System.Drawing.Point(667, 8);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddCategory.OnDisabledState.BorderRadius = 40;
            this.btnAddCategory.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCategory.OnDisabledState.BorderThickness = 1;
            this.btnAddCategory.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddCategory.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddCategory.OnDisabledState.IconLeftImage = null;
            this.btnAddCategory.OnDisabledState.IconRightImage = null;
            this.btnAddCategory.onHoverState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnAddCategory.onHoverState.BorderRadius = 40;
            this.btnAddCategory.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCategory.onHoverState.BorderThickness = 1;
            this.btnAddCategory.onHoverState.FillColor = System.Drawing.Color.RosyBrown;
            this.btnAddCategory.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.onHoverState.IconLeftImage = null;
            this.btnAddCategory.onHoverState.IconRightImage = null;
            this.btnAddCategory.OnIdleState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnAddCategory.OnIdleState.BorderRadius = 40;
            this.btnAddCategory.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCategory.OnIdleState.BorderThickness = 1;
            this.btnAddCategory.OnIdleState.FillColor = System.Drawing.Color.RosyBrown;
            this.btnAddCategory.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.OnIdleState.IconLeftImage = null;
            this.btnAddCategory.OnIdleState.IconRightImage = null;
            this.btnAddCategory.OnPressedState.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnAddCategory.OnPressedState.BorderRadius = 40;
            this.btnAddCategory.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddCategory.OnPressedState.BorderThickness = 1;
            this.btnAddCategory.OnPressedState.FillColor = System.Drawing.Color.RosyBrown;
            this.btnAddCategory.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.OnPressedState.IconLeftImage = null;
            this.btnAddCategory.OnPressedState.IconRightImage = null;
            this.btnAddCategory.Size = new System.Drawing.Size(100, 34);
            this.btnAddCategory.TabIndex = 5;
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCategory.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddCategory.TextMarginLeft = 0;
            this.btnAddCategory.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddCategory.UseDefaultRadiusAndThickness = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click_1);
            // 
            // AllCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AllCategoriesForm";
            this.Text = "Gestion des Catégories";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private FlowLayoutPanel flowLayoutNotes;
        private FlowLayoutPanel flowLayoutPanelCategories;
        private Label lblTitle;
        private Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddCategory;
    }
}
