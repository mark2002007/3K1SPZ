using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3K1SPZT1
{
    public partial class Settings_Form : Form
    {
        public bool Vanish { get; set; }
        public bool InvertDirection { get; set; }
        public bool InvertColors { get; set; }
        public bool DoubleSize { get; set; }

        public Settings_Form(bool Vanish, bool InvertDirection, bool InvertColors, bool DoubleSize)
        {
            InitializeComponent();
            Vanish_checkBox.Checked = Vanish;
            InvertDirection_checkBox.Checked = InvertDirection;
            InvertColors_checkBox.Checked = InvertColors;
            DoubleSize_checkBox.Checked = DoubleSize;
        }

        private void Apply_button_Click(object sender, EventArgs e)
        {
            Vanish = Vanish_checkBox.Checked;
            InvertDirection = InvertDirection_checkBox.Checked;
            InvertColors = InvertColors_checkBox.Checked;
            DoubleSize = DoubleSize_checkBox.Checked;
            DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
