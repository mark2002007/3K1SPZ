using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3K1SPZT1
{
    public partial class Main_Form : Form
    {
        private bool Vanish = false;
        private bool InvertDirection = false;
        private bool InvertColors = false;
        private bool DoubleSize = false;

        private void SetPictureBoxLocation()
        {
            pictureBox.Location = new Point(Width / 2 - pictureBox.Width / 2, Height / 2 - pictureBox.Height / 2 - Settings_button.Height);
        }
        public Main_Form()
        {
            InitializeComponent();
            SetPictureBoxLocation();
        }

        private void Settings_button_Click(object sender, EventArgs e)
        {
            using (var form = new Settings_Form(Vanish,InvertDirection, InvertColors, DoubleSize))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    Vanish = form.Vanish;
                    InvertColors = form.InvertColors;
                    DoubleSize = form.DoubleSize;

                    pictureBox.Visible = !Vanish;

                    pictureBox.Image = InvertColors ? Properties.Resources.check_negative : Properties.Resources.check;

                    pictureBox.Size = DoubleSize ? new Size(185 * 2, 185 * 2) : new Size(185, 185);
                    SetPictureBoxLocation();

                    if (form.InvertDirection != InvertDirection)
                    {
                        pictureBox.Image.RotateFlip(form.InvertDirection? RotateFlipType.RotateNoneFlipX : RotateFlipType.RotateNoneFlipNone);
                        pictureBox.Refresh();
                        InvertDirection = form.InvertDirection;
                    }
                }
            }
        }
    }
}
