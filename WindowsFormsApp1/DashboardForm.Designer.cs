namespace WindowsFormsApp1
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelToDo = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.flowLayoutPanelToDo = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuSeparator5 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrentSection = new System.Windows.Forms.Label();
            this.flowLayoutPanelCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelNotes = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelToDo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanelNotes);
            this.panel1.Controls.Add(this.flowLayoutPanelCategories);
            this.panel1.Controls.Add(this.lblCurrentSection);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 520);
            this.panel1.TabIndex = 0;
            // 
            // panelToDo
            // 
            this.panelToDo.BackColor = System.Drawing.Color.Transparent;
            this.panelToDo.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.panelToDo.BorderRadius = 5;
            this.panelToDo.BorderThickness = 1;
            this.panelToDo.Controls.Add(this.bunifuSeparator5);
            this.panelToDo.Controls.Add(this.label5);
            this.panelToDo.Controls.Add(this.flowLayoutPanelToDo);
            this.panelToDo.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.panelToDo.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.panelToDo.Location = new System.Drawing.Point(3, 3);
            this.panelToDo.Name = "panelToDo";
            this.panelToDo.PanelColor = System.Drawing.Color.White;
            this.panelToDo.PanelColor2 = System.Drawing.Color.White;
            this.panelToDo.ShadowColor = System.Drawing.Color.DarkGray;
            this.panelToDo.ShadowDept = 2;
            this.panelToDo.ShadowDepth = 5;
            this.panelToDo.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.panelToDo.ShadowTopLeftVisible = false;
            this.panelToDo.Size = new System.Drawing.Size(219, 431);
            this.panelToDo.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.panelToDo.TabIndex = 13;
            // 
            // flowLayoutPanelToDo
            // 
            this.flowLayoutPanelToDo.AutoScroll = true;
            this.flowLayoutPanelToDo.Location = new System.Drawing.Point(17, 57);
            this.flowLayoutPanelToDo.Name = "flowLayoutPanelToDo";
            this.flowLayoutPanelToDo.Size = new System.Drawing.Size(186, 356);
            this.flowLayoutPanelToDo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(23, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "    Tasks For Today";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.bunifuSeparator5.Location = new System.Drawing.Point(17, 41);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator5.Size = new System.Drawing.Size(184, 10);
            this.bunifuSeparator5.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panelToDo, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(676, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 587);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCurrentSection
            // 
            this.lblCurrentSection.AutoSize = true;
            this.lblCurrentSection.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblCurrentSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblCurrentSection.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentSection.Name = "lblCurrentSection";
            this.lblCurrentSection.Size = new System.Drawing.Size(148, 25);
            this.lblCurrentSection.TabIndex = 1;
            this.lblCurrentSection.Text = "Tableau de Bord";
            // 
            // flowLayoutPanelCategories
            // 
            this.flowLayoutPanelCategories.Location = new System.Drawing.Point(31, 88);
            this.flowLayoutPanelCategories.Name = "flowLayoutPanelCategories";
            this.flowLayoutPanelCategories.Size = new System.Drawing.Size(629, 129);
            this.flowLayoutPanelCategories.TabIndex = 2;
            // 
            // flowLayoutPanelNotes
            // 
            this.flowLayoutPanelNotes.Location = new System.Drawing.Point(31, 267);
            this.flowLayoutPanelNotes.Name = "flowLayoutPanelNotes";
            this.flowLayoutPanelNotes.Size = new System.Drawing.Size(627, 185);
            this.flowLayoutPanelNotes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(33, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "My Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "My Recent Notes";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 520);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelToDo.ResumeLayout(false);
            this.panelToDo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNotes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCategories;
        private System.Windows.Forms.Label lblCurrentSection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuShadowPanel panelToDo;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelToDo;
    }
}