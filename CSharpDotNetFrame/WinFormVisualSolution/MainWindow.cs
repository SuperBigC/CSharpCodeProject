using System.Windows.Forms;

namespace WinFormVisualSolution
{
    public partial class mainWindow : Form
    {
        private Size originalSize;
        private double scale = 1.0;
        private bool mouseDown = false;
        private int mouseX;
        private int mouseY;
        public mainWindow()
        {
            InitializeComponent();
            this.pbMainPic.MouseWheel += pbMainPic_MouseWheel;
        }

        private void mainWindow_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files[0].EndsWith(".jpg") || files[0].EndsWith(".png") || files[0].EndsWith(".bmp"))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void mainWindow_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data != null)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                this.pbMainPic.Image = Image.FromFile(files[0]);
                originalSize = this.pbMainPic.Size;
            }

        }

        private void pbMainPic_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void pbMainPic_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pbMainPic_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                pbMainPic.Left += e.X - mouseX;
                pbMainPic.Top += e.Y - mouseY;
            }
            this.toolStripTextBox2.Text = e.X.ToString() + "--" + e.Y.ToString();
        }

        private void pbMainPic_MouseWheel(object sender, MouseEventArgs e)
        {
            if (scale < 0.1 || scale > 5) return;
            double tempScale = 0.1;
            if (e.Delta > 0)
            {
                tempScale = 0.1;
            }
            else
            {
                tempScale = -0.1;
            }
            pbMainPic.Left -= (int)(e.X * tempScale);
            pbMainPic.Top -= (int)(e.Y * tempScale);
            pbMainPic.Width = (int)(pbMainPic.Width * (1 + tempScale));
            pbMainPic.Height = (int)(pbMainPic.Height * (1 + tempScale));
        }
    }
}