using Krypton.Toolkit;
using System;

namespace ThemeShowcase
{
    public partial class DemoWindow : KryptonForm
    {
        public DemoWindow()
        {
            InitializeComponent();
        }

        private void changeThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kpal.Import();

            kman.GlobalPalette = kpal;

            kman.GlobalPaletteMode = PaletteModeManager.Custom;

            kwlThemeDescription.Text = $"Theme: {kpal.GetCustomisedKryptonPaletteFilePath()}";
        }

        private void resetThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kman.GlobalPalette = null;

            kman.GlobalPaletteMode = PaletteModeManager.Office365Blue;
        }
    }
}
