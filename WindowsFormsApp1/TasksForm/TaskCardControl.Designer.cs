using System.Drawing;

namespace WindowsFormsApp1
{
    partial class TaskCardControl
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
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.rtbCardDescription = new System.Windows.Forms.RichTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.contextMenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOptions = new System.Windows.Forms.Button();
            this.pnlActiveIndicator = new System.Windows.Forms.Panel();
            this.contextMenuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.AutoEllipsis = true;
            this.lblCardTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCardTitle.Location = new System.Drawing.Point(2, 6);
            this.lblCardTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Padding = new System.Windows.Forms.Padding(7, 0, 23, 0);
            this.lblCardTitle.Size = new System.Drawing.Size(145, 20);
            this.lblCardTitle.TabIndex = 0;
            this.lblCardTitle.Text = "task Title";
            this.lblCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtbCardDescription
            // 
            this.rtbCardDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.rtbCardDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCardDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtbCardDescription.Location = new System.Drawing.Point(13, 28);
            this.rtbCardDescription.Margin = new System.Windows.Forms.Padding(2);
            this.rtbCardDescription.Name = "rtbCardDescription";
            this.rtbCardDescription.ReadOnly = true;
            this.rtbCardDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbCardDescription.Size = new System.Drawing.Size(148, 35);
            this.rtbCardDescription.TabIndex = 1;
            this.rtbCardDescription.Text = "";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDate.Location = new System.Drawing.Point(92, 65);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "dd/MM/yyyy";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
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
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
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
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.cancelToolStripMenuItem.Text = "Annuler";
            this.cancelToolStripMenuItem.Visible = false;
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
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
            this.btnOptions.ForeColor = System.Drawing.Color.Black;
            this.btnOptions.Location = new System.Drawing.Point(140, 0);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(0);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(30, 26);
            this.btnOptions.TabIndex = 2;
            this.btnOptions.Text = "⋮";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // pnlActiveIndicator
            // 
            this.pnlActiveIndicator.BackColor = System.Drawing.Color.Purple;
            this.pnlActiveIndicator.Location = new System.Drawing.Point(0, 0);
            this.pnlActiveIndicator.Name = "pnlActiveIndicator";
            this.pnlActiveIndicator.Size = new System.Drawing.Size(5, 82);
            this.pnlActiveIndicator.TabIndex = 4;
            // 
            // TaskCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pnlActiveIndicator);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lblCardTitle);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.rtbCardDescription);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "TaskCardControl";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Size = new System.Drawing.Size(170, 82);
            this.contextMenuOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.RichTextBox rtbCardDescription;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuOptions;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Panel pnlActiveIndicator;
    }
}