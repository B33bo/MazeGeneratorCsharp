using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGeneratorUI
{
    public partial class Advanced : Form
    {
        public Advanced()
        {
            InitializeComponent();
        }

        private void ChangeLineColor(object sender, EventArgs e)
        {
            if (Options.Instance is null)
                return;

            var colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;

            Options.Instance.lineColor = colorDialog.Color;
            lineColor.BackColor = colorDialog.Color;
        }

        private void Advanced_Load(object sender, EventArgs e)
        {
            if (Options.Instance is null)
                return;

            lineColor.BackColor = Options.Instance.lineColor;
            pathColor.BackColor = Options.Instance.pathColor;
            Seeded.Checked = Options.Instance.UseSeed;

            seedNumber.Visible = Options.Instance.UseSeed;
            ReseedButton.Visible = Options.Instance.UseSeed;
            seedNumber.Value = Options.Instance.Seed;
        }

        private void ChangePathColor(object sender, EventArgs e)
        {
            if (Options.Instance is null)
                return;

            var colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;

            Options.Instance.pathColor = colorDialog.Color;
            pathColor.BackColor = colorDialog.Color;
        }

        private void UseCustomSeedChanged(object sender, EventArgs e)
        {
            if (Options.Instance is null)
                return;

            seedNumber.Visible = Seeded.Checked;
            ReseedButton.Visible = Seeded.Checked;
            Options.Instance.UseSeed = Seeded.Checked;
        }

        private void SeedChange(object sender, EventArgs e)
        {
            if (Options.Instance is null)
                return;
            Options.Instance.Seed = (int)seedNumber.Value;
        }

        private void Reseed(object sender, EventArgs e)
        {
            if (Options.Instance is null)
                return;
            Options.Instance.Seed = new Random().Next();
            seedNumber.Value = Options.Instance.Seed;
        }

        private void CloseAdvanced(object sender, EventArgs e)
        {
            Close();
        }
    }
}
