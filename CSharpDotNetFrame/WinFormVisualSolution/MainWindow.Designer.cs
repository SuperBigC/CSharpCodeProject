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
            toolStrip1 = new ToolStrip();
            tssbBackwards = new ToolStripSplitButton();
            tssbForwards = new ToolStripSplitButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tssbNewFile = new ToolStripSplitButton();
            tsbOpenFolder = new ToolStripButton();
            tsbSave = new ToolStripButton();
            tsbSaveAll = new ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)formSplitContainer).BeginInit();
            formSplitContainer.Panel1.SuspendLayout();
            formSplitContainer.SuspendLayout();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // formSplitContainer
            // 
            formSplitContainer.Dock = DockStyle.Fill;
            formSplitContainer.Location = new Point(0, 0);
            formSplitContainer.Margin = new Padding(4);
            formSplitContainer.Name = "formSplitContainer";
            formSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // formSplitContainer.Panel1
            // 
            formSplitContainer.Panel1.Controls.Add(toolStrip1);
            formSplitContainer.Panel1.Controls.Add(menuStrip1);
            formSplitContainer.Size = new Size(1618, 1037);
            formSplitContainer.SplitterDistance = 119;
            formSplitContainer.SplitterWidth = 5;
            formSplitContainer.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tssbBackwards, tssbForwards, toolStripSeparator1, tssbNewFile, tsbOpenFolder, tsbSave, tsbSaveAll });
            toolStrip1.Location = new Point(0, 46);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(1618, 38);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tssbBackwards
            // 
            tssbBackwards.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tssbBackwards.Image = Properties.Resources.Backwards;
            tssbBackwards.ImageTransparentColor = Color.Magenta;
            tssbBackwards.Name = "tssbBackwards";
            tssbBackwards.Size = new Size(51, 32);
            tssbBackwards.Text = "Navigate Backward";
            // 
            // tssbForwards
            // 
            tssbForwards.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tssbForwards.Image = Properties.Resources.Forwards;
            tssbForwards.ImageTransparentColor = Color.Magenta;
            tssbForwards.Name = "tssbForwards";
            tssbForwards.Size = new Size(51, 32);
            tssbForwards.Text = "Navigate Forwards";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // tssbNewFile
            // 
            tssbNewFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tssbNewFile.Image = Properties.Resources.NewDocument;
            tssbNewFile.ImageTransparentColor = Color.Magenta;
            tssbNewFile.Name = "tssbNewFile";
            tssbNewFile.Size = new Size(51, 32);
            tssbNewFile.Text = "New File";
            // 
            // tsbOpenFolder
            // 
            tsbOpenFolder.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbOpenFolder.Image = Properties.Resources.OpenFolder;
            tsbOpenFolder.ImageTransparentColor = Color.Magenta;
            tsbOpenFolder.Name = "tsbOpenFolder";
            tsbOpenFolder.Size = new Size(46, 32);
            tsbOpenFolder.Text = "Open Folder";
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSave.Image = Properties.Resources.Save;
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(46, 32);
            tsbSave.Text = "Save";
            // 
            // tsbSaveAll
            // 
            tsbSaveAll.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSaveAll.Image = Properties.Resources.SaveAll;
            tsbSaveAll.ImageTransparentColor = Color.Magenta;
            tsbSaveAll.Name = "tsbSaveAll";
            tsbSaveAll.Size = new Size(46, 32);
            tsbSaveAll.Text = "Save All";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiFileMenuBar, tsmiGraphicMenuBar, tsmiToolMenuBar, tsmiWindowMenuBar, tsmiHelpMenuBar, tscbSearchMenuBar, toolStripTextBox1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1618, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFileMenuBar
            // 
            tsmiFileMenuBar.DropDownItems.AddRange(new ToolStripItem[] { tsmiFileNewMenuBar, tsmiFileOpenMenuBar, tsmiFileRecentMenuBar, tsmiFileSaveMenuBar, tsmiSaveAsMenuBar, tsmiFileSaveAllMenuBar, tsmiFileExitMenuBar });
            tsmiFileMenuBar.Name = "tsmiFileMenuBar";
            tsmiFileMenuBar.Size = new Size(97, 40);
            tsmiFileMenuBar.Text = "File(&F)";
            // 
            // tsmiFileNewMenuBar
            // 
            tsmiFileNewMenuBar.Name = "tsmiFileNewMenuBar";
            tsmiFileNewMenuBar.Size = new Size(263, 44);
            tsmiFileNewMenuBar.Text = "New(&N)";
            // 
            // tsmiFileOpenMenuBar
            // 
            tsmiFileOpenMenuBar.Name = "tsmiFileOpenMenuBar";
            tsmiFileOpenMenuBar.Size = new Size(263, 44);
            tsmiFileOpenMenuBar.Text = "Open(&O)";
            // 
            // tsmiFileRecentMenuBar
            // 
            tsmiFileRecentMenuBar.Name = "tsmiFileRecentMenuBar";
            tsmiFileRecentMenuBar.Size = new Size(263, 44);
            tsmiFileRecentMenuBar.Text = "Recent File";
            // 
            // tsmiFileSaveMenuBar
            // 
            tsmiFileSaveMenuBar.Name = "tsmiFileSaveMenuBar";
            tsmiFileSaveMenuBar.Size = new Size(263, 44);
            tsmiFileSaveMenuBar.Text = "Save(&S)";
            // 
            // tsmiSaveAsMenuBar
            // 
            tsmiSaveAsMenuBar.Name = "tsmiSaveAsMenuBar";
            tsmiSaveAsMenuBar.Size = new Size(263, 44);
            tsmiSaveAsMenuBar.Text = "Save As";
            // 
            // tsmiFileSaveAllMenuBar
            // 
            tsmiFileSaveAllMenuBar.Name = "tsmiFileSaveAllMenuBar";
            tsmiFileSaveAllMenuBar.Size = new Size(263, 44);
            tsmiFileSaveAllMenuBar.Text = "Save All";
            // 
            // tsmiFileExitMenuBar
            // 
            tsmiFileExitMenuBar.Name = "tsmiFileExitMenuBar";
            tsmiFileExitMenuBar.Size = new Size(263, 44);
            tsmiFileExitMenuBar.Text = "Exit";
            // 
            // tsmiGraphicMenuBar
            // 
            tsmiGraphicMenuBar.Name = "tsmiGraphicMenuBar";
            tsmiGraphicMenuBar.Size = new Size(145, 40);
            tsmiGraphicMenuBar.Text = "Graphic(&G)";
            // 
            // tsmiToolMenuBar
            // 
            tsmiToolMenuBar.Name = "tsmiToolMenuBar";
            tsmiToolMenuBar.Size = new Size(106, 40);
            tsmiToolMenuBar.Text = "Tool(&T)";
            // 
            // tsmiWindowMenuBar
            // 
            tsmiWindowMenuBar.Name = "tsmiWindowMenuBar";
            tsmiWindowMenuBar.Size = new Size(157, 40);
            tsmiWindowMenuBar.Text = "Window(&W)";
            // 
            // tsmiHelpMenuBar
            // 
            tsmiHelpMenuBar.Name = "tsmiHelpMenuBar";
            tsmiHelpMenuBar.Size = new Size(115, 40);
            tsmiHelpMenuBar.Text = "Help(&H)";
            // 
            // tscbSearchMenuBar
            // 
            tscbSearchMenuBar.AutoCompleteCustomSource.AddRange(new string[] { "Ctrl + F", "Ctrl + Q" });
            tscbSearchMenuBar.Items.AddRange(new object[] { "Ctrl + F", "Ctrl + Q" });
            tscbSearchMenuBar.Name = "tscbSearchMenuBar";
            tscbSearchMenuBar.Size = new Size(156, 40);
            tscbSearchMenuBar.Text = "Search";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(129, 40);
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1618, 1037);
            Controls.Add(formSplitContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.On;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "mainWindow";
            Text = "VisualSolution";
            formSplitContainer.Panel1.ResumeLayout(false);
            formSplitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)formSplitContainer).EndInit();
            formSplitContainer.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private ToolStripSplitButton tssbBackwards;
        private ToolStripSplitButton tssbForwards;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSplitButton tssbNewFile;
        private ToolStripButton tsbOpenFolder;
        private ToolStripButton tsbSave;
        private ToolStripButton tsbSaveAll;
    }
}