namespace CPKiosk
{
    partial class TaskBar
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
            this.StartButton = new System.Windows.Forms.Button();
            this.Border1 = new System.Windows.Forms.PictureBox();
            this.Border2 = new System.Windows.Forms.PictureBox();
            this.StartMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.shutDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.internetExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firefoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Border1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border2)).BeginInit();
            this.StartMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StartButton.Location = new System.Drawing.Point(2, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.StartButton.Size = new System.Drawing.Size(54, 22);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            this.StartButton.Paint += new System.Windows.Forms.PaintEventHandler(this.StartButton_Paint);
            // 
            // Border1
            // 
            this.Border1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Border1.Location = new System.Drawing.Point(0, 1);
            this.Border1.Name = "Border1";
            this.Border1.Size = new System.Drawing.Size(700, 1);
            this.Border1.TabIndex = 3;
            this.Border1.TabStop = false;
            // 
            // Border2
            // 
            this.Border2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Border2.Location = new System.Drawing.Point(0, 2);
            this.Border2.Name = "Border2";
            this.Border2.Size = new System.Drawing.Size(700, 1);
            this.Border2.TabIndex = 4;
            this.Border2.TabStop = false;
            // 
            // StartMenu
            // 
            this.StartMenu.DropShadowEnabled = false;
            this.StartMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firefoxToolStripMenuItem,
            this.internetExplorerToolStripMenuItem,
            this.testToolStripMenuItem,
            this.testToolStripMenuItem1,
            this.shutDownToolStripMenuItem});
            this.StartMenu.Name = "StartMenu";
            this.StartMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.StartMenu.ShowCheckMargin = true;
            this.StartMenu.Size = new System.Drawing.Size(203, 120);
            this.StartMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.StartMenu_Paint);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Image = global::CPKiosk.Properties.Resources.flag;
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testToolStripMenuItem.Text = "Google Chrome";
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // shutDownToolStripMenuItem
            // 
            this.shutDownToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.shutdownToolStripMenuItem1});
            this.shutDownToolStripMenuItem.Name = "shutDownToolStripMenuItem";
            this.shutDownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shutDownToolStripMenuItem.Text = "Shut Down";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartToolStripMenuItem.Text = "Restart...";
            // 
            // shutdownToolStripMenuItem1
            // 
            this.shutdownToolStripMenuItem1.Name = "shutdownToolStripMenuItem1";
            this.shutdownToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.shutdownToolStripMenuItem1.Text = "Shutdown...";
            // 
            // internetExplorerToolStripMenuItem
            // 
            this.internetExplorerToolStripMenuItem.Name = "internetExplorerToolStripMenuItem";
            this.internetExplorerToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.internetExplorerToolStripMenuItem.Text = "Internet Explorer";
            // 
            // firefoxToolStripMenuItem
            // 
            this.firefoxToolStripMenuItem.Name = "firefoxToolStripMenuItem";
            this.firefoxToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.firefoxToolStripMenuItem.Text = "Firefox";
            // 
            // TaskBar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(700, 28);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Border1);
            this.Controls.Add(this.Border2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskBar";
            this.Text = "CPK TaskBar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TaskBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Border1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border2)).EndInit();
            this.StartMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox Border1;
        private System.Windows.Forms.PictureBox Border2;
        private System.Windows.Forms.ContextMenuStrip StartMenu;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shutDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem firefoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internetExplorerToolStripMenuItem;
    }
}

