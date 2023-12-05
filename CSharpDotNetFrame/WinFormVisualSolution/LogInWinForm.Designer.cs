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
            btnLogIn = new Button();
            btnRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)pbSoftwareIcon).BeginInit();
            SuspendLayout();
            // 
            // pbSoftwareIcon
            // 
            pbSoftwareIcon.Image = Properties.Resources.Red_Dog_W;
            pbSoftwareIcon.Location = new Point(124, 11);
            pbSoftwareIcon.Margin = new Padding(2);
            pbSoftwareIcon.Name = "pbSoftwareIcon";
            pbSoftwareIcon.Size = new Size(248, 243);
            pbSoftwareIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbSoftwareIcon.TabIndex = 0;
            pbSoftwareIcon.TabStop = false;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(24, 324);
            lbName.Margin = new Padding(2, 0, 2, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(68, 25);
            lbName.TabIndex = 1;
            lbName.Text = "Name：";
            // 
            // lbPassward
            // 
            lbPassward.AutoSize = true;
            lbPassward.Location = new Point(24, 399);
            lbPassward.Margin = new Padding(2, 0, 2, 0);
            lbPassward.Name = "lbPassward";
            lbPassward.Size = new Size(89, 25);
            lbPassward.TabIndex = 2;
            lbPassward.Text = "Passward:";
            // 
            // tbName
            // 
            tbName.Location = new Point(124, 324);
            tbName.Margin = new Padding(2);
            tbName.Name = "tbName";
            tbName.Size = new Size(248, 31);
            tbName.TabIndex = 3;
            // 
            // tbPassward
            // 
            tbPassward.Location = new Point(124, 396);
            tbPassward.Margin = new Padding(2);
            tbPassward.Name = "tbPassward";
            tbPassward.PasswordChar = '*';
            tbPassward.Size = new Size(248, 31);
            tbPassward.TabIndex = 4;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(70, 473);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(112, 34);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(251, 473);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // LogInWinForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 547);
            Controls.Add(btnRegister);
            Controls.Add(btnLogIn);
            Controls.Add(tbPassward);
            Controls.Add(tbName);
            Controls.Add(lbPassward);
            Controls.Add(lbName);
            Controls.Add(pbSoftwareIcon);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
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
        private Button btnLogIn;
        private Button btnRegister;
    }
}