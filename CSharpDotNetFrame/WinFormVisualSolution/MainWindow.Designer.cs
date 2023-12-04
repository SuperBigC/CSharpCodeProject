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
            toolStripSeparator2 = new ToolStripSeparator();
            tssbUndo = new ToolStripSplitButton();
            tssbRedo = new ToolStripSplitButton();
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
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripComboBox1 = new ToolStripComboBox();
            tsbFindInFiles = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)formSplitContainer).BeginInit();
            formSplitContainer.Panel1.SuspendLayout();
            formSplitContainer.Panel2.SuspendLayout();
            formSplitContainer.SuspendLayout();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.SuspendLayout();
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
            // 
            // formSplitContainer.Panel2
            // 
            formSplitContainer.Panel2.Controls.Add(splitContainer1);
            formSplitContainer.Size = new Size(1618, 1037);
            formSplitContainer.SplitterDistance = 100;
            formSplitContainer.SplitterWidth = 5;
            formSplitContainer.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tssbBackwards, tssbForwards, toolStripSeparator1, tssbNewFile, tsbOpenFolder, tsbSave, tsbSaveAll, toolStripSeparator2, tssbUndo, tssbRedo, toolStripSeparator3, toolStripComboBox1, tsbFindInFiles });
            toolStrip1.Location = new Point(0, 46);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(1618, 54);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tssbBackwards
            // 
            tssbBackwards.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tssbBackwards.Image = Properties.Resources.Backwards;
            tssbBackwards.ImageTransparentColor = Color.Magenta;
            tssbBackwards.Name = "tssbBackwards";
            tssbBackwards.Size = new Size(51, 48);
            tssbBackwards.Text = "Navigate Backward";
            // 
            // tssbForwards
            // 
            tssbForwards.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tssbForwards.Image = Properties.Resources.Forwards;
            tssbForwards.ImageTransparentColor = Color.Magenta;
            tssbForwards.Name = "tssbForwards";
            tssbForwards.Size = new Size(51, 48);
            tssbForwards.Text = "Navigate Forwards";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // tssbNewFile
            // 
            tssbNewFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tssbNewFile.Image = Properties.Resources.NewDocument;
            tssbNewFile.ImageTransparentColor = Color.Magenta;
            tssbNewFile.Name = "tssbNewFile";
            tssbNewFile.Size = new Size(51, 48);
            tssbNewFile.Text = "New File";
            // 
            // tsbOpenFolder
            // 
            tsbOpenFolder.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbOpenFolder.Image = Properties.Resources.OpenFolder;
            tsbOpenFolder.ImageTransparentColor = Color.Magenta;
            tsbOpenFolder.Name = "tsbOpenFolder";
            tsbOpenFolder.Size = new Size(46, 48);
            tsbOpenFolder.Text = "Open Folder";
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSave.Image = Properties.Resources.Save;
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(46, 48);
            tsbSave.Text = "Save";
            // 
            // tsbSaveAll
            // 
            tsbSaveAll.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSaveAll.Image = Properties.Resources.SaveAll;
            tsbSaveAll.ImageTransparentColor = Color.Magenta;
            tsbSaveAll.Name = "tsbSaveAll";
            tsbSaveAll.Size = new Size(46, 48);
            tsbSaveAll.Text = "Save All";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 54);
            // 
            // tssbUndo
            // 
            tssbUndo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tssbUndo.Image = Properties.Resources.Undo;
            tssbUndo.ImageTransparentColor = Color.Magenta;
            tssbUndo.Name = "tssbUndo";
            tssbUndo.Size = new Size(51, 48);
            tssbUndo.Text = "Undo(Ctrl + Z)";
            // 
            // tssbRedo
            // 
            tssbRedo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tssbRedo.Image = Properties.Resources.Redo;
            tssbRedo.ImageTransparentColor = Color.Magenta;
            tssbRedo.Name = "tssbRedo";
            tssbRedo.Size = new Size(51, 48);
            tssbRedo.Text = "toolStripSplitButton2";
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
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 54);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 54);
            // 
            // tsbFindInFiles
            // 
            tsbFindInFiles.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFindInFiles.Image = Properties.Resources.FindInFile;
            tsbFindInFiles.ImageTransparentColor = Color.Magenta;
            tsbFindInFiles.Name = "tsbFindInFiles";
            tsbFindInFiles.Size = new Size(46, 48);
            tsbFindInFiles.Text = "toolStripButton1";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer3);
            splitContainer1.Size = new Size(1618, 932);
            splitContainer1.SplitterDistance = 315;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            splitContainer2.Size = new Size(315, 932);
            splitContainer2.SplitterDistance = 422;
            splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Size = new Size(1299, 932);
            splitContainer3.SplitterDistance = 993;
            splitContainer3.TabIndex = 0;
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
            formSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)formSplitContainer).EndInit();
            formSplitContainer.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
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
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSplitButton tssbUndo;
        private ToolStripSplitButton tssbRedo;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripButton tsbFindInFiles;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
    }
}