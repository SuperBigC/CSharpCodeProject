namespace WinFormVisualSolution
{
    partial class mainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            formSplitContainer = new SplitContainer();
            menuStrip1 = new MenuStrip();
            tsmiFileMenuBar = new ToolStripMenuItem();
            tsmiFileNewMenuBar = new ToolStripMenuItem();
            tsmiFileOpenMenuBar = new ToolStripMenuItem();
            tsmiFileRecentMenuBar = new ToolStripMenuItem();
            tsmiFileSaveMenuBar = new ToolStripMenuItem();
            tsmiSaveAsMenuBar = new ToolStripMenuItem();
            tsmiFileSaveAllMenuBar = new ToolStripMenuItem();
            tsmiFileExitMenuBar = new ToolStripMenuItem();
            tsmiGraphicMenuBar = new ToolStripMenuItem();
            tsmiToolMenuBar = new ToolStripMenuItem();
            tsmiWindowMenuBar = new ToolStripMenuItem();
            tsmiHelpMenuBar = new ToolStripMenuItem();
            tscbSearchMenuBar = new ToolStripComboBox();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStrip1 = new ToolStrip();
            toolStripSplitButton1 = new ToolStripSplitButton();
            toolStripSplitButton2 = new ToolStripSplitButton();
            ((System.ComponentModel.ISupportInitialize)formSplitContainer).BeginInit();
            formSplitContainer.Panel1.SuspendLayout();
            formSplitContainer.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // formSplitContainer
            // 
            formSplitContainer.Dock = DockStyle.Fill;
            formSplitContainer.Location = new Point(0, 0);
            formSplitContainer.Name = "formSplitContainer";
            formSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // formSplitContainer.Panel1
            // 
            formSplitContainer.Panel1.Controls.Add(toolStrip1);
            formSplitContainer.Panel1.Controls.Add(menuStrip1);
            formSplitContainer.Size = new Size(1245, 810);
            formSplitContainer.SplitterDistance = 94;
            formSplitContainer.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiFileMenuBar, tsmiGraphicMenuBar, tsmiToolMenuBar, tsmiWindowMenuBar, tsmiHelpMenuBar, tscbSearchMenuBar, toolStripTextBox1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1245, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFileMenuBar
            // 
            tsmiFileMenuBar.DropDownItems.AddRange(new ToolStripItem[] { tsmiFileNewMenuBar, tsmiFileOpenMenuBar, tsmiFileRecentMenuBar, tsmiFileSaveMenuBar, tsmiSaveAsMenuBar, tsmiFileSaveAllMenuBar, tsmiFileExitMenuBar });
            tsmiFileMenuBar.Name = "tsmiFileMenuBar";
            tsmiFileMenuBar.Size = new Size(73, 33);
            tsmiFileMenuBar.Text = "File(&F)";
            // 
            // tsmiFileNewMenuBar
            // 
            tsmiFileNewMenuBar.Name = "tsmiFileNewMenuBar";
            tsmiFileNewMenuBar.Size = new Size(197, 34);
            tsmiFileNewMenuBar.Text = "New(&N)";
            // 
            // tsmiFileOpenMenuBar
            // 
            tsmiFileOpenMenuBar.Name = "tsmiFileOpenMenuBar";
            tsmiFileOpenMenuBar.Size = new Size(197, 34);
            tsmiFileOpenMenuBar.Text = "Open(&O)";
            // 
            // tsmiFileRecentMenuBar
            // 
            tsmiFileRecentMenuBar.Name = "tsmiFileRecentMenuBar";
            tsmiFileRecentMenuBar.Size = new Size(197, 34);
            tsmiFileRecentMenuBar.Text = "Recent File";
            // 
            // tsmiFileSaveMenuBar
            // 
            tsmiFileSaveMenuBar.Name = "tsmiFileSaveMenuBar";
            tsmiFileSaveMenuBar.Size = new Size(197, 34);
            tsmiFileSaveMenuBar.Text = "Save(&S)";
            // 
            // tsmiSaveAsMenuBar
            // 
            tsmiSaveAsMenuBar.Name = "tsmiSaveAsMenuBar";
            tsmiSaveAsMenuBar.Size = new Size(197, 34);
            tsmiSaveAsMenuBar.Text = "Save As";
            // 
            // tsmiFileSaveAllMenuBar
            // 
            tsmiFileSaveAllMenuBar.Name = "tsmiFileSaveAllMenuBar";
            tsmiFileSaveAllMenuBar.Size = new Size(197, 34);
            tsmiFileSaveAllMenuBar.Text = "Save All";
            // 
            // tsmiFileExitMenuBar
            // 
            tsmiFileExitMenuBar.Name = "tsmiFileExitMenuBar";
            tsmiFileExitMenuBar.Size = new Size(197, 34);
            tsmiFileExitMenuBar.Text = "Exit";
            // 
            // tsmiGraphicMenuBar
            // 
            tsmiGraphicMenuBar.Name = "tsmiGraphicMenuBar";
            tsmiGraphicMenuBar.Size = new Size(110, 33);
            tsmiGraphicMenuBar.Text = "Graphic(&G)";
            // 
            // tsmiToolMenuBar
            // 
            tsmiToolMenuBar.Name = "tsmiToolMenuBar";
            tsmiToolMenuBar.Size = new Size(80, 33);
            tsmiToolMenuBar.Text = "Tool(&T)";
            // 
            // tsmiWindowMenuBar
            // 
            tsmiWindowMenuBar.Name = "tsmiWindowMenuBar";
            tsmiWindowMenuBar.Size = new Size(121, 33);
            tsmiWindowMenuBar.Text = "Window(&W)";
            // 
            // tsmiHelpMenuBar
            // 
            tsmiHelpMenuBar.Name = "tsmiHelpMenuBar";
            tsmiHelpMenuBar.Size = new Size(88, 33);
            tsmiHelpMenuBar.Text = "Help(&H)";
            // 
            // tscbSearchMenuBar
            // 
            tscbSearchMenuBar.AutoCompleteCustomSource.AddRange(new string[] { "Ctrl + F", "Ctrl + Q" });
            tscbSearchMenuBar.Items.AddRange(new object[] { "Ctrl + F", "Ctrl + Q" });
            tscbSearchMenuBar.Name = "tscbSearchMenuBar";
            tscbSearchMenuBar.Size = new Size(121, 33);
            tscbSearchMenuBar.Text = "Search";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 33);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1, toolStripSplitButton2 });
            toolStrip1.Location = new Point(0, 37);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1245, 33);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(45, 28);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripSplitButton2
            // 
            toolStripSplitButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton2.Image = (Image)resources.GetObject("toolStripSplitButton2.Image");
            toolStripSplitButton2.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton2.Name = "toolStripSplitButton2";
            toolStripSplitButton2.Size = new Size(45, 28);
            toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 810);
            Controls.Add(formSplitContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.On;
            MainMenuStrip = menuStrip1;
            Name = "mainWindow";
            Text = "VisualSolution";
            formSplitContainer.Panel1.ResumeLayout(false);
            formSplitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)formSplitContainer).EndInit();
            formSplitContainer.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer formSplitContainer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiFileMenuBar;
        private ToolStripMenuItem tsmiGraphicMenuBar;
        private ToolStripMenuItem tsmiToolMenuBar;
        private ToolStripMenuItem tsmiWindowMenuBar;
        private ToolStripMenuItem tsmiHelpMenuBar;
        private ToolStripComboBox tscbSearchMenuBar;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripMenuItem tsmiFileNewMenuBar;
        private ToolStripMenuItem tsmiFileOpenMenuBar;
        private ToolStripMenuItem tsmiFileRecentMenuBar;
        private ToolStripMenuItem tsmiFileSaveMenuBar;
        private ToolStripMenuItem tsmiSaveAsMenuBar;
        private ToolStripMenuItem tsmiFileSaveAllMenuBar;
        private ToolStripMenuItem tsmiFileExitMenuBar;
        private ToolStrip toolStrip1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripSplitButton toolStripSplitButton2;
    }
}