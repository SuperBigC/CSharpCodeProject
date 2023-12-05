namespace WinFormVisualSolution
{
    partial class LogInWinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInWinForm));
            pbSoftwareIcon = new PictureBox();
            lbName = new Label();
            lbPassward = new Label();
            tbName = new TextBox();
            tbPassward = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbSoftwareIcon).BeginInit();
            SuspendLayout();
            // 
            // pbSoftwareIcon
            // 
            pbSoftwareIcon.Image = Properties.Resources.Red_Dog_W;
            pbSoftwareIcon.Location = new Point(226, 30);
            pbSoftwareIcon.Name = "pbSoftwareIcon";
            pbSoftwareIcon.Size = new Size(322, 311);
            pbSoftwareIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbSoftwareIcon.TabIndex = 0;
            pbSoftwareIcon.TabStop = false;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(57, 415);
            lbName.Name = "lbName";
            lbName.Size = new Size(90, 32);
            lbName.TabIndex = 1;
            lbName.Text = "Name：";
            // 
            // lbPassward
            // 
            lbPassward.AutoSize = true;
            lbPassward.Location = new Point(57, 510);
            lbPassward.Name = "lbPassward";
            lbPassward.Size = new Size(114, 32);
            lbPassward.TabIndex = 2;
            lbPassward.Text = "Passward:";
            // 
            // tbName
            // 
            tbName.Location = new Point(197, 415);
            tbName.Name = "tbName";
            tbName.Size = new Size(351, 39);
            tbName.TabIndex = 3;
            // 
            // tbPassward
            // 
            tbPassward.Location = new Point(197, 507);
            tbPassward.Name = "tbPassward";
            tbPassward.Size = new Size(351, 39);
            tbPassward.TabIndex = 4;
            // 
            // LogInWinForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 605);
            Controls.Add(tbPassward);
            Controls.Add(tbName);
            Controls.Add(lbPassward);
            Controls.Add(lbName);
            Controls.Add(pbSoftwareIcon);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LogInWinForm";
            Text = "LogInWinForm";
            ((System.ComponentModel.ISupportInitialize)pbSoftwareIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSoftwareIcon;
        private Label lbName;
        private Label lbPassward;
        private TextBox tbName;
        private TextBox tbPassward;
    }
}