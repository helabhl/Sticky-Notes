using System.Drawing;

namespace WindowsFormsApp1
{
    partial class NoteCardControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteCardControl));
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.rtbCardDescription = new System.Windows.Forms.RichTextBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.contextMenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.contextMenuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.AutoEllipsis = true;
            this.lblCardTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCardTitle.Location = new System.Drawing.Point(0, 0);
            this.lblCardTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Padding = new System.Windows.Forms.Padding(7, 0, 23, 0);
            this.lblCardTitle.Size = new System.Drawing.Size(169, 26);
            this.lblCardTitle.TabIndex = 0;
            this.lblCardTitle.Text = "Titre de la Note";
            this.lblCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtbCardDescription
            // 
            this.rtbCardDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCardDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtbCardDescription.Location = new System.Drawing.Point(7, 49);
            this.rtbCardDescription.Margin = new System.Windows.Forms.Padding(2);
            this.rtbCardDescription.Name = "rtbCardDescription";
            this.rtbCardDescription.ReadOnly = true;
            this.rtbCardDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbCardDescription.Size = new System.Drawing.Size(170, 90);
            this.rtbCardDescription.TabIndex = 1;
            this.rtbCardDescription.Text = "";
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.btnOptions.Location = new System.Drawing.Point(150, -6);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(0);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(20, 26);
            this.btnOptions.TabIndex = 2;
            this.btnOptions.Text = "⋮";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.btnOptions);
            this.panelHeader.Controls.Add(this.lblCardTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(7, 6);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(169, 26);
            this.panelHeader.TabIndex = 3;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.lblDate);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(7, 143);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(169, 20);
            this.panelFooter.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDate.Location = new System.Drawing.Point(2, 3);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(109, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "dd/MM/yyyy HH:mm";
            // 
            // contextMenuOptions
            // 
            this.contextMenuOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.contextMenuOptions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuOptions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenuOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.pinToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.contextMenuOptions.Name = "contextMenuOptions";
            this.contextMenuOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuOptions.ShowImageMargin = false;
            this.contextMenuOptions.Size = new System.Drawing.Size(105, 92);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.editToolStripMenuItem.Text = "Éditer";
            // 
            // pinToolStripMenuItem
            // 
            this.pinToolStripMenuItem.Name = "pinToolStripMenuItem";
            this.pinToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.pinToolStripMenuItem.Text = "Épingler";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.deleteToolStripMenuItem.Text = "Supprimer";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.cancelToolStripMenuItem.Text = "Annuler";
            this.cancelToolStripMenuItem.Visible = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(11, 29);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(163, 20);
            this.bunifuSeparator1.TabIndex = 5;
            // 
            // NoteCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(179)))));
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.rtbCardDescription);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "NoteCardControl";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Size = new System.Drawing.Size(183, 169);
            this.panelHeader.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.contextMenuOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.RichTextBox rtbCardDescription;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuOptions;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
    }
}