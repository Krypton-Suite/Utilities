using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemeShowcase
{
    public partial class ThemeChanger : KryptonForm
    {
        private string _themeFileName;

        public ThemeChanger()
        {
            InitializeComponent();
        }

        private void kbtnImportTheme_Click(object sender, EventArgs e)
        {
            palette.Import();

            SetThemeFileName(Path.GetFileName(palette.CustomisedKryptonPaletteFilePath));
        }

        private void kbtnShowcaseTheme_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show($"Hello World! Theme: { GetThemeFileName() }");
        }

        private void SetThemeFileName(string name) => _themeFileName = name;

        private string GetThemeFileName() => _themeFileName;
    }
}
